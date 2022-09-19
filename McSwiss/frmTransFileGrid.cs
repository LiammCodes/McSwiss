using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms.Design;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Amazon.S3;
using Microsoft.VisualBasic;
using McSwiss.Properties;
using Amazon;
using System.Security.Policy;
using System.CodeDom.Compiler;
using Amazon.S3.Model;

namespace McSwiss
{

    public partial class frmTransFileGrid : Form
    {

        private List<String> selectedFiles = null;
        private string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string S3AccessKeyID = settings.Default.S3AccessKeyID;
        private string S3Secret = settings.Default.S3Secret;
        private string tempPath = Path.GetTempPath();
        private List<string> filesToUploadS3 = new List<string>();
        private bool download = false;

        public frmTransFileGrid()
        {
            InitializeComponent();
        }

        public frmTransFileGrid(List<String> selectedFiles)
        {
            this.selectedFiles = selectedFiles;
            InitializeComponent();
        }

        private void lstFileGrid_Enter(object sender, EventArgs e)
        {
            lstFileGrid.Items.Clear();
            lblOutputPath.Text = outputPath;
            foreach (String file in selectedFiles)
            {
                imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(file));
                FileInfo fi = new FileInfo(file);

                lstFileGrid.Items.Add(fi.Name, imgList.Images.Count-1);
            }
            
        }

        private void frmFileGrid_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmFileGrid_DragDrop(object sender, DragEventArgs e)
        {
            string[] newFiles = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (newFiles != null && newFiles.Any())
            {
                foreach (string file in newFiles)
                {
                    this.selectedFiles.Add(file);
                }

                lstFileGrid.Items.Clear();
                foreach (String file in selectedFiles)
                {
                    imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(file));
                    FileInfo fi = new FileInfo(file);

                    lstFileGrid.Items.Add(fi.Name, imgList.Images.Count - 1);
                }

            }
                
        }

        public async Task<bool> validS3Connection()
        {
            try
            {
                RegionEndpoint bucketRegion = RegionEndpoint.USEast1;
                var s3Client = new AmazonS3Client(S3AccessKeyID, S3Secret, bucketRegion);
                var buckets = await s3Client.ListBucketsAsync();
                Debug.WriteLine(buckets.Buckets.ToString());
                return true;
            }
            catch
            {
                Debug.WriteLine("Invalid keys");
                return false;
            }
        }

        public void downloadLocally(string url, string filepath)
        {
            // download files from trint
            using (var client = new WebClient())
            {
                // downloads to temp files
                client.DownloadFile(url, filepath);
            }
        }

        public async Task uploadToS3(string url, string filename)
        {
            // establish s3 connection
            RegionEndpoint bucketRegion = RegionEndpoint.USEast1;
            var s3Client = new AmazonS3Client(S3AccessKeyID, S3Secret, bucketRegion);
            var buckets = await s3Client.ListBucketsAsync();
            Debug.WriteLine(buckets.Buckets.ToString());
            string tempFile = Path.Join(tempPath, filename);

            // download files from trint
            using (var client = new WebClient())
            {
                // downloads to temp files
                client.DownloadFile(url, tempFile);
            }

            // upload to s3
            try
            {
                PutObjectRequest putRequest = new PutObjectRequest
                {
                    BucketName = "mcwebccfiles",
                    Key = filename,
                    FilePath = tempFile,
                    ContentType = "text/vtt"
                };

                PutObjectResponse response = await s3Client.PutObjectAsync(putRequest);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                    ||
                    amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    throw new Exception("Check the provided AWS Credentials.");
                }
                else
                {
                    throw new Exception("Error occurred: " + amazonS3Exception.Message);
                }
            }


            //filesToUploadS3.Add(tempFile);
        }

        public void generateTranscripts()
        {

            if (!validS3Connection().Result)
            {

                lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Error."));
                imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

                // Error Message
                string errorMessage = String.Format(@"Invalid keys. Please check your S3 Access Key ID and S3 Secret Access Key in Settings > Transcript Generator.");
                string errorCaption = "Error";
                MessageBoxButtons b = MessageBoxButtons.OK;
                DialogResult r;
                r = MessageBox.Show(errorMessage, errorCaption, b);



            } else
            {

                // Transcript Generator code
                List<string> stillTranscribing = new List<string>();

                // Upload videos to trint
                int filesUploadedTrint = 1;
                foreach (String file in selectedFiles)
                {

                    // Loading
                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Uploading files to Trint {0}/{1}", filesUploadedTrint, selectedFiles.Count())));

                    // Trint API call
                    string filename = Path.GetFileName(file);
                    string postUri = String.Format(@"https://upload.trint.com/?filename={0}&detect-speaker-change=true&custom-dictionary=true", filename);
                    WebRequest postRequest = WebRequest.Create(postUri);
                    postRequest.Method = "POST";
                    byte[] byteArray = File.ReadAllBytes(file);
                    postRequest.ContentType = "video/mp4";
                    postRequest.ContentLength = byteArray.Length;
                    postRequest.Headers.Add("accept", "application/json");
                    postRequest.Headers.Add("api-key", "75572047baff45fd4e49d3bbc4fb8d69875c8989");
                    Stream dataStream = postRequest.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    WebResponse postResponse = postRequest.GetResponse();
                    StreamReader reader = new StreamReader(postResponse.GetResponseStream());
                    string postResponseText = reader.ReadToEnd();
                    dynamic postResponseObj = JsonConvert.DeserializeObject(postResponseText);
                    string trintId = postResponseObj.trintId.ToString();

                    // Add Trintid to stillTranscribing list
                    Debug.WriteLine(trintId);
                    stillTranscribing.Add(trintId);
                    Debug.WriteLine(stillTranscribing[0]);

                    filesUploadedTrint++;
                    tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));

                }

                // if delete checkbox is checked, remove video files
                if (cBoxDelete.Checked)
                {
                    foreach (string file in selectedFiles)
                    {
                        File.Delete(file);
                    }
                }
                

                // Check if trint is done transcribing
                int totalToTranscribe = stillTranscribing.Count();
                int indexToTry = 0;
                List<Tuple<string, string>> completedTrints = new List<Tuple<string, string>>();
                tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value = 0));
                lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Transcribing files 1/{0}", totalToTranscribe)));
                while (stillTranscribing.Count > 0)
                {
                    try
                    {
                        string getUri = String.Format(@"https://api.trint.com/export/webvtt/{0}?captions-by-paragraph=false&max-subtitle-character-length=37&highlights-only=false&enable-speakers=false&speaker-on-new-line=false&speaker-uppercase=false&skip-strikethroughs=false", stillTranscribing[indexToTry]);
                        WebRequest getRequest = WebRequest.Create(getUri);
                        getRequest.Method = "GET";
                        getRequest.Headers.Add("accept", "application/json");
                        getRequest.Headers.Add("api-key", "75572047baff45fd4e49d3bbc4fb8d69875c8989");
                        WebResponse getResponse = getRequest.GetResponse();

                        StreamReader r = new StreamReader(getResponse.GetResponseStream());
                        string getResponseText = r.ReadToEnd();
                        dynamic getResponseObj = JsonConvert.DeserializeObject(getResponseText);
                        string transUrl = getResponseObj.url.ToString();
                        string transFileName = Path.ChangeExtension(getResponseObj.title.ToString(), ".vtt");
                        Debug.WriteLine(getResponseText);
                        Debug.WriteLine(transUrl + " " + transFileName);
                        completedTrints.Add(Tuple.Create(transUrl, transFileName));
                        stillTranscribing.RemoveAt(indexToTry);
                        lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Transcribing files {0}/{1}", totalToTranscribe - stillTranscribing.Count(), totalToTranscribe)));
                        tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));
                    }
                    catch (WebException e)
                    {
                        Debug.WriteLine(e.Status);
                    }

                    // increment index to try
                    if (indexToTry >= stillTranscribing.Count - 1)
                    {
                        indexToTry = 0;
                    }
                    else
                    {
                        indexToTry++;
                    }

                    // 2.2 second delay before making nesxt API call (max 30 api calls/minute)
                    Thread.Sleep(2200);
                }

                if (!download)
                {
                    // All trints done transcrbing, download and start uploading to amazon s3
                    foreach (Tuple<string, string> trint in completedTrints)
                    {
                        uploadToS3(trint.Item1, trint.Item2);

                        //remove temp file
                        File.Delete(Path.Join(tempPath, trint.Item2));
                    }

                    // cleanup
                    

                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Complete."));
                    imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

                    // Success message
                    string message = String.Format(@"{0} transcripts have been generated and stored in the S3 server.", totalToTranscribe);
                    string caption = "Success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);

                } else
                {

                    // All trints done transcribing, download and start uploading to amazon s3
                    foreach (Tuple<string, string> trint in completedTrints)
                    {
                        string op = Path.Join(outputPath, trint.Item2);
                        downloadLocally(trint.Item1, op);
                    }

                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Complete."));
                    imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

                    // Success message
                    string message = String.Format(@"{0} transcripts have been generated and saved to {1}", totalToTranscribe, outputPath);
                    string caption = "Success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);


                }

            }
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {  
            tgProgressBar.Minimum = 0;
            tgProgressBar.Maximum = selectedFiles.Count;
            btnRun.Visible = false;
            btnRunDownload.Visible = false;
            cBoxDelete.Visible = false;
            tgProgressBar.Visible = true;
            lblProgressText.Visible = true;
            imgLoading.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnRunDownload_Click(object sender, EventArgs e)
        {
            download = true;
            tgProgressBar.Minimum = 0;
            tgProgressBar.Maximum = selectedFiles.Count;
            btnRun.Visible = false;
            btnRunDownload.Visible = false;
            cBoxDelete.Visible = false;
            tgProgressBar.Visible = true;
            lblProgressText.Visible = true;
            imgLoading.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputPath = fbd.SelectedPath;
                    lblOutputPath.Text = outputPath;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            generateTranscripts();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tgProgressBar.Visible = false;
            tgProgressBar.Value = 0;
            lblProgressText.Visible = false;
            btnRun.Visible = true;
            btnRunDownload.Visible = true;
            cBoxDelete.Visible = true;
        }

        private void lstFileGrid_DoubleClick(object sender, EventArgs e)
        {
            Process openMp4 = new Process();

            openMp4.StartInfo.FileName = selectedFiles[lstFileGrid.SelectedIndices[0]];
            openMp4.StartInfo.UseShellExecute = true;
            openMp4.Start();
        }

        
    }
}
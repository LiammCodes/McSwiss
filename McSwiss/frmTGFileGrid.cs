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

namespace McSwiss
{
    public partial class frmTGFileGrid : Form
    {
        private string selectedFile = null;
        private List<String> thumbnails = new List<String>();
        private string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        string tempPath = Path.GetTempPath();
        public frmTGFileGrid()
        {
            InitializeComponent();
        }

        public frmTGFileGrid(String selectedFile)
        {
            this.selectedFile = selectedFile;
            InitializeComponent();
        }

        private void lstFileGrid_Enter(object sender, EventArgs e)
        {
            lstFileGrid.Items.Clear();
            lblOutputPath.Text = outputPath;
            
            imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(selectedFile));
            FileInfo fi = new FileInfo(selectedFile);

            lstFileGrid.Items.Add(fi.Name, imgList.Images.Count-1);

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
            
                
        }

        private int getTimeSeconds(String time)
        {
            int minutes = Int16.Parse(time.Split(':')[0]);
            int seconds = Int16.Parse(time.Split(':')[1]);
            int totalTime = (minutes * 60) + seconds;

            return totalTime;
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void generateThumbnails()
        {
            // Thumbnail Generator code

            // Formatting start time
            int timestamp = getTimeSeconds(txtboxTimestamp.Text);

            for (int i = 0; i < 20; i++)
            {
                string command = @"-ss {0} -i ""{1}"" -vframes 1 -an ""{2}""";

                // Create process for trimming the video
                Process ffmpeg = new Process();
                ffmpeg.StartInfo.RedirectStandardOutput = false;
                ffmpeg.StartInfo.RedirectStandardError = false;
                ffmpeg.StartInfo.FileName = "ffmpeg.exe";
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.CreateNoWindow = true;

                // Formatting preview filename
                string fullFileName = Path.GetFileName(selectedFile);
                int idx = fullFileName.LastIndexOf('.');
                string fileName = fullFileName[..idx];
                //string newFileName = string.Format("{0}.jpg", fileName);
                string newFileName = string.Format("tempThumb{0}.jpg", i);
                string outputFile = Path.Join(tempPath, newFileName);

                // check if output file already exists
                if (File.Exists(outputFile))
                {
                    // replace file
                    File.Delete(outputFile);
                   
                    ffmpeg.StartInfo.Arguments = string.Format(command, string.Format(@"{0}.{1}", timestamp.ToString(), i*5), selectedFile, outputFile);
                    ffmpeg.Start();
                    tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));
                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating thumbnail...")));
                    ffmpeg.WaitForExit();

                }
                else
                {
                    ffmpeg.StartInfo.Arguments = string.Format(command, string.Format(@"{0}.{1}", timestamp.ToString(), i * 5), selectedFile, outputFile);
                    ffmpeg.Start();
                    tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));
                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating thumbnail...")));
                    ffmpeg.WaitForExit();
                }

                //add temp thumbs to image list
                Debug.WriteLine(outputFile);
                thumbnails.Add(outputFile);

            }
            
            var imageAsByteArray = File.ReadAllBytes(thumbnails[0]);
            imgView.Invoke((MethodInvoker)(() => imgView.Image = byteArrayToImage(imageAsByteArray)));
            lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Complete."));
            imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

            // Make thumbnail selection tools visible
            imgView.Invoke((MethodInvoker)(() => imgView.Visible = true));
            trackBar.Invoke((MethodInvoker)(() => trackBar.Visible = true));
            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Visible = true));
            lblOutputPath.Invoke((MethodInvoker)(() => lblOutputPath.Visible = true));
            btnSelectOutput.Invoke((MethodInvoker)(() => btnSelectOutput.Visible = true));
            btnRun.Invoke((MethodInvoker)(() => btnRun.Visible = true));

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            // Formatting preview filename
            string fullFileName = Path.GetFileName(selectedFile);
            int idx = fullFileName.LastIndexOf('.');
            string fileName = fullFileName[..idx];
            string newFileName = string.Format("{0}.jpg", fileName);
            string outputFile = Path.Join(outputPath, newFileName);


            if (File.Exists(outputFile))
            {
                // Error message
                string errorMessage = String.Format(@"The file {0} already exists, would you like to replace it?", outputFile);
                string errorTitle = "Error: File already exists";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r;
                r = MessageBox.Show(errorMessage, errorTitle, b);
                if (r == DialogResult.Yes)
                {
                    // replace file
                    File.Delete(outputFile);
                    File.Copy(thumbnails[trackBar.Value], outputFile);

                    // Success message
                    string message = String.Format(@"Your thumbnail has been generated and saved to {0}", outputPath);
                    string caption = "Success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);

                } 
                else
                {
                    // Success message
                    string message = String.Format(@"No new thumbnails were saved.");
                    string caption = "Success!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                File.Copy(thumbnails[trackBar.Value], outputFile);
                // Success message
                string message = String.Format(@"Your thumbnail has been generated and saved to {0}", outputPath);
                string caption = "Success!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

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
            generateThumbnails();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tgProgressBar.Visible = false;
            tgProgressBar.Value = 0;
            lblProgressText.Visible = false;
            btnRun.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            imgView.Image = null;
            imgView.Visible = false;
            trackBar.Visible = false;
            trackBar.Value = 0;
            Debug.WriteLine(tempPath);

            // Get length of video first
            string command = @"-i ""{0}""";

            Process ffmpeg = new Process();
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.CreateNoWindow = true;

            ffmpeg.StartInfo.Arguments = string.Format(command, selectedFile);
            ffmpeg.Start();
            ffmpeg.WaitForExit();

            string s = ffmpeg.StandardError.ReadToEnd();
            var lines = s.Split("Duration: ");
            string duration = lines[1].Split(',')[0];
            duration = duration.Substring(0, duration.Length - 3);
            duration = duration.Remove(0, 3);

            // Generate 20 thumbnails in second specified
            // Create regex pattern for timestamps
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            if (!rg.IsMatch(txtboxTimestamp.Text) || txtboxTimestamp.Text.Length != 5 || getTimeSeconds(duration) <= getTimeSeconds(txtboxTimestamp.Text))
            {

                // Format error message
                string message = "Please enter a valid timestamp in the following format (MM:SS), and make sure the timestamp does not exceed the duration of the video.";
                string caption = "Timestamp Format Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

            }
            else
            {

                tgProgressBar.Minimum = 0;
                tgProgressBar.Maximum = 20;
                btnRun.Visible = false;
                tgProgressBar.Visible = true;
                lblProgressText.Visible = true;
                imgLoading.Visible = true;

                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            var imageAsByteArray = File.ReadAllBytes(thumbnails[trackBar.Value]);
            imgView.Image = byteArrayToImage(imageAsByteArray);
        }

        private void RemoveSelection(Object obj)
        {
            if (txtboxTimestamp != null)
            {
                txtboxTimestamp.SelectionLength = 0;
            }
        }

        private void txtboxTimestamp_TextChanged(object sender, EventArgs e)
        {
            string time = txtboxTimestamp.Text;

            // new number entered
            if (time.Length > 5)
            {
                var regex = new Regex(@"^\d$");
                if (!regex.IsMatch(time[5].ToString()))
                {
                    time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                }
                else
                {
                    if (!time[0].ToString().Equals("0"))
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                    }
                    else
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[1], time[3], time[4], time[5]);
                    }

                }
            }

            //new number removed
            if (time.Length < 5)
            {
                time = String.Format(@"{0}{1}:{2}{3}", "0", time[0], time[1], time[3]);
            }

            txtboxTimestamp.Text = time;
            txtboxTimestamp.Select(txtboxTimestamp.Text.Length, 0);
        }

        private void txtboxTimestamp_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveSelection(sender);
            txtboxTimestamp.Select(txtboxTimestamp.Text.Length, 0);
        }

        private void txtboxTimestamp_KeyUp(object sender, KeyEventArgs e)
        {
            RemoveSelection(sender);
            txtboxTimestamp.Select(txtboxTimestamp.Text.Length, 0);
        }

        private void lstFileGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            Process openMp4 = new Process();

            openMp4.StartInfo.FileName = selectedFile;
            openMp4.StartInfo.UseShellExecute = true;
            openMp4.Start();
            
        }
    }
}
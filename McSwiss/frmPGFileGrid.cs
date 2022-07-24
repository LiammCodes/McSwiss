using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McSwiss.Properties;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace McSwiss
{
    public partial class frmPGFileGrid : Form
    {
        private List<String> selectedFiles = null;
        private string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        private string suffix = settings.Default.PGSuffix;
        private int previewsGenerated = 0;

        public frmPGFileGrid()
        {
            InitializeComponent();
        }

        public frmPGFileGrid(List<String> selectedFiles)
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

        private int getTimeSeconds(String time)
        {
            // make sure textboxes are formatted right
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            int minutes = Int16.Parse(time.Split(':')[0]);
            int seconds = Int16.Parse(time.Split(':')[1]);
            int totalTime = (minutes * 60) + seconds;
            return totalTime;

        }

        public void generatePreviews()
        {
            frmSettings settings = new frmSettings();

            pgProgressBar.Minimum = 0;
            pgProgressBar.Maximum = selectedFiles.Count;
            btnRun.Visible = false;
            pgProgressBar.Visible = true;
            lblProgressText.Visible = true;

            // Preview Generator code

            // Formatting start time
            int startTime = getTimeSeconds(txtboxStart.Text);
            int endTime = getTimeSeconds(txtboxEnd.Text);
            string command = @"-ss {0} -to {1} -i ""{2}"" -c copy ""{3}""";

            foreach (String file in selectedFiles)
            {
                // Create process for trimming the video
                Process ffmpeg = new Process();
                ffmpeg.StartInfo.RedirectStandardOutput = false;
                ffmpeg.StartInfo.RedirectStandardError = false;
                ffmpeg.StartInfo.FileName = "ffmpeg.exe";
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.CreateNoWindow = true;

                // Formatting preview filename
                string fullFileName = Path.GetFileName(file);
                int idx = fullFileName.LastIndexOf('.');
                string fileName = fullFileName[..idx];
                string fileExt = fullFileName[(idx + 1)..];
                string newFileName = string.Format("{0}{1}.{2}", fileName, suffix, fileExt);
                string outputFile = Path.Join(outputPath, newFileName);

                // check if output file already exists
                if (File.Exists(outputFile))
                {
                    // Success message
                    string errorMessage = String.Format(@"The file {0} already exists, would you like to replace it?", outputFile);
                    string errorTitle = "Error: File already exists";
                    MessageBoxButtons b = MessageBoxButtons.YesNo;
                    DialogResult r;
                    r = MessageBox.Show(errorMessage, errorTitle, b);
                    if(r == DialogResult.Yes)
                    {
                        // replace file
                        File.Delete(outputFile);

                        ffmpeg.StartInfo.Arguments = string.Format(command, startTime.ToString(), endTime.ToString(), file, outputFile);
                        ffmpeg.Start();
                        pgProgressBar.Value += 1;
                        lblProgressText.Text = String.Format(@"Generating preview {0}/{1}...", pgProgressBar.Value.ToString(), selectedFiles.Count);
                        ffmpeg.WaitForExit();
                        previewsGenerated++;
                    }
                    else
                    {
                        continue;
                    }
                } else
                {
                    ffmpeg.StartInfo.Arguments = string.Format(command, startTime.ToString(), endTime.ToString(), file, outputFile);
                    ffmpeg.Start();
                    pgProgressBar.Value += 1;
                    lblProgressText.Text = String.Format(@"Generating preview {0}/{1}...", pgProgressBar.Value.ToString(), selectedFiles.Count);
                    ffmpeg.WaitForExit();
                    previewsGenerated++;
                }

            }

            lblProgressText.Text = "Complete.";

            // Success message
            string message = String.Format(@"{0} previews have been generated and saved to {1}", previewsGenerated, outputPath);
            string caption = "Success!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                pgProgressBar.Visible = false;
                pgProgressBar.Value = 0;
                lblProgressText.Visible = false;
                btnRun.Visible = true;
            }
            else
            {
                pgProgressBar.Visible = false;
                pgProgressBar.Value = 0;
                lblProgressText.Visible = false;
                btnRun.Visible = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            previewsGenerated = 0;

            // Create regex pattern for timestamps
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            if (!rg.IsMatch(txtboxStart.Text) || !rg.IsMatch(txtboxEnd.Text))
            {

                // Format error message
                string message = "Please enter valid start and end timestamps in the following format (MM:SS).";
                string caption = "Timestamp Format Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);


            } 
            else if (getTimeSeconds(txtboxStart.Text) >= getTimeSeconds(txtboxEnd.Text))
            {
                // Timestamp length error message
                string message = "Please ensure the start timestamp is before the end timestamp.";
                string caption = "Timestamp Length Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {  
                generatePreviews();
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

    }
}

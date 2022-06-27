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
        private List<String> selectedFiles = null;
        private String outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public frmTGFileGrid()
        {
            InitializeComponent();
        }

        public frmTGFileGrid(List<String> selectedFiles)
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
            int minutes = Int16.Parse(time.Split(':')[0]);
            int seconds = Int16.Parse(time.Split(':')[1]);
            int totalTime = (minutes * 60) + seconds;

            return totalTime;
        }

        public void generateThumbnails()
        {
            tgProgressBar.Minimum = 0;
            tgProgressBar.Maximum = selectedFiles.Count;
            btnRun.Visible = false;
            tgProgressBar.Visible = true;
            lblProgressText.Visible = true;

            // Preview Generator code

            // Formatting start time
            int timestamp = getTimeSeconds(txtboxTimestamp.Text);
            // string command = @"-ss {0} -to {1} -i ""{2}"" -c copy ""{3}""";
            string command = @"-i ""{0}"" -vframes 1 -an -ss {1} ""{2}""";

            foreach (String file in selectedFiles)
            {
                // Create process for trimming the video
                Process ffmpeg = new Process();
                ffmpeg.StartInfo.RedirectStandardOutput = false;
                ffmpeg.StartInfo.RedirectStandardError = false;
                ffmpeg.StartInfo.FileName = "ffmpeg.exe"; // TODO: Maybe this fixes the above ^ ??
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.CreateNoWindow = true;

                // Formatting preview filename
                string fullFileName = Path.GetFileName(file);
                int idx = fullFileName.LastIndexOf('.');
                string fileName = fullFileName[..idx];
                string newFileName = string.Format("{0}.jpg", fileName);
                string outputFile = Path.Join(outputPath, newFileName);

                ffmpeg.StartInfo.Arguments = string.Format(command, file, timestamp.ToString(), outputFile);
                ffmpeg.Start();
                tgProgressBar.Value += 1;
                lblProgressText.Text = String.Format(@"Generating thumbnail {0}/{1}...", tgProgressBar.Value.ToString(), selectedFiles.Count);
                ffmpeg.WaitForExit();
            }

            lblProgressText.Text = "Complete.";

            // Success message
            string message = String.Format(@"{0} thumbnails have been generated and saved to {1}", selectedFiles.Count, outputPath);
            string caption = "Success!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                tgProgressBar.Visible = false;
                tgProgressBar.Value = 0;
                lblProgressText.Visible = false;
                btnRun.Visible = true;
            }
            else
            {
                tgProgressBar.Visible = false;
                tgProgressBar.Value = 0;
                lblProgressText.Visible = false;
                btnRun.Visible = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Application.ExecutablePath);
            // Create regex pattern for timestamps
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            if (!rg.IsMatch(txtboxTimestamp.Text))
            {
                // Format error message
                string message = "Please enter a valid timestamp in the following format (MM:SS).";
                string caption = "Timestamp Format Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                generateThumbnails();
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

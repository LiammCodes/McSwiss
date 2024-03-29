﻿using System;
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
    public partial class frmHTGFileGrid : Form
    {
        private List<String> selectedFiles = null;
        private String outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        private int thumbnailsGenerated = 0;
        public frmHTGFileGrid()
        {
            InitializeComponent();
        }

        public frmHTGFileGrid(List<String> selectedFiles)
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
            // Thumbnail Generator code

            // Formatting start time
            int timestamp = getTimeSeconds(txtboxTimestamp.Text);
            string command = @"-ss {0} -i ""{1}"" -vframes 1 -an ""{2}""";

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

                // check if output file already exists
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

                        ffmpeg.StartInfo.Arguments = string.Format(command, timestamp.ToString(), file, outputFile);
                        ffmpeg.Start();
                        tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));
                        lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating thumbnail {0}/{1}...", tgProgressBar.Value.ToString(), selectedFiles.Count)));
                        ffmpeg.WaitForExit();
                        thumbnailsGenerated++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    ffmpeg.StartInfo.Arguments = string.Format(command, timestamp.ToString(), file, outputFile);
                    ffmpeg.Start();
                    tgProgressBar.Invoke((MethodInvoker)(() => tgProgressBar.Value += 1));
                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating thumbnail {0}/{1}...", tgProgressBar.Value.ToString(), selectedFiles.Count)));
                    ffmpeg.WaitForExit();
                    thumbnailsGenerated++;
                }
            }

            lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Complete."));
            imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

            // Success message
            string message = String.Format(@"{0} thumbnails have been generated and saved to {1}", thumbnailsGenerated, outputPath);
            string caption = "Success!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            thumbnailsGenerated = 0;

            // Create regex pattern for timestamps
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            if (!rg.IsMatch(txtboxTimestamp.Text) || txtboxTimestamp.Text.Length != 5)
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
                tgProgressBar.Minimum = 0;
                tgProgressBar.Maximum = selectedFiles.Count;
                btnRun.Visible = false;
                tgProgressBar.Visible = true;
                lblProgressText.Visible = true;
                imgLoading.Visible = true;
                backgroundWorker1.RunWorkerAsync();
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
                    } else
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

        private void lstFileGrid_DoubleClick(object sender, EventArgs e)
        {
            Process openMp4 = new Process();

            openMp4.StartInfo.FileName = selectedFiles[lstFileGrid.SelectedIndices[0]];
            openMp4.StartInfo.UseShellExecute = true;
            openMp4.Start();
        }
    }
}
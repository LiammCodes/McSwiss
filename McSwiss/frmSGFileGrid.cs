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
using McSwiss.Properties;

namespace McSwiss
{
    public partial class frmSGFileGrid : Form
    {
        private string selectedFile = null;
        private string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        private List<frmSegment> frmList = new List<frmSegment>();
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private bool numbers = settings.Default.SGNumbers;
        private int segmentsGenerated = 0;

        public frmSGFileGrid()
        {
            InitializeComponent();
        }

        public frmSGFileGrid(string selectedFile)
        {
            this.selectedFile = selectedFile;
            InitializeComponent();
        }

        private void btnAddSegment_Click(object sender, EventArgs e)
        {
            if (frmList.Count <= 26)
            {
                frmSegment segment_var = new frmSegment(this) { Dock = DockStyle.Top, TopLevel = false, TopMost = true };
                segment_var.FormBorderStyle = FormBorderStyle.None;
                frmList.Insert(0, segment_var);

                // format filename
                string fullFileName = Path.GetFileName(selectedFile);
                int idx = fullFileName.LastIndexOf('.');
                string fileName = fullFileName[..idx];
                string segTitle;
                if (numbers)
                {
                    segTitle = String.Format("{0}_{1}", fileName, frmList.Count().ToString());
                }
                else
                {
                    segTitle = String.Format("{0}_{1}", fileName, alphabet[frmList.Count() - 1].ToString());
                }

                string fileExt = fullFileName[(idx + 1)..];
                string newFileName = String.Format("{0}.{1}", segTitle, fileExt);
                string outputFile = Path.Join(outputPath, newFileName);

                segment_var.SegmentTitle = segTitle;
                this.pnlSegmentList.Controls.Clear();
                this.pnlSegmentList.Controls.AddRange(frmList.ToArray());

                foreach (frmSegment segment in frmList)
                {
                    segment.Show();
                }

                if (frmList.Count == 26)
                {
                    btnAddSegment.Enabled = false;
                }
            }
        }

        private void btnRemoveSegment_Click(object sender, EventArgs e)
        {
            if (frmList.Count > 0)
            {
                frmSegment lastSegment = frmList.First();
                frmList.Remove(lastSegment);
                this.pnlSegmentList.Controls.Remove(lastSegment);
                btnAddSegment.Enabled = true;
            }

        }

        private void lstFileGrid_Enter(object sender, EventArgs e)
        {
            lstFileGrid.Items.Clear();
            lblOutputPath.Text = outputPath;

            imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(selectedFile));
            FileInfo fi = new FileInfo(selectedFile);

            lstFileGrid.Items.Add(fi.Name, imgList.Images.Count - 1);

        }

        private int getTimeSeconds(String time)
        {
            int minutes = Int16.Parse(time.Split(':')[0]);
            int seconds = Int16.Parse(time.Split(':')[1]);
            int totalTime = (minutes * 60) + seconds;
            return totalTime;
        }

        public void generateSegments()
        {
            // Segment Generator code
            // {0}: input
            // {1}: start time
            // {2}: end time
            // {3}: output
            string command = @"-i ""{0}"" -ss {1} -to {2} -async 1 ""{3}""";

            foreach (frmSegment segment in frmList)
            {
                // Create process for trimming the video
                Process ffmpeg = new Process();
                ffmpeg.StartInfo.RedirectStandardOutput = false;
                ffmpeg.StartInfo.RedirectStandardError = false;
                ffmpeg.StartInfo.FileName = "ffmpeg.exe";
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.CreateNoWindow = true;

                // Formatting start time
                int startTime = getTimeSeconds(segment.StartTime);
                int endTime = getTimeSeconds(segment.EndTime);

                // Formatting preview filename
                string fullFileName = Path.GetFileName(selectedFile);
                int idx = fullFileName.LastIndexOf('.');
                string fileName = fullFileName[..idx];
                string fileExt = fullFileName[(idx + 1)..];

                string outputFile = Path.Join(outputPath, String.Format("{0}.{1}", segment.SegmentTitle, fileExt));

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

                        ffmpeg.StartInfo.Arguments = string.Format(command, selectedFile, startTime.ToString(), endTime.ToString(), outputFile);
                        ffmpeg.Start();
                        sgProgressBar.Invoke((MethodInvoker)(() => sgProgressBar.Value += 1));
                        lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating segment {0}/{1}...", sgProgressBar.Value.ToString(), frmList.Count)));
                        ffmpeg.WaitForExit();
                        segmentsGenerated++;

                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    ffmpeg.StartInfo.Arguments = string.Format(command, selectedFile, startTime.ToString(), endTime.ToString(), outputFile);
                    ffmpeg.Start();
                    sgProgressBar.Invoke((MethodInvoker)(() => sgProgressBar.Value += 1));
                    lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = String.Format(@"Generating segment {0}/{1}...", sgProgressBar.Value.ToString(), frmList.Count)));
                    ffmpeg.WaitForExit();
                    segmentsGenerated++;
                }
            }

            lblProgressText.Invoke((MethodInvoker)(() => lblProgressText.Text = "Complete."));
            imgLoading.Invoke((MethodInvoker)(() => imgLoading.Visible = false));

            // Success message
            string message = String.Format(@"{0} segments have been generated and saved to {1}", segmentsGenerated, outputPath);
            string caption = "Success!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            segmentsGenerated = 0;
            bool formatedCorrectly = true;
            bool correctLength = true;

            // Create regex pattern for timestamps
            string pattern = @"(2[0-3]|[01][0-9]):[0-5][0-9]";
            Regex rg = new Regex(pattern);

            foreach (frmSegment segment in frmList)
            {
                if (!rg.IsMatch(segment.StartTime) || !rg.IsMatch(segment.EndTime) || segment.StartTime.Length != 5 || segment.EndTime.Length != 5)
                {
                    formatedCorrectly = false;
                    break;
                }

                if (getTimeSeconds(segment.StartTime) >= getTimeSeconds(segment.EndTime))
                {
                    correctLength = false;
                    Debug.Print(@"start: {0}    end: {1}", getTimeSeconds(segment.StartTime).ToString(), getTimeSeconds(segment.EndTime).ToString());
                    break;
                }
            }

            if (!formatedCorrectly)
            {
                // Format error message
                string message = "Please enter valid start and end timestamps in the following format (MM:SS) for each segment.";
                string caption = "Timestamp Format Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else if (!correctLength)
            {
                // Timestamp length error message
                string message = "Please ensure the start timestamp is before the end timestamp for each segment.";
                string caption = "Timestamp Length Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                sgProgressBar.Minimum = 0;
                sgProgressBar.Maximum = frmList.Count;
                btnRun.Visible = false;
                sgProgressBar.Visible = true;
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

        private void lstFileGrid_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstFileGrid_DragDrop(object sender, DragEventArgs e)
        {
            string newFile = e.Data.GetData(DataFormats.FileDrop).ToString();
            if (newFile != null && newFile.Any())
            {
                selectedFile = newFile;

                lstFileGrid.Items.Clear();

                imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(selectedFile));
                FileInfo fi = new FileInfo(selectedFile);

                lstFileGrid.Items.Add(fi.Name, imgList.Images.Count - 1);


            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            generateSegments();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sgProgressBar.Visible = false;
            sgProgressBar.Value = 0;
            lblProgressText.Visible = false;
            btnRun.Visible = true;
        }

        private void lstFileGrid_DoubleClick(object sender, EventArgs e)
        {
            Process openMp4 = new Process();

            openMp4.StartInfo.FileName = selectedFile;
            openMp4.StartInfo.UseShellExecute = true;
            openMp4.Start();
        }
    }
}
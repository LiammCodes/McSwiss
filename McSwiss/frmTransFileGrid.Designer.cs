namespace McSwiss
{
    partial class frmTransFileGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransFileGrid));
            this.lstFileGrid = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.tgProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRunDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFileGrid
            // 
            this.lstFileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFileGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lstFileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFileGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFileGrid.ForeColor = System.Drawing.Color.White;
            this.lstFileGrid.LargeImageList = this.imgList;
            this.lstFileGrid.Location = new System.Drawing.Point(12, 12);
            this.lstFileGrid.Name = "lstFileGrid";
            this.lstFileGrid.Size = new System.Drawing.Size(741, 390);
            this.lstFileGrid.TabIndex = 0;
            this.lstFileGrid.UseCompatibleStateImageBehavior = false;
            this.lstFileGrid.DoubleClick += new System.EventHandler(this.lstFileGrid_DoubleClick);
            this.lstFileGrid.Enter += new System.EventHandler(this.lstFileGrid_Enter);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(32, 32);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(577, 419);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(176, 56);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Transcribe and Upload to S3";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(12, 422);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 15);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output:";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputPath.AutoEllipsis = true;
            this.lblOutputPath.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutputPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOutputPath.Location = new System.Drawing.Point(12, 451);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(302, 16);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "C:\\path\\to\\output\\";
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSelectOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOutput.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectOutput.ForeColor = System.Drawing.Color.White;
            this.btnSelectOutput.Location = new System.Drawing.Point(72, 419);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(75, 24);
            this.btnSelectOutput.TabIndex = 3;
            this.btnSelectOutput.Text = "browse...";
            this.btnSelectOutput.UseVisualStyleBackColor = false;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // tgProgressBar
            // 
            this.tgProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tgProgressBar.Location = new System.Drawing.Point(169, 420);
            this.tgProgressBar.Name = "tgProgressBar";
            this.tgProgressBar.Size = new System.Drawing.Size(584, 23);
            this.tgProgressBar.TabIndex = 8;
            this.tgProgressBar.Visible = false;
            // 
            // lblProgressText
            // 
            this.lblProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressText.AutoEllipsis = true;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgressText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgressText.Location = new System.Drawing.Point(528, 454);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(191, 16);
            this.lblProgressText.TabIndex = 9;
            this.lblProgressText.Text = "Transcribing video x/n...";
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProgressText.Visible = false;
            // 
            // imgLoading
            // 
            this.imgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(726, 451);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(22, 22);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 11;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnRunDownload
            // 
            this.btnRunDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRunDownload.FlatAppearance.BorderSize = 0;
            this.btnRunDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunDownload.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunDownload.ForeColor = System.Drawing.Color.White;
            this.btnRunDownload.Location = new System.Drawing.Point(395, 419);
            this.btnRunDownload.Name = "btnRunDownload";
            this.btnRunDownload.Size = new System.Drawing.Size(176, 56);
            this.btnRunDownload.TabIndex = 12;
            this.btnRunDownload.Text = "Transcribe and Download";
            this.btnRunDownload.UseVisualStyleBackColor = false;
            this.btnRunDownload.Click += new System.EventHandler(this.btnRunDownload_Click);
            // 
            // frmTransFileGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.tgProgressBar);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lstFileGrid);
            this.Controls.Add(this.btnRunDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransFileGrid";
            this.Text = "frmFileGrid";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmFileGrid_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmFileGrid_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstFileGrid;
        private ImageList imgList;
        private Button btnRun;
        private Label lblOutput;
        private Label lblOutputPath;
        private Button btnSelectOutput;
        private ProgressBar tgProgressBar;
        private Label lblProgressText;
        private PictureBox imgLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnRunDownload;
    }
}
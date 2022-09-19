namespace McSwiss
{
    partial class frmTGFileGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTGFileGrid));
            this.lstFileGrid = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.txtboxTimestamp = new System.Windows.Forms.TextBox();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.tgProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlTileBG = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFileGrid
            // 
            this.lstFileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFileGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lstFileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFileGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFileGrid.ForeColor = System.Drawing.Color.White;
            this.lstFileGrid.LargeImageList = this.imgList;
            this.lstFileGrid.Location = new System.Drawing.Point(28, 22);
            this.lstFileGrid.Name = "lstFileGrid";
            this.lstFileGrid.Size = new System.Drawing.Size(217, 309);
            this.lstFileGrid.TabIndex = 0;
            this.lstFileGrid.UseCompatibleStateImageBehavior = false;
            this.lstFileGrid.Enter += new System.EventHandler(this.lstFileGrid_Enter);
            this.lstFileGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFileGrid_MouseDoubleClick);
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
            this.btnRun.Location = new System.Drawing.Point(577, 422);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(176, 53);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Save Thumbnail";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Visible = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtboxTimestamp
            // 
            this.txtboxTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxTimestamp.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxTimestamp.Location = new System.Drawing.Point(95, 422);
            this.txtboxTimestamp.Name = "txtboxTimestamp";
            this.txtboxTimestamp.PlaceholderText = "00:00";
            this.txtboxTimestamp.Size = new System.Drawing.Size(56, 23);
            this.txtboxTimestamp.TabIndex = 1;
            this.txtboxTimestamp.Text = "00:00";
            this.txtboxTimestamp.TextChanged += new System.EventHandler(this.txtboxTimestamp_TextChanged);
            this.txtboxTimestamp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxTimestamp_KeyUp);
            this.txtboxTimestamp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtboxTimestamp_MouseUp);
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimestamp.ForeColor = System.Drawing.Color.White;
            this.lblTimestamp.Location = new System.Drawing.Point(19, 425);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(70, 15);
            this.lblTimestamp.TabIndex = 4;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(212, 425);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 15);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output:";
            this.lblOutput.Visible = false;
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputPath.AutoEllipsis = true;
            this.lblOutputPath.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutputPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOutputPath.Location = new System.Drawing.Point(212, 454);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(302, 16);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "C:\\path\\to\\output\\";
            this.lblOutputPath.Visible = false;
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSelectOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOutput.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectOutput.ForeColor = System.Drawing.Color.White;
            this.btnSelectOutput.Location = new System.Drawing.Point(272, 422);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(75, 24);
            this.btnSelectOutput.TabIndex = 3;
            this.btnSelectOutput.Text = "browse...";
            this.btnSelectOutput.UseVisualStyleBackColor = false;
            this.btnSelectOutput.Visible = false;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // tgProgressBar
            // 
            this.tgProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tgProgressBar.Location = new System.Drawing.Point(369, 422);
            this.tgProgressBar.Name = "tgProgressBar";
            this.tgProgressBar.Size = new System.Drawing.Size(384, 23);
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
            this.lblProgressText.Text = "Generating thumbnail x/n...";
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
            // imgView
            // 
            this.imgView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgView.Image = ((System.Drawing.Image)(resources.GetObject("imgView.Image")));
            this.imgView.Location = new System.Drawing.Point(272, 12);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(480, 270);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgView.TabIndex = 12;
            this.imgView.TabStop = false;
            this.imgView.Visible = false;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(265, 304);
            this.trackBar.Maximum = 19;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(495, 45);
            this.trackBar.TabIndex = 13;
            this.trackBar.Visible = false;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(19, 451);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 24);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Grab Thumbnails";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlTileBG
            // 
            this.pnlTileBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlTileBG.Location = new System.Drawing.Point(19, 12);
            this.pnlTileBG.Name = "pnlTileBG";
            this.pnlTileBG.Size = new System.Drawing.Size(240, 337);
            this.pnlTileBG.TabIndex = 15;
            // 
            // frmTGFileGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.lstFileGrid);
            this.Controls.Add(this.pnlTileBG);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.imgView);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.tgProgressBar);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.txtboxTimestamp);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTGFileGrid";
            this.Text = "frmFileGrid";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmFileGrid_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmFileGrid_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstFileGrid;
        private ImageList imgList;
        private Button btnRun;
        private TextBox txtboxTimestamp;
        private Label lblTimestamp;
        private Label lblOutput;
        private Label lblOutputPath;
        private Button btnSelectOutput;
        private ProgressBar tgProgressBar;
        private Label lblProgressText;
        private PictureBox imgLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox imgView;
        private TrackBar trackBar;
        private Button btnStart;
        private Panel pnlTileBG;
    }
}
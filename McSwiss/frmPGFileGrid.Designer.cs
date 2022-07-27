namespace McSwiss
{
    partial class frmPGFileGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPGFileGrid));
            this.lstFileGrid = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.txtboxStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.pgProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.btnRun.Location = new System.Drawing.Point(577, 422);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(176, 53);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Generate Previews 🎬";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtboxEnd
            // 
            this.txtboxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxEnd.Location = new System.Drawing.Point(129, 452);
            this.txtboxEnd.Name = "txtboxEnd";
            this.txtboxEnd.PlaceholderText = "00:00";
            this.txtboxEnd.Size = new System.Drawing.Size(56, 23);
            this.txtboxEnd.TabIndex = 2;
            // 
            // txtboxStart
            // 
            this.txtboxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxStart.Location = new System.Drawing.Point(129, 422);
            this.txtboxStart.Name = "txtboxStart";
            this.txtboxStart.PlaceholderText = "00:00";
            this.txtboxStart.Size = new System.Drawing.Size(56, 23);
            this.txtboxStart.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(19, 425);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(98, 15);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Timestamp:";
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(24, 455);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(93, 15);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End Timestamp:";
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
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // pgProgressBar
            // 
            this.pgProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgProgressBar.Location = new System.Drawing.Point(369, 422);
            this.pgProgressBar.Name = "pgProgressBar";
            this.pgProgressBar.Size = new System.Drawing.Size(384, 23);
            this.pgProgressBar.TabIndex = 8;
            this.pgProgressBar.Visible = false;
            // 
            // lblProgressText
            // 
            this.lblProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressText.AutoEllipsis = true;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgressText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgressText.Location = new System.Drawing.Point(529, 455);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(191, 16);
            this.lblProgressText.TabIndex = 9;
            this.lblProgressText.Text = "Generating preview x/n...";
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProgressText.Visible = false;
            // 
            // imgLoading
            // 
            this.imgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(726, 453);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(22, 22);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 10;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmPGFileGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtboxStart);
            this.Controls.Add(this.txtboxEnd);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lstFileGrid);
            this.Controls.Add(this.pgProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPGFileGrid";
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
        private TextBox txtboxEnd;
        private TextBox txtboxStart;
        private Label lblStart;
        private Label lblEnd;
        private Label lblOutput;
        private Label lblOutputPath;
        private Button btnSelectOutput;
        private ProgressBar pgProgressBar;
        private Label lblProgressText;
        private PictureBox imgLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
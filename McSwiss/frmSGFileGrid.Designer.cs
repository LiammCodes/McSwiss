namespace McSwiss
{
    partial class frmSGFileGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSGFileGrid));
            this.pnlGenButton = new System.Windows.Forms.Panel();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.sgProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRemoveSegment = new System.Windows.Forms.Button();
            this.btnAddSegment = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lstFileGrid = new System.Windows.Forms.ListView();
            this.pnlSegmentList = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlGenButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGenButton
            // 
            this.pnlGenButton.Controls.Add(this.imgLoading);
            this.pnlGenButton.Controls.Add(this.lblProgressText);
            this.pnlGenButton.Controls.Add(this.sgProgressBar);
            this.pnlGenButton.Controls.Add(this.btnSelectOutput);
            this.pnlGenButton.Controls.Add(this.lblOutputPath);
            this.pnlGenButton.Controls.Add(this.lblOutput);
            this.pnlGenButton.Controls.Add(this.btnRun);
            this.pnlGenButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGenButton.Location = new System.Drawing.Point(0, 419);
            this.pnlGenButton.Name = "pnlGenButton";
            this.pnlGenButton.Size = new System.Drawing.Size(765, 68);
            this.pnlGenButton.TabIndex = 0;
            // 
            // imgLoading
            // 
            this.imgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(731, 37);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(22, 22);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 13;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // lblProgressText
            // 
            this.lblProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressText.AutoEllipsis = true;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgressText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgressText.Location = new System.Drawing.Point(534, 40);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(191, 16);
            this.lblProgressText.TabIndex = 12;
            this.lblProgressText.Text = "Generating segment x/n...";
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProgressText.Visible = false;
            // 
            // sgProgressBar
            // 
            this.sgProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sgProgressBar.Location = new System.Drawing.Point(369, 8);
            this.sgProgressBar.Name = "sgProgressBar";
            this.sgProgressBar.Size = new System.Drawing.Size(384, 23);
            this.sgProgressBar.TabIndex = 11;
            this.sgProgressBar.Visible = false;
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSelectOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOutput.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectOutput.ForeColor = System.Drawing.Color.White;
            this.btnSelectOutput.Location = new System.Drawing.Point(72, 8);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(75, 24);
            this.btnSelectOutput.TabIndex = 8;
            this.btnSelectOutput.Text = "browse...";
            this.btnSelectOutput.UseVisualStyleBackColor = false;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputPath.AutoEllipsis = true;
            this.lblOutputPath.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutputPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOutputPath.Location = new System.Drawing.Point(12, 40);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(302, 16);
            this.lblOutputPath.TabIndex = 10;
            this.lblOutputPath.Text = "C:\\path\\to\\output\\";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(12, 11);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 15);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output:";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(534, 11);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(219, 46);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Generate Segments";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRemoveSegment
            // 
            this.btnRemoveSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRemoveSegment.FlatAppearance.BorderSize = 0;
            this.btnRemoveSegment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSegment.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSegment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSegment.Location = new System.Drawing.Point(59, 6);
            this.btnRemoveSegment.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveSegment.Name = "btnRemoveSegment";
            this.btnRemoveSegment.Size = new System.Drawing.Size(68, 24);
            this.btnRemoveSegment.TabIndex = 5;
            this.btnRemoveSegment.Text = "Remove";
            this.btnRemoveSegment.UseVisualStyleBackColor = false;
            this.btnRemoveSegment.Click += new System.EventHandler(this.btnRemoveSegment_Click);
            // 
            // btnAddSegment
            // 
            this.btnAddSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAddSegment.FlatAppearance.BorderSize = 0;
            this.btnAddSegment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSegment.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSegment.ForeColor = System.Drawing.Color.White;
            this.btnAddSegment.Location = new System.Drawing.Point(10, 6);
            this.btnAddSegment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSegment.Name = "btnAddSegment";
            this.btnAddSegment.Size = new System.Drawing.Size(40, 24);
            this.btnAddSegment.TabIndex = 4;
            this.btnAddSegment.Text = "Add";
            this.btnAddSegment.UseVisualStyleBackColor = false;
            this.btnAddSegment.Click += new System.EventHandler(this.btnAddSegment_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(32, 32);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstFileGrid
            // 
            this.lstFileGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lstFileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFileGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.lstFileGrid.LargeImageList = this.imgList;
            this.lstFileGrid.Location = new System.Drawing.Point(12, 0);
            this.lstFileGrid.Name = "lstFileGrid";
            this.lstFileGrid.Size = new System.Drawing.Size(516, 399);
            this.lstFileGrid.TabIndex = 0;
            this.lstFileGrid.UseCompatibleStateImageBehavior = false;
            this.lstFileGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFileGrid_DragDrop);
            this.lstFileGrid.DragOver += new System.Windows.Forms.DragEventHandler(this.lstFileGrid_DragOver);
            this.lstFileGrid.DoubleClick += new System.EventHandler(this.lstFileGrid_DoubleClick);
            this.lstFileGrid.Enter += new System.EventHandler(this.lstFileGrid_Enter);
            // 
            // pnlSegmentList
            // 
            this.pnlSegmentList.AutoScroll = true;
            this.pnlSegmentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlSegmentList.Location = new System.Drawing.Point(534, 0);
            this.pnlSegmentList.Name = "pnlSegmentList";
            this.pnlSegmentList.Size = new System.Drawing.Size(219, 382);
            this.pnlSegmentList.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnAddSegment);
            this.panel1.Controls.Add(this.btnRemoveSegment);
            this.panel1.Location = new System.Drawing.Point(534, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 36);
            this.panel1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmSGFileGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSegmentList);
            this.Controls.Add(this.lstFileGrid);
            this.Controls.Add(this.pnlGenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(765, 487);
            this.MinimumSize = new System.Drawing.Size(765, 487);
            this.Name = "frmSGFileGrid";
            this.Text = "frmSGFileGrid";
            this.pnlGenButton.ResumeLayout(false);
            this.pnlGenButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlGenButton;
        private ImageList imgList;
        private ListView lstFileGrid;
        private Panel pnlSegmentList;
        private Button btnAddSegment;
        private Button btnRemoveSegment;
        private Panel panel1;
        private Button btnRun;
        private Button btnSelectOutput;
        private Label lblOutputPath;
        private Label lblOutput;
        private Label lblProgressText;
        private ProgressBar sgProgressBar;
        private PictureBox imgLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
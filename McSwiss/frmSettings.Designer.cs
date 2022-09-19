namespace McSwiss
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblPG = new System.Windows.Forms.Label();
            this.lblSG = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblAboutName = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblDeveloped = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblPrevSuffix = new System.Windows.Forms.Label();
            this.lblSegSuffix = new System.Windows.Forms.Label();
            this.rdioNumbers = new System.Windows.Forms.RadioButton();
            this.rdioLetters = new System.Windows.Forms.RadioButton();
            this.txtBoxSuffix = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.imgThumbsUp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblExample = new System.Windows.Forms.Label();
            this.imgWarning = new System.Windows.Forms.PictureBox();
            this.lblLetterWarning = new System.Windows.Forms.Label();
            this.txtBoxAcccessKeyID = new System.Windows.Forms.TextBox();
            this.lblAccessKeyID = new System.Windows.Forms.Label();
            this.lblTansGen = new System.Windows.Forms.Label();
            this.txtBoxSecret = new System.Windows.Forms.TextBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPG
            // 
            this.lblPG.AutoSize = true;
            this.lblPG.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPG.ForeColor = System.Drawing.Color.White;
            this.lblPG.Location = new System.Drawing.Point(28, 30);
            this.lblPG.Name = "lblPG";
            this.lblPG.Size = new System.Drawing.Size(198, 30);
            this.lblPG.TabIndex = 2;
            this.lblPG.Text = "Preview Generator";
            // 
            // lblSG
            // 
            this.lblSG.AutoSize = true;
            this.lblSG.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSG.ForeColor = System.Drawing.Color.White;
            this.lblSG.Location = new System.Drawing.Point(28, 205);
            this.lblSG.Name = "lblSG";
            this.lblSG.Size = new System.Drawing.Size(208, 30);
            this.lblSG.TabIndex = 3;
            this.lblSG.Text = "Segment Generator";
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(478, 30);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(75, 30);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = "About";
            // 
            // pnlAbout
            // 
            this.pnlAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlAbout.Controls.Add(this.lblAboutName);
            this.pnlAbout.Controls.Add(this.lblProperty);
            this.pnlAbout.Controls.Add(this.lblDeveloped);
            this.pnlAbout.Controls.Add(this.lblVersion);
            this.pnlAbout.Location = new System.Drawing.Point(480, 72);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(245, 107);
            this.pnlAbout.TabIndex = 5;
            // 
            // lblAboutName
            // 
            this.lblAboutName.AutoSize = true;
            this.lblAboutName.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAboutName.Location = new System.Drawing.Point(6, 9);
            this.lblAboutName.Name = "lblAboutName";
            this.lblAboutName.Size = new System.Drawing.Size(169, 17);
            this.lblAboutName.TabIndex = 10;
            this.lblAboutName.Text = "McIntyre Swiss Army Knife";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProperty.ForeColor = System.Drawing.Color.LightGray;
            this.lblProperty.Location = new System.Drawing.Point(6, 76);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(192, 17);
            this.lblProperty.TabIndex = 9;
            this.lblProperty.Text = "Property of McIntyre Media Inc.";
            // 
            // lblDeveloped
            // 
            this.lblDeveloped.AutoSize = true;
            this.lblDeveloped.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeveloped.ForeColor = System.Drawing.Color.LightGray;
            this.lblDeveloped.Location = new System.Drawing.Point(6, 59);
            this.lblDeveloped.Name = "lblDeveloped";
            this.lblDeveloped.Size = new System.Drawing.Size(164, 17);
            this.lblDeveloped.TabIndex = 8;
            this.lblDeveloped.Text = "Developed by Liam Moore";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.LightGray;
            this.lblVersion.Location = new System.Drawing.Point(6, 37);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 17);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Version: 1.0.0.0";
            // 
            // lblPrevSuffix
            // 
            this.lblPrevSuffix.AutoSize = true;
            this.lblPrevSuffix.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrevSuffix.ForeColor = System.Drawing.Color.LightGray;
            this.lblPrevSuffix.Location = new System.Drawing.Point(31, 80);
            this.lblPrevSuffix.Name = "lblPrevSuffix";
            this.lblPrevSuffix.Size = new System.Drawing.Size(132, 17);
            this.lblPrevSuffix.TabIndex = 10;
            this.lblPrevSuffix.Text = "Preview name suffix:";
            // 
            // lblSegSuffix
            // 
            this.lblSegSuffix.AutoSize = true;
            this.lblSegSuffix.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegSuffix.ForeColor = System.Drawing.Color.LightGray;
            this.lblSegSuffix.Location = new System.Drawing.Point(31, 254);
            this.lblSegSuffix.Name = "lblSegSuffix";
            this.lblSegSuffix.Size = new System.Drawing.Size(264, 17);
            this.lblSegSuffix.TabIndex = 11;
            this.lblSegSuffix.Text = "Segment name suffix (letters or numbers):";
            // 
            // rdioNumbers
            // 
            this.rdioNumbers.AutoSize = true;
            this.rdioNumbers.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioNumbers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdioNumbers.Location = new System.Drawing.Point(35, 283);
            this.rdioNumbers.Name = "rdioNumbers";
            this.rdioNumbers.Size = new System.Drawing.Size(73, 20);
            this.rdioNumbers.TabIndex = 12;
            this.rdioNumbers.TabStop = true;
            this.rdioNumbers.Text = "Numbers";
            this.rdioNumbers.UseVisualStyleBackColor = true;
            // 
            // rdioLetters
            // 
            this.rdioLetters.AutoSize = true;
            this.rdioLetters.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioLetters.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdioLetters.Location = new System.Drawing.Point(35, 309);
            this.rdioLetters.Name = "rdioLetters";
            this.rdioLetters.Size = new System.Drawing.Size(60, 20);
            this.rdioLetters.TabIndex = 13;
            this.rdioLetters.TabStop = true;
            this.rdioLetters.Text = "Letters";
            this.rdioLetters.UseVisualStyleBackColor = true;
            this.rdioLetters.CheckedChanged += new System.EventHandler(this.rdioLetters_CheckedChanged);
            // 
            // txtBoxSuffix
            // 
            this.txtBoxSuffix.Location = new System.Drawing.Point(34, 103);
            this.txtBoxSuffix.Name = "txtBoxSuffix";
            this.txtBoxSuffix.Size = new System.Drawing.Size(191, 23);
            this.txtBoxSuffix.TabIndex = 14;
            this.txtBoxSuffix.Text = " Prev";
            this.txtBoxSuffix.TextChanged += new System.EventHandler(this.txtBoxSuffix_TextChanged);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(34, 410);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 35);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaved.ForeColor = System.Drawing.Color.LightGray;
            this.lblSaved.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSaved.Location = new System.Drawing.Point(169, 419);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(194, 17);
            this.lblSaved.TabIndex = 16;
            this.lblSaved.Text = "Your settings have been saved";
            this.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSaved.Visible = false;
            // 
            // imgThumbsUp
            // 
            this.imgThumbsUp.Image = ((System.Drawing.Image)(resources.GetObject("imgThumbsUp.Image")));
            this.imgThumbsUp.Location = new System.Drawing.Point(146, 417);
            this.imgThumbsUp.MaximumSize = new System.Drawing.Size(17, 19);
            this.imgThumbsUp.MinimumSize = new System.Drawing.Size(17, 19);
            this.imgThumbsUp.Name = "imgThumbsUp";
            this.imgThumbsUp.Size = new System.Drawing.Size(17, 19);
            this.imgThumbsUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgThumbsUp.TabIndex = 17;
            this.imgThumbsUp.TabStop = false;
            this.imgThumbsUp.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExample.ForeColor = System.Drawing.Color.LightGray;
            this.lblExample.Location = new System.Drawing.Point(31, 131);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(141, 17);
            this.lblExample.TabIndex = 18;
            this.lblExample.Text = "eg. filename Prev.mp4";
            // 
            // imgWarning
            // 
            this.imgWarning.Image = ((System.Drawing.Image)(resources.GetObject("imgWarning.Image")));
            this.imgWarning.Location = new System.Drawing.Point(35, 339);
            this.imgWarning.Name = "imgWarning";
            this.imgWarning.Size = new System.Drawing.Size(18, 19);
            this.imgWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWarning.TabIndex = 20;
            this.imgWarning.TabStop = false;
            this.imgWarning.Visible = false;
            // 
            // lblLetterWarning
            // 
            this.lblLetterWarning.AutoSize = true;
            this.lblLetterWarning.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLetterWarning.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblLetterWarning.Location = new System.Drawing.Point(59, 341);
            this.lblLetterWarning.Name = "lblLetterWarning";
            this.lblLetterWarning.Size = new System.Drawing.Size(330, 17);
            this.lblLetterWarning.TabIndex = 19;
            this.lblLetterWarning.Text = "With letter suffixes, you may only make 26 segments";
            this.lblLetterWarning.Visible = false;
            // 
            // txtBoxAcccessKeyID
            // 
            this.txtBoxAcccessKeyID.Location = new System.Drawing.Point(489, 277);
            this.txtBoxAcccessKeyID.Name = "txtBoxAcccessKeyID";
            this.txtBoxAcccessKeyID.Size = new System.Drawing.Size(191, 23);
            this.txtBoxAcccessKeyID.TabIndex = 23;
            // 
            // lblAccessKeyID
            // 
            this.lblAccessKeyID.AutoSize = true;
            this.lblAccessKeyID.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccessKeyID.ForeColor = System.Drawing.Color.LightGray;
            this.lblAccessKeyID.Location = new System.Drawing.Point(486, 254);
            this.lblAccessKeyID.Name = "lblAccessKeyID";
            this.lblAccessKeyID.Size = new System.Drawing.Size(109, 17);
            this.lblAccessKeyID.TabIndex = 22;
            this.lblAccessKeyID.Text = "S3 Access Key ID";
            // 
            // lblTansGen
            // 
            this.lblTansGen.AutoSize = true;
            this.lblTansGen.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTansGen.ForeColor = System.Drawing.Color.White;
            this.lblTansGen.Location = new System.Drawing.Point(480, 205);
            this.lblTansGen.Name = "lblTansGen";
            this.lblTansGen.Size = new System.Drawing.Size(215, 30);
            this.lblTansGen.TabIndex = 21;
            this.lblTansGen.Text = "Transcript Generator";
            // 
            // txtBoxSecret
            // 
            this.txtBoxSecret.Location = new System.Drawing.Point(489, 338);
            this.txtBoxSecret.Name = "txtBoxSecret";
            this.txtBoxSecret.PasswordChar = '●';
            this.txtBoxSecret.Size = new System.Drawing.Size(191, 23);
            this.txtBoxSecret.TabIndex = 25;
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecret.ForeColor = System.Drawing.Color.LightGray;
            this.lblSecret.Location = new System.Drawing.Point(486, 315);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(133, 17);
            this.lblSecret.TabIndex = 24;
            this.lblSecret.Text = "S3 Secret Access Key";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.txtBoxSecret);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.txtBoxAcccessKeyID);
            this.Controls.Add(this.lblAccessKeyID);
            this.Controls.Add(this.lblTansGen);
            this.Controls.Add(this.imgWarning);
            this.Controls.Add(this.lblLetterWarning);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.imgThumbsUp);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtBoxSuffix);
            this.Controls.Add(this.rdioLetters);
            this.Controls.Add(this.rdioNumbers);
            this.Controls.Add(this.lblSegSuffix);
            this.Controls.Add(this.lblPrevSuffix);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblSG);
            this.Controls.Add(this.lblPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(765, 487);
            this.MinimumSize = new System.Drawing.Size(765, 487);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPG;
        private Label lblSG;
        private Label lblAbout;
        private Panel pnlAbout;
        private Label lblVersion;
        private Label lblDeveloped;
        private Label lblProperty;
        private Label lblPrevSuffix;
        private Label lblSegSuffix;
        private RadioButton rdioNumbers;
        private RadioButton rdioLetters;
        private TextBox txtBoxSuffix;
        private Button btnApply;
        private Label lblSaved;
        private PictureBox imgThumbsUp;
        private System.Windows.Forms.Timer timer1;
        private Label lblExample;
        private PictureBox imgWarning;
        private Label lblLetterWarning;
        private Label lblAboutName;
        private TextBox txtBoxAcccessKeyID;
        private Label lblAccessKeyID;
        private Label lblTansGen;
        private TextBox txtBoxSecret;
        private Label lblSecret;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeveloped = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionTitle = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbsUp)).BeginInit();
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
            this.lblAbout.Location = new System.Drawing.Point(484, 30);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(75, 30);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDeveloped);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblVersionTitle);
            this.panel1.Location = new System.Drawing.Point(480, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 87);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Property of McIntyre Media Inc.";
            // 
            // lblDeveloped
            // 
            this.lblDeveloped.AutoSize = true;
            this.lblDeveloped.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeveloped.ForeColor = System.Drawing.Color.LightGray;
            this.lblDeveloped.Location = new System.Drawing.Point(7, 42);
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
            this.lblVersion.Location = new System.Drawing.Point(68, 8);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 17);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "1.0.0";
            // 
            // lblVersionTitle
            // 
            this.lblVersionTitle.AutoSize = true;
            this.lblVersionTitle.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVersionTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblVersionTitle.Location = new System.Drawing.Point(7, 8);
            this.lblVersionTitle.Name = "lblVersionTitle";
            this.lblVersionTitle.Size = new System.Drawing.Size(55, 17);
            this.lblVersionTitle.TabIndex = 6;
            this.lblVersionTitle.Text = "Version:";
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
            this.btnApply.Location = new System.Drawing.Point(34, 413);
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
            this.lblSaved.Location = new System.Drawing.Point(149, 422);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(194, 17);
            this.lblSaved.TabIndex = 16;
            this.lblSaved.Text = "Your settings have been saved";
            this.lblSaved.Visible = false;
            // 
            // imgThumbsUp
            // 
            this.imgThumbsUp.Image = ((System.Drawing.Image)(resources.GetObject("imgThumbsUp.Image")));
            this.imgThumbsUp.Location = new System.Drawing.Point(348, 415);
            this.imgThumbsUp.Name = "imgThumbsUp";
            this.imgThumbsUp.Size = new System.Drawing.Size(21, 26);
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
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.imgThumbsUp);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtBoxSuffix);
            this.Controls.Add(this.rdioLetters);
            this.Controls.Add(this.rdioNumbers);
            this.Controls.Add(this.lblSegSuffix);
            this.Controls.Add(this.lblPrevSuffix);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblSG);
            this.Controls.Add(this.lblPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(765, 487);
            this.MinimumSize = new System.Drawing.Size(765, 487);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThumbsUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPG;
        private Label lblSG;
        private Label lblAbout;
        private Panel panel1;
        private Label lblVersion;
        private Label lblVersionTitle;
        private Label lblDeveloped;
        private Label label1;
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
    }
}
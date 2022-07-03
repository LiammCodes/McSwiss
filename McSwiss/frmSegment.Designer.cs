namespace McSwiss
{
    partial class frmSegment
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
            this.lblSegmentTitle = new System.Windows.Forms.Label();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.txtBoxEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSegmentTitle
            // 
            this.lblSegmentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegmentTitle.AutoEllipsis = true;
            this.lblSegmentTitle.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegmentTitle.ForeColor = System.Drawing.Color.White;
            this.lblSegmentTitle.Location = new System.Drawing.Point(14, 11);
            this.lblSegmentTitle.Name = "lblSegmentTitle";
            this.lblSegmentTitle.Size = new System.Drawing.Size(224, 22);
            this.lblSegmentTitle.TabIndex = 15;
            this.lblSegmentTitle.Text = "Segment_a";
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStart.Location = new System.Drawing.Point(61, 47);
            this.txtBoxStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxStart.MaximumSize = new System.Drawing.Size(47, 23);
            this.txtBoxStart.MinimumSize = new System.Drawing.Size(47, 23);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.PlaceholderText = "00:00";
            this.txtBoxStart.Size = new System.Drawing.Size(47, 27);
            this.txtBoxStart.TabIndex = 0;
            this.txtBoxStart.TextChanged += new System.EventHandler(this.txtBoxStart_TextChanged);
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEnd.Location = new System.Drawing.Point(160, 47);
            this.txtBoxEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEnd.MaximumSize = new System.Drawing.Size(47, 23);
            this.txtBoxEnd.MinimumSize = new System.Drawing.Size(47, 23);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.PlaceholderText = "00:00";
            this.txtBoxEnd.Size = new System.Drawing.Size(47, 27);
            this.txtBoxEnd.TabIndex = 1;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(119, 51);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(38, 20);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "End:";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(14, 51);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(43, 20);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Start:";
            // 
            // frmSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(250, 92);
            this.Controls.Add(this.lblSegmentTitle);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.txtBoxEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSegment";
            this.Text = "frmSegment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSegmentTitle;
        private TextBox txtBoxStart;
        private TextBox txtBoxEnd;
        private Label lblEnd;
        private Label lblStart;
    }
}
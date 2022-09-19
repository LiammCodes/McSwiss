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
            this.lblSegmentTitle.Location = new System.Drawing.Point(12, 8);
            this.lblSegmentTitle.Name = "lblSegmentTitle";
            this.lblSegmentTitle.Size = new System.Drawing.Size(196, 24);
            this.lblSegmentTitle.TabIndex = 15;
            this.lblSegmentTitle.Text = "Segment_a";
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStart.Location = new System.Drawing.Point(53, 35);
            this.txtBoxStart.MaximumSize = new System.Drawing.Size(42, 23);
            this.txtBoxStart.MinimumSize = new System.Drawing.Size(42, 23);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.PlaceholderText = "00:00";
            this.txtBoxStart.Size = new System.Drawing.Size(42, 23);
            this.txtBoxStart.TabIndex = 0;
            this.txtBoxStart.Text = "00:00";
            this.txtBoxStart.TextChanged += new System.EventHandler(this.txtBoxStart_TextChanged);
            this.txtBoxStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxStart_KeyUp);
            this.txtBoxStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtBoxStart_MouseUp);
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEnd.Location = new System.Drawing.Point(140, 35);
            this.txtBoxEnd.MaximumSize = new System.Drawing.Size(42, 23);
            this.txtBoxEnd.MinimumSize = new System.Drawing.Size(42, 23);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.PlaceholderText = "00:00";
            this.txtBoxEnd.Size = new System.Drawing.Size(42, 23);
            this.txtBoxEnd.TabIndex = 1;
            this.txtBoxEnd.Text = "00:00";
            this.txtBoxEnd.TextChanged += new System.EventHandler(this.txtBoxEnd_TextChanged);
            this.txtBoxEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxEnd_KeyUp);
            this.txtBoxEnd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtBoxEnd_MouseUp);
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(104, 38);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 16);
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
            this.lblStart.Location = new System.Drawing.Point(12, 38);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 16);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Start:";
            // 
            // frmSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(219, 69);
            this.Controls.Add(this.lblSegmentTitle);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.txtBoxEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
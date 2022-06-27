namespace McSwiss
{
    partial class frmPreviewGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreviewGen));
            this.btnPGFiles = new System.Windows.Forms.Button();
            this.imgDAD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDAD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPGFiles
            // 
            this.btnPGFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPGFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPGFiles.FlatAppearance.BorderSize = 0;
            this.btnPGFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPGFiles.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPGFiles.ForeColor = System.Drawing.Color.Silver;
            this.btnPGFiles.Location = new System.Drawing.Point(332, 310);
            this.btnPGFiles.Name = "btnPGFiles";
            this.btnPGFiles.Size = new System.Drawing.Size(100, 35);
            this.btnPGFiles.TabIndex = 0;
            this.btnPGFiles.Text = "Select Files";
            this.btnPGFiles.UseVisualStyleBackColor = false;
            this.btnPGFiles.Click += new System.EventHandler(this.btnPGFiles_Click);
            // 
            // imgDAD
            // 
            this.imgDAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgDAD.Image = ((System.Drawing.Image)(resources.GetObject("imgDAD.Image")));
            this.imgDAD.Location = new System.Drawing.Point(0, 0);
            this.imgDAD.Name = "imgDAD";
            this.imgDAD.Size = new System.Drawing.Size(765, 487);
            this.imgDAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDAD.TabIndex = 2;
            this.imgDAD.TabStop = false;
            // 
            // frmPreviewGen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.btnPGFiles);
            this.Controls.Add(this.imgDAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPreviewGen";
            this.Text = "frmPreviewGen";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmPreviewGen_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmPreviewGen_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.imgDAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPGFiles;
        private PictureBox imgDAD;
    }
}
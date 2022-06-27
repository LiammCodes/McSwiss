﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McSwiss
{
    public partial class frmThumbnailGen : Form
    {
        private List<String> selectedFiles = new List<String>();
        public frmThumbnailGen()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public frmThumbnailGen(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnTGFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "Video Files|*.mp4;*.mov;*.avi;*.MP4;*.MOV;*.AVI";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        this.selectedFiles.Add(file);
                    }

                    mainForm.getFormLoader().Controls.Clear();
                    frmTGFileGrid frmTGFileGrid_Var = new frmTGFileGrid(selectedFiles) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmTGFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
                    mainForm.getFormLoader().Controls.Add(frmTGFileGrid_Var);
                    frmTGFileGrid_Var.Show();
                }
            }
        }

        private void frmThumbnailGen_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmThumbnailGen_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
            {
                string[] acceptableFileTypes = { ".mp4", ".mov", ".avi" };
                bool unacceptableFile = false;
                foreach (string file in files)
                {
                    if (acceptableFileTypes.Contains(Path.GetExtension(file).ToLower()))
                    {
                        this.selectedFiles.Add(file);
                    }
                    else
                    {
                        unacceptableFile = true;
                    }

                }
                if (unacceptableFile)
                {
                    // Warning message about unadded files
                    string message = "Some files were not added because of unacceptable filetypes.";
                    string caption = "Some files not added.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }

            mainForm.getFormLoader().Controls.Clear();
            frmTGFileGrid frmTGFileGrid_Var = new frmTGFileGrid(selectedFiles) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTGFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
            mainForm.getFormLoader().Controls.Add(frmTGFileGrid_Var);
            frmTGFileGrid_Var.Show();
        }
    }
}

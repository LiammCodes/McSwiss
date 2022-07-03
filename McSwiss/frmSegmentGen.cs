using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace McSwiss
{
    public partial class frmSegmentGen : Form
    {
        private string selectedFile;
        public frmSegmentGen()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public frmSegmentGen(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnSGFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Filter = "Video File|*.mp4;*.mov;*.avi;*.MP4;*.MOV;*.AVI";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.selectedFile = dialog.FileName;

                    mainForm.getFormLoader().Controls.Clear();
                    frmSGFileGrid frmSGFileGrid_Var = new frmSGFileGrid(selectedFile) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmSGFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
                    mainForm.getFormLoader().Controls.Add(frmSGFileGrid_Var);
                    frmSGFileGrid_Var.Show();
                }
            }
        }

        private void frmSegmentGen_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmSegmentGen_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
            {
                string[] acceptableFileTypes = { ".mp4", ".mov", ".avi" };

                if (files.Length == 1)
                {
                    if (acceptableFileTypes.Contains(Path.GetExtension(files.First()).ToLower()))
                    {
                        this.selectedFile = files.First();

                        mainForm.getFormLoader().Controls.Clear();
                        frmSGFileGrid frmSGFileGrid_Var = new frmSGFileGrid(selectedFile) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        frmSGFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
                        mainForm.getFormLoader().Controls.Add(frmSGFileGrid_Var);
                        frmSGFileGrid_Var.Show();

                    }
                    else
                    {
                        // Warning message about unadded files
                        string message = "Your file was not added because of an unacceptable filetype. Supported filetypes include: .mp4, .mov, and .avi";
                        string caption = "File not added.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                    }

                } 
                else
                {
                    // Warning message about unadded files
                    string message = "You may only add one file to the segment generator.";
                    string caption = "Too many files added.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }

            }
        }
    }
}

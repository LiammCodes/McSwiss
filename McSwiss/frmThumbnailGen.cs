using System;
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
        private string selectedFile;
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
                dialog.Multiselect = false;
                dialog.Filter = "Video File|*.mp4;*.mov;*.avi;*.MP4;*.MOV;*.AVI";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.selectedFile = dialog.FileName;

                    mainForm.getFormLoader().Controls.Clear();
                    frmTGFileGrid frmTGFileGrid_Var = new frmTGFileGrid(selectedFile) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

                if (files.Length == 1)
                {
                    if (acceptableFileTypes.Contains(Path.GetExtension(files.First()).ToLower()))
                    {
                        this.selectedFile = files.First();

                        mainForm.getFormLoader().Controls.Clear();
                        frmTGFileGrid frmTGFileGrid_Var = new frmTGFileGrid(selectedFile) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        frmTGFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
                        mainForm.getFormLoader().Controls.Add(frmTGFileGrid_Var);
                        frmTGFileGrid_Var.Show();

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

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
    public partial class frmTransGen : Form
    {
        private List<String> selectedFiles = new List<String>();
        public frmTransGen()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public frmTransGen(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnTGFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "Video Files|*.mp4;*.m4v;*.mov;*.avi;*.MP4;*.M4V*.MOV;*.AVI";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        this.selectedFiles.Add(file);
                    }

                    mainForm.getFormLoader().Controls.Clear();
                    frmTransFileGrid frmTransFileGrid_Var = new frmTransFileGrid(selectedFiles) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmTransFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
                    mainForm.getFormLoader().Controls.Add(frmTransFileGrid_Var);
                    frmTransFileGrid_Var.Show();
                }
            }
        }

        private void frmTransGen_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmTransGen_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
            {
                string[] acceptableFileTypes = { ".mp4", ".mov", ".m4v", ".avi" };
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
            frmTransFileGrid frmTransFileGrid_Var = new frmTransFileGrid(selectedFiles) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTransFileGrid_Var.FormBorderStyle = FormBorderStyle.None;
            mainForm.getFormLoader().Controls.Add(frmTransFileGrid_Var);
            frmTransFileGrid_Var.Show();
        }
    }
}

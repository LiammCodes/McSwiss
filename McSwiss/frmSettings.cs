using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McSwiss.Properties;

namespace McSwiss
{
    public partial class frmSettings : Form
    {
        private int ticks;

        public frmSettings()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;

        public frmSettings(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.txtBoxSuffix.Text = settings.Default.PGSuffix.ToString();
            
            if (settings.Default.SGNumbers)
            {
                this.rdioNumbers.Checked = true;
            }
            else
            {
                this.rdioLetters.Checked = true;
            }

        }

        public string Version
        {
            set
            {
                this.lblVersion.Text = value;
            }
        }

        public string PreviewSuffix
        {
            get
            {
                return this.txtBoxSuffix.Text;
            }
            set
            {
                this.txtBoxSuffix.Text = value;
            }
        }

        public bool SegmentNumbers
        {
            get
            {
                if (this.rdioNumbers.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { this.rdioNumbers.Checked = value; }
        }

        public bool SegmentLetters
        {
            get
            {
                if (this.rdioLetters.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { this.rdioLetters.Checked = value; }
        }



        private void btnApply_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            settings.Default.PGSuffix = this.txtBoxSuffix.Text.ToString();
            settings.Default.SGNumbers = this.rdioNumbers.Checked;
            settings.Default.SGLetters = this.rdioLetters.Checked;
            settings.Default.Save();
            this.imgThumbsUp.Show();
            this.lblSaved.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 5)
            {
                this.lblSaved.Hide();
                this.imgThumbsUp.Hide();
                timer1.Stop();
            }
        }

        private void txtBoxSuffix_TextChanged(object sender, EventArgs e)
        {
            this.lblExample.Text = String.Format(@"eg. filename{0}.mp4", this.txtBoxSuffix.Text);
        }

        private void rdioLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioLetters.Checked)
            {
                lblLetterWarning.Show();
                imgWarning.Show();
            }
            else
            {
                lblLetterWarning.Hide();
                imgWarning.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace McSwiss
{
    public partial class frmSegment : Form
    {
        public frmSegment()
        {
            InitializeComponent();
        }

        private frmSegment segmentList = null;
        public frmSegment(Form callingForm)
        {
            segmentList = callingForm as frmSegment;
            InitializeComponent();
        }

        public string SegmentTitle
        {
            get
            {
                return this.lblSegmentTitle.Text;
            }
            set
            {
                this.lblSegmentTitle.Text = value;
            }
        }
        public string StartTime
        {
            get
            {
                return this.txtBoxStart.Text;
            }
        }

        public string EndTime
        {
            get
            {
                return this.txtBoxEnd.Text;
            }
        }

        private void RemoveSelectionStart(Object obj)
        {
            if (txtBoxStart != null)
            {
                txtBoxStart.SelectionLength = 0;
            }
        }

        private void RemoveSelectionEnd(Object obj)
        {
            if (txtBoxEnd != null)
            {
                txtBoxEnd.SelectionLength = 0;
            }
        }

        private void txtBoxStart_TextChanged(object sender, EventArgs e)
        {
            string time = txtBoxStart.Text;

            // new number entered
            if (time.Length > 5)
            {
                var regex = new Regex(@"^\d$");
                if (!regex.IsMatch(time[5].ToString()))
                {
                    if (time.Length <= 1)
                    {
                        time = "00:00";
                    }
                    time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                }
                else
                {
                    if (!time[0].ToString().Equals("0"))
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                    }
                    else
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[1], time[3], time[4], time[5]);
                    }

                }
            }

            //new number removed
            if (time.Length < 5)
            {
                if (time.Length <= 1)
                {
                    time = "00:00";
                }
                time = String.Format(@"{0}{1}:{2}{3}", "0", time[0], time[1], time[3]);
            }

            txtBoxStart.Text = time;
            txtBoxStart.Select(txtBoxStart.Text.Length, 0);
        }

        private void txtBoxEnd_TextChanged(object sender, EventArgs e)
        {
            string time = txtBoxEnd.Text;

            // new number entered
            if (time.Length > 5)
            {
                var regex = new Regex(@"^\d$");
                if (!regex.IsMatch(time[5].ToString()))
                {
                    if (time.Length <= 1)
                    {
                        time = "00:00";
                    }
                    time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                }
                else
                {
                    if (!time[0].ToString().Equals("0"))
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[0], time[1], time[3], time[4]);
                    }
                    else
                    {
                        time = String.Format(@"{0}{1}:{2}{3}", time[1], time[3], time[4], time[5]);
                    }

                }
            }

            //new number removed
            if (time.Length < 5)
            {
                if (time.Length == 0)
                {
                    time = "00:00";
                }
                time = String.Format(@"{0}{1}:{2}{3}", "0", time[0], time[1], time[3]);
            }

            txtBoxEnd.Text = time;
            txtBoxEnd.Select(txtBoxEnd.Text.Length, 0);
        }

        private void txtBoxStart_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveSelectionStart(sender);
            txtBoxStart.Select(txtBoxStart.Text.Length, 0);
        }

        private void txtBoxEnd_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveSelectionEnd(sender);
            txtBoxEnd.Select(txtBoxEnd.Text.Length, 0);
        }

        private void txtBoxStart_KeyUp(object sender, KeyEventArgs e)
        {
            RemoveSelectionStart(sender);
            txtBoxStart.Select(txtBoxStart.Text.Length, 0);
        }

        private void txtBoxEnd_KeyUp(object sender, KeyEventArgs e)
        {
            RemoveSelectionEnd(sender);
            txtBoxEnd.Select(txtBoxEnd.Text.Length, 0);
        }
    }
}

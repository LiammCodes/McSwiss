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

        private void txtBoxStart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

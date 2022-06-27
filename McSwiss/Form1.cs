using System.Runtime.InteropServices;

namespace McSwiss
{
    public partial class Form1 : Form {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public Form1() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // init preview gen first
            lblTitle.Text = "Preview Generator";
            btnPreviewGen.BackColor = Color.FromArgb(43, 43, 43);

            this.pnlFormLoader.Controls.Clear();
            frmPreviewGen FrmPreviewGen_Var = new frmPreviewGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmPreviewGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmPreviewGen_Var);
            FrmPreviewGen_Var.Show();
        }
        // getter for main panel loader
        public Panel getFormLoader()
        {
            return this.pnlFormLoader;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void pnlMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void pnlMover_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnPreviewGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Preview Generator";
            btnPreviewGen.BackColor = Color.FromArgb(43, 43, 43);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmPreviewGen FrmPreviewGen_Var = new frmPreviewGen(this) {  Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmPreviewGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmPreviewGen_Var);
            FrmPreviewGen_Var.Show();
        }
        
        private void btnSegmentGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Segment Generator";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(43, 43, 43);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
        }

        private void btnThumbnailGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thumbnail Generator";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(43, 43, 43);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmThumbnailGen FrmThumbnailGen_Var = new frmThumbnailGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmThumbnailGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmThumbnailGen_Var);
            FrmThumbnailGen_Var.Show();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Settings";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(43, 43, 43);

            this.pnlFormLoader.Controls.Clear();
        }

        private void btnPreviewGen_Leave(object sender, EventArgs e)
        {
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnSegmentGen_Leave(object sender, EventArgs e)
        {
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnThumbnailGen_Leave(object sender, EventArgs e)
        {
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(43, 43, 43);
            btnClose.ForeColor = Color.DimGray;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.White;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.DimGray;
        }
    }
}
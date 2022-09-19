using System.Runtime.InteropServices;
using System.Reflection;

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
            // NEW
            if (!File.Exists("ffmpeg.exe"))
            {
                string tempExeName = Path.Combine(Directory.GetCurrentDirectory(), "ffmpeg.exe");
                using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Resource1.GetFFMpeg();
                    fsDst.Write(bytes, 0, bytes.Length);
                }
            }

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
            btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnTransGen.BackColor = Color.FromArgb(32, 32, 32);
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
            btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnTransGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmSegmentGen FrmSegmentGen_Var = new frmSegmentGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSegmentGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSegmentGen_Var);
            FrmSegmentGen_Var.Show();
        }

        private void btnThumbnailGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thumbnail Generator";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(43, 43, 43);
            btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnTransGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmThumbnailGen FrmThumbnailGen_Var = new frmThumbnailGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmThumbnailGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmThumbnailGen_Var);
            FrmThumbnailGen_Var.Show();
        }

        private void btnHypThumbnailGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Hyper Thumbnail Generator";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnHypThumbnailGen.BackColor = Color.FromArgb(43, 43, 43);
            btnTransGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmHypThumbnailGen FrmHypThumbnailGen_Var = new frmHypThumbnailGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHypThumbnailGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHypThumbnailGen_Var);
            FrmHypThumbnailGen_Var.Show();
        }

        private void btnTransGen_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Transcript Generator";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnTransGen.BackColor = Color.FromArgb(43, 43, 43);
            btnSettings.BackColor = Color.FromArgb(32, 32, 32);

            this.pnlFormLoader.Controls.Clear();
            frmTransGen FrmTransGen_Var = new frmTransGen(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmTransGen_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmTransGen_Var);
            FrmTransGen_Var.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Settings";
            btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
            btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
            btnTransGen.BackColor = Color.FromArgb(32, 32, 32);
            btnSettings.BackColor = Color.FromArgb(43, 43, 43);

            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmSettings_Var = new frmSettings(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_Var.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSettings_Var);

            FrmSettings_Var.PreviewSuffix = Properties.settings.Default.PGSuffix;
            FrmSettings_Var.SegmentNumbers = Properties.settings.Default.SGNumbers;
            FrmSettings_Var.SegmentLetters = Properties.settings.Default.SGLetters;
            FrmSettings_Var.S3AccessKeyID = Properties.settings.Default.S3AccessKeyID;
            FrmSettings_Var.S3Secret = Properties.settings.Default.S3Secret;

            FrmSettings_Var.Version = String.Format(@"Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            FrmSettings_Var.Show();


        }

        private void btnPreviewGen_Leave(object sender, EventArgs e)
        {
            //btnPreviewGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnSegmentGen_Leave(object sender, EventArgs e)
        {
            //btnSegmentGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnThumbnailGen_Leave(object sender, EventArgs e)
        {
            //btnThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnHypThumbnailGen_Leave(object sender, EventArgs e)
        {
            //btnHypThumbnailGen.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnTransGen_Leave(object sender, EventArgs e)
        {

        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //btnSettings.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // cleanup
            for (int i = 1; i <= 20; i++)
            {
                string tempFile = Path.Combine(Path.GetTempPath(), String.Format("tempThumb{0}.jpg", i));

                if (File.Exists(tempFile)){
                    File.Delete(tempFile);
                }
            }

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
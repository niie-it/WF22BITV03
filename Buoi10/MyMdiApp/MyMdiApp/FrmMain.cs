namespace MyMdiApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int loginNumber = 0;
        private void MnuDangNhap_Click(object sender, EventArgs e)
        {
            loginNumber++;
            var form = new FrmLogin();
            form.Text = $"Login {loginNumber}";
            //form.MdiParent = this;
            if (form.ShowDialog() == DialogResult.OK)
            {
                lblThongTin.Text = $"Xin chào: {form.Tag}";
                ThietLapMenu(true);
            }
        }

        private void MnuQLNguoiDung_Click(object sender, EventArgs e)
        {
            var form = new FrmQuanLyNguoiDung();
            form.MdiParent = this;
            form.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void đóngTấtCảFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

        void ThietLapMenu(bool giaTri = true)
        {
            MnuDangXuat.Enabled = giaTri;
            MnuQLNguoiDung.Visible = giaTri;
            MnuDangNhap.Enabled = !giaTri;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ThietLapMenu(false);
        }

        private void MnuDangXuat_Click(object sender, EventArgs e)
        {
            ThietLapMenu(false);
            lblThongTin.Text = "Bạn chưa đăng nhập";
        }
    }
}

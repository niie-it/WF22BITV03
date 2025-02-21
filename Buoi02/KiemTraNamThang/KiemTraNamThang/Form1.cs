﻿namespace KiemTraNamThang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int Nam, Thang;
            //Nam = int.Parse(txtNam.Text);
            if (!int.TryParse(txtNam.Text, out Nam) || (Nam < 0))
            {
                MessageBox.Show("Lỗi nhập liệu năm");
                txtNam.Focus();
                return;
            }
            if (!int.TryParse(txtThang.Text, out Thang) || (Thang < 1) || (Thang > 12))
            {
                MessageBox.Show("Lỗi nhập liệu tháng");
                txtThang.Focus();
                return;
            }

            bool laNamNhuan = false;
            if (Nam % 400 == 0)
            {
                laNamNhuan = true;
            }
            else if (Nam % 4 == 0 && Nam % 100 != 0)
            {
                laNamNhuan = true;
            }

            int soNgay = 0;
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30; break;
                case 2:
                    soNgay = laNamNhuan ? 29 : 28; break;
            }
            txtKetQua.Text = $"Năm: {Nam} là năm {(laNamNhuan ? "nhuận" : "không nhuận")}.\r\nTháng: {Thang}/{Nam} có {soNgay} ngày.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            txtNam.Clear();
            txtThang.Text = "";

            //đưa con trỏ chỏ vô ô nhập năm
            txtNam.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHinhChuNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<HinhChuNhat> dsHinh = new List<HinhChuNhat>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            double dai, rong;
            if (!double.TryParse(txtDai.Text, out dai) || (dai <= 0))
            {
                MessageBox.Show("Dài chưa hợp lệ");
                txtDai.Focus();
                return;
            }
            if (!double.TryParse(txtRong.Text, out rong) || (rong <= 0))
            {
                MessageBox.Show("Rộng chưa hợp lệ");
                txtRong.Focus();
                return;
            }

            HinhChuNhat hcn = new HinhChuNhat(dai, rong);
            dsHinh.Add(hcn);
            ResetTextBox();
            XuatDanhSach();
        }

        void XuatDanhSach()
        {
            txtKetQua.Clear();
            foreach (HinhChuNhat hcn in dsHinh)
            {
                txtKetQua.Text += $"{hcn}\r\n";
            }
            lblSoLuong.Text = $"Có {dsHinh.Count} hình";
        }

        void ResetTextBox()
        {
            txtDai.Clear(); txtRong.Clear();
            txtKetQua.Clear();
            lblSoLuong.Text = $"Hiện không có hình nào.";
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XuatDanhSach();
        }

        private void btnXoaDanhSach_Click(object sender, EventArgs e)
        {
            dsHinh.Clear();
            ResetTextBox();
        }
    }
}

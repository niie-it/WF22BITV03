using System.Text;
using System.Text.Json;

namespace QuanLyHinhHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<HinhHoc> dsHinh = new List<HinhHoc>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                dsHinh.Add(new HinhChuNhat
                {
                    Dai = double.Parse(txtDai.Text),
                    Rong = double.Parse(txtRong.Text)
                });
            }
            else if (radHT.Checked)
            {
                dsHinh.Add(new HinhTron { BanKinh = double.Parse(txtBanKinh.Text) });
            }
            HienThiDSHinh();
        }

        void HienThiDSHinh()
        {
            var sb = new StringBuilder();
            foreach (var hh in dsHinh)
            {
                hh.tinhDienTichChuVi();
                sb.Append($"{hh}\r\n");
            }
            txtKetQua.Text = sb.ToString();
        }

        private void radHCN_CheckedChanged(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                groupBoxHCN.Enabled = true;
                groupBoxHT.Enabled = false;
            }
            else
            {
                groupBoxHCN.Enabled = false;
                groupBoxHT.Enabled = true;
            }
        }

        private void btnXuatJSON_Click(object sender, EventArgs e)
        {
            if (dsHinh.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu xuất");
                return;
            }
            var jsonString = JsonSerializer.Serialize(dsHinh);
            File.WriteAllText("data.json", jsonString);
        }

        private void btnXuatTEXT_Click(object sender, EventArgs e)
        {
            if (dsHinh.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu xuất");
                return;
            }

            var mang = new List<string>();
            mang.Add("#1. Hình chữ nhật, 2. Hình tròn; các thông số các nhau bởi tab");
            foreach (var item in dsHinh)
            {
                //if (item.Type == 1)
                //{
                //    var hcn = item as HinhChuNhat;
                //    mang.Add($"{item.Type}\t{hcn.Dai}\t{hcn.Rong}");
                //}
                //else if (item.Type == 2)
                //{
                //    var ht = item as HinhTron;
                //    mang.Add($"{item.Type}\t{ht.BanKinh}");
                //}
                mang.Add(item.Output());
            }
            File.WriteAllLines("data.txt", mang.ToArray());
        }
    }
}

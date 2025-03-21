using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADONET
{
    public partial class FrmHocSinh : Form
    {
        public FrmHocSinh()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = "Data Source=.;Initial Catalog=QLHocSinh;Integrated Security=True;";
        private void FrmHocSinh_Load(object sender, EventArgs e)
        {
            LayDanhSachLop();
            CboLop.SelectedIndex = 0;//ép chọn lớp đầu tiên
        }

        private void LayDanhSachLop()
        {
            var conn = new SqlConnection(chuoiKetNoi);
            var da = new SqlDataAdapter("SELECT * FROM Lop ORDER BY TenLop", conn);
            var dt = new DataTable();
            da.Fill(dt);

            CboLop.DataSource = dt;
            CboLop.DisplayMember = "TenLop";
            CboLop.ValueMember = "MaLop";
        }

        private void CboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboLop.SelectedIndex > -1)
            {
                var sql = $"SELECT MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop FROM HocSinh WHERE MaLop='{CboLop.SelectedValue}'";
                //MessageBox.Show(sql);
                var conn = new SqlConnection(chuoiKetNoi);
                var da = new SqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);

                DgvHocSinh.DataSource = dt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmTest22BITV03 : Form
    {
        public FrmTest22BITV03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTest22BITV03_Load(object sender, EventArgs e)
        {
            txtKetQua.Text = "Tròn, R = 2.1, S = 13.847\r\n";
            txtKetQua.AppendText("Chữ nhật, D = 8, R = 6, S = 48\r\n");
            txtKetQua.AppendText("Ellipse, a = 8, b = 6, S = 37.68");
        }
    }
}

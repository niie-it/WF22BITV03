using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ2SQLExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new QLHSDataContext();
            dataGridView1.DataSource = db.HocSinhs;
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            var db = new QLHSDataContext();
            var dataHocSinh = db.HocSinhs.Where(hs => hs.TenHS.Contains(TxtTim.Text));

            dataGridView1.DataSource = dataHocSinh;
        }
    }
}

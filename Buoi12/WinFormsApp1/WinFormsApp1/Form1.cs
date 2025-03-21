using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = "Data Source=.;Initial Catalog=QLHS22BITV03;Integrated Security=True;";

        private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(chuoiKetNoi);
            var sql = "SELECT * FROM HocSinh";
            var da = new SqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void danhSáchLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(chuoiKetNoi);
            var sql = "SELECT * FROM Lop";
            var da = new SqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

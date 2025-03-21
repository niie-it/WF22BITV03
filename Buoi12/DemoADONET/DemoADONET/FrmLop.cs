using System.Data;
using System.Data.SqlClient;

namespace DemoADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var chuoiKetNoi = "Data Source=.;Initial Catalog=QLHocSinh;Integrated Security=True;";
            var conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            var da = new SqlDataAdapter("SELECT * FROM Lop ORDER BY TenLop", conn);

            var dtLop = new DataTable();
            da.Fill(dtLop);
            conn.Close();


            dataGridView1.DataSource = dtLop;
        }
    }
}

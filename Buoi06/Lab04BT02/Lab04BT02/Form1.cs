namespace Lab04BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int dong, cot;
            if (!int.TryParse(txtSoDong.Text, out dong) || dong < 1)
            {
                MessageBox.Show("Sai số dòng");
                txtSoDong.Focus();
                return;
            }
            if (!int.TryParse(txtSoCot.Text, out cot) || cot < 1)
            {
                MessageBox.Show("Sai số cột");
                txtSoCot.Focus();
                return;
            }
            var form = new FrmXuat(dong, cot);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}

namespace PaymentApp
{
    public partial class frmCustomer : Form
    {
        private bool isDataSaved = true;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            var form = new frmPayment();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lblPayment.Text = form.Tag?.ToString();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboCustomer.Items.Add("Teo Nguyen");
            cboCustomer.Items.Add("Dien Nguyen");
            cboCustomer.Items.Add("Tai Lam");
            cboCustomer.Items.Add("Lam Ly");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                saveData();
            }
        }

        private void saveData()
        {
            File.WriteAllText("payment.txt", lblPayment.Text);
            cboCustomer.SelectedIndex = -1;
            lblPayment.Text = "";
            isDataSaved = true;
            cboCustomer.Focus();

        }

        private bool isValidData()
        {
            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer.", "Entry Error");
                cboCustomer.Focus();
                return false;
            }

            if (lblPayment.Text == "")
            {
                MessageBox.Show("You must enter a payment.", "Entry Error");
                return false;
            }

            return true;

        }

        private void lblPayment_TextChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
            lblPayment.Text = "";
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataSaved == false)
            {
                string message = "This form contains unsaved data.\n\n" +
                    "Do you want to save it?";

                DialogResult button = MessageBox.Show(message, "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (isValidData())
                    {
                        this.saveData();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}

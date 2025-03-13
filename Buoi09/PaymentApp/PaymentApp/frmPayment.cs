using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCardType.SelectedIndex = 0;

            var currentYear = DateTime.Now.Year;
            for (int i = 0; i < 5; i++)
            {
                cboExpirationYear.Items.Add(currentYear + i);
            }

        }

        void EnableControls(bool enable = true)
        {
            lstCardType.Enabled = enable;
            txtCardNumber.Enabled = enable;
            cboExpirationYear.Enabled = enable;
            cboExpirationMonth.Enabled = enable;
        }

        private void Billing_CheckedChanged(object sender, EventArgs e)
        {
            if (radCreditCard.Checked)
            {
                EnableControls(true);
            }
            else
            {
                EnableControls(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool IsValidData()
        {
            if (radCreditCard.Checked)
            {
                if (lstCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    lstCardType.Focus();
                    return false;
                }

                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number.", "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.", "Entry Error");
                    cboExpirationMonth.Focus();
                    return false;
                }

                if (cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.", "Entry Error");
                    cboExpirationYear.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
            {
                return;
            }
            string msg = string.Empty;
            if (radCreditCard.Checked)
            {
                msg += "Charge to credit card.\nCard type: " +
                    lstCardType.Text + "\nCard number: " +
                    txtCardNumber.Text + "\nExpiration date: " +
                    cboExpirationMonth.Text + "/" +
                    cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer.\n\n";
            }

            msg += "Default billing: " + chkDefaultBilling.Checked;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }
    }
}

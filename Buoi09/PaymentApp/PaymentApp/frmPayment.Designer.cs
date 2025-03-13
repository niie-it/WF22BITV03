namespace PaymentApp
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radBillCustomber = new RadioButton();
            radCreditCard = new RadioButton();
            label1 = new Label();
            lstCardType = new ListBox();
            label2 = new Label();
            txtCardNumber = new TextBox();
            label3 = new Label();
            cboExpirationMonth = new ComboBox();
            cboExpirationYear = new ComboBox();
            chkDefaultBilling = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBillCustomber);
            groupBox1.Controls.Add(radCreditCard);
            groupBox1.Font = new Font("Tahoma", 12F);
            groupBox1.Location = new Point(65, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing";
            // 
            // radBillCustomber
            // 
            radBillCustomber.AutoSize = true;
            radBillCustomber.Font = new Font("Tahoma", 12F);
            radBillCustomber.Location = new Point(470, 80);
            radBillCustomber.Name = "radBillCustomber";
            radBillCustomber.Size = new Size(289, 52);
            radBillCustomber.TabIndex = 0;
            radBillCustomber.Text = "Bill Customer";
            radBillCustomber.UseVisualStyleBackColor = true;
            radBillCustomber.CheckedChanged += Billing_CheckedChanged;
            // 
            // radCreditCard
            // 
            radCreditCard.AutoSize = true;
            radCreditCard.Checked = true;
            radCreditCard.Font = new Font("Tahoma", 12F);
            radCreditCard.Location = new Point(42, 80);
            radCreditCard.Name = "radCreditCard";
            radCreditCard.Size = new Size(254, 52);
            radCreditCard.TabIndex = 0;
            radCreditCard.TabStop = true;
            radCreditCard.Text = "Credit Card";
            radCreditCard.UseVisualStyleBackColor = true;
            radCreditCard.CheckedChanged += Billing_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(65, 295);
            label1.Name = "label1";
            label1.Size = new Size(300, 48);
            label1.TabIndex = 1;
            label1.Text = "Credit card type";
            // 
            // lstCardType
            // 
            lstCardType.Font = new Font("Tahoma", 12F);
            lstCardType.FormattingEnabled = true;
            lstCardType.ItemHeight = 48;
            lstCardType.Items.AddRange(new object[] { "VISA", "Master Card", "American Express" });
            lstCardType.Location = new Point(388, 309);
            lstCardType.Name = "lstCardType";
            lstCardType.Size = new Size(524, 196);
            lstCardType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(72, 576);
            label2.Name = "label2";
            label2.Size = new Size(249, 48);
            label2.TabIndex = 3;
            label2.Text = "Card number";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Font = new Font("Tahoma", 12F);
            txtCardNumber.Location = new Point(388, 570);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(524, 56);
            txtCardNumber.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(72, 690);
            label3.Name = "label3";
            label3.Size = new Size(289, 48);
            label3.TabIndex = 5;
            label3.Text = "Expiration Date";
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.Font = new Font("Tahoma", 12F);
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Items.AddRange(new object[] { "Select month", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cboExpirationMonth.Location = new Point(388, 690);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new Size(218, 56);
            cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.Font = new Font("Tahoma", 12F);
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Location = new Point(694, 690);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new Size(218, 56);
            cboExpirationYear.TabIndex = 6;
            // 
            // chkDefaultBilling
            // 
            chkDefaultBilling.AutoSize = true;
            chkDefaultBilling.Checked = true;
            chkDefaultBilling.CheckState = CheckState.Checked;
            chkDefaultBilling.Font = new Font("Tahoma", 12F);
            chkDefaultBilling.Location = new Point(78, 841);
            chkDefaultBilling.Name = "chkDefaultBilling";
            chkDefaultBilling.Size = new Size(562, 52);
            chkDefaultBilling.TabIndex = 7;
            chkDefaultBilling.Text = "Set as default billing method";
            chkDefaultBilling.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Tahoma", 12F);
            btnOK.Location = new Point(388, 923);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(218, 79);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(694, 923);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(218, 79);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 1055);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkDefaultBilling);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(label3);
            Controls.Add(txtCardNumber);
            Controls.Add(label2);
            Controls.Add(lstCardType);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmPayment";
            Text = "Payment";
            Load += frmPayment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radBillCustomber;
        private RadioButton radCreditCard;
        private Label label1;
        private ListBox lstCardType;
        private Label label2;
        private TextBox txtCardNumber;
        private Label label3;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefaultBilling;
        private Button btnOK;
        private Button btnCancel;
    }
}
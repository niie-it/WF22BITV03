namespace PaymentApp
{
    partial class frmCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboCustomer = new ComboBox();
            label2 = new Label();
            btnSelectPayment = new Button();
            lblPayment = new Label();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(188, 48);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // cboCustomer
            // 
            cboCustomer.Font = new Font("Tahoma", 12F);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(277, 40);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(582, 56);
            cboCustomer.TabIndex = 1;
            cboCustomer.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(53, 187);
            label2.Name = "label2";
            label2.Size = new Size(173, 48);
            label2.TabIndex = 2;
            label2.Text = "Payment";
            // 
            // btnSelectPayment
            // 
            btnSelectPayment.Font = new Font("Tahoma", 12F);
            btnSelectPayment.Location = new Point(286, 175);
            btnSelectPayment.Name = "btnSelectPayment";
            btnSelectPayment.Size = new Size(573, 65);
            btnSelectPayment.TabIndex = 3;
            btnSelectPayment.Text = "Select Payment";
            btnSelectPayment.UseVisualStyleBackColor = true;
            btnSelectPayment.Click += btnSelectPayment_Click;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Tahoma", 12F);
            lblPayment.ForeColor = Color.Red;
            lblPayment.Location = new Point(62, 290);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(124, 48);
            lblPayment.TabIndex = 4;
            lblPayment.Text = "label3";
            lblPayment.TextChanged += lblPayment_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 12F);
            btnSave.Location = new Point(355, 527);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(204, 84);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Tahoma", 12F);
            btnExit.Location = new Point(622, 527);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(204, 84);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 641);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblPayment);
            Controls.Add(btnSelectPayment);
            Controls.Add(label2);
            Controls.Add(cboCustomer);
            Controls.Add(label1);
            Name = "frmCustomer";
            Text = "Customer";
            FormClosing += frmCustomer_FormClosing;
            Load += frmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCustomer;
        private Label label2;
        private Button btnSelectPayment;
        private Label lblPayment;
        private Button btnSave;
        private Button btnExit;
    }
}

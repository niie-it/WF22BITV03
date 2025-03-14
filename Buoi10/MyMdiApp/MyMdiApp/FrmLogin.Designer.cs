namespace MyMdiApp
{
    partial class FrmLogin
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
            label1 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(239, 44);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(250, 47);
            TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(239, 141);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '$';
            TxtPassword.Size = new Size(250, 47);
            TxtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 141);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(239, 218);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(250, 58);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 305);
            ControlBox = false;
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label2;
        private Button BtnLogin;
    }
}
namespace KiemTraNamThang
{
    partial class Form1
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
            label2 = new Label();
            txtNam = new TextBox();
            txtThang = new TextBox();
            btnKiemTra = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Năm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 140);
            label2.Name = "label2";
            label2.Size = new Size(101, 41);
            label2.TabIndex = 1;
            label2.Text = "Tháng";
            // 
            // txtNam
            // 
            txtNam.Location = new Point(210, 42);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(250, 47);
            txtNam.TabIndex = 2;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(210, 137);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(250, 47);
            txtThang.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(210, 212);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(250, 58);
            btnKiemTra.TabIndex = 4;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(34, 306);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(730, 132);
            txtKetQua.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(btnKiemTra);
            Controls.Add(txtThang);
            Controls.Add(txtNam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNam;
        private TextBox txtThang;
        private Button btnKiemTra;
        private TextBox txtKetQua;
    }
}

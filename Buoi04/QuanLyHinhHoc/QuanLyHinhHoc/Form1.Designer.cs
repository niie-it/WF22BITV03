namespace QuanLyHinhHoc
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
            groupBox1 = new GroupBox();
            radHT = new RadioButton();
            radHCN = new RadioButton();
            groupBoxHCN = new GroupBox();
            txtRong = new TextBox();
            label2 = new Label();
            txtDai = new TextBox();
            label1 = new Label();
            groupBoxHT = new GroupBox();
            txtBanKinh = new TextBox();
            label3 = new Label();
            btnThem = new Button();
            txtKetQua = new TextBox();
            btnXuatJSON = new Button();
            btnXuatTEXT = new Button();
            groupBox1.SuspendLayout();
            groupBoxHCN.SuspendLayout();
            groupBoxHT.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radHT);
            groupBox1.Controls.Add(radHCN);
            groupBox1.Font = new Font("Tahoma", 11.1F);
            groupBox1.Location = new Point(58, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại hình học";
            // 
            // radHT
            // 
            radHT.AutoSize = true;
            radHT.Checked = true;
            radHT.Location = new Point(516, 95);
            radHT.Name = "radHT";
            radHT.Size = new Size(210, 49);
            radHT.TabIndex = 1;
            radHT.TabStop = true;
            radHT.Text = "Hình tròn";
            radHT.UseVisualStyleBackColor = true;
            // 
            // radHCN
            // 
            radHCN.AutoSize = true;
            radHCN.Location = new Point(27, 95);
            radHCN.Name = "radHCN";
            radHCN.Size = new Size(289, 49);
            radHCN.TabIndex = 0;
            radHCN.Text = "Hình chữ nhật";
            radHCN.UseVisualStyleBackColor = true;
            radHCN.CheckedChanged += radHCN_CheckedChanged;
            // 
            // groupBoxHCN
            // 
            groupBoxHCN.Controls.Add(txtRong);
            groupBoxHCN.Controls.Add(label2);
            groupBoxHCN.Controls.Add(txtDai);
            groupBoxHCN.Controls.Add(label1);
            groupBoxHCN.Enabled = false;
            groupBoxHCN.Font = new Font("Tahoma", 11.1F);
            groupBoxHCN.Location = new Point(58, 259);
            groupBoxHCN.Name = "groupBoxHCN";
            groupBoxHCN.Size = new Size(786, 329);
            groupBoxHCN.TabIndex = 1;
            groupBoxHCN.TabStop = false;
            groupBoxHCN.Text = "Hình chữ nhật";
            // 
            // txtRong
            // 
            txtRong.Location = new Point(334, 192);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(250, 52);
            txtRong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 208);
            label2.Name = "label2";
            label2.Size = new Size(104, 45);
            label2.TabIndex = 2;
            label2.Text = "Rộng";
            // 
            // txtDai
            // 
            txtDai.Location = new Point(334, 98);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(250, 52);
            txtDai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 98);
            label1.Name = "label1";
            label1.Size = new Size(72, 45);
            label1.TabIndex = 0;
            label1.Text = "Dài";
            // 
            // groupBoxHT
            // 
            groupBoxHT.Controls.Add(txtBanKinh);
            groupBoxHT.Controls.Add(label3);
            groupBoxHT.Font = new Font("Tahoma", 11.1F);
            groupBoxHT.Location = new Point(943, 277);
            groupBoxHT.Name = "groupBoxHT";
            groupBoxHT.Size = new Size(856, 311);
            groupBoxHT.TabIndex = 2;
            groupBoxHT.TabStop = false;
            groupBoxHT.Text = "Hình tròn";
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(380, 147);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(250, 52);
            txtBanKinh.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 162);
            label3.Name = "label3";
            label3.Size = new Size(162, 45);
            label3.TabIndex = 0;
            label3.Text = "Bán kính";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Tahoma", 11.1F);
            btnThem.Location = new Point(297, 647);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(275, 118);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetQua.Location = new Point(48, 827);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(1968, 573);
            txtKetQua.TabIndex = 4;
            // 
            // btnXuatJSON
            // 
            btnXuatJSON.Font = new Font("Segoe UI", 12F);
            btnXuatJSON.Location = new Point(1323, 656);
            btnXuatJSON.Name = "btnXuatJSON";
            btnXuatJSON.Size = new Size(331, 118);
            btnXuatJSON.TabIndex = 5;
            btnXuatJSON.Text = "Xuất file JSON";
            btnXuatJSON.UseVisualStyleBackColor = true;
            btnXuatJSON.Click += btnXuatJSON_Click;
            // 
            // btnXuatTEXT
            // 
            btnXuatTEXT.Font = new Font("Segoe UI", 12F);
            btnXuatTEXT.Location = new Point(1685, 656);
            btnXuatTEXT.Name = "btnXuatTEXT";
            btnXuatTEXT.Size = new Size(331, 118);
            btnXuatTEXT.TabIndex = 5;
            btnXuatTEXT.Text = "Xuất file TEXT";
            btnXuatTEXT.UseVisualStyleBackColor = true;
            btnXuatTEXT.Click += btnXuatTEXT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2058, 1458);
            Controls.Add(btnXuatTEXT);
            Controls.Add(btnXuatJSON);
            Controls.Add(txtKetQua);
            Controls.Add(btnThem);
            Controls.Add(groupBoxHT);
            Controls.Add(groupBoxHCN);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý Hình học";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxHCN.ResumeLayout(false);
            groupBoxHCN.PerformLayout();
            groupBoxHT.ResumeLayout(false);
            groupBoxHT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radHT;
        private RadioButton radHCN;
        private GroupBox groupBoxHCN;
        private TextBox txtRong;
        private Label label2;
        private TextBox txtDai;
        private Label label1;
        private GroupBox groupBoxHT;
        private TextBox txtBanKinh;
        private Label label3;
        private Button btnThem;
        private TextBox txtKetQua;
        private Button btnXuatJSON;
        private Button btnXuatTEXT;
    }
}

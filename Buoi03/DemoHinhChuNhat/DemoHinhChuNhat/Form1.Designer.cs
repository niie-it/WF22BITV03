namespace DemoHinhChuNhat
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnXoaDanhSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều rộng";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(265, 50);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(249, 38);
            this.txtDai.TabIndex = 2;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(265, 123);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(249, 38);
            this.txtRong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(571, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 76);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(571, 123);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(185, 75);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(25, 348);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(763, 291);
            this.txtKetQua.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(30, 299);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(92, 32);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "label3";
            // 
            // btnXoaDanhSach
            // 
            this.btnXoaDanhSach.Location = new System.Drawing.Point(571, 230);
            this.btnXoaDanhSach.Name = "btnXoaDanhSach";
            this.btnXoaDanhSach.Size = new System.Drawing.Size(185, 75);
            this.btnXoaDanhSach.TabIndex = 8;
            this.btnXoaDanhSach.Text = "Xóa danh sách";
            this.btnXoaDanhSach.UseVisualStyleBackColor = true;
            this.btnXoaDanhSach.Click += new System.EventHandler(this.btnXoaDanhSach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.btnXoaDanhSach);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hình chữ nhật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnXoaDanhSach;
    }
}


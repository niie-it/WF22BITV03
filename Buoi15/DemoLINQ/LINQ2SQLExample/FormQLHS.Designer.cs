﻿using System.Drawing;
using System.Windows.Forms;

namespace LINQ2SQLExample
{
    partial class FormQLHS
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
            this.CboLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaHS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.DtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TxtDiemTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDiaChi = new System.Windows.Forms.TextBox();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // CboLop
            // 
            this.CboLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLop.FormattingEnabled = true;
            this.CboLop.Location = new System.Drawing.Point(242, 90);
            this.CboLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CboLop.Name = "CboLop";
            this.CboLop.Size = new System.Drawing.Size(391, 56);
            this.CboLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã HS";
            // 
            // TxtMaHS
            // 
            this.TxtMaHS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaHS.Location = new System.Drawing.Point(242, 183);
            this.TxtMaHS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtMaHS.Name = "TxtMaHS";
            this.TxtMaHS.Size = new System.Drawing.Size(391, 56);
            this.TxtMaHS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên";
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoTen.Location = new System.Drawing.Point(242, 298);
            this.TxtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(1306, 56);
            this.TxtHoTen.TabIndex = 6;
            // 
            // DtpNgaySinh
            // 
            this.DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DtpNgaySinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpNgaySinh.Location = new System.Drawing.Point(1172, 74);
            this.DtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpNgaySinh.Name = "DtpNgaySinh";
            this.DtpNgaySinh.Size = new System.Drawing.Size(376, 56);
            this.DtpNgaySinh.TabIndex = 7;
            // 
            // TxtDiemTB
            // 
            this.TxtDiemTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiemTB.Location = new System.Drawing.Point(1172, 183);
            this.TxtDiemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDiemTB.Name = "TxtDiemTB";
            this.TxtDiemTB.Size = new System.Drawing.Size(376, 56);
            this.TxtDiemTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đại chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(854, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = "Điểm TB";
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaChi.Location = new System.Drawing.Point(242, 411);
            this.TxtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(1306, 56);
            this.TxtDiaChi.TabIndex = 10;
            // 
            // BtnThem
            // 
            this.BtnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Location = new System.Drawing.Point(1613, 90);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(220, 159);
            this.BtnThem.TabIndex = 11;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(1850, 90);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(220, 159);
            this.BtnSua.TabIndex = 11;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Location = new System.Drawing.Point(1850, 308);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(220, 159);
            this.BtnXoa.TabIndex = 11;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnTim
            // 
            this.BtnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTim.Location = new System.Drawing.Point(1613, 306);
            this.BtnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTim.Name = "BtnTim";
            this.BtnTim.Size = new System.Drawing.Size(220, 159);
            this.BtnTim.TabIndex = 11;
            this.BtnTim.Text = "Tìm";
            this.BtnTim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 545);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2011, 845);
            this.dataGridView1.TabIndex = 12;
            // 
            // FormQLHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2142, 1459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnTim);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.TxtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDiemTB);
            this.Controls.Add(this.DtpNgaySinh);
            this.Controls.Add(this.TxtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMaHS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboLop);
            this.Controls.Add(this.label1);
            this.Name = "FormQLHS";
            this.Text = "FormQLHS";
            this.Load += new System.EventHandler(this.FormQLHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.DateTimePicker DtpNgaySinh;
        private System.Windows.Forms.TextBox TxtDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDiaChi;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnTim;
        private DataGridView dataGridView1;
    }
}
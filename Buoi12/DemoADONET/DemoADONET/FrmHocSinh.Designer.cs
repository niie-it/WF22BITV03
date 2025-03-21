namespace DemoADONET
{
    partial class FrmHocSinh
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
            label2 = new Label();
            TxtMaHS = new TextBox();
            label3 = new Label();
            CboLop = new ComboBox();
            label4 = new Label();
            TxtTenHs = new TextBox();
            label5 = new Label();
            DtpNgaySinh = new DateTimePicker();
            label6 = new Label();
            TxtDiaChi = new TextBox();
            label7 = new Label();
            TxtDTB = new TextBox();
            groupBox1 = new GroupBox();
            BtnTim = new Button();
            BtnSua = new Button();
            BtnXoa = new Button();
            BtnThem = new Button();
            groupBox2 = new GroupBox();
            DgvHocSinh = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(657, 35);
            label1.Name = "label1";
            label1.Size = new Size(724, 83);
            label1.TabIndex = 0;
            label1.Text = "QUÃN LÝ HỌC SINH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.1F);
            label2.Location = new Point(27, 192);
            label2.Name = "label2";
            label2.Size = new Size(254, 53);
            label2.TabIndex = 1;
            label2.Text = "Mã học sinh";
            // 
            // TxtMaHS
            // 
            TxtMaHS.Font = new Font("Times New Roman", 14.1F);
            TxtMaHS.Location = new Point(287, 189);
            TxtMaHS.Name = "TxtMaHS";
            TxtMaHS.Size = new Size(415, 62);
            TxtMaHS.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.1F);
            label3.Location = new Point(863, 181);
            label3.Name = "label3";
            label3.Size = new Size(112, 53);
            label3.TabIndex = 3;
            label3.Text = "Lớp:";
            // 
            // CboLop
            // 
            CboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            CboLop.Font = new Font("Times New Roman", 14.1F);
            CboLop.FormattingEnabled = true;
            CboLop.Location = new Point(1029, 181);
            CboLop.Name = "CboLop";
            CboLop.Size = new Size(369, 61);
            CboLop.TabIndex = 4;
            CboLop.SelectedIndexChanged += CboLop_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.1F);
            label4.Location = new Point(27, 324);
            label4.Name = "label4";
            label4.Size = new Size(264, 53);
            label4.TabIndex = 5;
            label4.Text = "Tên học sinh";
            // 
            // TxtTenHs
            // 
            TxtTenHs.Font = new Font("Times New Roman", 14.1F);
            TxtTenHs.Location = new Point(287, 318);
            TxtTenHs.Name = "TxtTenHs";
            TxtTenHs.Size = new Size(1111, 62);
            TxtTenHs.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.1F);
            label5.Location = new Point(27, 430);
            label5.Name = "label5";
            label5.Size = new Size(210, 53);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh";
            // 
            // DtpNgaySinh
            // 
            DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            DtpNgaySinh.Font = new Font("Times New Roman", 14.1F);
            DtpNgaySinh.Format = DateTimePickerFormat.Custom;
            DtpNgaySinh.Location = new Point(287, 430);
            DtpNgaySinh.Name = "DtpNgaySinh";
            DtpNgaySinh.Size = new Size(500, 62);
            DtpNgaySinh.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.1F);
            label6.Location = new Point(27, 547);
            label6.Name = "label6";
            label6.Size = new Size(158, 53);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // TxtDiaChi
            // 
            TxtDiaChi.Font = new Font("Times New Roman", 14.1F);
            TxtDiaChi.Location = new Point(287, 547);
            TxtDiaChi.Name = "TxtDiaChi";
            TxtDiaChi.Size = new Size(1111, 62);
            TxtDiaChi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.1F);
            label7.Location = new Point(854, 430);
            label7.Name = "label7";
            label7.Size = new Size(333, 53);
            label7.TabIndex = 11;
            label7.Text = "Điểm trung bình";
            // 
            // TxtDTB
            // 
            TxtDTB.Font = new Font("Times New Roman", 14.1F);
            TxtDTB.Location = new Point(1188, 432);
            TxtDTB.Name = "TxtDTB";
            TxtDTB.Size = new Size(210, 62);
            TxtDTB.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTim);
            groupBox1.Controls.Add(BtnSua);
            groupBox1.Controls.Add(BtnXoa);
            groupBox1.Controls.Add(BtnThem);
            groupBox1.Font = new Font("Times New Roman", 14.1F);
            groupBox1.Location = new Point(1469, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 567);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // BtnTim
            // 
            BtnTim.Font = new Font("Times New Roman", 14.1F);
            BtnTim.Location = new Point(94, 441);
            BtnTim.Name = "BtnTim";
            BtnTim.Size = new Size(298, 88);
            BtnTim.TabIndex = 0;
            BtnTim.Text = "Tìm";
            BtnTim.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            BtnSua.Font = new Font("Times New Roman", 14.1F);
            BtnSua.Location = new Point(94, 324);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(298, 88);
            BtnSua.TabIndex = 0;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            BtnXoa.Font = new Font("Times New Roman", 14.1F);
            BtnXoa.Location = new Point(94, 194);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(298, 88);
            BtnXoa.TabIndex = 0;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnThem
            // 
            BtnThem.Font = new Font("Times New Roman", 14.1F);
            BtnThem.Location = new Point(94, 83);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(298, 88);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvHocSinh);
            groupBox2.Location = new Point(46, 699);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1914, 498);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách học sinh";
            // 
            // DgvHocSinh
            // 
            DgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHocSinh.Dock = DockStyle.Fill;
            DgvHocSinh.Location = new Point(3, 43);
            DgvHocSinh.Name = "DgvHocSinh";
            DgvHocSinh.RowHeadersWidth = 102;
            DgvHocSinh.Size = new Size(1908, 452);
            DgvHocSinh.TabIndex = 0;
            // 
            // FrmHocSinh
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1998, 1243);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TxtDTB);
            Controls.Add(label7);
            Controls.Add(TxtDiaChi);
            Controls.Add(label6);
            Controls.Add(DtpNgaySinh);
            Controls.Add(label5);
            Controls.Add(TxtTenHs);
            Controls.Add(label4);
            Controls.Add(CboLop);
            Controls.Add(label3);
            Controls.Add(TxtMaHS);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHocSinh";
            Text = "FrmHocSinh";
            Load += FrmHocSinh_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtMaHS;
        private Label label3;
        private ComboBox CboLop;
        private Label label4;
        private TextBox TxtTenHs;
        private Label label5;
        private DateTimePicker DtpNgaySinh;
        private Label label6;
        private TextBox TxtDiaChi;
        private Label label7;
        private TextBox TxtDTB;
        private GroupBox groupBox1;
        private Button BtnTim;
        private Button BtnSua;
        private Button BtnXoa;
        private Button BtnThem;
        private GroupBox groupBox2;
        private DataGridView DgvHocSinh;
    }
}
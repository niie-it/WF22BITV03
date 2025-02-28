namespace Lab04BT3._2
{
    partial class FrmMonAn
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
            txtTenMon = new TextBox();
            btnThem = new Button();
            lstThucDon = new ListBox();
            lstChon = new ListBox();
            btnChon = new Button();
            btnChonTatCa = new Button();
            btnXoa = new Button();
            btnXoaTatCa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(47, 92);
            label1.Name = "label1";
            label1.Size = new Size(177, 48);
            label1.TabIndex = 0;
            label1.Text = "Tên món";
            label1.Click += label1_Click;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Tahoma", 12F);
            txtTenMon.Location = new Point(272, 89);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(712, 56);
            txtTenMon.TabIndex = 1;
            txtTenMon.KeyPress += txtTenMon_KeyPress;
            txtTenMon.KeyUp += txtTenMon_KeyUp;
            // 
            // btnThem
            // 
            btnThem.Enabled = false;
            btnThem.Font = new Font("Tahoma", 12F);
            btnThem.Location = new Point(1144, 68);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(278, 96);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstThucDon
            // 
            lstThucDon.Font = new Font("Tahoma", 12F);
            lstThucDon.FormattingEnabled = true;
            lstThucDon.ItemHeight = 48;
            lstThucDon.Location = new Point(56, 221);
            lstThucDon.Name = "lstThucDon";
            lstThucDon.SelectionMode = SelectionMode.MultiSimple;
            lstThucDon.Size = new Size(588, 676);
            lstThucDon.TabIndex = 3;
            // 
            // lstChon
            // 
            lstChon.Font = new Font("Tahoma", 12F);
            lstChon.FormattingEnabled = true;
            lstChon.ItemHeight = 48;
            lstChon.Location = new Point(834, 211);
            lstChon.Name = "lstChon";
            lstChon.SelectionMode = SelectionMode.MultiSimple;
            lstChon.Size = new Size(588, 676);
            lstChon.TabIndex = 3;
            // 
            // btnChon
            // 
            btnChon.Font = new Font("Tahoma", 12F);
            btnChon.Location = new Point(670, 267);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(138, 128);
            btnChon.TabIndex = 4;
            btnChon.Text = ">";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Font = new Font("Tahoma", 12F);
            btnChonTatCa.Location = new Point(670, 433);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(138, 128);
            btnChonTatCa.TabIndex = 4;
            btnChonTatCa.Text = ">>";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Tahoma", 12F);
            btnXoa.Location = new Point(670, 593);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 128);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "<";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Font = new Font("Tahoma", 12F);
            btnXoaTatCa.Location = new Point(670, 759);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(138, 128);
            btnXoaTatCa.TabIndex = 4;
            btnXoaTatCa.Text = "<<";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Tahoma", 12F);
            btnThoat.Location = new Point(1144, 938);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(278, 96);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 1063);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnXoa);
            Controls.Add(btnChonTatCa);
            Controls.Add(btnChon);
            Controls.Add(lstChon);
            Controls.Add(lstThucDon);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(txtTenMon);
            Controls.Add(label1);
            Name = "FrmMonAn";
            Text = "ĐẶT MÓN ĂN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenMon;
        private Button btnThem;
        private ListBox lstThucDon;
        private ListBox lstChon;
        private Button btnChon;
        private Button btnChonTatCa;
        private Button btnXoa;
        private Button btnXoaTatCa;
        private Button btnThoat;
    }
}

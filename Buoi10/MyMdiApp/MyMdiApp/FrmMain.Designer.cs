namespace MyMdiApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            MnuDangNhap = new ToolStripMenuItem();
            MnuQLNguoiDung = new ToolStripMenuItem();
            MnuDangXuat = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            đóngTấtCảFormConToolStripMenuItem = new ToolStripMenuItem();
            thoátChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            tiệnÍchToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblThongTin = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, tiệnÍchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1747, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuDangNhap, MnuQLNguoiDung, MnuDangXuat, toolStripSeparator1, đóngTấtCảFormConToolStripMenuItem, thoátChươngTrìnhToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(167, 48);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // MnuDangNhap
            // 
            MnuDangNhap.Name = "MnuDangNhap";
            MnuDangNhap.Size = new Size(466, 54);
            MnuDangNhap.Text = "Đăng nhập";
            MnuDangNhap.Click += MnuDangNhap_Click;
            // 
            // MnuQLNguoiDung
            // 
            MnuQLNguoiDung.Name = "MnuQLNguoiDung";
            MnuQLNguoiDung.Size = new Size(466, 54);
            MnuQLNguoiDung.Text = "Quản lý người dùng";
            MnuQLNguoiDung.Click += MnuQLNguoiDung_Click;
            // 
            // MnuDangXuat
            // 
            MnuDangXuat.Name = "MnuDangXuat";
            MnuDangXuat.Size = new Size(466, 54);
            MnuDangXuat.Text = "Đăng xuất";
            MnuDangXuat.Click += MnuDangXuat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(463, 6);
            // 
            // đóngTấtCảFormConToolStripMenuItem
            // 
            đóngTấtCảFormConToolStripMenuItem.Name = "đóngTấtCảFormConToolStripMenuItem";
            đóngTấtCảFormConToolStripMenuItem.Size = new Size(466, 54);
            đóngTấtCảFormConToolStripMenuItem.Text = "Đóng tất cả form con";
            đóngTấtCảFormConToolStripMenuItem.Click += đóngTấtCảFormConToolStripMenuItem_Click;
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            thoátChươngTrìnhToolStripMenuItem.Size = new Size(466, 54);
            thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            // 
            // tiệnÍchToolStripMenuItem
            // 
            tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sắpXếpToolStripMenuItem });
            tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            tiệnÍchToolStripMenuItem.Size = new Size(144, 48);
            tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            // 
            // sắpXếpToolStripMenuItem
            // 
            sắpXếpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem, arrangeIconsToolStripMenuItem });
            sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            sắpXếpToolStripMenuItem.Size = new Size(297, 54);
            sắpXếpToolStripMenuItem.Text = "Sắp  xếp";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(375, 54);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(375, 54);
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(375, 54);
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(375, 54);
            arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 52);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1747, 51);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(58, 44);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(58, 44);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(40, 40);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTin });
            statusStrip1.Location = new Point(0, 1172);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1747, 54);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTin
            // 
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(290, 41);
            lblThongTin.Text = "Bạn chưa đăng nhập";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 1226);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Main Form";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem MnuDangNhap;
        private ToolStripMenuItem MnuQLNguoiDung;
        private ToolStripMenuItem MnuDangXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem đóngTấtCảFormConToolStripMenuItem;
        private ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem sắpXếpToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTin;
    }
}

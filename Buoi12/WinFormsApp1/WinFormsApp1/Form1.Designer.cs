namespace WinFormsApp1
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            danhSáchLớpToolStripMenuItem = new ToolStripMenuItem();
            danhSáchHọcSinhToolStripMenuItem = new ToolStripMenuItem();
            danhSáchLớpToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1766, 963);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchLớpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1766, 52);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            danhSáchLớpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchHọcSinhToolStripMenuItem, danhSáchLớpToolStripMenuItem1 });
            danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            danhSáchLớpToolStripMenuItem.Size = new Size(177, 48);
            danhSáchLớpToolStripMenuItem.Text = "Danh mục";
            // 
            // danhSáchHọcSinhToolStripMenuItem
            // 
            danhSáchHọcSinhToolStripMenuItem.Name = "danhSáchHọcSinhToolStripMenuItem";
            danhSáchHọcSinhToolStripMenuItem.Size = new Size(448, 54);
            danhSáchHọcSinhToolStripMenuItem.Text = "Danh sách Học sinh";
            danhSáchHọcSinhToolStripMenuItem.Click += danhSáchHọcSinhToolStripMenuItem_Click;
            // 
            // danhSáchLớpToolStripMenuItem1
            // 
            danhSáchLớpToolStripMenuItem1.Name = "danhSáchLớpToolStripMenuItem1";
            danhSáchLớpToolStripMenuItem1.Size = new Size(448, 54);
            danhSáchLớpToolStripMenuItem1.Text = "Danh sách Lớp";
            danhSáchLớpToolStripMenuItem1.Click += danhSáchLớpToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1766, 1015);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private ToolStripMenuItem danhSáchHọcSinhToolStripMenuItem;
        private ToolStripMenuItem danhSáchLớpToolStripMenuItem1;
    }
}

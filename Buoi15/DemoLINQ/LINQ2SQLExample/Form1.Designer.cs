namespace LINQ2SQLExample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2099, 1235);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnLoc
            // 
            this.BtnLoc.Font = new System.Drawing.Font("Tahoma", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc.Location = new System.Drawing.Point(1066, 65);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(204, 89);
            this.BtnLoc.TabIndex = 1;
            this.BtnLoc.Text = "Lọc học sinh";
            this.BtnLoc.UseVisualStyleBackColor = true;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm";
            // 
            // TxtTim
            // 
            this.TxtTim.Font = new System.Drawing.Font("Tahoma", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTim.Location = new System.Drawing.Point(222, 71);
            this.TxtTim.Name = "TxtTim";
            this.TxtTim.Size = new System.Drawing.Size(773, 71);
            this.TxtTim.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2163, 1475);
            this.Controls.Add(this.TxtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTim;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT02
{
    public partial class FrmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        const int DISTANCE = 20;
        const int WIDTH = 100;
        const int HEIGHT = 100;
        public FrmXuat(int dong = 1, int cot = 1)
        {
            SoDong = dong;
            SoCot = cot;
            InitializeComponent();

            Button button;
            //tạo ra control Button và thêm vô form
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    button = new Button
                    {
                        Width = WIDTH,
                        Height = HEIGHT,
                        Left = DISTANCE + (WIDTH + DISTANCE)*j,
                        Top = DISTANCE + (HEIGHT + DISTANCE)*i,
                        Text = (i * SoCot + j + 1).ToString()
                    };
                    button.Click += XuLyClick;
                    button.MouseHover += HoChuot;
                    this.Controls.Add(button);
                }
            }
            this.Size = new Size
            {
                Width = DISTANCE + (WIDTH + DISTANCE) * SoCot + 30,
                Height = DISTANCE + (HEIGHT + DISTANCE) * SoDong + 80
            };
        }

        void XuLyClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show($"Bạn vừa click button {btn.Text}");
        }

        void HoChuot(object sender, EventArgs e)
        {
            var btn = sender as Button;
            this.Text = $"Hover button {btn.Text}";
        }
    }
}

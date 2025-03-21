namespace DemoGDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var font = new Font("Tahoma", 16);
            var brush = new SolidBrush(Color.Red);
            //vẽ chữ
            g.DrawString("HELLO 22BITV03 GDI+", font, brush, 100, 100);
            //vẽ đường thẳng
            var pen = new Pen(Color.Magenta, 4);
            g.DrawLine(pen, 200, 200, 500, 400);
            //vẽ hình chữ nhật
            g.DrawRectangle(pen, 300, 300, 300, 500);
            g.DrawEllipse(new Pen(Color.DarkBlue, 7), 500, 300, 300, 500);
        }
    }
}

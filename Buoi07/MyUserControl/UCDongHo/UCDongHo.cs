using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UCDongHo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        DateTime startTime;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) //đang chạy
            {
                timer1.Enabled = false;
                btnLap.Enabled = false;
                btnStartStop.Text = "START";
            }
            else
            {
                timer1.Enabled = true;
                btnLap.Enabled = true;
                startTime = DateTime.Now;
                btnStartStop.Text = "STOP";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var mytime = DateTime.Now - startTime;
            lblDongHo.Text = $"{mytime.Hours.ToString("00")}:{mytime.Minutes.ToString("00")}:{mytime.Seconds.ToString("00")} {mytime.Milliseconds.ToString("000")}";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //ghi nhận thời gian hiện tại xuống file (tính từ lúc START)
            using (var sw = new StreamWriter("MyRecord.txt", true))
            {
                sw.WriteLine(lblDongHo.Text);
            }
        }
    }
}

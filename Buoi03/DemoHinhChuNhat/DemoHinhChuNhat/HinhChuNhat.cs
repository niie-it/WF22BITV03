using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHinhChuNhat
{
    public class HinhChuNhat
    {
        //Properties : biểu diễn đặc điểm của lớp
        public double Dai { get; set; }
        public double Rong { get; set; }
        public double DienTich { get; set; }
        public double ChuVi { get; set; }

        //Hàm tạo
        public HinhChuNhat(double dai = 1, double rong = 1)
        {
            this.Dai = dai; Rong = rong;
            DienTich = Dai * Rong;
            ChuVi = 2 * (Dai + Rong);
        }

        public override string ToString()
        {
            return $"HCN dài: {Dai}, rộng: {Rong}, S= {DienTich}, P = {ChuVi}";
        }
    }
}

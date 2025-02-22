using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    public abstract class HinhHoc
    {
        public double DienTich { get; set; }
        public double ChuVi { get; set; }
        public int Type { get; set; }
        public abstract void tinhDienTichChuVi();
        public abstract string Output();
    }

    public class HinhChuNhat : HinhHoc
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public HinhChuNhat(double d = 1, double r = 1)
        {
            Type = 1;
            Dai = d;
            Rong = r;
        }

        public override void tinhDienTichChuVi()
        {
            DienTich = Dai * Rong;
            ChuVi = (Dai + Rong) * 2;
        }

        public override string ToString()
        {
            return $"HCN D={Dai}, R={Rong}, S={DienTich}, P ={ChuVi}";
        }

        public override string Output()
        {
            return $"1\t{Dai}\t{Rong}";
        }
    }

    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }

        public HinhTron(double bk = 1)
        {
            Type = 2;
            BanKinh = bk;
        }

        public override void tinhDienTichChuVi()
        {
            DienTich = Math.Pow(BanKinh, 2) * Math.PI;
            ChuVi = 2 * BanKinh * Math.PI;
        }

        public override string ToString()
        {
            return $"Tròn R = {BanKinh}, S = {DienTich}, P = {ChuVi}";
        }

        public override string Output()
        {
            return $"{Type}\t{BanKinh}";
        }
    }
}

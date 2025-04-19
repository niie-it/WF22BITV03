using DemoQLBH.Entities;

namespace DemoQLBH
{
    public partial class FrmMain : Form
    {
        QlbanHangContext ctx;
        public FrmMain()
        {
            InitializeComponent();
            ctx = new QlbanHangContext();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CboKhachHang.DisplayMember = "TenCty";
            CboKhachHang.ValueMember = "MaKH";
            CboKhachHang.DataSource = ctx.KhachHangs.ToList();


            CboNhanVien.DisplayMember = "HoTen";
            CboNhanVien.ValueMember = "MaNV";
            CboNhanVien.DataSource = ctx.NhanViens
                .Select(p => new
                {
                    HoTen = $"{p.Ho} {p.Ten}",
                    MaNV = p.MaNv
                })
                .ToList();
        }
    }
}

using System;
using System.Collections.Generic;

namespace DemoQLBH.Entities;

public partial class ThanhPho
{
    public int MaThanhPho { get; set; }

    public string? TenThanhPho { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}

using System;
using System.Collections.Generic;

namespace Nhemiu.Models;

public partial class MauSac
{
    public Guid IdMauSac { get; set; }

    public string MauSac1 { get; set; } = null!;

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}

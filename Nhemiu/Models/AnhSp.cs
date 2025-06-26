using System;
using System.Collections.Generic;

namespace Nhemiu.Models;

public partial class AnhSp
{
    public Guid IdAnhSp { get; set; }

    public string FileAnh { get; set; } = null!;

    public Guid? IdSpct { get; set; }

    public virtual SanPhamChiTiet? IdSpctNavigation { get; set; }
}

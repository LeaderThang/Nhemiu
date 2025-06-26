﻿using System;
using System.Collections.Generic;

namespace Nhemiu.Models;

public partial class ThanhToan
{
    public Guid IdThanhToan { get; set; }

    public Guid IdHoaDon { get; set; }

    public string PhuongThucThanhToan { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double SoTienThanhToan { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? HoTen { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<DonHangThanhToan> DonHangThanhToans { get; set; } = new List<DonHangThanhToan>();

    public virtual ICollection<GiaoHang> GiaoHangs { get; set; } = new List<GiaoHang>();

    public virtual HoaDon IdHoaDonNavigation { get; set; } = null!;

    public virtual ICollection<SanPhamThanhToan> SanPhamThanhToans { get; set; } = new List<SanPhamThanhToan>();
}

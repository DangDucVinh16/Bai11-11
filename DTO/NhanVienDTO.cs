using System;

namespace DTO;

public class NhanVienDTO
{
    public int MaNV { get; set; }
    public string HoTen { get; set; } = string.Empty;
    public DateTime NgaySinh { get; set; }
    public string CCCD { get; set; } = string.Empty;
    public int MaPB { get; set; }
    public decimal LuongCoBan { get; set; }
    public float HeSoLuong { get; set; } = 1.0f;

    public NhanVienDTO() { }

    public NhanVienDTO(int maNV, string hoTen, DateTime ngaySinh, string cccd, int maPB, decimal luongCoBan, float heSoLuong)
    {
        MaNV = maNV;
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        CCCD = cccd;
        MaPB = maPB;
        LuongCoBan = luongCoBan;
        HeSoLuong = heSoLuong;
    }
}
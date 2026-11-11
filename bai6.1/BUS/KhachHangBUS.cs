using System.Data;
using DAL;
using DTO;

namespace BUS;

public class KhachHangBUS
{
    private readonly KhachHangDAL _dal = new KhachHangDAL();

    public DataTable LayDanhSachKhachHang()
    {
        return _dal.LayDanhSachKhachHang();
    }

    public bool ThemKhachHang(KhachHangDTO kh, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(kh.TenKH))
        {
            error = "Tên khách hàng không được để trống!";
            return false;
        }
        return _dal.ThemKhachHang(kh);
    }

    public bool SuaKhachHang(KhachHangDTO kh, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(kh.TenKH))
        {
            error = "Tên khách hàng không được để trống!";
            return false;
        }
        return _dal.SuaKhachHang(kh);
    }

    public bool XoaKhachHang(int maKH)
    {
        return _dal.XoaKhachHang(maKH);
    }
}
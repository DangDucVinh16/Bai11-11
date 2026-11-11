using System.Data;
using DAL;
using DTO;

namespace BUS;

public class NhanVienBUS
{
    private readonly NhanVienDAL _dal = new NhanVienDAL();

    public DataTable LayDanhSachNhanVien()
    {
        return _dal.LayDanhSachNhanVien();
    }

    public DataTable TimKiemNhanVien(string keyword)
    {
        return _dal.TimKiemNhanVien(keyword);
    }

    public bool ThemNhanVien(NhanVienDTO nv, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(nv.HoTen))
        {
            error = "Họ tên nhân viên không được để trống!";
            return false;
        }
        if (nv.LuongCoBan <= 0)
        {
            error = "Lương cơ bản phải lớn hơn 0!";
            return false;
        }
        return _dal.ThemNhanVien(nv);
    }

    public bool SuaNhanVien(NhanVienDTO nv, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(nv.HoTen))
        {
            error = "Họ tên nhân viên không được để trống!";
            return false;
        }
        if (nv.LuongCoBan <= 0)
        {
            error = "Lương cơ bản phải lớn hơn 0!";
            return false;
        }
        return _dal.SuaNhanVien(nv);
    }

    public bool XoaNhanVien(int maNV)
    {
        return _dal.XoaNhanVien(maNV);
    }
}
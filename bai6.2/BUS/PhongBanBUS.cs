using System.Data;
using DAL;
using DTO;

namespace BUS;

public class PhongBanBUS
{
    private readonly PhongBanDAL _dal = new PhongBanDAL();

    public DataTable LayDanhSachPhongBan()
    {
        return _dal.LayDanhSachPhongBan();
    }

    public bool ThemPhongBan(PhongBanDTO pb, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(pb.TenPB))
        {
            error = "Tên phòng ban không được để trống!";
            return false;
        }
        return _dal.ThemPhongBan(pb);
    }

    public bool SuaPhongBan(PhongBanDTO pb, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(pb.TenPB))
        {
            error = "Tên phòng ban không được để trống!";
            return false;
        }
        return _dal.SuaPhongBan(pb);
    }

    public bool XoaPhongBan(int maPB)
    {
        return _dal.XoaPhongBan(maPB);
    }
}
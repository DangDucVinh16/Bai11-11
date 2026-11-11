using System.Data;
using DAL;

namespace BUS;

public class BangChamCongBUS
{
    private readonly BangChamCongDAL _dal = new BangChamCongDAL();

    public DataTable LayDanhSachChamCong(string thangNam)
    {
        return _dal.LayDanhSachChamCong(thangNam);
    }

    public bool LuuChamCong(DataTable dtChamCong, string thangNam, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(thangNam))
        {
            error = "Tháng năm chấm công không hợp lệ!";
            return false;
        }

        bool result = _dal.LuuChamCong(dtChamCong, thangNam);
        if (!result)
        {
            error = "Lưu chấm công thất bại! Vui lòng kiểm tra lại số ngày công (tối đa 31 ngày).";
        }
        return result;
    }
}
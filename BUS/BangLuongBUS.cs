using DAL;

namespace BUS;

public class BangLuongBUS
{
    private readonly BangLuongDAL _dal = new BangLuongDAL();

    public bool ChotLuongThang(string thangNam, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(thangNam))
        {
            error = "Vui lòng chọn tháng năm cần chốt lương!";
            return false;
        }

        return _dal.ChotLuongThang(thangNam, out error);
    }
}
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL;

public class BangChamCongDAL
{
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";

    /// <summary>
    /// Nạp dữ liệu chấm công theo Tháng/Năm (Sử dụng đơn bảng để SqlCommandBuilder hoạt động chính xác)
    /// </summary>
    public DataTable LayDanhSachChamCong(string thangNam)
    {
        DataTable dt = new DataTable();
        using var conn = new MySqlConnection(_connStr);
        conn.Open();

        // Bước 1: Tự động bổ sung bản ghi chấm công mặc định (0 ngày công, 0 giờ OT) 
        // cho những nhân viên mới được thêm vào hệ thống nhưng chưa có dữ liệu trong tháng này.
        string initQuery = @"
            INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT)
            SELECT MaNV, @ThangNam, 0, 0 
            FROM NhanVien 
            WHERE MaNV NOT IN (SELECT MaNV FROM BangChamCong WHERE ThangNam = @ThangNam)";

        using (var cmdInit = new MySqlCommand(initQuery, conn))
        {
            cmdInit.Parameters.AddWithValue("@ThangNam", thangNam);
            cmdInit.ExecuteNonQuery();
        }

        // Bước 2: Lấy dữ liệu thuần từ bảng BangChamCong theo đúng tháng/năm yêu cầu
        string query = "SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT FROM BangChamCong WHERE ThangNam = @ThangNam";
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@ThangNam", thangNam);

        using var da = new MySqlDataAdapter(cmd);
        da.Fill(dt);

        // Bước 3: RẤT QUAN TRỌNG - Khai báo khóa chính cho DataTable 
        // để SqlCommandBuilder nhận diện dòng unique và tự sinh lệnh UPDATE/INSERT.
        if (dt.Columns["MaCong"] != null)
        {
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaCong"] };
        }

        return dt;
    }

    /// <summary>
    /// Đồng bộ toàn bộ thay đổi từ DataTable về CSDL trong 1 thao tác sử dụng SqlCommandBuilder và adapter.Update()
    /// </summary>
    public bool LuuChamCong(DataTable dtChamCong, string thangNam)
    {
        using var conn = new MySqlConnection(_connStr);
        string query = "SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT FROM BangChamCong WHERE ThangNam = @ThangNam";

        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@ThangNam", thangNam);

        using var da = new MySqlDataAdapter(cmd);
        
        // SqlCommandBuilder tự động sinh câu lệnh INSERT/UPDATE dựa trên Primary Key của DataTable
        using var builder = new MySqlCommandBuilder(da);

        try
        {
            conn.Open();
            da.Update(dtChamCong); // Đồng bộ thay đổi ngắt kết nối
            return true;
        }
        catch
        {
            return false;
        }
    }
}
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL;

public class BangLuongDAL
{
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";

    public bool ChotLuongThang(string thangNam, out string errorMsg)
    {
        errorMsg = string.Empty;
        using var conn = new MySqlConnection(_connStr);
        conn.Open();
        using var trans = conn.BeginTransaction();

        try
        {
            // Bước 1: Lấy thông tin lương & chấm công của nhân viên trong tháng
            string getQuery = @"
                SELECT nv.MaNV, nv.LuongCoBan, nv.HeSoLuong, cc.SoNgayCong, cc.SoGioOT 
                FROM NhanVien nv 
                JOIN BangChamCong cc ON nv.MaNV = cc.MaNV 
                WHERE cc.ThangNam = @ThangNam";

            DataTable dt = new DataTable();
            using (var cmdGet = new MySqlCommand(getQuery, conn, trans))
            {
                cmdGet.Parameters.AddWithValue("@ThangNam", thangNam);
                using var da = new MySqlDataAdapter(cmdGet);
                da.Fill(dt);
            }

            if (dt.Rows.Count == 0)
            {
                trans.Rollback();
                errorMsg = "Không tìm thấy dữ liệu chấm công hợp lệ trong tháng!";
                return false;
            }

            // Bước 2: Tính toán và lưu vào bảng BangLuong
            foreach (DataRow row in dt.Rows)
            {
                int maNV = Convert.ToInt32(row["MaNV"]);
                decimal luongCoBan = Convert.ToDecimal(row["LuongCoBan"]);
                float heSoLuong = Convert.ToSingle(row["HeSoLuong"]);
                float soNgayCong = Convert.ToSingle(row["SoNgayCong"]);
                float soGioOT = Convert.ToSingle(row["SoGioOT"]);

                // Công thức tính: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50000)
                decimal thucLinh = (decimal)((luongCoBan * (decimal)heSoLuong / 22m) * (decimal)soNgayCong) + (decimal)(soGioOT * 50000);

                string upsertQuery = @"
                    INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) 
                    VALUES (@MaNV, @ThangNam, @ThucLinh)
                    ON DUPLICATE KEY UPDATE ThucLinh = @ThucLinh";

                using var cmdSave = new MySqlCommand(upsertQuery, conn, trans);
                cmdSave.Parameters.AddWithValue("@MaNV", maNV);
                cmdSave.Parameters.AddWithValue("@ThangNam", thangNam);
                cmdSave.Parameters.AddWithValue("@ThucLinh", thucLinh);
                cmdSave.ExecuteNonQuery();
            }

            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            trans.Rollback();
            errorMsg = "Lỗi hệ thống khi chốt lương: " + ex.Message;
            return false;
        }
    }
}
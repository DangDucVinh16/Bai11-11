using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL;

public class PhongBanDAL
{
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";

    public DataTable LayDanhSachPhongBan()
    {
        DataTable dt = new DataTable();
        const string query = "SELECT * FROM PhongBan";

        using var conn = new MySqlConnection(_connStr);
        using var da = new MySqlDataAdapter(query, conn);
        da.Fill(dt);
        return dt;
    }

    public bool ThemPhongBan(PhongBanDTO pb)
    {
        const string query = "INSERT INTO PhongBan (TenPB, Mota) VALUES (@TenPB, @Mota)";
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@TenPB", pb.TenPB);
        cmd.Parameters.AddWithValue("@Mota", string.IsNullOrEmpty(pb.Mota) ? (object)DBNull.Value : pb.Mota);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool SuaPhongBan(PhongBanDTO pb)
    {
        const string query = "UPDATE PhongBan SET TenPB = @TenPB, Mota = @Mota WHERE MaPB = @MaPB";
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@MaPB", pb.MaPB);
        cmd.Parameters.AddWithValue("@TenPB", pb.TenPB);
        cmd.Parameters.AddWithValue("@Mota", string.IsNullOrEmpty(pb.Mota) ? (object)DBNull.Value : pb.Mota);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool XoaPhongBan(int maPB)
    {
        const string query = "DELETE FROM PhongBan WHERE MaPB = @MaPB";
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@MaPB", maPB);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}
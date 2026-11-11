using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL;

public class NhanVienDAL
{
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";

    public DataTable LayDanhSachNhanVien()
    {
        DataTable dt = new DataTable();
        const string query = @"
            SELECT nv.*, pb.TenPB 
            FROM NhanVien nv 
            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB";

        using var conn = new MySqlConnection(_connStr);
        using var da = new MySqlDataAdapter(query, conn);
        da.Fill(dt);
        return dt;
    }

    public DataTable TimKiemNhanVien(string keyword)
    {
        DataTable dt = new DataTable();
        const string query = @"
            SELECT nv.*, pb.TenPB 
            FROM NhanVien nv 
            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB 
            WHERE nv.HoTen LIKE @kw OR nv.CCCD LIKE @kw OR pb.TenPB LIKE @kw";

        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

        using var da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public bool ThemNhanVien(NhanVienDTO nv)
    {
        const string query = @"
            INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) 
            VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";

        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
        cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
        cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
        cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
        cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool SuaNhanVien(NhanVienDTO nv)
    {
        const string query = @"
            UPDATE NhanVien 
            SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, MaPB = @MaPB, LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong 
            WHERE MaNV = @MaNV";

        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
        cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
        cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
        cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
        cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
        cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool XoaNhanVien(int maNV)
    {
        const string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@MaNV", maNV);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}
using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        private string connStr = "Server=localhost;Database=SalesDB;Uid=root;Pwd=;";

        public DataTable LayDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM KhachHang";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public bool ThemKhachHang(KhachHangDTO kh)
        {
            string query = "INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES (@TenKH, @DienThoai, @DiemTichLuy)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                    cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SuaKhachHang(KhachHangDTO kh)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiemTichLuy = @DiemTichLuy WHERE MaKH = @MaKH";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                    cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool XoaKhachHang(int maKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
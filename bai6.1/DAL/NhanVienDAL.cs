using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        private string connStr = "Server=localhost;Database=SalesDB;Uid=root;Pwd=;";

        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NhanVien";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            string query = "INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES (@TenNV, @SoDienThoai, @ChucVu)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                    cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                    cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {
            string query = "UPDATE NhanVien SET TenNV = @TenNV, SoDienThoai = @SoDienThoai, ChucVu = @ChucVu WHERE MaNV = @MaNV";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                    cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                    cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool XoaNhanVien(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
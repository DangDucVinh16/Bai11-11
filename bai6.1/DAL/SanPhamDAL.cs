using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class SanPhamDAL
    {
        private string connStr = "Server=localhost;Database=SalesDB;Uid=root;Pwd=;";

        // Phương thức lấy danh sách toàn bộ sản phẩm
        public DataTable LayDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SanPham";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Tìm kiếm sản phẩm chống SQL Injection bằng SqlParameter
        public DataTable TimKiemSanPham(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SanPham WHERE MaSP LIKE @keyword OR TenSP LIKE @keyword";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@keyword", MySqlDbType.VarChar).Value = "%" + keyword + "%";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Thêm sản phẩm
        public bool ThemSanPham(SanPhamDTO sp)
        {
            string query = "INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongTon)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SanPhamDTO sp)
        {
            string query = "UPDATE SanPham SET TenSP = @TenSP, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaSP = @MaSP";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa sản phẩm
        public bool XoaSanPham(string maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
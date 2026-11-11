using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ThongKeDAL
    {
        private string connStr = "Server=localhost;Database=SalesDB;Uid=root;Pwd=;";

        // Tính tổng doanh thu theo ngày (dùng ExecuteScalar)
        public decimal TongDoanhThuTheoNgay(DateTime ngay)
        {
            string query = "SELECT IFNULL(SUM(TongTien), 0) FROM HoaDon WHERE DATE(NgayLap) = @Ngay";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Ngay", MySqlDbType.Date).Value = ngay.Date;
                    conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        // Tính tổng doanh thu theo tháng/năm (dùng ExecuteScalar)
        public decimal TongDoanhThuTheoThang(int thang, int nam)
        {
            string query = "SELECT IFNULL(SUM(TongTien), 0) FROM HoaDon WHERE MONTH(NgayLap) = @Thang AND YEAR(NgayLap) = @Nam";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        // Lấy Top 5 sản phẩm bán chạy nhất (dùng SqlDataReader / DataTable)
        public DataTable Top5SanPhamBanChay()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT sp.MaSP, sp.TenSP, SUM(ct.SoLuong) AS TongBan 
                             FROM ChiTietHoaDon ct 
                             JOIN SanPham sp ON ct.MaSP = sp.MaSP 
                             GROUP BY sp.MaSP, sp.TenSP 
                             ORDER BY TongBan DESC 
                             LIMIT 5;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
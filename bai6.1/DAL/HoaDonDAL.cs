using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL;

public class HoaDonDAL
{
    private readonly string _connStr = "Server=localhost;Database=SalesDB;Uid=root;Pwd=;";

    public bool ThanhToanHoaDon(int maNV, int? maKH, List<ChiTietHoaDonDTO> chiTietList, out string errorMsg)
    {
        errorMsg = string.Empty;

        using var conn = new MySqlConnection(_connStr);
        conn.Open();
        
        using var trans = conn.BeginTransaction();

        try
        {
            // Bước 1: Kiểm tra tồn kho
            foreach (var item in chiTietList)
            {
                const string checkStock = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                using var cmdCheck = new MySqlCommand(checkStock, conn, trans);
                cmdCheck.Parameters.AddWithValue("@MaSP", item.MaSP);
                
                var result = cmdCheck.ExecuteScalar();
                if (result == null)
                {
                    trans.Rollback();
                    errorMsg = $"Không tìm thấy sản phẩm có mã: {item.MaSP}";
                    return false;
                }

                int tonKho = Convert.ToInt32(result);
                if (tonKho < item.SoLuong)
                {
                    trans.Rollback();
                    errorMsg = $"Sản phẩm {item.MaSP} không đủ số lượng tồn kho (Còn lại: {tonKho}, Yêu cầu: {item.SoLuong}).";
                    return false;
                }
            }

            // Bước 2: Tính tổng tiền
            decimal tongTien = 0;
            foreach (var item in chiTietList)
            {
                tongTien += item.SoLuong * item.DonGia;
            }

            // Bước 3: Tạo hóa đơn
            const string insertHD = "INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) VALUES (NOW(), @MaNV, @MaKH, @TongTien); SELECT LAST_INSERT_ID();";
            int maHD;
            using (var cmdHD = new MySqlCommand(insertHD, conn, trans))
            {
                cmdHD.Parameters.AddWithValue("@MaNV", maNV);
                cmdHD.Parameters.AddWithValue("@MaKH", maKH.HasValue ? maKH.Value : DBNull.Value);
                cmdHD.Parameters.AddWithValue("@TongTien", tongTien);

                maHD = Convert.ToInt32(cmdHD.ExecuteScalar());
            }

            // Bước 4: Thêm ChiTietHoaDon & Trừ tồn kho (LUÔN DÙNG MySqlCommand)
            foreach (var item in chiTietList)
            {
                const string insertCT = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                using (var cmdCT = new MySqlCommand(insertCT, conn, trans))
                {
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                    cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                    cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                    cmdCT.ExecuteNonQuery();
                }

                const string updateStock = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";
                using (var cmdUp = new MySqlCommand(updateStock, conn, trans)) // Đã sửa từ SqlCommand thành MySqlCommand
                {
                    cmdUp.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                    cmdUp.Parameters.AddWithValue("@MaSP", item.MaSP);
                    cmdUp.ExecuteNonQuery();
                }
            }

            // Bước 5: Cộng điểm tích lũy
            if (maKH.HasValue)
            {
                int diemThem = (int)(tongTien / 100000);
                const string updateDiem = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @Diem WHERE MaKH = @MaKH";
                using var cmdDiem = new MySqlCommand(updateDiem, conn, trans);
                cmdDiem.Parameters.AddWithValue("@Diem", diemThem);
                cmdDiem.Parameters.AddWithValue("@MaKH", maKH.Value);
                cmdDiem.ExecuteNonQuery();
            }

            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            try { trans.Rollback(); } catch { }
            errorMsg = "Lỗi hệ thống khi thanh toán: " + ex.Message;
            return false;
        }
    }
}
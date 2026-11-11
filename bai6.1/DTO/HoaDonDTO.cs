using System;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public int? MaKH { get; set; } // Nullable nếu là khách lẻ
        public decimal TongTien { get; set; }

        public HoaDonDTO() { }

        public HoaDonDTO(int maHD, DateTime ngayLap, int maNV, int? maKH, decimal tongTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaNV = maNV;
            MaKH = maKH;
            TongTien = tongTien;
        }
    }
}
namespace DTO;

public class ChiTietHoaDonDTO
{
    public int MaHD { get; set; }
    public string MaSP { get; set; }
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;

    public ChiTietHoaDonDTO() { }

    public ChiTietHoaDonDTO(int maHD, string maSP, int soLuong, decimal donGia)
    {
        MaHD = maHD;
        MaSP = maSP;
        SoLuong = soLuong;
        DonGia = donGia;
    }
}
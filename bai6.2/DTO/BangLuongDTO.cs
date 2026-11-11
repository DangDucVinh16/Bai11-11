namespace DTO;

public class BangLuongDTO
{
    public int MaLuong { get; set; }
    public int MaNV { get; set; }
    public string ThangNam { get; set; } = string.Empty;
    public decimal ThucLinh { get; set; }

    public BangLuongDTO() { }

    public BangLuongDTO(int maLuong, int maNV, string thangNam, decimal thucLinh)
    {
        MaLuong = maLuong;
        MaNV = maNV;
        ThangNam = thangNam;
        ThucLinh = thucLinh;
    }
}
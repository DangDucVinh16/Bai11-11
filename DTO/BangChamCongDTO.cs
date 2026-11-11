namespace DTO;

public class BangChamCongDTO
{
    public int MaCong { get; set; }
    public int MaNV { get; set; }
    public string ThangNam { get; set; } = string.Empty; // Ví dụ: "11/2026"
    public float SoNgayCong { get; set; }
    public float SoGioOT { get; set; }

    public BangChamCongDTO() { }

    public BangChamCongDTO(int maCong, int maNV, string thangNam, float soNgayCong, float soGioOT)
    {
        MaCong = maCong;
        MaNV = maNV;
        ThangNam = thangNam;
        SoNgayCong = soNgayCong;
        SoGioOT = soGioOT;
    }
}
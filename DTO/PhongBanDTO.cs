namespace DTO;

public class PhongBanDTO
{
    public int MaPB { get; set; }
    public string TenPB { get; set; } = string.Empty;
    public string Mota { get; set; } = string.Empty;

    public PhongBanDTO() { }

    public PhongBanDTO(int maPB, string tenPB, string mota)
    {
        MaPB = maPB;
        TenPB = tenPB;
        Mota = mota;
    }
}
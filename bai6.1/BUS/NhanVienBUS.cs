using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public DataTable LayDanhSachNhanVien()
        {
            return dal.LayDanhSachNhanVien();
        }

        public bool ThemNhanVien(NhanVienDTO nv, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(nv.TenNV))
            {
                error = "Tên nhân viên không được để trống!";
                return false;
            }
            return dal.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(NhanVienDTO nv, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(nv.TenNV))
            {
                error = "Tên nhân viên không được để trống!";
                return false;
            }
            return dal.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(int maNV)
        {
            return dal.XoaNhanVien(maNV);
        }
    }
}
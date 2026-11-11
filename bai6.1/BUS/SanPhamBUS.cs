using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public DataTable LayDanhSachSanPham()
        {
            return dal.LayDanhSachSanPham();
        }

        public DataTable TimKiemSanPham(string keyword)
        {
            return dal.TimKiemSanPham(keyword);
        }

        public bool ThemSanPham(SanPhamDTO sp, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(sp.MaSP))
            {
                error = "Mã sản phẩm không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                error = "Tên sản phẩm không được để trống!";
                return false;
            }
            if (sp.GiaBan <= 0)
            {
                error = "Giá bán phải lớn hơn 0!";
                return false;
            }
            if (sp.SoLuongTon < 0)
            {
                error = "Số lượng tồn không được âm!";
                return false;
            }
            return dal.ThemSanPham(sp);
        }

        public bool SuaSanPham(SanPhamDTO sp, out string error)
        {
            error = "";
            if (sp.GiaBan <= 0)
            {
                error = "Giá bán phải lớn hơn 0!";
                return false;
            }
            return dal.SuaSanPham(sp);
        }

        public bool XoaSanPham(string maSP)
        {
            return dal.XoaSanPham(maSP);
        }
    }
}
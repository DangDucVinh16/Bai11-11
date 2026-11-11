using System;
using System.Data;
using DAL;

namespace BUS
{
    public class ThongKeBUS
    {
        private ThongKeDAL dal = new ThongKeDAL();

        public decimal TongDoanhThuTheoNgay(DateTime ngay)
        {
            return dal.TongDoanhThuTheoNgay(ngay);
        }

        public decimal TongDoanhThuTheoThang(int thang, int nam)
        {
            return dal.TongDoanhThuTheoThang(thang, nam);
        }

        public DataTable Top5SanPhamBanChay()
        {
            return dal.Top5SanPhamBanChay();
        }
    }
}
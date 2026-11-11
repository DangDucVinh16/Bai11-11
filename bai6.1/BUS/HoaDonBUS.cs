using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public bool ThanhToanHoaDon(int maNV, int? maKH, List<ChiTietHoaDonDTO> chiTietList, out string errorMsg)
        {
            errorMsg = "";
            if (chiTietList == null || chiTietList.Count == 0)
            {
                errorMsg = "Giỏ hàng trống, không thể thanh toán!";
                return false;
            }

            foreach (var item in chiTietList)
            {
                if (item.SoLuong <= 0)
                {
                    errorMsg = $"Sản phẩm {item.MaSP} có số lượng mua phải lớn hơn 0!";
                    return false;
                }
            }

            // Gọi DAL để thực hiện Transaction ACID
            return dal.ThanhToanHoaDon(maNV, maKH, chiTietList, out errorMsg);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormBanHang : Form
{
    private readonly SanPhamBUS _spBus = new SanPhamBUS();
    private readonly NhanVienBUS _nvBus = new NhanVienBUS();
    private readonly KhachHangBUS _khBus = new KhachHangBUS();
    private readonly HoaDonBUS _hdBus = new HoaDonBUS();

    private List<ChiTietHoaDonDTO> _gioHang = new List<ChiTietHoaDonDTO>();

    public FormBanHang()
    {
        InitializeComponent();
        LoadComboBoxData();
        dgvGioHang.AutoGenerateColumns = false;
    }

    private void LoadComboBoxData()
    {
        // Load Nhân viên
        cmbNhanVien.DataSource = _nvBus.LayDanhSachNhanVien();
        cmbNhanVien.DisplayMember = "TenNV";
        cmbNhanVien.ValueMember = "MaNV";

        // Load Khách hàng
        var dtKH = _khBus.LayDanhSachKhachHang();
        // Thêm dòng khách lẻ tùy chọn nếu muốn
        cmbKhachHang.DataSource = dtKH;
        cmbKhachHang.DisplayMember = "TenKH";
        cmbKhachHang.ValueMember = "MaKH";

        // Load Sản phẩm
        cmbSanPham.DataSource = _spBus.LayDanhSachSanPham();
        cmbSanPham.DisplayMember = "TenSP";
        cmbSanPham.ValueMember = "MaSP";
    }

    private void btnThemGH_Click(object sender, EventArgs e)
    {
        if (cmbSanPham.SelectedValue == null) return;

        string maSP = cmbSanPham.SelectedValue.ToString();
        DataRowView selectedRow = (DataRowView)cmbSanPham.SelectedItem;
        string tenSP = selectedRow["TenSP"].ToString();
        decimal giaBan = Convert.ToDecimal(selectedRow["GiaBan"]);

        if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
        {
            MessageBox.Show("Số lượng mua phải là số nguyên lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
        var existingItem = _gioHang.Find(x => x.MaSP == maSP);
        if (existingItem != null)
        {
            existingItem.SoLuong += soLuong;
        }
        else
        {
            _gioHang.Add(new ChiTietHoaDonDTO
            {
                MaSP = maSP,
                SoLuong = soLuong,
                DonGia = giaBan
            });
        }

        RefreshDataGridView();
    }

    private void RefreshDataGridView()
    {
        dgvGioHang.Rows.Clear();
        decimal tongTien = 0;

        foreach (var item in _gioHang)
        {
            // Lấy tên sản phẩm từ mã SP để hiển thị
            string tenSP = "";
            var dtSP = _spBus.TimKiemSanPham(item.MaSP);
            if (dtSP.Rows.Count > 0)
            {
                tenSP = dtSP.Rows[0]["TenSP"].ToString();
            }

            dgvGioHang.Rows.Add(item.MaSP, tenSP, item.SoLuong, item.DonGia.ToString("N0"), item.ThanhTien.ToString("N0"));
            tongTien += item.ThanhTien;
        }

        lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        if (_gioHang.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbNhanVien.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int maNV = Convert.ToInt32(cmbNhanVien.SelectedValue);
        int? maKH = cmbKhachHang.SelectedValue != null ? (int?)Convert.ToInt32(cmbKhachHang.SelectedValue) : null;

        // Gọi BUS thực thi giao dịch Transaction ACID
        if (_hdBus.ThanhToanHoaDon(maNV, maKH, _gioHang, out string errorMsg))
        {
            MessageBox.Show("Thanh toán hóa đơn thành công và đã trừ tồn kho tự động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Reset giỏ hàng sau khi thanh toán thành công
            _gioHang.Clear();
            RefreshDataGridView();
            LoadComboBoxData(); // Cập nhật lại tồn kho trên combobox sản phẩm
        }
        else
        {
            MessageBox.Show("Thanh toán thất bại: " + errorMsg, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
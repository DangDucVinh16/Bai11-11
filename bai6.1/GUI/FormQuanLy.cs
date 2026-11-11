using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormQuanLy : Form
{
    private readonly SanPhamBUS _spBus = new SanPhamBUS();
    private readonly NhanVienBUS _nvBus = new NhanVienBUS();
    private readonly KhachHangBUS _khBus = new KhachHangBUS();

    public FormQuanLy()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        dgvSanPham.DataSource = _spBus.LayDanhSachSanPham();
        dgvNhanVien.DataSource = _nvBus.LayDanhSachNhanVien();
        dgvKhachHang.DataSource = _khBus.LayDanhSachKhachHang();
    }

    #region Xử lý Sản Phẩm
    private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
            txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();
            txtMaSP.Enabled = false; // Khóa mã sản phẩm khi đang chọn sửa
        }
    }

    private void btnThemSP_Click(object sender, EventArgs e)
    {
        var sp = new SanPhamDTO
        {
            MaSP = txtMaSP.Text.Trim(),
            TenSP = txtTenSP.Text.Trim(),
            GiaBan = decimal.TryParse(txtGiaBan.Text, out var gia) ? gia : 0,
            SoLuongTon = int.TryParse(txtSoLuongTon.Text, out var sl) ? sl : 0
        };

        if (_spBus.ThemSanPham(sp, out string error))
        {
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearSanPhamFields();
        }
        else
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSuaSP_Click(object sender, EventArgs e)
    {
        var sp = new SanPhamDTO
        {
            MaSP = txtMaSP.Text.Trim(),
            TenSP = txtTenSP.Text.Trim(),
            GiaBan = decimal.TryParse(txtGiaBan.Text, out var gia) ? gia : 0,
            SoLuongTon = int.TryParse(txtSoLuongTon.Text, out var sl) ? sl : 0
        };

        if (_spBus.SuaSanPham(sp, out string error))
        {
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            txtMaSP.Enabled = true;
            ClearSanPhamFields();
        }
        else
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoaSP_Click(object sender, EventArgs e)
    {
        string maSP = txtMaSP.Text.Trim();
        if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {maSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            if (_spBus.XoaSanPham(maSP))
            {
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtMaSP.Enabled = true;
                ClearSanPhamFields();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void txtTimKiem_TextChanged(object sender, EventArgs e)
    {
        string keyword = txtTimKiem.Text.Trim();
        dgvSanPham.DataSource = _spBus.TimKiemSanPham(keyword);
    }

    private void ClearSanPhamFields()
    {
        txtMaSP.Clear();
        txtTenSP.Clear();
        txtGiaBan.Clear();
        txtSoLuongTon.Clear();
    }
    #endregion

    #region Xử lý Nhân Viên
    private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
            txtSDTNV.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
        }
    }

    private void btnThemNV_Click(object sender, EventArgs e)
    {
        var nv = new NhanVienDTO
        {
            TenNV = txtTenNV.Text.Trim(),
            SoDienThoai = txtSDTNV.Text.Trim(),
            ChucVu = txtChucVu.Text.Trim()
        };

        if (_nvBus.ThemNhanVien(nv, out string error))
        {
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearNhanVienFields();
        }
        else
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSuaNV_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaNV.Text, out int maNV))
        {
            var nv = new NhanVienDTO
            {
                MaNV = maNV,
                TenNV = txtTenNV.Text.Trim(),
                SoDienThoai = txtSDTNV.Text.Trim(),
                ChucVu = txtChucVu.Text.Trim()
            };

            if (_nvBus.SuaNhanVien(nv, out string error))
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearNhanVienFields();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnXoaNV_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaNV.Text, out int maNV))
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_nvBus.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearNhanVienFields();
                }
            }
        }
    }

    private void ClearNhanVienFields()
    {
        txtMaNV.Clear();
        txtTenNV.Clear();
        txtSDTNV.Clear();
        txtChucVu.Clear();
    }
    #endregion

    #region Xử lý Khách Hàng
    private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
            txtSDTKH.Text = row.Cells["DienThoai"].Value.ToString();
            txtDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value.ToString();
        }
    }

    private void btnThemKH_Click(object sender, EventArgs e)
    {
        var kh = new KhachHangDTO
        {
            TenKH = txtTenKH.Text.Trim(),
            DienThoai = txtSDTKH.Text.Trim(),
            DiemTichLuy = int.TryParse(txtDiemTichLuy.Text, out var diem) ? diem : 0
        };

        if (_khBus.ThemKhachHang(kh, out string error))
        {
            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearKhachHangFields();
        }
        else
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSuaKH_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaKH.Text, out int maKH))
        {
            var kh = new KhachHangDTO
            {
                MaKH = maKH,
                TenKH = txtTenKH.Text.Trim(),
                DienThoai = txtSDTKH.Text.Trim(),
                DiemTichLuy = int.TryParse(txtDiemTichLuy.Text, out var diem) ? diem : 0
            };

            if (_khBus.SuaKhachHang(kh, out string error))
            {
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearKhachHangFields();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnXoaKH_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaKH.Text, out int maKH))
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_khBus.XoaKhachHang(maKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearKhachHangFields();
                }
            }
        }
    }

    private void ClearKhachHangFields()
    {
        txtMaKH.Clear();
        txtTenKH.Clear();
        txtSDTKH.Clear();
        txtDiemTichLuy.Clear();
    }
    #endregion
}
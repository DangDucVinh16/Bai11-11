using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormNhanVien : Form
{
    private readonly NhanVienBUS _nvBus = new NhanVienBUS();
    private readonly PhongBanBUS _pbBus = new PhongBanBUS();

    public FormNhanVien()
    {
        InitializeComponent();
        LoadData();
        LoadPhongBanComboBox();
    }

    private void LoadData()
    {
        dgvNhanVien.DataSource = _nvBus.LayDanhSachNhanVien();
    }

    private void LoadPhongBanComboBox()
    {
        cmbPhongBan.DataSource = _pbBus.LayDanhSachPhongBan();
        cmbPhongBan.DisplayMember = "TenPB";
        cmbPhongBan.ValueMember = "MaPB";
    }

    private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            
            if (row.Cells["NgaySinh"].Value != DBNull.Value)
            {
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }

            txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
            if (row.Cells["MaPB"].Value != DBNull.Value)
            {
                cmbPhongBan.SelectedValue = Convert.ToInt32(row.Cells["MaPB"].Value);
            }
            txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value.ToString();
            txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value.ToString();
        }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        var nv = new NhanVienDTO
        {
            HoTen = txtHoTen.Text.Trim(),
            NgaySinh = dtpNgaySinh.Value,
            CCCD = txtCCCD.Text.Trim(),
            MaPB = Convert.ToInt32(cmbPhongBan.SelectedValue),
            LuongCoBan = decimal.TryParse(txtLuongCoBan.Text, out var luong) ? luong : 0,
            HeSoLuong = float.TryParse(txtHeSoLuong.Text, out var heso) ? heso : 1.0f
        };

        if (_nvBus.ThemNhanVien(nv, out string error))
        {
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearFields();
        }
        else
        {
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaNV.Text, out int maNV))
        {
            var nv = new NhanVienDTO
            {
                MaNV = maNV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                CCCD = txtCCCD.Text.Trim(),
                MaPB = Convert.ToInt32(cmbPhongBan.SelectedValue), // Hỗ trợ tính năng chuyển phòng ban
                LuongCoBan = decimal.TryParse(txtLuongCoBan.Text, out var luong) ? luong : 0,
                HeSoLuong = float.TryParse(txtHeSoLuong.Text, out var heso) ? heso : 1.0f
            };

            if (_nvBus.SuaNhanVien(nv, out string error))
            {
                MessageBox.Show("Cập nhật thông tin / chuyển phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtMaNV.Text, out int maNV))
        {
            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên mã {maNV}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_nvBus.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    private void txtTimKiem_TextChanged(object sender, EventArgs e)
    {
        string keyword = txtTimKiem.Text.Trim();
        dgvNhanVien.DataSource = _nvBus.TimKiemNhanVien(keyword); // Sử dụng Parameterized Query an toàn
    }

    private void ClearFields()
    {
        txtMaNV.Clear();
        txtHoTen.Clear();
        txtCCCD.Clear();
        txtLuongCoBan.Clear();
        txtHeSoLuong.Text = "1.0";
        dtpNgaySinh.Value = DateTime.Now;
    }
}
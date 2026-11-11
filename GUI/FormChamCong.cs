using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using MySql.Data.MySqlClient;

namespace GUI;

public partial class FormChamCong : Form
{
    private readonly BangChamCongBUS _ccBus = new BangChamCongBUS();
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";
    private DataTable _dtChamCong;
    private string _currentThangNam = string.Empty;

    public FormChamCong()
    {
        InitializeComponent();
    }

    private void btnTaiDanhSach_Click(object sender, EventArgs e)
    {
        _currentThangNam = txtThangNam.Text.Trim();
        if (string.IsNullOrEmpty(_currentThangNam))
        {
            MessageBox.Show("Vui lòng nhập tháng năm (VD: 11/2026)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 1. Lấy bảng chấm công thuần (đáp ứng đúng yêu cầu SqlCommandBuilder của DAL)
        _dtChamCong = _ccBus.LayDanhSachChamCong(_currentThangNam);

        // 2. Bổ sung thêm cột "HoTen" vào DataTable nếu chưa có để hiển thị tên nhân viên
        if (!_dtChamCong.Columns.Contains("HoTen"))
        {
            _dtChamCong.Columns.Add("HoTen", typeof(string));
        }

        // 3. Truy vấn lấy Họ tên từ bảng NhanVien và gán vào tương ứng với MaNV
        using (var conn = new MySqlConnection(_connStr))
        {
            conn.Open();
            foreach (DataRow row in _dtChamCong.Rows)
            {
                int maNV = Convert.ToInt32(row["MaNV"]);
                string sqlName = "SELECT HoTen FROM NhanVien WHERE MaNV = @MaNV";
                using (var cmd = new MySqlCommand(sqlName, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        row["HoTen"] = result.ToString();
                    }
                }
            }
        }

        // Đưa lên DataGridView hiển thị
        dgvChamCong.DataSource = _dtChamCong;

        // 4. Cấu hình các cột trên lưới
        if (dgvChamCong.Columns["MaCong"] != null) dgvChamCong.Columns["MaCong"].Visible = false;
        if (dgvChamCong.Columns["ThangNam"] != null) dgvChamCong.Columns["ThangNam"].Visible = false;

        // Khóa các cột không được sửa, đặt Họ tên lên đầu cho dễ nhìn
        if (dgvChamCong.Columns["MaNV"] != null) 
        {
            dgvChamCong.Columns["MaNV"].ReadOnly = true;
            dgvChamCong.Columns["MaNV"].HeaderText = "Mã NV";
        }
        if (dgvChamCong.Columns["HoTen"] != null) 
        {
            dgvChamCong.Columns["HoTen"].ReadOnly = true;
            dgvChamCong.Columns["HoTen"].HeaderText = "Họ và Tên Nhân Viên";
            dgvChamCong.Columns["HoTen"].DisplayIndex = 1; // Đưa tên lên vị trí thứ 2 sau Mã NV
        }

        // Mở khóa cho phép nhập liệu Ngày công và Giờ OT
        if (dgvChamCong.Columns["SoNgayCong"] != null) 
        {
            dgvChamCong.Columns["SoNgayCong"].ReadOnly = false;
            dgvChamCong.Columns["SoNgayCong"].HeaderText = "Số Ngày Công (<=31)";
        }
        if (dgvChamCong.Columns["SoGioOT"] != null) 
        {
            dgvChamCong.Columns["SoGioOT"].ReadOnly = false;
            dgvChamCong.Columns["SoGioOT"].HeaderText = "Số Giờ OT";
        }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (_dtChamCong == null)
        {
            MessageBox.Show("Chưa tải dữ liệu chấm công để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Kết thúc trạng thái đang nhập cell trên DataGridView
        dgvChamCong.EndEdit();

        // Đồng bộ dữ liệu về CSDL sử dụng adapter.Update() và SqlCommandBuilder
        if (_ccBus.LuuChamCong(_dtChamCong, _currentThangNam, out string error))
        {
            MessageBox.Show("Đồng bộ chấm công thành công qua Disconnected Model!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTaiDanhSach_Click(sender, e); // Tải lại lưới
        }
        else
        {
            MessageBox.Show(error, "Lỗi đồng bộ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
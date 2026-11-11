using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DAL;
using MySql.Data.MySqlClient;

namespace GUI;

public partial class FormTinhLuong : Form
{
    private readonly BangLuongBUS _blBus = new BangLuongBUS();
    private readonly string _connStr = "Server=localhost;Database=HRMDB;Uid=root;Pwd=;";

    public FormTinhLuong()
    {
        InitializeComponent();
    }

    private void btnXemLuong_Click(object sender, EventArgs e)
    {
        string thangNam = txtThangNam.Text.Trim();
        if (string.IsNullOrEmpty(thangNam))
        {
            MessageBox.Show("Vui lòng nhập tháng năm cần xem bảng lương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Truy vấn xem trước bảng lương dự kiến dựa trên chấm công hiện tại
        DataTable dt = new DataTable();
        string query = @"
            SELECT nv.MaNV, nv.HoTen, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong, 
                   IFNULL(cc.SoNgayCong, 0) AS SoNgayCong, 
                   IFNULL(cc.SoGioOT, 0) AS SoGioOT,
                   IFNULL(bl.ThucLinh, (nv.LuongCoBan * nv.HeSoLuong / 22 * IFNULL(cc.SoNgayCong, 0) + IFNULL(cc.SoGioOT, 0) * 50000)) AS ThucLinh
            FROM NhanVien nv
            LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB
            LEFT JOIN BangChamCong cc ON nv.MaNV = cc.MaNV AND cc.ThangNam = @ThangNam
            LEFT JOIN BangLuong bl ON nv.MaNV = bl.MaNV AND bl.ThangNam = @ThangNam";

        using (var conn = new MySqlConnection(_connStr))
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
        }

        dgvBangLuong.DataSource = dt;
        
        // Định dạng tiêu đề cột
        if (dgvBangLuong.Columns["MaNV"] != null) dgvBangLuong.Columns["MaNV"].HeaderText = "Mã NV";
        if (dgvBangLuong.Columns["HoTen"] != null) dgvBangLuong.Columns["HoTen"].HeaderText = "Họ Tên";
        if (dgvBangLuong.Columns["TenPB"] != null) dgvBangLuong.Columns["TenPB"].HeaderText = "Phòng Ban";
        if (dgvBangLuong.Columns["LuongCoBan"] != null) dgvBangLuong.Columns["LuongCoBan"].HeaderText = "Lương Cơ Bản";
        if (dgvBangLuong.Columns["HeSoLuong"] != null) dgvBangLuong.Columns["HeSoLuong"].HeaderText = "Hệ Số Lương";
        if (dgvBangLuong.Columns["SoNgayCong"] != null) dgvBangLuong.Columns["SoNgayCong"].HeaderText = "Số Ngày Công";
        if (dgvBangLuong.Columns["SoGioOT"] != null) dgvBangLuong.Columns["SoGioOT"].HeaderText = "Giờ OT";
        if (dgvBangLuong.Columns["ThucLinh"] != null) dgvBangLuong.Columns["ThucLinh"].HeaderText = "Thực Lính (VNĐ)";
    }

    private void btnChotLuong_Click(object sender, EventArgs e)
    {
        string thangNam = txtThangNam.Text.Trim();
        if (string.IsNullOrEmpty(thangNam))
        {
            MessageBox.Show("Vui lòng nhập tháng năm cần chốt lương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn CHỐT LƯƠNG cho toàn bộ nhân viên tháng {thangNam}? Thao tác này sẽ ghi nhận vào bảng lương và khóa dữ liệu chấm công.", 
                                            "Xác nhận chốt lương", 
                                            MessageBoxButtons.YesNo, 
                                            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            // Gọi tầng BUS thực hiện SqlTransaction
            if (_blBus.ChotLuongThang(thangNam, out string error))
            {
                MessageBox.Show("Chốt lương tháng thành công thông qua SqlTransaction!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnXemLuong_Click(sender, e); // Tải lại lưới để cập nhật dữ liệu mới nhất
            }
            else
            {
                MessageBox.Show("Chốt lương thất bại: " + error, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
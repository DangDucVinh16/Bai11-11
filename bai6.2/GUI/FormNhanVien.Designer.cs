namespace GUI;

partial class FormNhanVien
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.groupBoxInfo = new System.Windows.Forms.GroupBox();
        this.txtMaNV = new System.Windows.Forms.TextBox();
        this.lblMaNV = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        this.lblNgaySinh = new System.Windows.Forms.Label();
        this.txtCCCD = new System.Windows.Forms.TextBox();
        this.lblCCCD = new System.Windows.Forms.Label();
        this.cmbPhongBan = new System.Windows.Forms.ComboBox();
        this.lblPhongBan = new System.Windows.Forms.Label();
        this.txtLuongCoBan = new System.Windows.Forms.TextBox();
        this.lblLuong = new System.Windows.Forms.Label();
        this.txtHeSoLuong = new System.Windows.Forms.TextBox();
        this.lblHeSo = new System.Windows.Forms.Label();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        this.lblTimKiem = new System.Windows.Forms.Label();
        this.dgvNhanVien = new System.Windows.Forms.DataGridView();
        this.groupBoxInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(300, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(350, 31);
        this.lblTitle.Text = "QUẢN LÝ HỒ SƠ NHÂN SỰ";

        // groupBoxInfo
        this.groupBoxInfo.Controls.Add(this.txtHeSoLuong);
        this.groupBoxInfo.Controls.Add(this.lblHeSo);
        this.groupBoxInfo.Controls.Add(this.txtLuongCoBan);
        this.groupBoxInfo.Controls.Add(this.lblLuong);
        this.groupBoxInfo.Controls.Add(this.cmbPhongBan);
        this.groupBoxInfo.Controls.Add(this.lblPhongBan);
        this.groupBoxInfo.Controls.Add(this.txtCCCD);
        this.groupBoxInfo.Controls.Add(this.lblCCCD);
        this.groupBoxInfo.Controls.Add(this.dtpNgaySinh);
        this.groupBoxInfo.Controls.Add(this.lblNgaySinh);
        this.groupBoxInfo.Controls.Add(this.txtHoTen);
        this.groupBoxInfo.Controls.Add(this.lblHoTen);
        this.groupBoxInfo.Controls.Add(this.txtMaNV);
        this.groupBoxInfo.Controls.Add(this.lblMaNV);
        this.groupBoxInfo.Location = new System.Drawing.Point(30, 70);
        this.groupBoxInfo.Name = "groupBoxInfo";
        this.groupBoxInfo.Size = new System.Drawing.Size(890, 160);
        this.groupBoxInfo.TabStop = false;
        this.groupBoxInfo.Text = "Thông tin chi tiết nhân viên";

        // Controls trong GroupBox
        this.lblMaNV.AutoSize = true;
        this.lblMaNV.Location = new System.Drawing.Point(20, 35);
        this.lblMaNV.Name = "lblMaNV";
        this.lblMaNV.Size = new System.Drawing.Size(89, 16);
        this.lblMaNV.Text = "Mã nhân viên:";

        this.txtMaNV.Location = new System.Drawing.Point(120, 32);
        this.txtMaNV.Name = "txtMaNV";
        this.txtMaNV.ReadOnly = true;
        this.txtMaNV.Size = new System.Drawing.Size(180, 22);

        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(20, 75);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(49, 16);
        this.lblHoTen.Text = "Họ tên:";

        this.txtHoTen.Location = new System.Drawing.Point(120, 72);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(180, 22);

        this.lblNgaySinh.AutoSize = true;
        this.lblNgaySinh.Location = new System.Drawing.Point(20, 115);
        this.lblNgaySinh.Name = "lblNgaySinh";
        this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
        this.lblNgaySinh.Text = "Ngày sinh:";

        this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpNgaySinh.Location = new System.Drawing.Point(120, 112);
        this.dtpNgaySinh.Name = "dtpNgaySinh";
        this.dtpNgaySinh.Size = new System.Drawing.Size(180, 22);

        this.lblCCCD.AutoSize = true;
        this.lblCCCD.Location = new System.Drawing.Point(330, 35);
        this.lblCCCD.Name = "lblCCCD";
        this.lblCCCD.Size = new System.Drawing.Size(68, 16);
        this.lblCCCD.Text = "Số CCCD:";

        this.txtCCCD.Location = new System.Drawing.Point(430, 32);
        this.txtCCCD.Name = "txtCCCD";
        this.txtCCCD.Size = new System.Drawing.Size(160, 22);

        this.lblPhongBan.AutoSize = true;
        this.lblPhongBan.Location = new System.Drawing.Point(330, 75);
        this.lblPhongBan.Name = "lblPhongBan";
        this.lblPhongBan.Size = new System.Drawing.Size(75, 16);
        this.lblPhongBan.Text = "Phòng ban:";

        this.cmbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPhongBan.FormattingEnabled = true;
        this.cmbPhongBan.Location = new System.Drawing.Point(430, 72);
        this.cmbPhongBan.Name = "cmbPhongBan";
        this.cmbPhongBan.Size = new System.Drawing.Size(160, 24);

        this.lblLuong.AutoSize = true;
        this.lblLuong.Location = new System.Drawing.Point(620, 35);
        this.lblLuong.Name = "lblLuong";
        this.lblLuong.Size = new System.Drawing.Size(91, 16);
        this.lblLuong.Text = "Lương cơ bản:";

        this.txtLuongCoBan.Location = new System.Drawing.Point(720, 32);
        this.txtLuongCoBan.Name = "txtLuongCoBan";
        this.txtLuongCoBan.Size = new System.Drawing.Size(140, 22);

        this.lblHeSo.AutoSize = true;
        this.lblHeSo.Location = new System.Drawing.Point(620, 75);
        this.lblHeSo.Name = "lblHeSo";
        this.lblHeSo.Size = new System.Drawing.Size(83, 16);
        this.lblHeSo.Text = "Hệ số lương:";

        this.txtHeSoLuong.Location = new System.Drawing.Point(720, 72);
        this.txtHeSoLuong.Name = "txtHeSoLuong";
        this.txtHeSoLuong.Size = new System.Drawing.Size(140, 22);
        this.txtHeSoLuong.Text = "1.0";

        // Các nút chức năng
        this.btnThem.Location = new System.Drawing.Point(30, 245);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(90, 35);
        this.btnThem.TabIndex = 1;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        this.btnSua.Location = new System.Drawing.Point(140, 245);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(90, 35);
        this.btnSua.TabIndex = 2;
        this.btnSua.Text = "Sửa / Chuyển PB";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        this.btnXoa.Location = new System.Drawing.Point(250, 245);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(90, 35);
        this.btnXoa.TabIndex = 3;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // Tìm kiếm
        this.lblTimKiem.AutoSize = true;
        this.lblTimKiem.Location = new System.Drawing.Point(530, 254);
        this.lblTimKiem.Name = "lblTimKiem";
        this.lblTimKiem.Size = new System.Drawing.Size(65, 16);
        this.lblTimKiem.Text = "Tìm kiếm:";

        this.txtTimKiem.Location = new System.Drawing.Point(610, 251);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.Size = new System.Drawing.Size(310, 22);
        this.txtTimKiem.TabIndex = 4;
        this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

        // dgvNhanVien
        this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvNhanVien.Location = new System.Drawing.Point(30, 300);
        this.dgvNhanVien.Name = "dgvNhanVien";
        this.dgvNhanVien.RowHeadersWidth = 51;
        this.dgvNhanVien.Size = new System.Drawing.Size(890, 230);
        this.dgvNhanVien.TabIndex = 5;
        this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);

        // FormNhanVien
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(950, 560);
        this.Controls.Add(this.dgvNhanVien);
        this.Controls.Add(this.txtTimKiem);
        this.Controls.Add(this.lblTimKiem);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.groupBoxInfo);
        this.Controls.Add(this.lblTitle);
        this.Name = "FormNhanVien";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý Hồ sơ Nhân sự";
        this.groupBoxInfo.ResumeLayout(false);
        this.groupBoxInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox groupBoxInfo;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.Label lblMaNV;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.TextBox txtCCCD;
    private System.Windows.Forms.Label lblCCCD;
    private System.Windows.Forms.ComboBox cmbPhongBan;
    private System.Windows.Forms.Label lblPhongBan;
    private System.Windows.Forms.TextBox txtLuongCoBan;
    private System.Windows.Forms.Label lblLuong;
    private System.Windows.Forms.TextBox txtHeSoLuong;
    private System.Windows.Forms.Label lblHeSo;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.DataGridView dgvNhanVien;
}
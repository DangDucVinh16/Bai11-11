namespace GUI;

partial class FormQuanLy
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
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabSanPham = new System.Windows.Forms.TabPage();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        this.lblTimKiem = new System.Windows.Forms.Label();
        this.btnXoaSP = new System.Windows.Forms.Button();
        this.btnSuaSP = new System.Windows.Forms.Button();
        this.btnThemSP = new System.Windows.Forms.Button();
        this.txtSoLuongTon = new System.Windows.Forms.TextBox();
        this.lblSLT = new System.Windows.Forms.Label();
        this.txtGiaBan = new System.Windows.Forms.TextBox();
        this.lblGia = new System.Windows.Forms.Label();
        this.txtTenSP = new System.Windows.Forms.TextBox();
        this.lblTenSP = new System.Windows.Forms.Label();
        this.txtMaSP = new System.Windows.Forms.TextBox();
        this.lblMaSP = new System.Windows.Forms.Label();
        this.dgvSanPham = new System.Windows.Forms.DataGridView();
        this.tabNhanVien = new System.Windows.Forms.TabPage();
        this.btnXoaNV = new System.Windows.Forms.Button();
        this.btnSuaNV = new System.Windows.Forms.Button();
        this.btnThemNV = new System.Windows.Forms.Button();
        this.txtChucVu = new System.Windows.Forms.TextBox();
        this.lblChucVu = new System.Windows.Forms.Label();
        this.txtSDTNV = new System.Windows.Forms.TextBox();
        this.lblSDTNV = new System.Windows.Forms.Label();
        this.txtTenNV = new System.Windows.Forms.TextBox();
        this.lblTenNV = new System.Windows.Forms.Label();
        this.txtMaNV = new System.Windows.Forms.TextBox();
        this.lblMaNV = new System.Windows.Forms.Label();
        this.dgvNhanVien = new System.Windows.Forms.DataGridView();
        this.tabKhachHang = new System.Windows.Forms.TabPage();
        this.btnXoaKH = new System.Windows.Forms.Button();
        this.btnSuaKH = new System.Windows.Forms.Button();
        this.btnThemKH = new System.Windows.Forms.Button();
        this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
        this.lblDiem = new System.Windows.Forms.Label();
        this.txtSDTKH = new System.Windows.Forms.TextBox();
        this.lblSDTKH = new System.Windows.Forms.Label();
        this.txtTenKH = new System.Windows.Forms.TextBox();
        this.lblTenKH = new System.Windows.Forms.Label();
        this.txtMaKH = new System.Windows.Forms.TextBox();
        this.lblMaKH = new System.Windows.Forms.Label();
        this.dgvKhachHang = new System.Windows.Forms.DataGridView();

        this.tabControl1.SuspendLayout();
        this.tabSanPham.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
        this.tabNhanVien.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
        this.tabKhachHang.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
        this.SuspendLayout();

        // tabControl1
        this.tabControl1.Controls.Add(this.tabSanPham);
        this.tabControl1.Controls.Add(this.tabNhanVien);
        this.tabControl1.Controls.Add(this.tabKhachHang);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(900, 550);
        this.tabControl1.TabIndex = 0;

        // tabSanPham
        this.tabSanPham.Controls.Add(this.txtTimKiem);
        this.tabSanPham.Controls.Add(this.lblTimKiem);
        this.tabSanPham.Controls.Add(this.btnXoaSP);
        this.tabSanPham.Controls.Add(this.btnSuaSP);
        this.tabSanPham.Controls.Add(this.btnThemSP);
        this.tabSanPham.Controls.Add(this.txtSoLuongTon);
        this.tabSanPham.Controls.Add(this.lblSLT);
        this.tabSanPham.Controls.Add(this.txtGiaBan);
        this.tabSanPham.Controls.Add(this.lblGia);
        this.tabSanPham.Controls.Add(this.txtTenSP);
        this.tabSanPham.Controls.Add(this.lblTenSP);
        this.tabSanPham.Controls.Add(this.txtMaSP);
        this.tabSanPham.Controls.Add(this.lblMaSP);
        this.tabSanPham.Controls.Add(this.dgvSanPham);
        this.tabSanPham.Location = new System.Drawing.Point(4, 25);
        this.tabSanPham.Name = "tabSanPham";
        this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
        this.tabSanPham.Size = new System.Drawing.Size(892, 521);
        this.tabSanPham.TabIndex = 0;
        this.tabSanPham.Text = "Quản lý Sản Phẩm";
        this.tabSanPham.UseVisualStyleBackColor = true;

        // Controls SanPham...
        this.txtTimKiem.Location = new System.Drawing.Point(550, 20);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.Size = new System.Drawing.Size(300, 22);
        this.txtTimKiem.TabIndex = 13;
        this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

        this.lblTimKiem.AutoSize = true;
        this.lblTimKiem.Location = new System.Drawing.Point(470, 23);
        this.lblTimKiem.Name = "lblTimKiem";
        this.lblTimKiem.Size = new System.Drawing.Size(62, 16);
        this.lblTimKiem.Text = "Tìm kiếm:";

        this.btnXoaSP.Location = new System.Drawing.Point(280, 180);
        this.btnXoaSP.Name = "btnXoaSP";
        this.btnXoaSP.Size = new System.Drawing.Size(90, 35);
        this.btnXoaSP.TabIndex = 11;
        this.btnXoaSP.Text = "Xóa";
        this.btnXoaSP.UseVisualStyleBackColor = true;
        this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);

        this.btnSuaSP.Location = new System.Drawing.Point(150, 180);
        this.btnSuaSP.Name = "btnSuaSP";
        this.btnSuaSP.Size = new System.Drawing.Size(90, 35);
        this.btnSuaSP.TabIndex = 10;
        this.btnSuaSP.Text = "Sửa";
        this.btnSuaSP.UseVisualStyleBackColor = true;
        this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);

        this.btnThemSP.Location = new System.Drawing.Point(20, 180);
        this.btnThemSP.Name = "btnThemSP";
        this.btnThemSP.Size = new System.Drawing.Size(90, 35);
        this.btnThemSP.TabIndex = 9;
        this.btnThemSP.Text = "Thêm";
        this.btnThemSP.UseVisualStyleBackColor = true;
        this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);

        this.txtSoLuongTon.Location = new System.Drawing.Point(550, 120);
        this.txtSoLuongTon.Name = "txtSoLuongTon";
        this.txtSoLuongTon.Size = new System.Drawing.Size(200, 22);
        this.txtSoLuongTon.TabIndex = 8;

        this.lblSLT.AutoSize = true;
        this.lblSLT.Location = new System.Drawing.Point(450, 123);
        this.lblSLT.Name = "lblSLT";
        this.lblSLT.Size = new System.Drawing.Size(90, 16);
        this.lblSLT.Text = "Số lượng tồn:";

        this.txtGiaBan.Location = new System.Drawing.Point(550, 70);
        this.txtGiaBan.Name = "txtGiaBan";
        this.txtGiaBan.Size = new System.Drawing.Size(200, 22);
        this.txtGiaBan.TabIndex = 6;

        this.lblGia.AutoSize = true;
        this.lblGia.Location = new System.Drawing.Point(450, 73);
        this.lblGia.Name = "lblGia";
        this.lblGia.Size = new System.Drawing.Size(58, 16);
        this.lblGia.Text = "Giá bán:";

        this.txtTenSP.Location = new System.Drawing.Point(120, 120);
        this.txtTenSP.Name = "txtTenSP";
        this.txtTenSP.Size = new System.Drawing.Size(250, 22);
        this.txtTenSP.TabIndex = 4;

        this.lblTenSP.AutoSize = true;
        this.lblTenSP.Location = new System.Drawing.Point(20, 123);
        this.lblTenSP.Name = "lblTenSP";
        this.lblTenSP.Size = new System.Drawing.Size(99, 16);
        this.lblTenSP.Text = "Tên sản phẩm:";

        this.txtMaSP.Location = new System.Drawing.Point(120, 70);
        this.txtMaSP.Name = "txtMaSP";
        this.txtMaSP.Size = new System.Drawing.Size(250, 22);
        this.txtMaSP.TabIndex = 2;

        this.lblMaSP.AutoSize = true;
        this.lblMaSP.Location = new System.Drawing.Point(20, 73);
        this.lblMaSP.Name = "lblMaSP";
        this.lblMaSP.Size = new System.Drawing.Size(94, 16);
        this.lblMaSP.Text = "Mã sản phẩm:";

        this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvSanPham.Location = new System.Drawing.Point(20, 230);
        this.dgvSanPham.Name = "dgvSanPham";
        this.dgvSanPham.RowHeadersWidth = 51;
        this.dgvSanPham.Size = new System.Drawing.Size(850, 270);
        this.dgvSanPham.TabIndex = 0;
        this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);

        // tabNhanVien
        this.tabNhanVien.Controls.Add(this.btnXoaNV);
        this.tabNhanVien.Controls.Add(this.btnSuaNV);
        this.tabNhanVien.Controls.Add(this.btnThemNV);
        this.tabNhanVien.Controls.Add(this.txtChucVu);
        this.tabNhanVien.Controls.Add(this.lblChucVu);
        this.tabNhanVien.Controls.Add(this.txtSDTNV);
        this.tabNhanVien.Controls.Add(this.lblSDTNV);
        this.tabNhanVien.Controls.Add(this.txtTenNV);
        this.tabNhanVien.Controls.Add(this.lblTenNV);
        this.tabNhanVien.Controls.Add(this.txtMaNV);
        this.tabNhanVien.Controls.Add(this.lblMaNV);
        this.tabNhanVien.Controls.Add(this.dgvNhanVien);
        this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
        this.tabNhanVien.Name = "tabNhanVien";
        this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
        this.tabNhanVien.Size = new System.Drawing.Size(892, 521);
        this.tabNhanVien.TabIndex = 1;
        this.tabNhanVien.Text = "Quản lý Nhân Viên";
        this.tabNhanVien.UseVisualStyleBackColor = true;

        // Controls NhanVien...
        this.btnXoaNV.Location = new System.Drawing.Point(280, 180);
        this.btnXoaNV.Name = "btnXoaNV";
        this.btnXoaNV.Size = new System.Drawing.Size(90, 35);
        this.btnXoaNV.TabIndex = 11;
        this.btnXoaNV.Text = "Xóa";
        this.btnXoaNV.UseVisualStyleBackColor = true;
        this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);

        this.btnSuaNV.Location = new System.Drawing.Point(150, 180);
        this.btnSuaNV.Name = "btnSuaNV";
        this.btnSuaNV.Size = new System.Drawing.Size(90, 35);
        this.btnSuaNV.TabIndex = 10;
        this.btnSuaNV.Text = "Sửa";
        this.btnSuaNV.UseVisualStyleBackColor = true;
        this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);

        this.btnThemNV.Location = new System.Drawing.Point(20, 180);
        this.btnThemNV.Name = "btnThemNV";
        this.btnThemNV.Size = new System.Drawing.Size(90, 35);
        this.btnThemNV.TabIndex = 9;
        this.btnThemNV.Text = "Thêm";
        this.btnThemNV.UseVisualStyleBackColor = true;
        this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);

        this.txtChucVu.Location = new System.Drawing.Point(550, 120);
        this.txtChucVu.Name = "txtChucVu";
        this.txtChucVu.Size = new System.Drawing.Size(200, 22);
        this.txtChucVu.TabIndex = 8;

        this.lblChucVu.AutoSize = true;
        this.lblChucVu.Location = new System.Drawing.Point(450, 123);
        this.lblChucVu.Name = "lblChucVu";
        this.lblChucVu.Size = new System.Drawing.Size(57, 16);
        this.lblChucVu.Text = "Chức vụ:";

        this.txtSDTNV.Location = new System.Drawing.Point(550, 70);
        this.txtSDTNV.Name = "txtSDTNV";
        this.txtSDTNV.Size = new System.Drawing.Size(200, 22);
        this.txtSDTNV.TabIndex = 6;

        this.lblSDTNV.AutoSize = true;
        this.lblSDTNV.Location = new System.Drawing.Point(450, 73);
        this.lblSDTNV.Name = "lblSDTNV";
        this.lblSDTNV.Size = new System.Drawing.Size(88, 16);
        this.lblSDTNV.Text = "Số điện thoại:";

        this.txtTenNV.Location = new System.Drawing.Point(120, 120);
        this.txtTenNV.Name = "txtTenNV";
        this.txtTenNV.Size = new System.Drawing.Size(250, 22);
        this.txtTenNV.TabIndex = 4;

        this.lblTenNV.AutoSize = true;
        this.lblTenNV.Location = new System.Drawing.Point(20, 123);
        this.lblTenNV.Name = "lblTenNV";
        this.lblTenNV.Size = new System.Drawing.Size(94, 16);
        this.lblTenNV.Text = "Tên nhân viên:";

        this.txtMaNV.Location = new System.Drawing.Point(120, 70);
        this.txtMaNV.Name = "txtMaNV";
        this.txtMaNV.ReadOnly = true;
        this.txtMaNV.Size = new System.Drawing.Size(250, 22);
        this.txtMaNV.TabIndex = 2;

        this.lblMaNV.AutoSize = true;
        this.lblMaNV.Location = new System.Drawing.Point(20, 73);
        this.lblMaNV.Name = "lblMaNV";
        this.lblMaNV.Size = new System.Drawing.Size(89, 16);
        this.lblMaNV.Text = "Mã nhân viên:";

        this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvNhanVien.Location = new System.Drawing.Point(20, 230);
        this.dgvNhanVien.Name = "dgvNhanVien";
        this.dgvNhanVien.RowHeadersWidth = 51;
        this.dgvNhanVien.Size = new System.Drawing.Size(850, 270);
        this.dgvNhanVien.TabIndex = 0;
        this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);

        // tabKhachHang
        this.tabKhachHang.Controls.Add(this.btnXoaKH);
        this.tabKhachHang.Controls.Add(this.btnSuaKH);
        this.tabKhachHang.Controls.Add(this.btnThemKH);
        this.tabKhachHang.Controls.Add(this.txtDiemTichLuy);
        this.tabKhachHang.Controls.Add(this.lblDiem);
        this.tabKhachHang.Controls.Add(this.txtSDTKH);
        this.tabKhachHang.Controls.Add(this.lblSDTKH);
        this.tabKhachHang.Controls.Add(this.txtTenKH);
        this.tabKhachHang.Controls.Add(this.lblTenKH);
        this.tabKhachHang.Controls.Add(this.txtMaKH);
        this.tabKhachHang.Controls.Add(this.lblMaKH);
        this.tabKhachHang.Controls.Add(this.dgvKhachHang);
        this.tabKhachHang.Location = new System.Drawing.Point(4, 25);
        this.tabKhachHang.Name = "tabKhachHang";
        this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
        this.tabKhachHang.Size = new System.Drawing.Size(892, 521);
        this.tabKhachHang.TabIndex = 2;
        this.tabKhachHang.Text = "Quản lý Khách Hàng";
        this.tabKhachHang.UseVisualStyleBackColor = true;

        // Controls KhachHang...
        this.btnXoaKH.Location = new System.Drawing.Point(280, 180);
        this.btnXoaKH.Name = "btnXoaKH";
        this.btnXoaKH.Size = new System.Drawing.Size(90, 35);
        this.btnXoaKH.TabIndex = 11;
        this.btnXoaKH.Text = "Xóa";
        this.btnXoaKH.UseVisualStyleBackColor = true;
        this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);

        this.btnSuaKH.Location = new System.Drawing.Point(150, 180);
        this.btnSuaKH.Name = "btnSuaKH";
        this.btnSuaKH.Size = new System.Drawing.Size(90, 35);
        this.btnSuaKH.TabIndex = 10;
        this.btnSuaKH.Text = "Sửa";
        this.btnSuaKH.UseVisualStyleBackColor = true;
        this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);

        this.btnThemKH.Location = new System.Drawing.Point(20, 180);
        this.btnThemKH.Name = "btnThemKH";
        this.btnThemKH.Size = new System.Drawing.Size(90, 35);
        this.btnThemKH.TabIndex = 9;
        this.btnThemKH.Text = "Thêm";
        this.btnThemKH.UseVisualStyleBackColor = true;
        this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);

        this.txtDiemTichLuy.Location = new System.Drawing.Point(550, 120);
        this.txtDiemTichLuy.Name = "txtDiemTichLuy";
        this.txtDiemTichLuy.Size = new System.Drawing.Size(200, 22);
        this.txtDiemTichLuy.TabIndex = 8;

        this.lblDiem.AutoSize = true;
        this.lblDiem.Location = new System.Drawing.Point(450, 123);
        this.lblDiem.Name = "lblDiem";
        this.lblDiem.Size = new System.Drawing.Size(89, 16);
        this.lblDiem.Text = "Điểm tích lũy:";

        this.txtSDTKH.Location = new System.Drawing.Point(550, 70);
        this.txtSDTKH.Name = "txtSDTKH";
        this.txtSDTKH.Size = new System.Drawing.Size(200, 22);
        this.txtSDTKH.TabIndex = 6;

        this.lblSDTKH.AutoSize = true;
        this.lblSDTKH.Location = new System.Drawing.Point(450, 73);
        this.lblSDTKH.Name = "lblSDTKH";
        this.lblSDTKH.Size = new System.Drawing.Size(88, 16);
        this.lblSDTKH.Text = "Số điện thoại:";

        this.txtTenKH.Location = new System.Drawing.Point(120, 120);
        this.txtTenKH.Name = "txtTenKH";
        this.txtTenKH.Size = new System.Drawing.Size(250, 22);
        this.txtTenKH.TabIndex = 4;

        this.lblTenKH.AutoSize = true;
        this.lblTenKH.Location = new System.Drawing.Point(20, 123);
        this.lblTenKH.Name = "lblTenKH";
        this.lblTenKH.Size = new System.Drawing.Size(106, 16);
        this.lblTenKH.Text = "Tên khách hàng:";

        this.txtMaKH.Location = new System.Drawing.Point(120, 70);
        this.txtMaKH.Name = "txtMaKH";
        this.txtMaKH.ReadOnly = true;
        this.txtMaKH.Size = new System.Drawing.Size(250, 22);
        this.txtMaKH.TabIndex = 2;

        this.lblMaKH.AutoSize = true;
        this.lblMaKH.Location = new System.Drawing.Point(20, 73);
        this.lblMaKH.Name = "lblMaKH";
        this.lblMaKH.Size = new System.Drawing.Size(101, 16);
        this.lblMaKH.Text = "Mã khách hàng:";

        this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvKhachHang.Location = new System.Drawing.Point(20, 230);
        this.dgvKhachHang.Name = "dgvKhachHang";
        this.dgvKhachHang.RowHeadersWidth = 51;
        this.dgvKhachHang.Size = new System.Drawing.Size(850, 270);
        this.dgvKhachHang.TabIndex = 0;
        this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);

        // FormQuanLy
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 550);
        this.Controls.Add(this.tabControl1);
        this.Name = "FormQuanLy";
        this.Text = "Hệ thống Quản lý Danh mục Siêu thị Mini";

        this.tabControl1.ResumeLayout(false);
        this.tabSanPham.ResumeLayout(false);
        this.tabSanPham.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
        this.tabNhanVien.ResumeLayout(false);
        this.tabNhanVien.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
        this.tabKhachHang.ResumeLayout(false);
        this.tabKhachHang.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabSanPham;
    private System.Windows.Forms.TabPage tabNhanVien;
    private System.Windows.Forms.TabPage tabKhachHang;

    // Controls SanPham
    private System.Windows.Forms.DataGridView dgvSanPham;
    private System.Windows.Forms.TextBox txtMaSP;
    private System.Windows.Forms.TextBox txtTenSP;
    private System.Windows.Forms.TextBox txtGiaBan;
    private System.Windows.Forms.TextBox txtSoLuongTon;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label lblMaSP;
    private System.Windows.Forms.Label lblTenSP;
    private System.Windows.Forms.Label lblGia;
    private System.Windows.Forms.Label lblSLT;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.Button btnThemSP;
    private System.Windows.Forms.Button btnSuaSP;
    private System.Windows.Forms.Button btnXoaSP;

    // Controls NhanVien
    private System.Windows.Forms.DataGridView dgvNhanVien;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.TextBox txtTenNV;
    private System.Windows.Forms.TextBox txtSDTNV;
    private System.Windows.Forms.TextBox txtChucVu;
    private System.Windows.Forms.Label lblMaNV;
    private System.Windows.Forms.Label lblTenNV;
    private System.Windows.Forms.Label lblSDTNV;
    private System.Windows.Forms.Label lblChucVu;
    private System.Windows.Forms.Button btnThemNV;
    private System.Windows.Forms.Button btnSuaNV;
    private System.Windows.Forms.Button btnXoaNV;

    // Controls KhachHang
    private System.Windows.Forms.DataGridView dgvKhachHang;
    private System.Windows.Forms.TextBox txtMaKH;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.TextBox txtSDTKH;
    private System.Windows.Forms.TextBox txtDiemTichLuy;
    private System.Windows.Forms.Label lblMaKH;
    private System.Windows.Forms.Label lblTenKH;
    private System.Windows.Forms.Label lblSDTKH;
    private System.Windows.Forms.Label lblDiem;
    private System.Windows.Forms.Button btnThemKH;
    private System.Windows.Forms.Button btnSuaKH;
    private System.Windows.Forms.Button btnXoaKH;
}
namespace GUI;

partial class FormBanHang
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.cmbNhanVien = new System.Windows.Forms.ComboBox();
        this.lblNV = new System.Windows.Forms.Label();
        this.cmbKhachHang = new System.Windows.Forms.ComboBox();
        this.lblKH = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btnThemGH = new System.Windows.Forms.Button();
        this.txtSoLuong = new System.Windows.Forms.TextBox();
        this.lblSL = new System.Windows.Forms.Label();
        this.cmbSanPham = new System.Windows.Forms.ComboBox();
        this.lblSP = new System.Windows.Forms.Label();
        this.dgvGioHang = new System.Windows.Forms.DataGridView();
        this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnThanhToan = new System.Windows.Forms.Button();
        this.lblTongTienTitle = new System.Windows.Forms.Label();
        this.lblTongTien = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(300, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(320, 31);
        this.lblTitle.Text = "MÀN HÌNH BÁN HÀNG";

        // groupBox1 (Thông tin chung)
        this.groupBox1.Controls.Add(this.cmbNhanVien);
        this.groupBox1.Controls.Add(this.lblNV);
        this.groupBox1.Controls.Add(this.cmbKhachHang);
        this.groupBox1.Controls.Add(this.lblKH);
        this.groupBox1.Location = new System.Drawing.Point(30, 70);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(840, 80);
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Thông tin giao dịch";

        // cmbNhanVien
        this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbNhanVien.FormattingEnabled = true;
        this.cmbNhanVien.Location = new System.Drawing.Point(120, 30);
        this.cmbNhanVien.Name = "cmbNhanVien";
        this.cmbNhanVien.Size = new System.Drawing.Size(250, 24);

        // lblNV
        this.lblNV.AutoSize = true;
        this.lblNV.Location = new System.Drawing.Point(20, 33);
        this.lblNV.Name = "lblNV";
        this.lblNV.Size = new System.Drawing.Size(94, 16);
        this.lblNV.Text = "Nhân viên lập:";

        // cmbKhachHang
        this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbKhachHang.FormattingEnabled = true;
        this.cmbKhachHang.Location = new System.Drawing.Point(550, 30);
        this.cmbKhachHang.Name = "cmbKhachHang";
        this.cmbKhachHang.Size = new System.Drawing.Size(250, 24);

        // lblKH
        this.lblKH.AutoSize = true;
        this.lblKH.Location = new System.Drawing.Point(450, 33);
        this.lblKH.Name = "lblKH";
        this.lblKH.Size = new System.Drawing.Size(80, 16);
        this.lblKH.Text = "Khách hàng:";

        // groupBox2 (Chọn sản phẩm)
        this.groupBox2.Controls.Add(this.btnThemGH);
        this.groupBox2.Controls.Add(this.txtSoLuong);
        this.groupBox2.Controls.Add(this.lblSL);
        this.groupBox2.Controls.Add(this.cmbSanPham);
        this.groupBox2.Controls.Add(this.lblSP);
        this.groupBox2.Location = new System.Drawing.Point(30, 170);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(840, 80);
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Chọn sản phẩm vào giỏ";

        // cmbSanPham
        this.cmbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSanPham.FormattingEnabled = true;
        this.cmbSanPham.Location = new System.Drawing.Point(120, 30);
        this.cmbSanPham.Name = "cmbSanPham";
        this.cmbSanPham.Size = new System.Drawing.Size(250, 24);

        // lblSP
        this.lblSP.AutoSize = true;
        this.lblSP.Location = new System.Drawing.Point(20, 33);
        this.lblSP.Name = "lblSP";
        this.lblSP.Size = new System.Drawing.Size(70, 16);
        this.lblSP.Text = "Sản phẩm:";

        // txtSoLuong
        this.txtSoLuong.Location = new System.Drawing.Point(550, 30);
        this.txtSoLuong.Name = "txtSoLuong";
        this.txtSoLuong.Size = new System.Drawing.Size(80, 22);
        this.txtSoLuong.TabIndex = 2;
        this.txtSoLuong.Text = "1";

        // lblSL
        this.lblSL.AutoSize = true;
        this.lblSL.Location = new System.Drawing.Point(450, 33);
        this.lblSL.Name = "lblSL";
        this.lblSL.Size = new System.Drawing.Size(63, 16);
        this.lblSL.Text = "Số lượng:";

        // btnThemGH
        this.btnThemGH.Location = new System.Drawing.Point(670, 25);
        this.btnThemGH.Name = "btnThemGH";
        this.btnThemGH.Size = new System.Drawing.Size(130, 32);
        this.btnThemGH.TabIndex = 3;
        this.btnThemGH.Text = "Thêm vào giỏ";
        this.btnThemGH.UseVisualStyleBackColor = true;
        this.btnThemGH.Click += new System.EventHandler(this.btnThemGH_Click);

        // dgvGioHang
        this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien
        });
        this.dgvGioHang.Location = new System.Drawing.Point(30, 270);
        this.dgvGioHang.Name = "dgvGioHang";
        this.dgvGioHang.RowHeadersWidth = 51;
        this.dgvGioHang.Size = new System.Drawing.Size(840, 220);
        this.dgvGioHang.TabIndex = 3;

        // Columns setup
        this.colMaSP.HeaderText = "Mã SP";
        this.colMaSP.Name = "colMaSP";
        this.colMaSP.Width = 100;
        this.colTenSP.HeaderText = "Tên Sản Phẩm";
        this.colTenSP.Name = "colTenSP";
        this.colTenSP.Width = 250;
        this.colSoLuong.HeaderText = "Số Lượng";
        this.colSoLuong.Name = "colSoLuong";
        this.colSoLuong.Width = 100;
        this.colDonGia.HeaderText = "Đơn Giá";
        this.colDonGia.Name = "colDonGia";
        this.colDonGia.Width = 150;
        this.colThanhTien.HeaderText = "Thành Tiền";
        this.colThanhTien.Name = "colThanhTien";
        this.colThanhTien.Width = 180;

        // lblTongTienTitle
        this.lblTongTienTitle.AutoSize = true;
        this.lblTongTienTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.lblTongTienTitle.Location = new System.Drawing.Point(30, 510);
        this.lblTongTienTitle.Name = "lblTongTienTitle";
        this.lblTongTienTitle.Size = new System.Drawing.Size(115, 25);
        this.lblTongTienTitle.Text = "Tổng tiền: ";

        // lblTongTien
        this.lblTongTien.AutoSize = true;
        this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
        this.lblTongTien.ForeColor = System.Drawing.Color.Red;
        this.lblTongTien.Location = new System.Drawing.Point(150, 508);
        this.lblTongTien.Name = "lblTongTien";
        this.lblTongTien.Size = new System.Drawing.Size(76, 29);
        this.lblTongTien.Text = "0 VNĐ";

        // btnThanhToan
        this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.btnThanhToan.BackColor = System.Drawing.Color.LimeGreen;
        this.btnThanhToan.ForeColor = System.Drawing.Color.White;
        this.btnThanhToan.Location = new System.Drawing.Point(670, 502);
        this.btnThanhToan.Name = "btnThanhToan";
        this.btnThanhToan.Size = new System.Drawing.Size(200, 45);
        this.btnThanhToan.TabIndex = 6;
        this.btnThanhToan.Text = "THANH TOÁN";
        this.btnThanhToan.UseVisualStyleBackColor = false;
        this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

        // FormBanHang
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 570);
        this.Controls.Add(this.btnThanhToan);
        this.Controls.Add(this.lblTongTien);
        this.Controls.Add(this.lblTongTienTitle);
        this.Controls.Add(this.dgvGioHang);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.lblTitle);
        this.Name = "FormBanHang";
        this.Text = "Màn hình Bán hàng & Thanh toán";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cmbNhanVien;
    private System.Windows.Forms.Label lblNV;
    private System.Windows.Forms.ComboBox cmbKhachHang;
    private System.Windows.Forms.Label lblKH;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox cmbSanPham;
    private System.Windows.Forms.Label lblSP;
    private System.Windows.Forms.TextBox txtSoLuong;
    private System.Windows.Forms.Label lblSL;
    private System.Windows.Forms.Button btnThemGH;
    private System.Windows.Forms.DataGridView dgvGioHang;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    private System.Windows.Forms.Label lblTongTienTitle;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.Button btnThanhToan;
}
namespace GUI;

partial class FormTinhLuong
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
        this.lblThangNam = new System.Windows.Forms.Label();
        this.txtThangNam = new System.Windows.Forms.TextBox();
        this.btnXemLuong = new System.Windows.Forms.Button();
        this.dgvBangLuong = new System.Windows.Forms.DataGridView();
        this.btnChotLuong = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(260, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(380, 31);
        this.lblTitle.Text = "TÍNH LƯƠNG & CHỐT LƯƠNG";

        // lblThangNam
        this.lblThangNam.AutoSize = true;
        this.lblThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.lblThangNam.Location = new System.Drawing.Point(30, 80);
        this.lblThangNam.Name = "lblThangNam";
        this.lblThangNam.Size = new System.Drawing.Size(142, 20);
        this.lblThangNam.Text = "Tháng/Năm (MM/YYYY):";

        // txtThangNam
        this.txtThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.txtThangNam.Location = new System.Drawing.Point(190, 77);
        this.txtThangNam.Name = "txtThangNam";
        this.txtThangNam.Size = new System.Drawing.Size(150, 26);
        this.txtThangNam.TabIndex = 1;
        this.txtThangNam.Text = "11/2026";

        // btnXemLuong
        this.btnXemLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
        this.btnXemLuong.Location = new System.Drawing.Point(360, 73);
        this.btnXemLuong.Name = "btnXemLuong";
        this.btnXemLuong.Size = new System.Drawing.Size(160, 35);
        this.btnXemLuong.TabIndex = 2;
        this.btnXemLuong.Text = "Xem Bảng Lương";
        this.btnXemLuong.UseVisualStyleBackColor = true;
        this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);

        // dgvBangLuong
        this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvBangLuong.Location = new System.Drawing.Point(30, 130);
        this.dgvBangLuong.Name = "dgvBangLuong";
        this.dgvBangLuong.RowHeadersWidth = 51;
        this.dgvBangLuong.Size = new System.Drawing.Size(840, 340);
        this.dgvBangLuong.TabIndex = 3;

        // btnChotLuong
        this.btnChotLuong.BackColor = System.Drawing.Color.Crimson;
        this.btnChotLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.btnChotLuong.ForeColor = System.Drawing.Color.White;
        this.btnChotLuong.Location = new System.Drawing.Point(640, 490);
        this.btnChotLuong.Name = "btnChotLuong";
        this.btnChotLuong.Size = new System.Drawing.Size(230, 45);
        this.btnChotLuong.TabIndex = 4;
        this.btnChotLuong.Text = "CHỐT LƯƠNG THÁNG";
        this.btnChotLuong.UseVisualStyleBackColor = false;
        this.btnChotLuong.Click += new System.EventHandler(this.btnChotLuong_Click);

        // FormTinhLuong
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 560);
        this.Controls.Add(this.btnChotLuong);
        this.Controls.Add(this.dgvBangLuong);
        this.Controls.Add(this.btnXemLuong);
        this.Controls.Add(this.txtThangNam);
        this.Controls.Add(this.lblThangNam);
        this.Controls.Add(this.lblTitle);
        this.Name = "FormTinhLuong";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Màn hình Tính lương & Chốt lương (SqlTransaction)";
        ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblThangNam;
    private System.Windows.Forms.TextBox txtThangNam;
    private System.Windows.Forms.Button btnXemLuong;
    private System.Windows.Forms.DataGridView dgvBangLuong;
    private System.Windows.Forms.Button btnChotLuong;
}
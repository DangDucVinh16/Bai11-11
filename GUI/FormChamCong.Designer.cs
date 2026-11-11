namespace GUI;

partial class FormChamCong
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
        this.btnTaiDanhSach = new System.Windows.Forms.Button();
        this.dgvChamCong = new System.Windows.Forms.DataGridView();
        this.btnLuu = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(280, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(350, 31);
        this.lblTitle.Text = "QUẢN LÝ BẢNG CHẤM CÔNG";

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

        // btnTaiDanhSach
        this.btnTaiDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
        this.btnTaiDanhSach.Location = new System.Drawing.Point(360, 73);
        this.btnTaiDanhSach.Name = "btnTaiDanhSach";
        this.btnTaiDanhSach.Size = new System.Drawing.Size(150, 35);
        this.btnTaiDanhSach.TabIndex = 2;
        this.btnTaiDanhSach.Text = "Tải Chấm Công";
        this.btnTaiDanhSach.UseVisualStyleBackColor = true;
        this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);

        // dgvChamCong
        this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChamCong.Location = new System.Drawing.Point(30, 130);
        this.dgvChamCong.Name = "dgvChamCong";
        this.dgvChamCong.RowHeadersWidth = 51;
        this.dgvChamCong.Size = new System.Drawing.Size(840, 340);
        this.dgvChamCong.TabIndex = 3;

        // btnLuu
        this.btnLuu.BackColor = System.Drawing.Color.ForestGreen;
        this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.btnLuu.ForeColor = System.Drawing.Color.White;
        this.btnLuu.Location = new System.Drawing.Point(670, 490);
        this.btnLuu.Name = "btnLuu";
        this.btnLuu.Size = new System.Drawing.Size(200, 45);
        this.btnLuu.TabIndex = 4;
        this.btnLuu.Text = "LƯU CHẤM CÔNG";
        this.btnLuu.UseVisualStyleBackColor = false;
        this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

        // FormChamCong
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 560);
        this.Controls.Add(this.btnLuu);
        this.Controls.Add(this.dgvChamCong);
        this.Controls.Add(this.btnTaiDanhSach);
        this.Controls.Add(this.txtThangNam);
        this.Controls.Add(this.lblThangNam);
        this.Controls.Add(this.lblTitle);
        this.Name = "FormChamCong";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Màn hình Chấm công (Disconnected Model)";
        ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblThangNam;
    private System.Windows.Forms.TextBox txtThangNam;
    private System.Windows.Forms.Button btnTaiDanhSach;
    private System.Windows.Forms.DataGridView dgvChamCong;
    private System.Windows.Forms.Button btnLuu;
}
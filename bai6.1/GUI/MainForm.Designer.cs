namespace GUI;

partial class MainForm
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
        this.btnMoQuanLy = new System.Windows.Forms.Button();
        this.btnMoBanHang = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(125, 50);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(550, 36);
        this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG - SIÊU THỊ MINI";

        // btnMoQuanLy
        this.btnMoQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.btnMoQuanLy.Location = new System.Drawing.Point(250, 140);
        this.btnMoQuanLy.Name = "btnMoQuanLy";
        this.btnMoQuanLy.Size = new System.Drawing.Size(300, 60);
        this.btnMoQuanLy.TabIndex = 1;
        this.btnMoQuanLy.Text = "Quản lý Danh mục (CRUD)";
        this.btnMoQuanLy.UseVisualStyleBackColor = true;
        this.btnMoQuanLy.Click += new System.EventHandler(this.btnMoQuanLy_Click);

        // btnMoBanHang
        this.btnMoBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.btnMoBanHang.Location = new System.Drawing.Point(250, 230);
        this.btnMoBanHang.Name = "btnMoBanHang";
        this.btnMoBanHang.Size = new System.Drawing.Size(300, 60);
        this.btnMoBanHang.TabIndex = 2;
        this.btnMoBanHang.Text = "Màn hình Bán hàng (Transaction)";
        this.btnMoBanHang.UseVisualStyleBackColor = true;
        this.btnMoBanHang.Click += new System.EventHandler(this.btnMoBanHang_Click);

        // MainForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 400);
        this.Controls.Add(this.btnMoBanHang);
        this.Controls.Add(this.btnMoQuanLy);
        this.Controls.Add(this.lblTitle);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Main Menu - Siêu thị Mini";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnMoQuanLy;
    private System.Windows.Forms.Button btnMoBanHang;
}
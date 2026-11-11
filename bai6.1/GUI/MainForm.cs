using System;
using System.Windows.Forms;

namespace GUI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnMoQuanLy_Click(object sender, EventArgs e)
    {
        FormQuanLy frm = new FormQuanLy();
        frm.ShowDialog(); // Mở form quản lý danh mục dạng cửa sổ độc lập
    }

    private void btnMoBanHang_Click(object sender, EventArgs e)
    {
        FormBanHang frm = new FormBanHang();
        frm.ShowDialog(); // Mở form bán hàng & thanh toán transaction
    }
}
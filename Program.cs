using System;
using System.Windows.Forms;

namespace GUI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Khởi tạo các thiết lập cấu hình giao diện mặc định (.NET 6/8/10)
        ApplicationConfiguration.Initialize();
        
        // Chỉ định MainForm là Form khởi chạy đầu tiên của ứng dụng
        Application.Run(new MainForm());
    }
}
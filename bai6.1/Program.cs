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
        // Khởi tạo cấu hình ứng dụng WinForms hiện đại (.NET 6/8/10)
        ApplicationConfiguration.Initialize();
        
        // Chạy form chính (MainForm) làm giao diện khởi đầu điều hướng
        Application.Run(new MainForm());
    }
}
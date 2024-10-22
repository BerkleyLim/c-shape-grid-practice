// Program.cs
using System;
using System.Windows.Forms;

namespace grid_test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Form1을 메인 폼으로 실행
        }
    }
}
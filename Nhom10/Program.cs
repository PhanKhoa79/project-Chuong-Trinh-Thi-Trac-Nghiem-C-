using System;
using System.Windows.Forms;

namespace Nhom10
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // FormMoDau modau = new FormMoDau();
            //  if (modau.ShowDialog() == DialogResult.OK)
            Application.Run(new fBaiThi());
        }
    }
}

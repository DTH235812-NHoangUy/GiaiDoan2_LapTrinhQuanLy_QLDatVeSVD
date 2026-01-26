using System.Windows.Forms;
using LapTrinhQuanLy_QuanLyDatVeSVD.Form;
using LapTrinhQuanLy_QuanLyDatVeSVD.Forms;

namespace LapTrinhQuanLy_QuanLyDatVeSVD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmSuKien());
        }
    }
}
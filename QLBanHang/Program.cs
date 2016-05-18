using QLBanHang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoadingForm.ShowSplashScreen();
            //MainForm main = new MainForm();
            //LoadingForm.CloseForm();
            //Application.Run(main);
            Application.Run(new FrmDanhMucSP());
            //Application.Run(new MainForm());

        }
    }
}

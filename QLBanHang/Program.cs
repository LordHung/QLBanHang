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
            Application.Run(new MainForm());
<<<<<<< HEAD
=======
            //Application.Run(new FrmCuaHang());
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        }
    }
}

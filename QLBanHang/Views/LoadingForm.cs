using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QLBanHang.Views
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

         //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static LoadingForm loadingForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (loadingForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(LoadingForm.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            //Thread.Sleep(3000);
        }

        static private void ShowForm()
        {
            loadingForm = new LoadingForm();
            Application.Run(loadingForm);
        }

        static public void CloseForm()
        {
            loadingForm.Invoke(new CloseDelegate(LoadingForm.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            loadingForm.Close();
        }
    }
}

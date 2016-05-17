using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Controls;
namespace QLBanHang.Views
{
    public partial class BaseAddUpdatePhieuThu : Dlg_Them_Xoa_Sua_base
    {
        public BaseAddUpdatePhieuThu()
        {
            InitializeComponent();
        }

        private void numSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {   
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }
    }
}

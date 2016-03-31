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
using QLBanHang.Objects;
using QLBanHang.Views;

namespace QLBanHang.Views
{
    public partial class FrmDangNhapDlg : Form
    {

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        public FrmDangNhapDlg()
        {
            InitializeComponent();
        }


        public string TenDangNhap
        {
            get { return txtDangNhap.Text; }
            set { txtDangNhap.Text = value; }
        }


        public string MatKhau
        {
            get { return txtMatKhau.Text; }
            set { txtMatKhau.Text = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

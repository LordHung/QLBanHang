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
    public partial class FrmDangNhapDlg : Form,IDangNhapView
    {

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        ctrlDangNhap _ctrlDangNhap = new ctrlDangNhap();

        private bool _isLoggedIn = false;

        public FrmDangNhapDlg()
        {
            InitializeComponent();
            _ctrlDangNhap.SetView(this);
        }
        public bool IsLoggedIn 
        {
            get { return _isLoggedIn; } 
            set { _isLoggedIn = value;}
        }

        public string TenDangNhap
        {
            get { return txtTenDangNhap.Text; }
            set { txtTenDangNhap.Text = value; }
        }


        public string MatKhau
        {
            get { return txtMatKhau.Text; }
            set { txtMatKhau.Text = value; }
        }

        public void DangNhap()
        {
             _ctrlDangNhap.DangNhapFromView();
        }

        public void HuyDangNhap()
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {    
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

       
    }
}

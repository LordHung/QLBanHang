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

        private bool _isLoggedIn = false;

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }

        public FrmDangNhapDlg()
        {
            InitializeComponent();
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


        private bool LogInSuccessful()
        {
            string _tenDangNhap = txtTenDangNhap.Text;
            if (_ctrlNhanVien.IsExist(_tenDangNhap))
            {
                string _matKhau = _ctrlNhanVien.GetMatKhauNhanVien(_tenDangNhap);
                if (_matKhau == txtMatKhau.Text)
                {
                    return true;
                }
            }
            return false;
        }


        private void DangNhap()
        {
            while (!_isLoggedIn)
            {
                if (LogInSuccessful())
                {
                    _isLoggedIn = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ko thể đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

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

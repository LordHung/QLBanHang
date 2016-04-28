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

<<<<<<< HEAD
        private bool _isLoggedIn = false;

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }

=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        public FrmDangNhapDlg()
        {
            InitializeComponent();
        }


        public string TenDangNhap
        {
<<<<<<< HEAD
            get { return txtTenDangNhap.Text; }
            set { txtTenDangNhap.Text = value; }
=======
            get { return txtDangNhap.Text; }
            set { txtDangNhap.Text = value; }
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        }


        public string MatKhau
        {
            get { return txtMatKhau.Text; }
            set { txtMatKhau.Text = value; }
        }

<<<<<<< HEAD

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

=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
       
    }
}

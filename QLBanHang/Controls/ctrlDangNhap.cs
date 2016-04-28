using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.Controls
{
    public interface IDangNhapView
    {
        void DangNhap();
        void HuyDangNhap();


        string TenDangNhap { get; set; }
        string MatKhau { get; set; }
        bool IsLoggedIn { get; set; }
    }

    class ctrlDangNhap
    {
        public ctrlDangNhap()
        { }

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        IDangNhapView _viewDangNhap;

        private bool _isLoggedIn = false;

        public void SetView(IDangNhapView view)
        {
            this._viewDangNhap = view;
        }

        public bool KiemTra()
        {
            string _tenDangNhap = _viewDangNhap.TenDangNhap;
            if (_ctrlNhanVien.IsExist(_tenDangNhap))
            {
                string _matKhau = _ctrlNhanVien.GetMatKhauNhanVien(_tenDangNhap);
                if (_matKhau == _viewDangNhap.MatKhau)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsLoggedIn
        {
            get { return _isLoggedIn;}
            set {_isLoggedIn = value;}
        }

        public void DangNhapFromView()
        {
            if (KiemTra())
            {
                    MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this._viewDangNhap = null;
                    IsLoggedIn = true;
                    _viewDangNhap.HuyDangNhap();
            }
            else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

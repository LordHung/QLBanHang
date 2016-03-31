using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsNhanVien
    {
        ///
        /// Identity,
        /// 
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// 
        /// TenNhanVien
        /// 
        string _tenNhanVien;

        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        ///
        /// TenDangNhap
        ///
        string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        /// 
        /// MatKhau
        ///
        string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        /// 
        /// ChucVu
        /// 
        string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        /// 
        /// HopLe
        /// 
        bool _hopLe;

        public bool HopLe
        {
            get { return _hopLe; }
            set { _hopLe = value; }
        }

        /// 
        /// IdCuaHang,THam chiếu đến cửa hàng
        /// 
        int _idCuaHang;

        public int IdCuaHang
        {
            get { return _idCuaHang; }
            set { _idCuaHang = value; }
        }

        /// 
        /// IsToanQuyen
        /// 
        bool _isToanQuyen;

        public bool IsToanQuyen
        {
            get { return _isToanQuyen; }
            set { _isToanQuyen = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsNganhSanPham
    {
        /// <summary>
        /// Priamry key,identity(1,1) ,được LoaiSanPham tham chiếu đến
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// MaNganhSanPham
        /// </summary>
        string _maNganhSanPham;

        public string MaNganhSanPham
        {
            get { return _maNganhSanPham; }
            set { _maNganhSanPham = value; }
        }

        /// <summary>
        /// TenNganhSanPham
        /// </summary>
        string _tenNganhSanPham;

        public string TenNganhSanPham
        {
            get { return _tenNganhSanPham; }
            set { _tenNganhSanPham = value; }
        }

        /// <summary>
        /// MoTa
        /// </summary>
        string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        /// <summary>
        /// Constructros
        /// </summary>
        public clsNganhSanPham()
        {
 
        }

        public clsNganhSanPham(string maNganhSanPham,string tenNganhSanPham,string moTa)
        {
            _maNganhSanPham = maNganhSanPham;
            _tenNganhSanPham = tenNganhSanPham;
            _moTa = moTa;
        }
    }
}

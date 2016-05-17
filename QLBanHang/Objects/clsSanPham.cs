using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsSanPham
    {
        /// <summary>
        /// IDENTIY,PRIAMRY KEY,được tbSanPhamCuaHang tham chiếu đến
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// CodeSanPham
        /// </summary>
        int _codeSanPham;

        public int CodeSanPham
        {
            get { return _codeSanPham; }
            set { _codeSanPham = value; }
        }

        /// <summary>
        /// TenSanPham
        /// </summary>
        string _tenSanPham;

        public string TenSanPham
        {
            get { return _tenSanPham; }
            set { _tenSanPham = value; }
        }

        /// <summary>
        /// Donvi
        /// </summary>
        string _donVi;

        public string DonVi
        {
            get { return _donVi; }
            set { _donVi = value; }
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
        /// IdLoaiSanPham ,Tham chiếu đến tbLoaiSanPham
        /// </summary>
        int _idLoaiSanPham;

        public int IdLoaiSanPham
        {
            get { return _idLoaiSanPham; }
            set { _idLoaiSanPham = value; }
        }

        /// <summary>
        /// IdNhaSanXuat,tham chiếu đến tbNhaSanXuat
        /// </summary>
        int _idNhaSanXuat;

        public int IdNhaSanXuat
        {
            get { return _idNhaSanXuat; }
            set { _idNhaSanXuat = value; }
        }

        public clsSanPham()
        { }

        public clsSanPham(int codeSanPham, string tenSanPham, string donVi, string moTa, int idLoaiSanPham, int idNhaSanXuat)
        {
            _codeSanPham = codeSanPham;
            _tenSanPham = tenSanPham;
            _donVi = donVi;
            _moTa = moTa;
            _idLoaiSanPham = idLoaiSanPham;
            _idNhaSanXuat = idNhaSanXuat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsLoaiSanPham
    {
        /// <summary>
        /// ID,Piramary key ,identity(1,1),được SanPham tham chiếu đến
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// MaLoaiSanPham
        /// </summary>
        string _maLoaiSanPham;

        public string MaLoaiSanPham
        {
            get { return _maLoaiSanPham; }
            set { _maLoaiSanPham = value; }
        }

        /// <summary>
        /// TenLoaiSanPham
        /// </summary>
        string _tenLoaiSanPham;

        public string TenLoaiSanPham
        {
            get { return _tenLoaiSanPham; }
            set { _tenLoaiSanPham = value; }
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
        /// IdNganhSanPham,Tham chiếu đến ngành sản phấm
        /// </summary>
        int _idNganhSanPham;

        public int IdNganhSanPham
        {
            get { return _idNganhSanPham; }
            set { _idNganhSanPham = value; }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsNhaSanXuat
    {
        /// <summary>
        /// ID ,Pirmary key,identity(1,1),SanPham tham chiếu đến
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// MaNhaSanXuat 
        /// </summary>
        string _maNhaSanXuat;

        public string MaNhaSanXuat
        {
            get { return _maNhaSanXuat; }
            set { _maNhaSanXuat = value; }
        }

        /// <summary>
        /// TenNhaSanXuat
        /// </summary>
        string _tenNhaSanXuat;

        public string TenNhaSanXuat
        {
            get { return _tenNhaSanXuat; }
            set { _tenNhaSanXuat = value; }
        }

        /// <summary>
        ///DiaChi
        /// </summary>
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        /// <summary>
        /// GhiChu
        /// </summary>
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public clsNhaSanXuat()
        { }
        public clsNhaSanXuat(string maNhaSanXuat,string tenNhaSanXuat,string diaChi,string ghiChu)
        {
            _maNhaSanXuat = maNhaSanXuat;
            _tenNhaSanXuat = tenNhaSanXuat;
            _diaChi = diaChi;
            _ghiChu = ghiChu;
        }
    }
}

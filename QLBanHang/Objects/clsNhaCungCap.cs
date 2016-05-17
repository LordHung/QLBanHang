using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsNhaCungCap
    {
        /// <summary>
        /// ID
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// IDCuahang
        /// </summary>
        int _IDCuahang;
        public int IDCuahang
        {
            get { return _IDCuahang; }
            set { _IDCuahang = value; }
        }

        /// <summary>
        /// CodeNhaCungCap
        /// </summary>
        string _codeNhaCungCap;

        public string CodeNhaCungCap
        {
            get { return _codeNhaCungCap; }
            set { _codeNhaCungCap = value; }
        }

        /// <summary>
        /// TenNhaCungCap
        /// </summary>
        string _tenNhaCungCap;

        public string TenNhaCungCap
        {
            get { return _tenNhaCungCap; }
            set { _tenNhaCungCap = value; }
        }
        /// <summary>
        /// DiaChi
        /// </summary>
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

       
        /// <summary>
        /// SoDienThoai
        /// </summary>
        string _soDienThoai;

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
         /// <summary>
        /// CongNoDauKy
         /// </summary>
        decimal _congNoDauKy;

        public decimal CongNoDauKy
        {
            get { return _congNoDauKy; }
            set { _congNoDauKy = value; }
        }

        ///Constructor
        public clsNhaCungCap()
        { }
    }
}

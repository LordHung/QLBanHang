using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsLoaiPhieuXuat
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        string _loaiPhieuXuat;

        public string LoaiPhieuXuat
        {
            get { return _loaiPhieuXuat; }
            set { _loaiPhieuXuat = value; }
        }
        string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        int _loai;

        public int Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsLoaiPhieuNhap
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _loaiPhieuNhap;

        public string LoaiPhieuNhap
        {
            get { return _loaiPhieuNhap; }
            set { _loaiPhieuNhap = value; }
        }

        string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        string _loai;

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
    }
}

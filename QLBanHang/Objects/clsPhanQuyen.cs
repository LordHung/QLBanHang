using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsPhanQuyen
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }
        int _idQuyen;

        public int IdQuyen
        {
            get { return _idQuyen; }
            set { _idQuyen = value; }
        }
        bool _trangThai;

        public bool TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
    }
}

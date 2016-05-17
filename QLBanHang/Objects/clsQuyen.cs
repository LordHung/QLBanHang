using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsQuyen
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _tenQuyen;

        public string TenQuyen
        {
            get { return _tenQuyen; }
            set { _tenQuyen = value; }
        }
        string _tenControl;

        public string TenControl
        {
            get { return _tenControl; }
            set { _tenControl = value; }
        }
        int _hinhThuc;

        public int HinhThuc
        {
            get { return _hinhThuc; }
            set { _hinhThuc = value; }
        }
        /// <summary>
        /// Tham chiếu ngược lại tb để lấy id Quyền cha
        /// </summary>
        int _idQuyenCha;

        public int IdQuyenCha
        {
            get { return _idQuyenCha; }
            set { _idQuyenCha = value; }
        }
    }
}

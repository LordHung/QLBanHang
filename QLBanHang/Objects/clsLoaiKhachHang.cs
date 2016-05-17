using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsLoaiKhachHang
    {
        /// <summary>
        /// ID,identity,primary key,được tham chiếu bởi khách hàng
        /// </summary>
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// LoaiThe
        /// </summary>
        string _loaiThe;

        public string LoaiThe
        {
            get { return _loaiThe; }
            set { _loaiThe = value; }
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
        /// TiLeQuyDoiDiem
        /// </summary>
        double _tiLeQuyDoiDiem;

        public double TiLeQuyDoiDiem
        {
            get { return _tiLeQuyDoiDiem; }
            set { _tiLeQuyDoiDiem = value; }
        }
        /// <summary>
        ///NguongQuyDoi
        /// </summary>
        int _nguongQuyDoi;

        public int NguongQuyDoi
        {
            get { return _nguongQuyDoi; }
            set { _nguongQuyDoi = value; }
        }

        ///Constructor 
        public clsLoaiKhachHang()
        { }
    }
}

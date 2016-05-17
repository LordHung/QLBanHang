using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsDonDatHang
    {
        //<summary>
        //Idenity,primary key
        //</summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Số đơn theo ngày
        /// </summary>
        int _soDonDatHang;

        public int SoDonDatHang
        {
            get { return _soDonDatHang; }
            set { _soDonDatHang = value; }
        }
        /// <summary>
        /// Tham chiếu đến idCuaHang
        /// </summary>
        int _idCuaHang;

        public int IdCuaHang
        {
            get { return _idCuaHang; }
            set { _idCuaHang = value; }
        }
        /// <summary>
        /// Tham chiếu đến idNhanVien
        /// </summary>
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        /// <summary>
        /// Ngày lập
        /// </summary>
        DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        /// <summary>
        /// Tham chiếu đến idNhaCungCap
        /// </summary>
        int _idNhaCungCap;

        public int IdNhaCungCap
        {
            get { return _idNhaCungCap; }
            set { _idNhaCungCap = value; }
        }
    }
}

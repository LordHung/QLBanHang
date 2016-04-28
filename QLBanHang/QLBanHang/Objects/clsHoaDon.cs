using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsHoaDon
    {
        /// <summary>
        /// identity primary key
        /// </summary>
        decimal _id;

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Ngày lập hóa đơn
        /// </summary>
        DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
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
        /// Tham chiếu đến idKhachHang
        /// </summary>
        int _idKhachHang;

        public int IdKhachHang
        {
            get { return _idKhachHang; }
            set { _idKhachHang = value; }
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

        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        int _chietKhau;

        public int ChietKhau
        {
            get { return _chietKhau; }
            set { _chietKhau = value; }
        }
        /// <summary>
        /// Số Hóa đơn dùng để hiển thị trên UI
        /// </summary>
        decimal _soHoaDon;

        public decimal SoHoaDon
        {
            get { return _soHoaDon; }
            set { _soHoaDon = value; }
        }

        decimal _soTienKhachDua;

        public decimal SoTienKhachDua
        {
            get { return _soTienKhachDua; }
            set { _soTienKhachDua = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        bool _siLe;

        public bool SiLe
        {
            get { return _siLe; }
            set { _siLe = value; }
        }
    }
}

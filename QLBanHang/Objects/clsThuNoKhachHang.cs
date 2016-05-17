using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsThuNoKhachHang
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        DateTime _ngayThu;

        public DateTime NgayThu
        {
            get { return _ngayThu; }
            set { _ngayThu = value; }
        }
        /// <summary>
        /// số tiền khách đưa
        /// </summary>
        decimal _soTien;

        public decimal SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
        /// <summary>
        /// tham chiếu đến idHoaDon
        /// </summary>
        decimal _idHoaDon;

        public decimal IdHoaDon
        {
            get { return _idHoaDon; }
            set { _idHoaDon = value; }
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
        /// Tham chiếu đến idNhanVien
        /// </summary>
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
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
        /// Só phiếu trong ngày
        /// </summary>
        int _soPhieu;

        public int SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        /// <summary>
        /// tham chiếu đến idPhieuNhap,nếu lập hóa đơn thì null
        /// </summary>
        int _idPhieuNhap;

        public int IdPhieuNhap
        {
            get { return _idPhieuNhap; }
            set { _idPhieuNhap = value; }
        }
    }
}

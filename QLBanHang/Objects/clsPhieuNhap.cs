using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsPhieuNhap
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        /// <summary>
        /// THam chiếu đến id cửa hàng
        /// </summary>
        int _idCuaHang;

        public int IdCuaHang
        {
            get { return _idCuaHang; }
            set { _idCuaHang = value; }
        }
        /// <summary>
        /// Tham chiếu đến id nhân viên
        /// </summary>
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }
        /// <summary>
        /// Chi chú
        /// </summary>
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        /// <summary>
        /// Số phiếu nhập
        /// </summary>
        decimal _soPhieuNhap;

        public decimal SoPhieuNhap
        {
            get { return _soPhieuNhap; }
            set { _soPhieuNhap = value; }
        }
        /// <summary>
        /// tham chiếu đến idLoaiPhieuNhap
        /// </summary>
        int _idLoaiPhieuNhap;

        public int IdLoaiPhieuNhap
        {
            get { return _idLoaiPhieuNhap; }
            set { _idLoaiPhieuNhap = value; }
        }
        /// <summary>
        /// Tham chiếu đến idDonDatHang
        /// </summary>
        int _idDonDatHang;

        public int IdDonDatHang
        {
            get { return _idDonDatHang; }
            set { _idDonDatHang = value; }
        }
        /// <summary>
        /// Tham chiếu đến idChuyenHang
        /// </summary>
        int _idChuyenHang;

        public int IdChuyenHang
        {
            get { return _idChuyenHang; }
            set { _idChuyenHang = value; }
        }
        /// <summary>
        /// Thâm chiếu đến idNhaCungCap
        /// </summary>
        int _idNhaCungCap;

        public int IdNhaCungCap
        {
            get { return _idNhaCungCap; }
            set { _idNhaCungCap = value; }
        }
        /// <summary>
        /// Tham chiếu đến idHoaDon
        /// </summary>
        decimal _idHoaDon;

        public decimal IdHoaDon
        {
            get { return _idHoaDon; }
            set { _idHoaDon = value; }
        }
    }
}

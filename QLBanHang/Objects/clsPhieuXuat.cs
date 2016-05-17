using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsPhieuXuat
    {
        /// <summary>
        /// prmary key
        /// </summary>
        decimal _id;

        public decimal Id
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
        decimal _soPhieuXuat;

        public decimal SoPhieuXuat
        {
            get { return _soPhieuXuat; }
            set { _soPhieuXuat = value; }
        }
        /// <summary>
        /// Tham chiếu đến idLoaiPhieuXuat
        /// </summary>
        int _idLoaiPhieuXuat;

        public int IdLoaiPhieuXuat
        {
            get { return _idLoaiPhieuXuat; }
            set { _idLoaiPhieuXuat = value; }
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
        /// Tham chiếu đến idChuyenHang
        /// </summary>
        int _idChuyenHang;

        public int IdChuyenHang
        {
            get { return _idChuyenHang; }
            set { _idChuyenHang = value; }
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

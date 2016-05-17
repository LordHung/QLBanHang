using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsTraNoNhaCungCap
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        DateTime _ngayTra;

        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }
        decimal _soTien;

        public decimal SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
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
        /// Tham chiếu đến idPhieuNhap
        /// </summary>
        int _idPhieuNhap;

        public int IdPhieuNhap
        {
            get { return _idPhieuNhap; }
            set { _idPhieuNhap = value; }
        }
        int _soPhieu;

        public int SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        /// <summary>
        /// Tham chiếu đến idPhieuXuat
        /// </summary>
        decimal _idPhieuXuat;

        public decimal IdPhieuXuat
        {
            get { return _idPhieuXuat; }
            set { _idPhieuXuat = value; }
        }
    }
}

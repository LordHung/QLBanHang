using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsChiTietPhieuXuat
    {
        decimal _id;

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Tham chiếu đến _idPhieuXuat
        /// </summary>
        decimal _idPhieuXuat;

        public decimal IdPhieuXuat
        {
            get { return _idPhieuXuat; }
            set { _idPhieuXuat = value; }
        }
        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        decimal _donGia;

        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        /// <summary>
        /// Tham chiếu đến _idMaVachSanPham
        /// </summary>
        int _idMaVachSanPham;

        public int IdMaVachSanPham
        {
            get { return _idMaVachSanPham; }
            set { _idMaVachSanPham = value; }
        }
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        decimal _giaVon;

        public decimal GiaVon
        {
            get { return _giaVon; }
            set { _giaVon = value; }
        }
    }
}

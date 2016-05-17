using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsChiTietPhieuNhap
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        /// 
        /// 
        /// 
        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        /// 
        /// 
        /// 
        decimal _donGia;

        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        /// 
        /// tham chiếu đến idMaVachSanPham
        /// 
        int _idMaVachSanPham;

        public int IdMaVachSanPham
        {
            get { return _idMaVachSanPham; }
            set { _idMaVachSanPham = value; }
        }
        /// 
        /// 
        /// 
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        /// 
        /// 
        /// 
        decimal _giaBan;

        public decimal GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }
        /// 
        /// Tham chiếu đến idChiTietHoaDon
        /// 
        int _idChiTietHoaDon;

        public int IdChiTietHoaDon
        {
            get { return _idChiTietHoaDon; }
            set { _idChiTietHoaDon = value; }
        }
    }
}

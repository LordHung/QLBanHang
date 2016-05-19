using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsChiTietChuyenHang
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// 
        /// Tham chiếu đến idMaVachSanPham
        /// 
        int _idMaVachSanPham;

        public int IdMaVachSanPham
        {
            get { return _idMaVachSanPham; }
            set { _idMaVachSanPham = value; }
        }

        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
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
        decimal _donGia;

        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
    }
}

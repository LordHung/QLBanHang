using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsChiTietDonDatHang
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idDonDatHang;

        public int IdDonDatHang
        {
            get { return _idDonDatHang; }
            set { _idDonDatHang = value; }
        }
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
        int _donGia;

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}

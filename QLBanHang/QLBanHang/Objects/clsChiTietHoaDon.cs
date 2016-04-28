using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsChiTietHoaDon
    {
        /// <summary>
        /// Identity,primary key
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Tham chiếu đến idHoaDon trong tbHoaDon
        /// </summary>
        decimal _idHoaDon;

        public decimal IdHoaDon
        {
            get { return _idHoaDon; }
            set { _idHoaDon = value; }
        }
        /// <summary>
        /// Số lượng của sản phẩm bán ra
        /// </summary>
        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        /// <summary>
        /// Tham chiếu đến sản phẩm trong cửa hàng với mã vạch
        /// </summary>
        int _idMaVachSanPham;

        public int IdMaVachSanPham
        {
            get { return _idMaVachSanPham; }
            set { _idMaVachSanPham = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        int _chietKhau;

        public int ChietKhau
        {
            get { return _chietKhau; }
            set { _chietKhau = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        decimal _donGia;

        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        int _thoiGianBaoHanh;

        public int ThoiGianBaoHanh
        {
            get { return _thoiGianBaoHanh; }
            set { _thoiGianBaoHanh = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        decimal _giaVon;

        public decimal GiaVon
        {
            get { return _giaVon; }
            set { _giaVon = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        int _vAT;

        public int VAT
        {
            get { return _vAT; }
            set { _vAT = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        int _sanPhamComBo;

        public int SanPhamComBo
        {
            get { return _sanPhamComBo; }
            set { _sanPhamComBo = value; }
        }
        ///
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    class clsMaVachSanPham
    {
        ///Là Mã Vạch của 1 sản phẩm thuộc 1 cửa hàng


        /// <summary>
        /// Idnetity,primary key,
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _maVach;

        public string MaVach
        {
            get { return _maVach; }
            set { _maVach = value; }
        }
        /// <summary>
        /// Tham chiếu đến tbNhaCungCap
        /// </summary>
        int _idNhaCungCap;

        public int IdNhaCungCap
        {
            get { return _idNhaCungCap; }
            set { _idNhaCungCap = value; }
        }
        /// <summary>
        /// Số lượng sản phẩm
        /// </summary>
        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        bool _suDung;

        public bool SuDung
        {
            get { return _suDung; }
            set { _suDung = value; }
        }
        /// <summary>
        /// Giá bán sản phẩm
        /// </summary>
        int _giaBan;

        public int GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }
        /// <summary>
        /// lần sửa cuối
        /// </summary>
        DateTime _lanSuaCuoi;

        public DateTime LanSuaCuoi
        {
            get { return _lanSuaCuoi; }
            set { _lanSuaCuoi = value; }
        }
        /// <summary>
        /// Nhân viên
        /// </summary>
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }

        string _ghiChuThayDoi;

        public string GhiChuThayDoi
        {
            get { return _ghiChuThayDoi; }
            set { _ghiChuThayDoi = value; }
        }

        int _giaNhap;

        public int GiaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
        }
        int _giaBQGQ;

        public int GiaBQGQ
        {
            get { return _giaBQGQ; }
            set { _giaBQGQ = value; }
        }
        int _VAT;

        public int VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }
        bool _hetBan;

        public bool HetBan
        {
            get { return _hetBan; }
            set { _hetBan = value; }
        }
        bool _khongTichLuyDiem;

        public bool KhongTichLuyDiem
        {
            get { return _khongTichLuyDiem; }
            set { _khongTichLuyDiem = value; }
        }
        int _giaSi;

        public int GiaSi
        {
            get { return _giaSi; }
            set { _giaSi = value; }
        }
        /// <summary>
        /// Tham chiếu đến tbSanPhamCuaHang ràng buộc với sản phẩm thuộc cửa hàng nào
        /// </summary>
        int _idSanPhamCuaHang;

        public int IdSanPhamCuaHang
        {
            get { return _idSanPhamCuaHang; }
            set { _idSanPhamCuaHang = value; }
        }

        DateTime _ngayTao;

        public DateTime NgayTao
        {
            get { return _ngayTao; }
            set { _ngayTao = value; }
        }
    }
}

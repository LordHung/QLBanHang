using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBanHang.Objects
{
    /// <summary>
    /// Nắm thông tin khách hàng,khách hàng của cứa hàng nào,loại khách hàng
    /// </summary>
    public class clsKhachHang
    {
        /// <summary>
        /// ID,indentity
        /// </summary>
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// MaKhachHang
        /// </summary>
        string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        /// <summary>
        /// TenKhachHang
        /// </summary>
        string _tenKhachHang;

        public string TenKhachHang
        {
            get { return _tenKhachHang; }
            set { _tenKhachHang = value; }
        }

        /// <summary>
        /// Email
        /// </summary>
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// DiaChi
        /// </summary>
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        /// <summary>
        /// SoDienThoai
        /// </summary>
        string _soDienThoai;

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        /// <summary>
        /// SoDienThoai
        /// </summary>
        decimal _congNoDauKi;

        public decimal CongNoDauKi
        {
            get { return _congNoDauKi; }
            set { _congNoDauKi = value; }
        }
        /// <summary>
        /// NgayNhap1
        /// </summary>
        DateTime _ngayNhap;

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }
        /// <summary>
        /// IdCuaHang,tham chiếu đến khóa chính tbCUaHang
        /// </summary>
        int _idCuaHang;

        public int IdCuaHang
        {
            get { return _idCuaHang; }
            set { _idCuaHang = value; }
        }
        /// <summary>
        /// GioiTinh
        /// </summary>
        bool _gioiTinh;

        public bool GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        /// <summary>
        /// IdLoaiKhachHang,tham chiếu đến khóa chính tbLoaiKhachHang
        /// </summary>
        int _idLoaiKhachHang;

        public int IdLoaiKhachHang
        {
            get { return _idLoaiKhachHang; }
            set { _idLoaiKhachHang = value; }
        }
        /// <summary>
        /// DiemTichLuy
        /// </summary>
        int _diemTichLuy;

        public int DiemTichLuy
        {
            get { return _diemTichLuy; }
            set { _diemTichLuy = value; }
        }
        /// <summary>
        /// DiemTichLuyAll
        /// </summary>
        decimal _diemTichLuyAll;

        public decimal DiemTichLuyAll
        {
            get { return _diemTichLuyAll; }
            set { _diemTichLuyAll = value; }
        }

        ///Constructor
        public clsKhachHang()
        { }
    }
}

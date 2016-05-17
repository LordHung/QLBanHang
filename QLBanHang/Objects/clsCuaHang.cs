using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QLBanHang.Objects
{
    public class clsCuaHang
    {
        /// <summary>
        /// Primarykey
        /// tbKhuyenMaiSanPham,tbKhuyenMaiGiaTo,tbSanPhamCuaHang,tbChuyenHang,tbDonDatHang,tbHoaDon,tbKhachHang,tbPhieuXuat
        /// tbPhieuNhap,tbNhanVien,tbPhieuThu,tbPhieuChi,tbReport
        /// tham thiếu đến
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// 
        /// TenCuaHang
        /// 
        string _tenCuaHang;

        public string TenCuaHang
        {
            get { return _tenCuaHang; }
            set { _tenCuaHang = value; }
        }

        ///
        ///DiaChiCuaHang
        ///
        string _diaChiCuaHang;

        public string DiaChiCuaHang
        {
            get { return _diaChiCuaHang; }
            set { _diaChiCuaHang = value; }
        }

        ///
        ///NguoiQuanLy
        ///
        string _nguoiQuanLy;

        public string NguoiQuanLy
        {
            get { return _nguoiQuanLy; }
            set { _nguoiQuanLy = value; }
        }

        ///
        ///SoDienThoai
        ///
        string _soDienThoai;

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        ///
        ///TenCuaHangTrenBill
        ///
        string _tenCuaHangTrenBill;

        public string TenCuaHangTrenBill
        {
            get { return _tenCuaHangTrenBill; }
            set { _tenCuaHangTrenBill = value; }
        }


        ///
        ///ThongTinLienHeTrenBill
        ///
        string _thongTinLienHeTrenBill;

        public string ThongTinLienHeTrenBill
        {
            get { return _thongTinLienHeTrenBill; }
            set { _thongTinLienHeTrenBill = value; }
        }

        ///
        ///LogoTrenBill
        ///
        Bitmap _logoTrenBill;

        public Bitmap LogoTrenBill
        {
            get { return _logoTrenBill; }
            set { _logoTrenBill = value; }
        }


        ///
        ///MaCuaHang
        ///
        string _maCuaHang;

        public string MaCuaHang
        {
            get { return _maCuaHang; }
            set { _maCuaHang = value; }
        }

    }
}

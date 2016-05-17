using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsPhieuThu
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        string _tenNguoiNop;

        public string TenNguoiNop
        {
            get { return _tenNguoiNop; }
            set { _tenNguoiNop = value; }
        }
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }
        decimal _soTien;

        public decimal SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
        string _chungTyKemTheo;

        public string ChungTyKemTheo
        {
            get { return _chungTyKemTheo; }
            set { _chungTyKemTheo = value; }
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
        int _soPhieu;

        public int SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsPhieuChi
    {
        /// <summary>
        /// 
        /// </summary>
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idNhanVien;
        /// <summary>
        /// Tham chiếu đến idNhanVien
        /// </summary>
        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        string _tenNguoiNhan;

        public string TenNguoiNhan
        {
            get { return _tenNguoiNhan; }
            set { _tenNguoiNhan = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        decimal _soTien;

        public decimal SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
    }
}

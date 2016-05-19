using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsChuyenHang
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _soChuyenHang;

        public int SoChuyenHang
        {
            get { return _soChuyenHang; }
            set { _soChuyenHang = value; }
        }
        DateTime _ngayChuyen;

        public DateTime NgayChuyen
        {
            get { return _ngayChuyen; }
            set { _ngayChuyen = value; }
        }
        int _idCuaHangTu;

        public int IdCuaHangTu
        {
            get { return _idCuaHangTu; }
            set { _idCuaHangTu = value; }
        }
        int _idCuaHangDen;

        public int IdCuaHangDen
        {
            get { return _idCuaHangDen; }
            set { _idCuaHangDen = value; }
        }
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        int _idNhanVien;

        public int IdNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
        }
    }
}

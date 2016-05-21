using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Objects
{
    public class clsPhieuQuaTang
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        int _maVach;

        public int MaVach
        {
            get { return _maVach; }
            set { _maVach = value; }
        }
        int _triGia;

        public int TriGia
        {
            get { return _triGia; }
            set { _triGia = value; }
        }
        DateTime _ngayTao;

        public DateTime NgayTao
        {
            get { return _ngayTao; }
            set { _ngayTao = value; }
        }
        DateTime _ngaySuDung;

        public DateTime NgaySuDung
        {
            get { return _ngaySuDung; }
            set { _ngaySuDung = value; }
        }
        string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        int _idKhachHang;

        public int IdKhachHang
        {
            get { return _idKhachHang; }
            set { _idKhachHang = value; }
        }
        DateTime _hanSuDung;

        public DateTime HanSuDung
        {
            get { return _hanSuDung; }
            set { _hanSuDung = value; }
        }
    }
}

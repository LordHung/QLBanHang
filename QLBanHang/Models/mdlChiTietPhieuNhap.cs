using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBanHang.Objects;
using System.Windows.Forms;

namespace QLBanHang.Models
{
    class mdlChiTietPhieuNhap
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietPhieuNhap chiTietPhieuNhap)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietPhieuNhap] (idPhieuNhap,SoLuong,DonGia,idMaVachSanPham,GhiChu,GiaBan,idChiTietHoaDon) "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5},{6})"
            , chiTietPhieuNhap.IdPhieuNhap
            , chiTietPhieuNhap.SoLuong
            , chiTietPhieuNhap.DonGia
            , chiTietPhieuNhap.IdMaVachSanPham
            , chiTietPhieuNhap.GhiChu
            , (chiTietPhieuNhap.GiaBan != 0) ? "'" + chiTietPhieuNhap.GiaBan.ToString() + "'" : "null"
            , (chiTietPhieuNhap.IdChiTietHoaDon != 0) ? "'" + chiTietPhieuNhap.IdChiTietHoaDon.ToString() + "'" : "null");
      
            return _conn.ExecuteCMD();
        }

    }
}

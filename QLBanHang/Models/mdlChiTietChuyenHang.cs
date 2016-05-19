using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.Objects;

namespace QLBanHang.Models
{
    class mdlChiTietChuyenHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietChuyenHang chiTietChuyenHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietChuyenHang] (idPhieuChuyen,SoLuong,DonGia,idMaVachSanPham) "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}')"
            , chiTietChuyenHang.IdChuyenHang
            , chiTietChuyenHang.SoLuong
            , chiTietChuyenHang.DonGia
            , chiTietChuyenHang.IdMaVachSanPham
            );

            return _conn.ExecuteCMD();
        }
    }
}

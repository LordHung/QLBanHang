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
    class mdlChiTietPhieuXuat
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietPhieuXuat chiTietPhieuXuat)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietPhieuXuat] (idPhieuXuat,SoLuong,DonGia,idMaVachSanPham,GhiChu,GiaVon)  "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
            , chiTietPhieuXuat.IdPhieuXuat
            , chiTietPhieuXuat.SoLuong
            , chiTietPhieuXuat.DonGia
            , chiTietPhieuXuat.IdMaVachSanPham
            , chiTietPhieuXuat.GhiChu
            , chiTietPhieuXuat.GiaVon);

            return _conn.ExecuteCMD();
        }
    }
}

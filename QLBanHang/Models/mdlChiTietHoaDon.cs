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
    class mdlChiTietHoaDon
    {

        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietHoaDon chiTietHoaDon)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietHoaDon] (idHoaDon,SoLuong,ChietKhau,DonGia,GhiChu,"
                +"idMaVachSanPham,ThoiGianBaoHanh,GiaVon,VAT,SanPhamComBo)"
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')"
                 ,chiTietHoaDon.IdHoaDon,chiTietHoaDon.SoLuong,chiTietHoaDon.ChietKhau,chiTietHoaDon.DonGia,chiTietHoaDon.GhiChu
                 ,chiTietHoaDon.IdMaVachSanPham,chiTietHoaDon.ThoiGianBaoHanh,chiTietHoaDon.GiaVon,chiTietHoaDon.VAT,chiTietHoaDon.SanPhamComBo);
            return _conn.ExecuteCMD();
        }
    }
}

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
    class mdlChiTietDonDatHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietDonDatHang chiTietDonDatHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietDonDatHang] (idDonDatHang,idMaVachSanPham,SoLuong,DonGia,GhiChu)"
            + " VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')"
                 ,chiTietDonDatHang.IdDonDatHang,chiTietDonDatHang.IdMaVachSanPham,chiTietDonDatHang.SoLuong
                 ,chiTietDonDatHang.DonGia,chiTietDonDatHang.GhiChu);
            return _conn.ExecuteCMD();
        }
    }
}

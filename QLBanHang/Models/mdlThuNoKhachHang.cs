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
    class mdlThuNoKhachHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsThuNoKhachHang thuNoKhachHang)//Không add idPhieNhap tại đây
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbThuNoKhachHang] (idKhachHang,NgayThu,SoTien,idHoaDon,"
            +"GhiChu,idNhanVien,idCuaHang,SoPhieu) "
            + "VALUES (N'{0}',cast(N'{1}' as datetime),N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                 ,thuNoKhachHang.IdKhachHang, thuNoKhachHang.NgayThu.ToString("yyyy-MM-dd hh:mm:ss.FFF"),thuNoKhachHang.SoTien
                 ,thuNoKhachHang.IdHoaDon, thuNoKhachHang.GhiChu, thuNoKhachHang.IdNhanVien, thuNoKhachHang.IdCuaHang, thuNoKhachHang.SoPhieu
                 );
            return _conn.ExecuteCMD();
        }

        public int GenerateNewSoPhieu(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieu) + 1,1) as SP from tbThuNoKhachHang where cast(NgayThu as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SP"].ToString());
        }
    }
}

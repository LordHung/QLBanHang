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
    class mdlHoaDon
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GetNewSoHoaDon(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoHoaDon) + 1,1) as SHD from tbHoaDon where cast(NgayLap as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SHD"].ToString());
        }

        public bool AddData(clsHoaDon hoaDon)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbHoaDon] (NgayLap,idKhachHang,idCuaHang,idNhanVien,GhiChu,ChietKhau,SoHoaDon,SoTienKhachDua,SiLe) "
            + "VALUES (cast('{0}' as datetime),N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
                 , hoaDon.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF"), hoaDon.IdKhachHang, hoaDon.IdCuaHang, hoaDon.IdNhanVien, hoaDon.GhiChu, hoaDon.ChietKhau, hoaDon.SoHoaDon, hoaDon.SoTienKhachDua, hoaDon.SiLe);
            return _conn.ExecuteCMD();
        }

        public decimal GetIdHoaDon()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbHoaDon");
            _conn.FillData(table);
            return Convert.ToDecimal(table.Rows[0]["ID"].ToString());

        }
    }
}

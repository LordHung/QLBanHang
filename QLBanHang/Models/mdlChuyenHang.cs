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
    class mdlChuyenHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GenerateNewSoChuyenHang(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoChuyenHang) + 1,1) as SoCH from tbChuyenHang where cast(NgayChuyen as date)  = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SoCH"].ToString());
        }

        public bool AddData(clsChuyenHang chuyenHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChuyenHang] (SoChuyenHang,NgayChuyen,idCuaHangTu"
                +",idCuaHangDen,GhiChu,idNhanVien) "
           + "VALUES (N'{0}',cast(N'{1}' as datetime),N'{2}',N'{3}',N'{4}',N'{5}')"
                , chuyenHang.SoChuyenHang
                , chuyenHang.NgayChuyen.ToString("yyyy-MM-dd hh:mm:ss.FFF")
                , chuyenHang.IdCuaHangTu
                , chuyenHang.IdCuaHangDen
                , chuyenHang.GhiChu
                , chuyenHang.IdNhanVien);
            return _conn.ExecuteCMD();
        }

        public int GetIdChuyenKho()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbChuyenHang");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }

    }
}

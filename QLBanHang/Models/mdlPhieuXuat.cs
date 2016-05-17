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
    class mdlPhieuXuat
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public decimal GenerateNewSoPhieuXuat(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieuXuat) + 1,1) as SPX from tbPhieuXuat where cast(NgayLap as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToDecimal(table.Rows[0]["SPX"].ToString());
        }

        public bool AddData(clsPhieuXuat phieuXuat)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbPhieuXuat] (NgayLap,idCuaHang,idNhanVien,GhiChu,SoPhieuXuat"
                +",idLoaiPhieuXuat,idKhachHang,idChuyenHang,idNhaCungCap) "
                + "VALUES (cast('{0}' as datetime),N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},{8})"
                 , phieuXuat.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF")
                 , phieuXuat.IdCuaHang
                 , phieuXuat.IdNhanVien
                 , phieuXuat.GhiChu
                 , phieuXuat.SoPhieuXuat
                 , phieuXuat.IdLoaiPhieuXuat
                 , (phieuXuat.IdKhachHang != 0) ? "'" + phieuXuat.IdKhachHang.ToString() + "'" : "null"
                 , (phieuXuat.IdChuyenHang != 0) ? "'" + phieuXuat.IdChuyenHang.ToString() + "'" : "null"
                 , (phieuXuat.IdNhaCungCap != 0) ? "'" + phieuXuat.IdNhaCungCap.ToString() + "'" : "null"
                );

            return _conn.ExecuteCMD();
        }

        public int GetIdPhieuXuat()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbPhieuXuat");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }
    }
}

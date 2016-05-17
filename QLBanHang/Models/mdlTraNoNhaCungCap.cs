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
    class mdlTraNoNhaCungCap
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsTraNoNhaCungCap traNoNhaCungCap)//Không add idPhieNhap tại đây
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbTraNoNhaCungCap] (idNhaCungCap,NgayTra,SoTien,idNhanVien"
                +",GhiChu,idCuaHang,idPhieuNhap,SoPhieu,idPhieuXuat) "
            + "VALUES (N'{0}',cast(N'{1}' as datetime),N'{2}',{3},N'{4}',N'{5}',{6},N'{7}',N'{8}')"
                 , traNoNhaCungCap.IdNhaCungCap
                 , traNoNhaCungCap.NgayTra.ToString("yyyy-MM-dd hh:mm:ss.FFF")
                 , traNoNhaCungCap.SoTien
                 , traNoNhaCungCap.IdNhanVien
                 , traNoNhaCungCap.GhiChu
                 , traNoNhaCungCap.IdCuaHang
                 , (traNoNhaCungCap.IdPhieuNhap != 0) ? "'" + traNoNhaCungCap.IdPhieuNhap.ToString() + "'" : "null"
                 , traNoNhaCungCap.SoPhieu
                 , traNoNhaCungCap.IdPhieuXuat
                 );

            return _conn.ExecuteCMD();
        }

        public int GenerateNewSoPhieu(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieu) + 1,1) as SP from tbTraNoNhaCungCap where cast(NgayTra as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SP"].ToString());
        }
    }
}

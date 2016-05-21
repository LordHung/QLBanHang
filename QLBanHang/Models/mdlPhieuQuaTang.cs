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
    class mdlPhieuQuaTang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        /// <summary>
        /// Tạo ra số phiếu mới cho phiếu quà tặng vào thời điểm date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GenerateNewSoPhieu(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(MaVach) + 1,1) as MV from tbPhieuQuaTang");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["MV"].ToString());
        }
        /// <summary>
        /// Lấy hết dữ liệu từ phiếu quà tặng bên dưới databse lên datatable 
        /// </summary>
        /// <returns></returns>
        public DataTable GetData(int topRows = 0)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format(
        "select distinct {0}  tbPhieuQuaTang.id, REPLACE(STR(MaVach, 4), SPACE(1), '0') + CONVERT(nvarchar(8),FORMAT(NgayTao,'MMyyyy')) as MaVach"
        + ",MaVach as SoPhieu,TriGia,NgayTao,NgaySuDung,GhiChu,idKhachHang,HanSuDung "
         + "from tbPhieuQuaTang,tbKhachHang "
         +" order by SoPhieu desc"
         ,(topRows != 0) ? "TOP " + topRows.ToString() : ""
         );
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// THêm dữ liệu vào databse 
        /// </summary>
        /// <param name="phieuQuaTang"></param>
        /// <returns></returns>
        public bool AddData(clsPhieuQuaTang phieuQuaTang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbPhieuQuaTang] "
                + "(MaVach,TriGia,NgayTao,NgaySuDung,GhiChu,idKhachHang,HanSuDung) "
         + "VALUES (N'{0}',N'{1}',cast(N'{2}' as datetime),{3},N'{4}',{5},N'{6}')"
              , phieuQuaTang.MaVach
              , phieuQuaTang.TriGia
              , phieuQuaTang.NgayTao.ToString("yyyy-MM-dd hh:mm:ss.FFF")
              , (phieuQuaTang.NgaySuDung != DateTime.MinValue) ? "cast(N'" + phieuQuaTang.NgaySuDung.ToString("yyyy-MM-dd hh:mm:ss.FFF") + "' as datetime)" : "null"
              , phieuQuaTang.GhiChu
              , (phieuQuaTang.IdKhachHang != 0) ? "'" + phieuQuaTang.IdKhachHang + "'" : "null"
              , phieuQuaTang.HanSuDung.ToString("yyyy-MM-dd hh:mm:ss.FFF"));
            return _conn.ExecuteCMD();
        }
        /// <summary>
        /// Cập nhập dữ liệu của một phiếu quà tặng
        /// </summary>
        /// <param name="phieuQuaTang"></param>
        /// <returns></returns>
        public bool UpdateData(clsPhieuQuaTang phieuQuaTang)
        {
            _conn.CMD.CommandText = String.Format("UPDATE [dbo].[tbPhieuQuaTang] "
         + "set MaVach = N'{0}',TriGia = N'{1}'"
         +",NgayTao = cast(N'{2}' as datetime),NgaySuDung = {3}"
         + ",GhiChu = N'{4}',idKhachHang = {5},HanSuDung = N'{6}'"
         +" where id = '{7}'"
              , phieuQuaTang.MaVach
              , phieuQuaTang.TriGia
              , phieuQuaTang.NgayTao.ToString("yyyy-MM-dd hh:mm:ss.FFF")
              , (phieuQuaTang.NgaySuDung != DateTime.MinValue) ? "cast(N'" + phieuQuaTang.NgaySuDung.ToString("yyyy-MM-dd hh:mm:ss.FFF") + "' as datetime)" : "null"
              , phieuQuaTang.GhiChu
              , (phieuQuaTang.IdKhachHang != 0) ? "'" + phieuQuaTang.IdKhachHang + "'" : "null"
              , phieuQuaTang.HanSuDung.ToString("yyyy-MM-dd hh:mm:ss.FFF")
              , phieuQuaTang.Id);
            return _conn.ExecuteCMD();
        }
        /// <summary>
        /// Xóa dữ liệu phiếu quà tặng
        /// </summary>
        /// <param name="idPhieuQuaTang"></param>
        /// <returns></returns>
        public bool DeleteData(int idPhieuQuaTang)
        {
            _conn.CMD.CommandText = String.Format("Delete tbPhieuQuaTang where id = '{0}'",idPhieuQuaTang);
            return _conn.ExecuteCMD();
        }

        public string GetMaPhieuQuaTangById(int idPhieuQuaTang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select REPLACE(STR(MaVach, 4), SPACE(1), '0') "
                +"+ CONVERT(nvarchar(8),FORMAT(NgayTao,'MMyyyy')) as MaVach from tbPhieuQuaTang where id = '{0}'"
                ,idPhieuQuaTang);
            _conn.FillData(table);
            return table.Rows[0]["MaVach"].ToString();
        }
    }
}

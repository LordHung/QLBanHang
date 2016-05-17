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
    class mdlPhieuNhap
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GenerateNewSoPhieuNhap(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieuNhap) + 1,1) as SPN from tbPhieuNhap where cast(NgayLap as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SPN"].ToString());
        }

        public bool AddData(clsPhieuNhap phieuNhap)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbPhieuNhap] (NgayLap,idCuaHang,idNhanVien,GhiChu,SoPhieuNhap"
                + ",idLoaiPhieuNhap,idDonDatHang,idChuyenHang,idNhaCungCap,idHoaDon) "
                + "VALUES (cast('{0}' as datetime),N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},{8},{9})"
                 , phieuNhap.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF")
                 , phieuNhap.IdCuaHang
                 , phieuNhap.IdNhanVien
                 , phieuNhap.GhiChu
                 , phieuNhap.SoPhieuNhap
                 , phieuNhap.IdLoaiPhieuNhap
                 , (phieuNhap.IdDonDatHang != 0) ? "'" + phieuNhap.IdDonDatHang.ToString() + "'" : "null"
                 , (phieuNhap.IdChuyenHang != 0) ? "'" +phieuNhap.IdChuyenHang.ToString() + "'" : "null"
                 , (phieuNhap.IdNhaCungCap != 0) ? "'" + phieuNhap.IdNhaCungCap.ToString() + "'" : "null"
                 , (phieuNhap.IdHoaDon != 0) ? "'" + phieuNhap.IdHoaDon.ToString() + "'" : "null");

            return _conn.ExecuteCMD();
        }



        public int GetIdPhieuNhap()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbPhieuNhap");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }
    }
}

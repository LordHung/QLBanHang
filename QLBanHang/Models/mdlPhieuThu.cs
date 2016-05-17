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
    class mdlPhieuThu
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GenerateNewSoPhieuThu(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieu) + 1,1) as SPT from tbPhieuThu where cast(NgayLap as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SPT"].ToString());
        }

        string GetDataString = "select TenCuaHang,CONVERT(nvarchar(10),FORMAT(NgayLap,'dd/MM/yyyy')) as NgayLap "
                    + ",'PT02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) as MaPhieu "
                    + ",SoTien "
                    + ",LyDo "
                    + ",TenNguoiNop "
                    + ",DiaChi "
                    + ",TenNhanVien "
                    + ",ChungTyKemTheo "
                    + "from tbPhieuThu,tbCuaHang,tbNhanVien "
                    + "where tbCuaHang.id = tbPhieuThu.idCuaHang and tbNhanVien.id = tbPhieuThu.idNhanVien ";

        public DataTable GetData()
        {
           DataTable table = new DataTable();//Create template table to get data from database
           _conn.CMD.CommandText = GetDataString;
            _conn.FillData(table);
            return table;
        }

        public int GetIdByMaPhieu(string maPhieu)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbPhieuThu where 'PT02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) = '{0}'", maPhieu);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public bool DeleteData(string maPhieu)
        {
            _conn.CMD.CommandText = String.Format("delete tbPhieuThu where 'PT02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) = '{0}'", maPhieu);
            return _conn.ExecuteCMD();
        }

        public DataTable GetPhieuThuById(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select tbPhieuThu.idNhanVien,tbPhieuThu.TenNguoiNop,tbPhieuThu.DiaChi,tbPhieuThu.LyDo,tbPhieuThu.SoTien,"
                + "tbPhieuThu.ChungTyKemTheo,tbPhieuThu.idCuaHang,tbPhieuThu.SoPhieu,tbPhieuThu.NgayLap from tbPhieuThu where id = '{0}'", id);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsPhieuThu phieuThu)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbPhieuThu] (idNhanVien,TenNguoiNop,DiaChi,LyDo,SoTien,"
                +"ChungTyKemTheo,idCuaHang,SoPhieu,NgayLap)  "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',cast('{8}' as datetime))"
            ,phieuThu.IdNhanVien
            ,phieuThu.TenNguoiNop
            ,phieuThu.DiaChi
            ,phieuThu.LyDo
            ,phieuThu.SoTien
            ,phieuThu.ChungTyKemTheo
            ,phieuThu.IdCuaHang
            ,phieuThu.SoPhieu
            ,phieuThu.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF"));
            return _conn.ExecuteCMD();
        }

        public bool UpdateData(clsPhieuThu phieuThu)
        {
            _conn.CMD.CommandText = String.Format("Update  tbPhieuThu set idNhanVien = N'{0}',TenNguoiNop = N'{1}' ,DiaChi = N'{2}'," +
                " LyDo = N'{3}',SoTien = N'{4}',ChungTyKemTheo = N'{5}',idCuaHang = N'{6}',SoPhieu = N'{7}',NgayLap = N'{8}' where id = '{9}'"
           , phieuThu.IdNhanVien
           , phieuThu.TenNguoiNop
           , phieuThu.DiaChi
           , phieuThu.LyDo
           , phieuThu.SoTien
           , phieuThu.ChungTyKemTheo
           , phieuThu.IdCuaHang
           , phieuThu.SoPhieu
           , phieuThu.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF")
           , phieuThu.Id);
            return _conn.ExecuteCMD();
        }
    }
}

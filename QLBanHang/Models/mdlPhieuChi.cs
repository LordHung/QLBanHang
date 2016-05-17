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
    class mdlPhieuChi
    {

        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GenerateNewSoPhieuChi(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoPhieu) + 1,1) as SPC from tbPhieuChi where cast(NgayLap as date) = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SPC"].ToString());
        }

        string GetDataString = "select TenCuaHang,CONVERT(nvarchar(10),FORMAT(NgayLap,'dd/MM/yyyy')) as NgayLap "
                    + ",'PC02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) as MaPhieu "
                    + ",SoTien "
                    + ",LyDo "
                    + ",TenNguoiNhan "
                    + ",DiaChi "
                    + ",TenNhanVien "
                    + ",ChungTyKemTheo "
                    + "from tbPhieuChi,tbCuaHang,tbNhanVien "
                    + "where tbCuaHang.id = tbPhieuChi.idCuaHang and tbNhanVien.id = tbPhieuChi.idNhanVien ";

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
            _conn.CMD.CommandText = String.Format("select id from tbPhieuChi where 'PC02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) = '{0}'", maPhieu);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public bool DeleteData(string maPhieu)
        {
            _conn.CMD.CommandText = String.Format("delete tbPhieuChi where 'PC02/' + REPLACE(STR(SoPhieu, 5), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) = '{0}'", maPhieu);
            return _conn.ExecuteCMD();
        }

        public DataTable GetPhieuChiById(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbPhieuChi where id = '{0}'", id);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsPhieuChi phieuChi)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbPhieuChi] (idNhanVien,TenNguoiNhan,DiaChi,LyDo,SoTien,"
                + "ChungTyKemTheo,idCuaHang,SoPhieu,NgayLap)  "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',cast('{8}' as datetime))"
            , phieuChi.IdNhanVien
            , phieuChi.TenNguoiNhan
            , phieuChi.DiaChi
            , phieuChi.LyDo
            , phieuChi.SoTien
            , phieuChi.ChungTyKemTheo
            , phieuChi.IdCuaHang
            , phieuChi.SoPhieu
            , phieuChi.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF"));
            return _conn.ExecuteCMD();
        }

        public bool UpdateData(clsPhieuChi phieuChi)
        {
            _conn.CMD.CommandText = String.Format("Update  tbPhieuChi set idNhanVien = N'{0}',TenNguoiNhan = N'{1}' ,DiaChi = N'{2}'," +
                " LyDo = N'{3}',SoTien = N'{4}',ChungTyKemTheo = N'{5}',idCuaHang = N'{6}',SoPhieu = N'{7}',NgayLap = N'{8}' where id = '{9}'"
           , phieuChi.IdNhanVien
           , phieuChi.TenNguoiNhan
           , phieuChi.DiaChi
           , phieuChi.LyDo
           , phieuChi.SoTien
           , phieuChi.ChungTyKemTheo
           , phieuChi.IdCuaHang
           , phieuChi.SoPhieu
           , phieuChi.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF")
           , phieuChi.Id);
            return _conn.ExecuteCMD();
        }
    }
}

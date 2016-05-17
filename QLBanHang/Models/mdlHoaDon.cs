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

        public decimal GenerateNewSoHoaDon(string date)
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


        public DataTable TimKiemHoaDon()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText =
                 "select ch.TenCuaHang,CONVERT(nvarchar(10),FORMAT(hd.NgayLap,'dd/MM/yyyy')) as NgayLap "
                + ",'IV02' + REPLACE(STR(SoHoaDon, 5), SPACE(1), '0') + CONVERT(nvarchar(8),FORMAT(hd.NgayLap,'ddMMyyyy'))  as MaHoaDon "
                + ",nv.TenNhanVien,hd.ChietKhau,hd.SoTienKhachDua "
                + ",ISNULL((SELECT SoTien FROM  dbo.tbThuNoKhachHang AS tn "
                + "WHERE (idHoaDon = hd.id)), 0) AS SoTienThanhToan "
                + "FROM    dbo.tbHoaDon AS hd INNER JOIN "
                + "dbo.tbNhanVien AS nv ON hd.idNhanVien = nv.id INNER JOIN "
                + "dbo.tbKhachHang AS kh ON hd.idKhachHang = kh.id INNER JOIN "
                + "dbo.tbCuaHang AS ch ON hd.idCuaHang = ch.id ";
            _conn.FillData(table);
            return table;
        }


        public decimal GetIdHoaDon()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbHoaDon");
            _conn.FillData(table);
            return Convert.ToDecimal(table.Rows[0]["ID"].ToString());
        }

        public decimal GetIdHoaDon(string maHoaDon)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as ID from tbHoaDon where 'IV02'+REPLACE(STR(SoHoaDon, 5), SPACE(1), '0') +"
                + " CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) ='{0}'", maHoaDon);
            _conn.FillData(table);
            return Convert.ToDecimal(table.Rows[0]["ID"].ToString());
        }

        public string GetMaHoaDonById(decimal Id)
        { 
            
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select 'IV02' + REPLACE(STR(SoHoaDon, 5), SPACE(1), '0') "
                + "+ CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) as MaHoaDon from tbHoaDon where id ='{0}'", Id);
            _conn.FillData(table);
            return table.Rows[0]["MaHoaDon"].ToString();
        }

        string Search = String.Format("select TenCuaHang,CONVERT(nvarchar(10),FORMAT(NgayLap,'dd/MM/yyyy')) as NgayLap, "
                + "'IV02' + REPLACE(STR(SoHoaDon, 5), SPACE(1), '0') + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy'))  as MaHoaDon "
                + ",TongTienVAT,ChietKhau,TongTien,TongTienSauChietKhau as TongTienCuoi,TongTienPhieuQuaTang as TongTienPQT "
                + ",SoTienThanhToan,TongVon,(TongTien-TongVon) as LoiNhuan "
                + ",TenKhachHang,TenNhanVien,SiLe "
                 + "from vwHoaDon ");


        public DataTable ThongKeHoaDon(DateTime fromDate, DateTime toDate, int idKhachHang, int idCuaHang, int idNhanVien,LoaiHoaDon loaiHoaDon)
        {
            DataTable table = new DataTable();//Create template table to get data from database
        
            string SearchString = Search + String.Format("where	cast(NgayLap as datetime) between '{0}' and '{1}' "
                , fromDate.ToString("MM-dd-yyyy"), toDate.ToString("MM-dd-yyyy"));
            if (idKhachHang != 0)
            {
                SearchString += String.Format("and idKhachHang = '{0}' ", idKhachHang);
            }

            if (idCuaHang != 0)
            {
                SearchString += String.Format("and idCuaHang = '{0}' ", idCuaHang);
            }

            if (idNhanVien != 0)
            {
                SearchString += String.Format("and idNhanVien = '{0}' ", idNhanVien);
            }

            switch (loaiHoaDon)
            {
                case LoaiHoaDon.TatCa:
                    break;
                case LoaiHoaDon.BanLe:
                    SearchString += String.Format("and SiLe = '{0}' ",0);
                    break;
                case LoaiHoaDon.BanSi:
                    SearchString += String.Format("and SiLe = '{0}' ", 1);
                    break;
            }

            _conn.CMD.CommandText = SearchString;
            _conn.FillData(table);
            return table;
        }
    }
}

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
    class mdlCuaHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,MaCuaHang,TenCuaHang,NguoiQuanLy,SoDienThoai,DiaChiCuaHang,TenCuaHangTrenBill,ThongTinLienHeTrenBill "
                                    +"from tbCuaHang";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetCuaHangByCode(string maCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbCuaHang where tbCuaHang.MaCuaHang = '{0}'", maCuaHang);
            _conn.FillData(table);
            return table;
        }

        public DataTable GetTenCuaHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TenCuaHang from tbCuaHang ");
            _conn.FillData(table);
            return table;
        }

        public DataTable GetIdCuaHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbCuaHang ");
            _conn.FillData(table);
            return table;
        }

        public DataTable GetCuaHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id,MaCuaHang + '/' + TenCuaHang as TenCuaHang from tbCuaHang ");
            _conn.FillData(table);
            return table;
        }

        public int GetIdCuaHangByCode(string maCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as id from tbCuaHang where tbCuaHang.MaCuaHang = N'{0}'", maCuaHang);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public int GetIdCuaHangByTen(string tenCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as id from tbCuaHang where tbCuaHang.TenCuaHang = '{0}'", tenCuaHang);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public bool AddData(clsCuaHang cuaHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbCuaHang] (TenCuaHang,DiaChiCuaHang,NguoiQuanLy,SoDienThoai,TenCuaHangTrenBill"
                +",ThongTinLienHeTrenBill,MaCuaHang)  " 
                + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')"
                , cuaHang.TenCuaHang,cuaHang.DiaChiCuaHang,cuaHang.NguoiQuanLy,cuaHang.SoDienThoai,cuaHang.TenCuaHangTrenBill,
                cuaHang.ThongTinLienHeTrenBill,cuaHang.MaCuaHang);
            return _conn.ExecuteCMD();
        }


        public bool IsExist(string maCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbCuaHang where [tbCuaHang].[MaCuaHang] = '{0}'", maCuaHang);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateData(clsCuaHang cuaHang)
        {
            _conn.CMD.CommandText = String.Format("Update  tbCuaHang set TenCuaHang = N'{0}',DiaChiCuaHang = N'{1}' ,NguoiQuanLy = N'{2}'," +
                " SoDienThoai = N'{3}',TenCuaHangTrenBill = N'{4}',ThongTinLienHeTrenBill = N'{5}',"
                + "MaCuaHang = N'{6}' where id = '{7}'"
                , cuaHang.TenCuaHang, cuaHang.DiaChiCuaHang, cuaHang.NguoiQuanLy, cuaHang.SoDienThoai, cuaHang.TenCuaHangTrenBill,
                cuaHang.ThongTinLienHeTrenBill, cuaHang.MaCuaHang,cuaHang.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(int idCuaHang)
        {
            _conn.CMD.CommandText = "delete tbCuaHang where id = '" + idCuaHang + "'";
            return _conn.ExecuteCMD();
        }

        public string GetTenCuaHangById(int idCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TenCuaHang  from tbCuaHang where tbCuaHang.id = '{0}'", idCuaHang);
            _conn.FillData(table);
            return table.Rows[0]["TenCuaHang"].ToString();
        }

        public int GetMaxIdCuaHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as id  from tbCuaHang");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }
    }
}

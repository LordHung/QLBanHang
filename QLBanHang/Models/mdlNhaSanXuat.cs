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
    class mdlNhaSanXuat
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,MaNhaSanXuat, TenNhaSanXuat,DiaChi ,GhiChu from tbNhaSanXuat";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetNhaSanXuatByCode(string maNhaSanXuat)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNhaSanXuat where [tbNhaSanXuat].[MaNhaSanXuat] = '{0}'", maNhaSanXuat);
            _conn.FillData(table);
            return table;
        }

        public string GetMaNhaSanXuatById(int idNhaSanXuat)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MaNhaSanXuat from tbNhaSanXuat where [tbNhaSanXuat].[id] = '{0}'", idNhaSanXuat);
            _conn.FillData(table);
            return table.Rows[0]["MaNhaSanXuat"].ToString();
        }

        public string GetMaNhaSanXuat(int idNhaSanXuat)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MaNhaSanXuat from tbNhaSanXuat where id = '{0}'", idNhaSanXuat);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["MaNhaSanXuat"].ToString();
            else return null;
        }

        public DataTable GetNhaSanXuat()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id,TenNhaSanXuat from tbNhaSanXuat");
            _conn.FillData(table);
            return table;
        }

        public int GetIdNhaSanXuat(string maNhaSanXuat)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbNhaSanXuat where MaNhaSanXuat = '{0}'", maNhaSanXuat);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }


        public bool AddData(clsNhaSanXuat nhaSanXuat)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbNhaSanXuat] ([MaNhaSanXuat],[TenNhaSanXuat],[DiaChi],[GhiChu]) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')"
                , nhaSanXuat.MaNhaSanXuat, nhaSanXuat.TenNhaSanXuat, nhaSanXuat.DiaChi, nhaSanXuat.GhiChu);
            return _conn.ExecuteCMD();
        }

        public bool IsExist(string maNhaSanXuat)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNhaSanXuat where [tbNhaSanXuat].[MaNhaSanXuat] = '{0}'", maNhaSanXuat);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateData(clsNhaSanXuat nhaSanXuat)
        {
            _conn.CMD.CommandText = String.Format("Update  tbNhaSanXuat set MaNhaSanXuat = N'{0}',TenNhaSanXuat = N'{1}' ,DiaChi = N'{2}'," +
                " GhiChu = N'{3}' where id = '{4}'"
                , nhaSanXuat.MaNhaSanXuat,nhaSanXuat.TenNhaSanXuat,nhaSanXuat.DiaChi,nhaSanXuat.GhiChu,nhaSanXuat.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(int idNhaSanXuat)
        {
            _conn.CMD.CommandText = "delete tbNhaSanXuat where id = '" + idNhaSanXuat + "'";
            return _conn.ExecuteCMD();
        }
    }
}

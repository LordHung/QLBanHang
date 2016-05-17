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
    class mdlLoaiKhachHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,LoaiThe,MoTa,TiTeQuyDoiDiem,NguongQuyDoi from [tbLoaiKhachHang]";
            _conn.FillData(table);
            return table;
        }

        public bool IsExist(string loaiThe)
        {
            DataTable table = new DataTable();
            _conn.CMD.CommandText = String.Format("select id from tbLoaiKhachHang where tbLoaiKhachHang.LoaiThe = N'{0}'", loaiThe);
            _conn.FillData(table);
            return (table.Rows.Count > 0);
        }

        public DataTable GetLoaiKhachHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,LoaiThe from tbLoaiKhachHang";
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsLoaiKhachHang loaiKhachHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbLoaiKhachHang] (LoaiThe,MoTa,TiTeQuyDoiDiem,NguongQuyDoi) VALUES (N'{0}',N'{1}','{2}','{3}')"
                , loaiKhachHang.LoaiThe, loaiKhachHang.MoTa, loaiKhachHang.TiLeQuyDoiDiem, loaiKhachHang.NguongQuyDoi);
            return _conn.ExecuteCMD();
        }

        public bool UpdateData(clsLoaiKhachHang loaiKhachHang)
        {
            _conn.CMD.CommandText = String.Format("UPDATE [dbo].[tbLoaiKhachHang] set LoaiThe = N'{0}',MoTa= N'{1}',"
                + "TiTeQuyDoiDiem = '{2}',NguongQuyDoi = '{3}' where id ='{4}'" 
                , loaiKhachHang.LoaiThe, loaiKhachHang.MoTa, 
                loaiKhachHang.TiLeQuyDoiDiem, loaiKhachHang.NguongQuyDoi
                ,loaiKhachHang.Id);
            return _conn.ExecuteCMD();
        }

        public int GetIdLoaiKhachHangByLoai(string loaiThe)
        {
            DataTable table = new DataTable();
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as id from tbLoaiKhachHang where tbLoaiKhachHang.LoaiThe = N'{0}'", loaiThe);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public bool DeleteData(int idLoaiKhachHang)
        {
            _conn.CMD.CommandText = String.Format("delete tbLoaiKhachHang where id = '{0}'", idLoaiKhachHang);
            return _conn.ExecuteCMD();
        }

        public string GetLoaiKhachHangById(int idLoaiKhachHang)
        {
            DataTable table = new DataTable();
            _conn.CMD.CommandText = String.Format("select LoaiThe from tbLoaiKhachHang where id = '{0}'",idLoaiKhachHang);
            _conn.FillData(table);
            return table.Rows[0]["LoaiThe"].ToString();
        }

    }
}

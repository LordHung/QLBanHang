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
    class mdlNhanVien
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select * from tbNhanVien";
            _conn.FillData(table);
            return table;
        }


        public int GetIdNhanVien(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbNhanVien where tbNhanVien.TenDangNhap = '{0}'", tenDangNhap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["id"].ToString());
            else return 0;
        }

        public string GetTenNhaVienById(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TenNhanVien from tbNhanVien where tbNhanVien.id = '{0}'", id);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["TenNhanVien"].ToString();
            else return null;
        }

        public string GetMatKhauNhanVien(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MatKhau from tbNhanVien where tbNhanVien.TenDangNhap = '{0}'", tenDangNhap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["MatKhau"].ToString();
            else return "";
        }

        public bool AddData(clsNhanVien nhanVien)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbNhanVien] (TenNhanVien,TenDangNhap,MatKhau,ChucVu,HopLe,idCuaHang,isToanQuyen) "
                +" VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')"
                , nhanVien.TenDangNhap,nhanVien.TenDangNhap,nhanVien.MatKhau,nhanVien.ChucVu,nhanVien.HopLe,nhanVien.IdCuaHang,nhanVien.IsToanQuyen);
            return _conn.ExecuteCMD();
        }


        public bool IsExist(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNhanVien where [tbNhanVien].[TenDangNhap] = '{0}'", tenDangNhap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateData(clsNhanVien nhanVien)
        {
            _conn.CMD.CommandText = String.Format("Update  tbNhanVien set TenNhanVien = N'{0}',TenDangNhap = N'{1}' ,MatKhau = N'{2}'," +
                " ChucVu = N'{3}',HopLe = N'{4}',idCuaHang = N'{5}',isToanQuyen = N'{6}' where id = '{7}'"
                , nhanVien.TenNhanVien,nhanVien.TenDangNhap,nhanVien.MatKhau,nhanVien.ChucVu,nhanVien.HopLe,nhanVien.IdCuaHang,
                nhanVien.IsToanQuyen,nhanVien.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(string tenDangNhap)
        {
            _conn.CMD.CommandText = "delete tbNhanVien where TenDangNhap = '" + tenDangNhap + "'";
            return _conn.ExecuteCMD();
        }
    }
}

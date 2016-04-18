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
    class mdlNhaCungCap
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select CodeNhaCungCap,TenNhaCungCap,CongNoDauKy,SoDienThoai,DiaChi from [tbNhaCungCap]";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetNhaCungCapByCode(string maNhaCungCap)
        {

            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNhaCungCap where [tbNhaCungCap].[CodeNhaCungCap] = '{0}'", maNhaCungCap);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsNhaCungCap nhaCungCap)
        {
            _conn.CMD.CommandText = String.Format("INSERT tbNhaCungCap (CodeNhaCungCap,TenNhaCungCap, DiaChi,SoDienThoai, CongNoDauKy,idCuaHang) " +
                "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                , nhaCungCap.CodeNhaCungCap,nhaCungCap.TenNhaCungCap,nhaCungCap.DiaChi,nhaCungCap.SoDienThoai, nhaCungCap.CongNoDauKy,9);
            return _conn.ExecuteCMD();
        }

        public bool IsExist(string maNhaCungCap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select CodeNhaCungCap from tbNhaCungCap where [tbNhaCungCap].[CodeNhaCungCap] = '{0}'", maNhaCungCap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }


        public bool UpdateData(clsNhaCungCap nhaCungCap)
        {
            _conn.CMD.CommandText = String.Format("Update  tbNhaCungCap set CodeNhaCungCap = N'{0}',TenNhaCungCap = N'{1}' ,CongNoDauKy = N'{2}'," +
              " SoDienThoai = N'{3}' ,DiaChi = N'{4}',idCuaHang = N'{5}' where id = '{6}'"
              , nhaCungCap.CodeNhaCungCap,nhaCungCap.TenNhaCungCap,nhaCungCap.CongNoDauKy,nhaCungCap.SoDienThoai,nhaCungCap.DiaChi,9,nhaCungCap.Id);
            return _conn.ExecuteCMD();
        }
    }
}

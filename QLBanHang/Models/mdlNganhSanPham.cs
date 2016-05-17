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
    class mdlNganhSanPham
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,MaNganhSanPham,TenNganhSanPham,MoTa from [tbNganhSanPham]";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetNganhSanPham()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select  id,MaNganhSanPham + '/' + TenNganhSanPham as NganhSanPham " +
                                        "from tbNganhSanPham ";
            _conn.FillData(table);
            return table;
        }


        public int GetIdNganhSanPham(string maNganh_tenNganh)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbNganhSanPham where MaNganhSanPham + '/' + TenNganhSanPham = '{0}'",maNganh_tenNganh);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public DataTable GetNganhSanPhamByCode(string code)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from [tbNganhSanPham] where [tbNganhSanPham].[MaNganhSanPham] = '{0}'", code);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsNganhSanPham nganhSanPham)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbNganhSanPham] ([MaNganhSanPham],[TenNganhSanPham],[MoTa]) VALUES (N'{0}',N'{1}',N'{2}')"
                , nganhSanPham.MaNganhSanPham, nganhSanPham.TenNganhSanPham, nganhSanPham.MoTa);
            return _conn.ExecuteCMD();
        }

        public bool IsExist(string maNganhSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNganhSanPham where [tbNganhSanPham].[MaNganhSanPham] = '{0}'", maNganhSanPham);
            _conn.FillData(table);
            return (table.Rows.Count > 0);
        }

        public bool UpdateData(clsNganhSanPham nganhSanPham)
        {
            _conn.CMD.CommandText = String.Format("Update  tbNganhSanPham set MaNganhSanPham = N'{0}',TenNganhSanPham = N'{1}' ," +
                " MoTa = N'{2}' where id = '{3}'"
                , nganhSanPham.MaNganhSanPham,nganhSanPham.TenNganhSanPham,nganhSanPham.MoTa,nganhSanPham.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(int idNganhSanPham)
        {
            _conn.CMD.CommandText = "delete tbNganhSanPham where id = '" + idNganhSanPham + "'";
            return _conn.ExecuteCMD();
        }

        public int GetIdNganhSanPhamByMa(string maNganhSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as id from tbNganhSanPham where [tbNganhSanPham].[MaNganhSanPham] = '{0}'", maNganhSanPham);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        public string GetMaNganhSanPhamById(int idNganhSanPham)
        {

            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MaNganhSanPham from tbNganhSanPham where [tbNganhSanPham].[id] = '{0}'", idNganhSanPham);
            _conn.FillData(table);
            return table.Rows[0]["MaNganhSanPham"].ToString();
        }
    }
}

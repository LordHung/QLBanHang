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
    class mdlSanPham
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "SELECT dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
			    +",tbSanPham.TenSanPham,tbNhaSanXuat.TenNhaSanXuat,MaLoaiSanPham + '/' + TenLoaiSanPham as LoaiSanPham,tbSanPham.DonVi,tbSanPham.MoTa "
                +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham "
                +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham ";
            _conn.FillData(table);
            return table;
        }

        public int GetIdSanPham(string code)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbSanPham,tbNhaSanXuat" +
                                    "where  dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') = '{0}' "+
                                    "and tbNhaSanXuat.id = tbSanPham.idNhaSanXuat",code);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["code"].ToString()) + 1;
        }

        public int GetNewMaSanPham()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(CodeSanPham) as code from tbSanPham");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["code"].ToString()) + 1;
        }

        public DataTable GetSanPhamByCode(string code)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT tbSanPham.CodeSanPham,tbSanPham.id,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
			    +",tbSanPham.TenSanPham,tbNhaSanXuat.TenNhaSanXuat,MaLoaiSanPham + '/' + TenLoaiSanPham as LoaiSanPham,tbSanPham.DonVi,tbSanPham.MoTa "
                +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham "
                +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham " 
                +"and dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') = '{0}'",code);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsSanPham sanPham)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbSanPham] (CodeSanPham,TenSanPham,DonVi,MoTa,idLoaiSanPham,idNhaSanXuat) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                , sanPham.CodeSanPham, sanPham.TenSanPham, sanPham.DonVi, sanPham.MoTa, sanPham.IdLoaiSanPham, sanPham.IdNhaSanXuat);
            return _conn.ExecuteCMD();
        }

        public bool IsExist(string maSanPham)// /// dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0')
                                                /// Mã sẩn phẩm hiển thị trên datagridview 
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbSanPham,tbNhaSanXuat" +
                                    "where  dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') = '{0}' " +   
		                            "and tbNhaSanXuat.id = tbSanPham.idNhaSanXuat",maSanPham);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateData(clsSanPham sanPham)
        {
            _conn.CMD.CommandText = String.Format("Update  tbSanPham set CodeSanPham = N'{0}',TenSanPham = N'{1}' ,DonVi = N'{2}'," +
                " MoTa = N'{3}',idLoaiSanPham = N'{4}',idNhaSanXuat = '{5}' where id = '{6}'"
                , sanPham.CodeSanPham,sanPham.TenSanPham,sanPham.DonVi,sanPham.MoTa,sanPham.IdLoaiSanPham,sanPham.IdNhaSanXuat,sanPham.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(string maSanPham)
        {
            _conn.CMD.CommandText =String.Format ("delete tbSanPham  where " +
            "dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') = '{0}' "
            + "and tbNhaSanXuat.id = tbSanPham.idNhaSanXuat",maSanPham);
            return _conn.ExecuteCMD();
        }

    }
}

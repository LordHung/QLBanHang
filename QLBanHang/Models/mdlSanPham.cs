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
            _conn.CMD.CommandText = "SELECT tbSanPham.id"
                +",dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
			    +",tbSanPham.TenSanPham,tbNhaSanXuat.TenNhaSanXuat,MaLoaiSanPham + '/' + TenLoaiSanPham as LoaiSanPham,tbSanPham.DonVi,tbSanPham.MoTa "
                +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham "
                +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham ";
            _conn.FillData(table);
            return table;
        }

        public string GenerateMaSanPham(string maNhaSanXuat,int CodeSanPham)
        {
            int length = CodeSanPham.ToString().Length;
            string tmp = "";
            for (int i = 0; i < 6 - length; i++)
            {
                tmp += "0";
            }
            return (maNhaSanXuat + tmp + CodeSanPham.ToString());
        }

        public int GetCodeSanPhamById(int idSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select CodeSanPham as CodeSanPham from tbSanPham where id = '{0}'",idSanPham);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["CodeSanPham"].ToString());
            else return 0;
        }

        public int GetIdSanPhamByCode(string code)
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
            return (table.Rows.Count > 0);
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
            "tbSanPham.idNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') = '{0}' ", maSanPham);
            return _conn.ExecuteCMD();
        }

        public bool DeleletDataById(int idSanPham)
        {
            _conn.CMD.CommandText = String.Format("delete tbSanPham  where " +
                     "id = '{0}' ", idSanPham);
            return _conn.ExecuteCMD();
        }

        public DataTable GetIdSanPham()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbSanPham");
            _conn.FillData(table);
            return table;
        }

        public int GetMaxIdSanPham()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as id from tbSanPham");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }
    }
}

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
    class mdlLoaiSanPham
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select  MaNganhSanPham + '/' + TenNganhSanPham as NganhSanPham ,MaLoaiSanPham,TenLoaiSanPham,tbLoaiSanPham.MoTa " + 
                                        "from tbLoaiSanPham,tbNganhSanPham where tbNganhSanPham.id = idNganhSanPham";
            _conn.FillData(table);
            return table;
        }

     

        public DataTable GetLoaiSanPham()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select  MaLoaiSanPham + '/' + TenLoaiSanPham as LoaiSanPham from tbLoaiSanPham";
            _conn.FillData(table);
            return table;
        }

        public int GetIdLoaiSanPham(string maLoaiSanPham_TenLoaiSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbLoaiSanPham where  MaLoaiSanPham + '/' + TenLoaiSanPham = '{0}'", maLoaiSanPham_TenLoaiSanPham);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["id"].ToString());
            else return 0;
        }

        public DataTable GetLoaiSanPhamByCode(string maLoaiSanPham)
        {

            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from [tbLoaiSanPham] where [tbLoaiSanPham].[MaLoaiSanPham] = '{0}'", maLoaiSanPham);
            _conn.FillData(table);
            return table;
        }


        public bool AddData(clsLoaiSanPham loaiSanPham)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbLoaiSanPham] (MaLoaiSanPham,TenLoaiSanPham,MoTa,idNganhSanPham) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')"
                , loaiSanPham.MaLoaiSanPham, loaiSanPham.TenLoaiSanPham, loaiSanPham.MoTa,loaiSanPham.IdNganhSanPham);
            return _conn.ExecuteCMD();
        }


        public bool IsExist(string maLoaiSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbLoaiSanPham where [tbLoaiSanPham].[MaLoaiSanPham] = '{0}'", maLoaiSanPham);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateData(clsLoaiSanPham loaiSanPham)
        {
            _conn.CMD.CommandText = String.Format("Update  tbLoaiSanPham set MaLoaiSanPham = N'{0}',TenLoaiSanPham = N'{1}' ,MoTa = N'{2}'," +
                " idNganhSanPham = N'{3}' where id = '{4}'"
                , loaiSanPham.MaLoaiSanPham,loaiSanPham.TenLoaiSanPham,loaiSanPham.MoTa,loaiSanPham.IdNganhSanPham,loaiSanPham.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(string maLoaiSanPham)
        {
            _conn.CMD.CommandText = "delete tbLoaiSanPham where MaLoaiSanPham = '" + maLoaiSanPham + "'";
            return _conn.ExecuteCMD();
        }
    }
}

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
    class mdlSanPhamCuaHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "SELECT dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
                + ",tbSanPham.TenSanPham,tbNhaSanXuat.TenNhaSanXuat,MaLoaiSanPham + '/' + TenLoaiSanPham as LoaiSanPham,tbSanPham.DonVi,tbSanPham.MoTa "
                + "from tbNhaSanXuat,tbSanPham,tbLoaiSanPham "
                + "where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham ";
            _conn.FillData(table);
            return table;
        }
    }
}

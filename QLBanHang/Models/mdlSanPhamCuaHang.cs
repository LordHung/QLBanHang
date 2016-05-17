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

        mdlSanPham _mdlSanPham = new mdlSanPham();

        mdlCuaHang _mdlCuaHang = new mdlCuaHang();

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

        public bool AddData(clsSanPhamCuaHang sanPhamCuaHang)
        { 
             _conn.CMD.CommandText = String.Format("INSERT tbSanPhamCuaHang (idCuaHang,idSanPham) VALUES('{0}','{1}')",
                 sanPhamCuaHang.IdCuaHang,sanPhamCuaHang.IdSanPham);
             return _conn.ExecuteCMD();
        }


        public bool AddSanPhamVaoCuaHang(int idCuaHang)
        {
            clsSanPhamCuaHang sanPhamCuaHang = new clsSanPhamCuaHang();
            sanPhamCuaHang.IdCuaHang = idCuaHang;
            DataTable table = _mdlSanPham.GetIdSanPham();
            foreach (DataRow row in table.Rows)
            {
                sanPhamCuaHang.IdSanPham = Convert.ToInt32(row["id"].ToString());
                if (!AddData(sanPhamCuaHang))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddCuaHangTheoSanPham(int idSanPham)
        {
            clsSanPhamCuaHang sanPhamCuaHang = new clsSanPhamCuaHang();
            sanPhamCuaHang.IdSanPham = idSanPham;
            DataTable table = _mdlCuaHang.GetIdCuaHang();
            foreach (DataRow row in table.Rows)
            {
                sanPhamCuaHang.IdCuaHang = Convert.ToInt32(row["id"].ToString());
                if (!AddData(sanPhamCuaHang))
                {
                    return false;
                }
            }
            return true;
        }

        public bool DeleteSanPhamTheoCuaHang(int idCuaHang)
        {
            _conn.CMD.CommandText = String.Format("delete tbSanPhamCuaHang where idCuaHang = '{0}')",idCuaHang);
            return _conn.ExecuteCMD();
        }
    }
}

﻿using System;
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
    class mdlMaVachSanPham
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData(int idCuaHang = 9,int idSanPham = 0)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT tbMaVachSanPham.id,tbMaVachSanPham.MaVach,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
	                                +",tbSanPham.TenSanPham,DonVi,SoLuong,GiaBan,GiaSi,GiaNhap,tbNhaSanXuat.TenNhaSanxuat,TenLoaiSanPham as LoaiSanPham,tbNganhSanPham.TenNganhSanPham,tbNhaCungCap.TenNhaCungCap "
                                    +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham,tbNganhSanPham,tbMaVachSanPham,tbSanPhamCuaHang,tbNhaCungCap "
                                    +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham and tbLoaiSanPham.idNganhSanPham = tbNganhSanPham.id "
	                                +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id and tbSanPham.id = tbSanPhamCuaHang.idSanPham and tbSanPhamCuaHang.idCuaHang = '{0}' "
	                                +"and tbMaVachSanPham.SuDung = '1' "
	                                +"and tbNhaCungCap.id = tbMaVachSanPham.idNhaCungCap ",idCuaHang);
            if (idSanPham != 0)
            {
                _conn.CMD.CommandText += String.Format("and idSanPham = '{0}' ",idSanPham);
            }
            _conn.FillData(table);
            return table;
        }

        public int GetIdByMaVach(string maVach)
        { 
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(id,0) as ID from tbMaVachSanPham where MaVach ='{0}'", maVach);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }

        public DataTable GetRowMaVachSanPham(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT tbMaVachSanPham.id,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
                                        + ",tbSanPham.TenSanPham,tbSanPham.DonVi,tbMaVachSanPham.SoLuong,tbMaVachSanPham.GiaBan,tbMaVachSanPham.GiaNhap,tbMaVachSanPham.VAT "
                                        +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham,tbNganhSanPham,tbMaVachSanPham,tbSanPhamCuaHang,tbNhaCungCap "
                                        +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham and tbLoaiSanPham.idNganhSanPham = tbNganhSanPham.id "
	                                    +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id and tbSanPham.id = tbSanPhamCuaHang.idSanPham and tbSanPhamCuaHang.idCuaHang = '9' "
	                                    +"and tbMaVachSanPham.SuDung = '1' "
	                                    +"and tbNhaCungCap.id = tbMaVachSanPham.idNhaCungCap "
	                                    +"and tbMaVachSanPham.id = '{0}' ",id);
            _conn.FillData(table);
            return table;
        }


        public bool GiamSoLuong(int id, int soLuong)
        {
            _conn.CMD.CommandText = String.Format("Update  tbMaVachSanPham set SoLuong = SoLuong - {0} " +
                "where id = '{1}'"
                ,soLuong,id);
            return _conn.ExecuteCMD();
        }

        public bool TangSoLuong(int id, int soLuong)
        {
            _conn.CMD.CommandText = String.Format("Update  tbMaVachSanPham set SoLuong = SoLuong + {0} " +
                "where id = '{1}'"
                , soLuong, id);
            return _conn.ExecuteCMD();
        }

        /// 
        /// Bán lẽ 
        ///

        public int GetGiaVonBanLe(int id,int soLuong)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select  {0}*GiaNhap as GN from  tbMaVachSanPham " +
               "where id = '{1}'"
               , soLuong,id);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["GN"].ToString());
        }
        //("select  {0}*Round(GiaNhap,-2) as GN from  tbMaVachSanPham 

    }
}

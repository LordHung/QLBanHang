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
    class mdlDonDatHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public int GenerateNewDonDatHang(string date)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(max(SoDonDatHang) + 1,1) as SoDDH from tbDonDatHang where cast(NgayLap as date)  = '{0}'", date);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["SoDDH"].ToString());
        }

        public DataTable GetDonDatHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select CONVERT(nvarchar(8),FORMAT(NgayLap,'dd-MM-yyyy'))"
                +", 'DH02/' +  REPLACE(STR(SoDonDatHang, 4), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) "
        + ",tbNhaCungCap.TenNhaCungCap,tbCuaHang.TenCuaHang,tbNhanVien.TenNhanVien,tbDonDatHang.GhiChu "
        +"from tbDonDatHang,tbNhaCungCap,tbCuaHang,tbNhanVien  "
        +"where tbDonDatHang.id not in(select distinct(isnull(idDonDatHang,0)) from tbPhieuNhap) and tbNhaCungCap.id = tbDonDatHang.idNhaCungCap "
		+"and tbNhanVien.id = tbDonDatHang.idNhanVien "
		+"and tbCuaHang.id = tbDonDatHang.idCuaHang");
            _conn.FillData(table);
            return table;
        }


        public int GetIdDonDatHangTheoSoDon(string maHoaDon)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select ISNULL(id,0) as id from tbDonDatHang where 'DH02/' +  REPLACE(STR(SoDonDatHang, 4), SPACE(1), '0') + '/' + CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) = '{0}'", maHoaDon);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["id"].ToString());
        }


        public string GetMaDonDatHangById(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select 'DH02/' +  REPLACE(STR(SoDonDatHang, 4), SPACE(1), '0') + '/' "
                +"+ CONVERT(nvarchar(8),FORMAT(NgayLap,'ddMMyyyy')) as MaDonDatHang from tbDonDatHang where id = '{0}'", id);
            _conn.FillData(table);
            return table.Rows[0]["MaDonDatHang"].ToString();
        }


        public bool AddData(clsDonDatHang donDatHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbDonDatHang] (SoDonDatHang,idCuaHang,idNhanVien,GhiChu,NgayLap,idNhaCungCap) "
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',cast(N'{4}' as datetime),N'{5}')"
                 ,donDatHang.SoDonDatHang, donDatHang.IdCuaHang, donDatHang.IdNhanVien, donDatHang.GhiChu
                 , donDatHang.NgayLap.ToString("yyyy-MM-dd hh:mm:ss.FFF"), donDatHang.IdNhaCungCap);
            return _conn.ExecuteCMD();
        }

        public int GetIdDonDatHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MAX(id) as ID from tbDonDatHang");
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }

    }
}

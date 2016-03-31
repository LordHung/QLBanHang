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
    class mdlKhachHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = " select tbCuaHang.TenCuaHang,MaKhachHang,TenKhachHang,GioiTinh,"
                                + " tbKhachHang.CongNoDauKy,DiaChi,DiemTichLuy,DiemTichLuyAll"
                                + " from tbCuaHang,tbKhachHang"
                                + " where tbCuaHang.id = tbKhachHang.idCuaHang";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetKhachHangByCode(string maKhachHang)
        {

            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from [tbKhachHang] where [tbKhachHang].[MaKhachHang] = '{0}'", maKhachHang);
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsKhachHang khachHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbKhachHang] "
                +"(MaKhachHang,TenKhachHang,DiaChi,SoDienThoai,Email,CongNoDauKy,NgayNhap,idCuaHang,GioiTinh,idLoaiKhachHang,DiemTichLuy,DiemTichLuyAll) "
                +"VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}')"
                , khachHang.MaKhachHang, khachHang.TenKhachHang, khachHang.DiaChi, khachHang.SoDienThoai, 
                khachHang.Email, khachHang.CongNoDauKi, khachHang.NgayNhap, khachHang.IdCuaHang, khachHang.GioiTinh,
                khachHang.IdLoaiKhachHang,khachHang.DiemTichLuy,khachHang.DiemTichLuyAll);
            return _conn.ExecuteCMD();
        }

    }
}

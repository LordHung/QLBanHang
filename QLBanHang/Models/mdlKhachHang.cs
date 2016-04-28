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

        /// <summary>
        /// Lấy ra tên khách hàng
        /// </summary>
        public DataTable GetTenKhachHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = " select TenKhachHang "
                                + " from tbCuaHang,tbKhachHang"
                                + " where tbCuaHang.id = tbKhachHang.idCuaHang";
            _conn.FillData(table);
            return table;
        }

        /// <summary>
        /// Lấy mã khách hàng + '/' +tên khách hàng VD:_VL/Vang lai
        /// </summary>
        /// <returns></returns>
        public DataTable GetKhachHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select MaKhachHang + '/' + TenKhachHang as KhachHang from tbKhachHang";
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// Lấy IDS
        /// </summary>
        public DataTable GetIdKhachHang()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select  id from tbKhachHang ";
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// Lấy hết dữ liệu về khách hàng
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Trả về khách hàng theo mã khách hàng
        /// </summary>
        public DataTable GetKhachHangByCode(string maKhachHang)
        {

            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from [tbKhachHang] where [tbKhachHang].[MaKhachHang] = '{0}'", maKhachHang);
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// Thêm khách hàng,CẦN SỬA DỔI DỮ LIỆU LIÊN QUAN ĐẾN IDCUAHANG
        /// </summary>
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

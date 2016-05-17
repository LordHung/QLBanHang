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
    class mdlNhanVien
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        /// <summary>
        /// lấy tất cả dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = " select tbNhanVien.id,tbCuaHang.MaCuaHang + '/' + tbCuaHang.TenCuaHang as TenCuaHang,"
                                + " TenNhanVien,TenDangNhap,MatKhau,HopLe,isToanQuyen,ChucVu"
                                + " from tbCuaHang,tbNhanVien"
                                + " where tbCuaHang.id = tbNhanVien.idCuaHang";
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// lấy id và tennhanvien
        /// </summary>
        /// <returns></returns>
        public DataTable GetNhanVien()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,TenNhanVien from tbNhanVien";
            _conn.FillData(table);
            return table;
        }
        /// <summary>
        /// lấy idnhanvien bằng TenDangNhap
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public int GetIdNhanVien(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select id from tbNhanVien where tbNhanVien.TenDangNhap = '{0}'", tenDangNhap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["id"].ToString());
            else return 0;
        }
        /// <summary>
        /// Lấy tennhanvien bằng id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetTenNhaVienById(int id)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TenNhanVien from tbNhanVien where tbNhanVien.id = '{0}'", id);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["TenNhanVien"].ToString();
            else return null;
        }
        /// <summary>
        /// Lấy mật khẩu bằng tên đăng nhập
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public string GetMatKhauNhanVien(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MatKhau from tbNhanVien where tbNhanVien.TenDangNhap = '{0}'", tenDangNhap);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["MatKhau"].ToString();
            else return "";
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool AddData(clsNhanVien nhanVien)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbNhanVien] (TenNhanVien,TenDangNhap,MatKhau,ChucVu,HopLe,idCuaHang,isToanQuyen) "
                +" VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')"
                , nhanVien.TenDangNhap,nhanVien.TenDangNhap,nhanVien.MatKhau,nhanVien.ChucVu,nhanVien.HopLe,nhanVien.IdCuaHang,nhanVien.IsToanQuyen);
            return _conn.ExecuteCMD();
        }

        /// <summary>
        /// Kiểm tra xem nhân viên đã có trong databse chưa
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public bool IsExist(string tenDangNhap)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbNhanVien where [tbNhanVien].[TenDangNhap] = '{0}'", tenDangNhap);
            _conn.FillData(table);
            return (table.Rows.Count > 0) ;
        }

        public bool UpdateData(clsNhanVien nhanVien)
        {
            _conn.CMD.CommandText = String.Format("Update  tbNhanVien set TenNhanVien = N'{0}',TenDangNhap = N'{1}' ,MatKhau = N'{2}'," +
                " ChucVu = N'{3}',HopLe = N'{4}',idCuaHang = N'{5}',isToanQuyen = N'{6}' where id = '{7}'"
                , nhanVien.TenNhanVien,nhanVien.TenDangNhap,nhanVien.MatKhau,nhanVien.ChucVu,nhanVien.HopLe,nhanVien.IdCuaHang,
                nhanVien.IsToanQuyen,nhanVien.Id);
            return _conn.ExecuteCMD();
        }

        public bool DeleteData(int idNhanVien)
        {
            _conn.CMD.CommandText = "delete tbNhanVien where id = '" + idNhanVien + "'";
            return _conn.ExecuteCMD();
        }

        public bool IsToanQuyen(int idNhanVien)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isToanQuyen from tbNhanVien where id ='{0}'", idNhanVien);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToBoolean(table.Rows[0]["isToanQuyen"].ToString());
            else return false ;
        }


        public string GetTenNhanVienById(int idNhanVien)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TenNhanVien from tbNhanVien where id ='{0}'", idNhanVien);
            _conn.FillData(table);
            return table.Rows[0]["TenNhanVien"].ToString();
        }
    }
}

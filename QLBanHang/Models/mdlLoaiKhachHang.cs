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
    class mdlLoaiKhachHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select LoaiThe,MoTa,TiTeQuyDoiDiem,NguongQuyDoi from [tbLoaiKhachHang]";
            _conn.FillData(table);
            return table;
        }

        public bool AddData(clsLoaiKhachHang loaiKhachHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbLoaiKhachHang] (LoaiThe,MoTa,TiLeQuyDoiDiem,NguongQuyDoi) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')"
                , loaiKhachHang.LoaiThe, loaiKhachHang.MoTa, loaiKhachHang.TiLeQuyDoiDiem, loaiKhachHang.NguongQuyDoi);
            return _conn.ExecuteCMD();
        }

        
    

    }
}

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
    class mdlPhanQuyen
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetQuyen(int idNhanVien)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbPhanQuyen where idNhanVien = '{0}'",idNhanVien);
            _conn.FillData(table);
            return table;
        }

        public bool GetTrangThai(int idNhanVien, int idQuyen)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select TrangThai from tbPhanQuyen where idQuyen = '{0}' and idNhanVien = '{1}'"
                , idQuyen, idNhanVien);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToBoolean(table.Rows[0]["TrangThai"].ToString());
            else return false;
        }

        public bool SetTrangThai(int idNhanVien, int idQuyen,bool trangThai)
        {
            _conn.CMD.CommandText = String.Format("update tbPhanQuyen set TrangThai = '{0}' where idQuyen = '{1}' and idNhanVien = '{2}' "
              ,trangThai,idQuyen,idNhanVien);
            return _conn.ExecuteCMD();
        }
    }
}

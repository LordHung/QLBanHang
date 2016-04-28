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
    class mdlLoaiPhieuNhap
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public DataTable GetLoaiPhieuNhap()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,LoaiPhieuNhap from tbLoaiPhieuNhap";
            _conn.FillData(table);
            return table;
        }
    }
}

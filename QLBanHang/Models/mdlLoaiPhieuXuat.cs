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
    class mdlLoaiPhieuXuat
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public DataTable GetLoaiPhieuXuat()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select id,LoaiPhieuXuat from tbLoaiPhieuXuat";
            _conn.FillData(table);
            return table;
        }
    }
}

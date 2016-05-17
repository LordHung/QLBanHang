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
    class mdlQuyen
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetQuyenCha()
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = "select * from tbQuyen where idQuyenCha is null";
            _conn.FillData(table);
            return table;
        }

        public DataTable GetSubQuyen(int idQuyenCha)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select * from tbQuyen where idQuyenCha = '{0}'", idQuyenCha);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table;
            else return null;
        }



    }
}

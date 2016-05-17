using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace QLBanHang.Controls
{
    class ImprovePerfomance
    {
        public static  void SetDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               control,
               new object[] { true });
        }

        public static void CellValueNeeded(object sender, DataGridViewCellValueEventArgs e,DataTable DT)
        {
            if (e.RowIndex >= DT.Rows.Count)
                return;

            if (e.ColumnIndex >= DT.Columns.Count)
                return;

            e.Value = DT.Rows[e.RowIndex][e.ColumnIndex];
        }
    }
}

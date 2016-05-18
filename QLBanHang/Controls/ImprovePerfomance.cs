using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Controls;
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

        public static  void RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e,Form frm)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, frm.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}

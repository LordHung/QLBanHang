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

namespace QLBanHang.Views
{
    public partial class FrmPhieuThuChiBase : Form
    {
        public FrmPhieuThuChiBase()
        {
            InitializeComponent();
            ImprovePerfomance.SetDoubleBuffering(this);
            ImprovePerfomance.SetDoubleBuffering(dgViewPhieu);
        }

        private void FrmQuanLyPhieuThuChiBase_Load(object sender, EventArgs e)
        {
            dgViewPhieu.Invalidate();
        }

        protected virtual void tSBtnThem_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tsBtnXoa_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tsBtnSua_Click(object sender, EventArgs e)
        {

        }

        protected void dgViewPhieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}

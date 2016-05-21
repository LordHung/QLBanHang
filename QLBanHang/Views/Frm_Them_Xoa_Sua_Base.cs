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
    public partial class Frm_Them_Xoa_Sua_Base : Form
    {
        public Frm_Them_Xoa_Sua_Base()
        {
            InitializeComponent();
            ImprovePerfomance.SetDoubleBuffering(dgView);
            ImprovePerfomance.SetDoubleBuffering(panel1);

            this.panel1.BackColor = GlobalValues.GlobalBackGroundColor;
            this.toolStrip1.BackColor = GlobalValues.GlobalBackGroundColor;
        }

        public enum DisplayFlag
        {
            Normal,
            Update
        }


        protected DisplayFlag _displayFlag = DisplayFlag.Normal;

        protected int index;

        protected void EnableItems()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.Normal:
                    panel1.Enabled = false;
                    tSBtnThem.Enabled = true;
                    tsBtnXoa.Enabled = true;
                    tsBtnLuu.Enabled = false;
                    break;
                case DisplayFlag.Update:
                    panel1.Enabled = true;
                    tSBtnThem.Enabled = false;
                    tsBtnXoa.Enabled = false;
                    tsBtnLuu.Enabled = true;
                    break;
            }
        }


        protected virtual void tSBtnThem_Click(object sender, EventArgs e)
        {
        }

        protected virtual void tsBtnXoa_Click(object sender, EventArgs e)
        {
        }

        protected virtual void tsBtnSua_Click(object sender, EventArgs e)
        {
            if (_displayFlag == DisplayFlag.Update)
                _displayFlag = DisplayFlag.Normal;
            else _displayFlag = DisplayFlag.Update;
            EnableItems();
        }


        protected virtual void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        protected virtual void tsBtnLuu_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.Normal;
            UpdateData();
            EnableItems();
            dgView.Invalidate();
        }

        protected virtual void UpdateData()
        {
 
        }

        protected virtual void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        protected virtual void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {

        }

        protected virtual void dgView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {

        }


    }
}

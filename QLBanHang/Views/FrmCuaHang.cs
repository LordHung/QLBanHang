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
using QLBanHang.Objects;
using QLBanHang.Views;

namespace QLBanHang.Views
{
    public partial class FrmCuaHang : Form
    {
        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        string _codeForUpdateDelete;

        public FrmCuaHang()
        {
            InitializeComponent();
            this.dgView.ContextMenuStrip = this.contextMenuStrip1;
        }

        /// <summary>
        /// Add data
        /// </summary>

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AddCuaHangDlg dlg = new AddCuaHangDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmCuaHang_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Update
        /// </summary>

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpdateCuaHangDlg dlg = new UpdateCuaHangDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmCuaHang_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Delete data
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_ctrlCuaHang.DeleteData(_codeForUpdateDelete))
                    MessageBox.Show(this, "Xóa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show(this, "Xóa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmCuaHang_Load(sender, e);
        }

        private void FrmCuaHang_Load(object sender, EventArgs e)
        {
            dgView.DataSource = _ctrlCuaHang.GetData();
        }

        /// </summary>
        private void dgView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgView.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dgView.ClearSelection();
                    dgView.Rows[hti.RowIndex].Selected = true;
                    dgView.CurrentCell = dgView.Rows[hti.RowIndex].Cells[0];
                }
            }
            _codeForUpdateDelete = dgView.CurrentCell.Value.ToString();
        }
    }
}

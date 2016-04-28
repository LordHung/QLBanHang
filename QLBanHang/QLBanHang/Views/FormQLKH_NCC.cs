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
    public partial class FormQLKH_NCC : Form
    {
        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        ctrlLoaiKhachHang _ctrlLoaiKhachHang = new ctrlLoaiKhachHang();

        DataTable _dataTable = new DataTable();

        private string _codeForUpdateDelete;

        enum DisplayFlag 
        {
            KhachHang,
            NhaCungCap,
            LoaiKhachHang,
            PhieuQuaTang,
            ThangHangThe,
        }

        private DisplayFlag _displayFlag = DisplayFlag.KhachHang;

        public FormQLKH_NCC()
        {
            InitializeComponent();
            dgView.ContextMenuStrip = contextMenuStrip1;
        }


        private void FormQLKH_NCC_Load(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.KhachHang:
                    LoadKhachHangDB();
                    break;
                case DisplayFlag.NhaCungCap:
                    LoadNhaCungCapDB();
                    break;
                case DisplayFlag.LoaiKhachHang:
                    LoadLoaiKhachHangDB();
                    break;
                default:
                    LoadKhachHangDB();
                    break;
            }

            dgView.DataSource = _dataTable;
        }

        private void LoadKhachHangDB()
        {
            _dataTable = _ctrlKhachHang.GetData();
        }

        private void LoadLoaiKhachHangDB()
        {
            _dataTable = _ctrlLoaiKhachHang.GetData();
        }

        private void LoadNhaCungCapDB()
        {
            _dataTable = _ctrlNhaCungCap.GetData();
        }


        /// 
        /// CHọn tùy chỉnh hiển thị
        /// 

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.KhachHang;
            FormQLKH_NCC_Load(sender, e);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhaCungCap;
            FormQLKH_NCC_Load(sender, e);
        }

        private void btnLoaiKhacHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.LoaiKhachHang;
            FormQLKH_NCC_Load(sender, e);
        }

        private void btnPhieuQuaTang_Click(object sender, EventArgs e)
        {

        }

        private void btnTangHangThe_Click(object sender, EventArgs e)
        {

        }

        /// 
        /// Thêm Dữ Liệu
        /// 

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaCungCap:
                    AddNhaCungCap(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void AddNhaCungCap(object sender, EventArgs e)
        {
            using (AddNhaCungCapDlg dlg = new AddNhaCungCapDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    FormQLKH_NCC_Load(sender, e);
            }
        }
      

        ///
        ///Chình sửa dữ liệu
        ///
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaCungCap:
                    UpdateNhaCungCap(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void UpdateNhaCungCap(object sender, EventArgs e)
        {
            using (UpdateNhaCungCapDlg dlg = new UpdateNhaCungCapDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    FormQLKH_NCC_Load(sender, e);
            }
        }


        ///
        ///Xóa Dữ Liệu
        ///
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


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

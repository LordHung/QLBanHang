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

namespace QLBanHang
{
    public partial class FormQuanLyBanHang : Form
    {
        /// <summary>
        /// NhaCungCap controller
        /// </summary>
        private ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        /// <summary>
        /// NhaSanXuat controller
        /// </summary>
        private ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();
        
        /// <summary>
        /// ctrlNganhSanPham
        /// </summary>
        private ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        /// <summary>
        /// ctrlLoadSanPham
        /// </summary>
        private ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        /// <summary>
        /// ctrlSanPham
        /// </summary>

        private ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        /// <summary>
        /// Datatable 
        /// </summary>
        private DataTable _dataTable = new DataTable();

        /// <summary>
        /// Dùng để update và delete dữ liệu
        /// </summary>
        private string _codeForUpdateDelete;
        /// <summary>
        /// Display Flag
        /// </summary>
        private enum DisplayFlag
        {
            NhaSanXuat,
            NganhHang,
            NhomHang,
            SanPham,
            DanhMucSP,
            InMaVach,
            LOGThayDoi,
        }

        private DisplayFlag _displayFlag = DisplayFlag.NhaSanXuat;

        /// <summary>
        /// Contructor
        /// </summary>
        public FormQuanLyBanHang()
        {
            InitializeComponent();
            dgView.ContextMenuStrip = contextMenuStrip1;
        }

        /// <summary>
        /// Thêm data
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NganhHang:
                    AddNganhSanPham(sender, e);
                    break;
                case DisplayFlag.NhaSanXuat:
                    AddNhaSanXuat(sender, e);
                    break;
                case DisplayFlag.NhomHang:
                    AddNhomHang(sender, e);
                    break;
                case DisplayFlag.SanPham:
                    AddSanPham(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void AddNhaSanXuat(object sender,EventArgs e)
        {
            using (AddNhaSanXuatDlg dlg = new AddNhaSanXuatDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void AddNganhSanPham(object sender, EventArgs e)
        {
            using (AddNganhSanPhamDlg dlg = new AddNganhSanPhamDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void AddNhomHang(object sender, EventArgs e)
        {
            using (AddNhomHangDlg dlg = new AddNhomHangDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void AddSanPham(object sender, EventArgs e)
        {
            using (AddSanPhamDlg dlg = new AddSanPhamDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

      


        /// <summary>
        /// Update data
        /// </summary>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NganhHang:
                    UpdateNganhSanPham(sender, e);
                    break;
                case DisplayFlag.NhaSanXuat:
                    UpdateNhaSanXuat(sender, e);
                    break;
                case DisplayFlag.NhomHang:
                    UpdateNhomHang(sender, e);
                    break;
                case DisplayFlag.SanPham:
                    UpdateSanPham(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void UpdateNhaSanXuat(object sender, EventArgs e)
        {
            using (UpdateNhaSanXuatDlg dlg = new UpdateNhaSanXuatDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void UpdateNganhSanPham(object sender, EventArgs e)
        {
            using (UpdateNganhSanPhamDlg dlg = new UpdateNganhSanPhamDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void UpdateNhomHang(object sender, EventArgs e)
        {
            using (UpdateNhomHangDlg dlg = new UpdateNhomHangDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        private void UpdateSanPham(object sender, EventArgs e)
        {
            using (UpdateSanPhamDlg dlg = new UpdateSanPhamDlg(_codeForUpdateDelete))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FrmQuanLySanPham_Load(sender, e);
                }
            }
        }

        /// <summary>
        /// Xóa data
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_ctrlNhaSanXuat.DeleteData(_codeForUpdateDelete))
                    MessageBox.Show(this, "Xóa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show(this, "Xóa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmQuanLySanPham_Load(sender, e);
        }


        private bool deleteData()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    return _ctrlNhaSanXuat.DeleteData(_codeForUpdateDelete);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Load Form
        /// </summary>
        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    LoadNhaSanXuatDB();
                    break;
                case DisplayFlag.NganhHang:
                    LoadNganhHangDB();
                    break;
                case DisplayFlag.NhomHang:
                    LoadNhomHangDB();
                    break;
                case DisplayFlag.SanPham:
                    LoadSanPhamDB();
                    break;
                default:
                    dgView.DataSource = _ctrlNhaCungCap.GetData();
                    break;
            }

            dgView.DataSource = _dataTable;
            //LoadSTT();
        }

        /// <summary>
        /// Thêm cột STT vào đầu datagridview 
        /// </summary>
        //private void LoadSTT()
        //{
        //    _dataTable.Columns.Add("STT");
        //    //for (int i = 0; i < _dataTable.Rows.Count; i++)
        //    //    _dataTable.Rows[i]["STT"] = i + 1;
          
        //    dgView.Columns["STT"].DisplayIndex = 0;
        //    dgView.Columns["STT"].SortMode = DataGridViewColumnSortMode.NotSortable;

        //}

        //private void dgView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    dgView.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        //}


        /// <summary>
        /// Button Click events,dùng để load dữ liệu
        /// </summary>
        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhaSanXuat;
            FrmQuanLySanPham_Load(sender, e);
        }

        private void btnNganhHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NganhHang;
            FrmQuanLySanPham_Load(sender, e);
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhomHang;
            FrmQuanLySanPham_Load(sender, e);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.SanPham;
            FrmQuanLySanPham_Load(sender, e);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.DanhMucSP;
            FrmQuanLySanPham_Load(sender, e);
        }

        private void btnInMaVach_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.InMaVach;
            FrmQuanLySanPham_Load(sender, e);
        }

        /// <summary>
        /// Load Data
        /// </summary>
        private void LoadNhaSanXuatDB()
        {
            _dataTable = _ctrlNhaSanXuat.GetData();
        }

        private void LoadNganhHangDB()
        {
            _dataTable = _ctrlNganhSanPham.GetData();
        }

        private void LoadNhomHangDB()
        {
            _dataTable = _ctrlLoaiSanPham.GetData();
        }

        private void LoadSanPhamDB()
        {
            _dataTable = _ctrlSanPham.GetData();
        }

        private void LoadDanhMucDB()
        { 
        }

        private void LoadInMaVachDB()
        { 
        }

        /// <summary>
        /// Chọn dòng khi click chuột phải hiển thị contextmenustrip
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
                    if (_displayFlag == DisplayFlag.NhomHang)
                        dgView.CurrentCell = dgView.Rows[hti.RowIndex].Cells[1];
                    else
                        dgView.CurrentCell = dgView.Rows[hti.RowIndex].Cells[0];
                }
            }
            _codeForUpdateDelete = dgView.CurrentCell.Value.ToString();
        }
        /// <summary>
        /// Lấy mã từ dòng được chọn
        /// </summary>
        private void GetDataByCell()
        {
            ///Gán mã được chọn từ dòng để update,delete
          
        }

    
    }
}

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
    public partial class FormQuanLyBanHang : Form,INhaSanXuatView,INganhSanPhamView,ISanPhamView,ILoaiSanPhamView
    {

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
            _ctrlNhaSanXuat.SetView(this);
            _ctrlNganhSanPham.SetView(this);
            _ctrlLoaiSanPham.SetView(this);
            _ctrlSanPham.SetView(this);
        }

        /// <summary>
        /// Thêm data
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NganhHang:
                    AddNganhSanPham();
                    break;
                case DisplayFlag.NhaSanXuat:
                    AddNhaSanXuat();
                    break;
                case DisplayFlag.NhomHang:
                    AddLoaiSanPham();
                    break;
                case DisplayFlag.SanPham:
                    AddSanPham();
                    break;
                default:
                    break;
            }
        }

        public void AddNhaSanXuat()
        {
            _ctrlNhaSanXuat.AddNhaSanXuatFromView();
        }

        public void AddNganhSanPham()
        {
            _ctrlNganhSanPham.AddNganhSanPhamFromView();
        }

        public void AddLoaiSanPham()
        {
            _ctrlLoaiSanPham.AddLoaiSanPhamFromView();
        }

        public void AddSanPham()
        {
            _ctrlSanPham.AddSanPhamFromView();
        }

      


        /// <summary>
        /// Update data
        /// </summary>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NganhHang:
                    UpdateNganhSanPham();
                    break;
                case DisplayFlag.NhaSanXuat:
                    UpdateNhaSanXuat();
                    break;
                case DisplayFlag.NhomHang:
                    UpdateLoaiSanPham();
                    break;
                case DisplayFlag.SanPham:
                    UpdateSanPham();
                    break;
                default:
                    break;
            }
        }

        public void UpdateNhaSanXuat()
        {
            _ctrlNhaSanXuat.UpdateNhaSanXuatFromView(_codeForUpdateDelete);
        }

        public void UpdateNganhSanPham()
        {
            _ctrlNganhSanPham.UpdateNganhSanPhamFromView(_codeForUpdateDelete);
        }

        public void UpdateLoaiSanPham()
        {
            _ctrlLoaiSanPham.UpdateLoaiSanPhamFromView(_codeForUpdateDelete);
        }

        public void UpdateSanPham()
        {
            _ctrlSanPham.UpdateSanPhamFromView(_codeForUpdateDelete);
        }

        /// <summary>
        /// Xóa data
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        public void DeleteNhaSanXuat()
        {
            _ctrlNhaSanXuat.DeleteNhaSanXuatFromView(_codeForUpdateDelete);
        }

        public void DeleteNganhSanPham()
        {
            _ctrlNganhSanPham.DeleteNganhSanPhamFromView(_codeForUpdateDelete);
        }

        public void DeleteLoaiSanPham()
        {
            _ctrlLoaiSanPham.DeleteLoaiSanPhamFromView(_codeForUpdateDelete);
        }

        public void DeleteSanPham()
        {
            _ctrlSanPham.DeleteSanPhamFromView(_codeForUpdateDelete);
        }

        public void deleteData()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    DeleteNhaSanXuat();
                    break;
                case DisplayFlag.NganhHang:
                    DeleteNganhSanPham();
                    break;
                case DisplayFlag.NhomHang:
                    DeleteLoaiSanPham();
                    break;
                case DisplayFlag.SanPham:
                    DeleteSanPham();
                    break;
                default:
                    break;
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
                    break;
            }
            ResetColorButtons();
            dgView.DataSource = _dataTable;
        }

        /// <summary>
        /// Button Click events,dùng để load dữ liệu
        /// </summary>
        /// 
        private void ResetColorButtons()
        {
            btnNhaSanXuat.BackColor = Color.LightCyan;

            btnNganhHang.BackColor = Color.LightCyan;

            btnNhomHang.BackColor = Color.LightCyan;

            btnSanPham.BackColor = Color.LightCyan;

            btnDanhMuc.BackColor = Color.LightCyan;

            btnInMaVach.BackColor = Color.LightCyan; 

            switch (_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    btnNhaSanXuat.BackColor = Color.Cyan;
                    break;
                case DisplayFlag.NganhHang:
                    btnNganhHang.BackColor = Color.Cyan;
                    break;
                case DisplayFlag.NhomHang:
                    btnNhomHang.BackColor = Color.Cyan; 
                    break;
                case DisplayFlag.SanPham:
                    btnSanPham.BackColor = Color.Cyan; 
                    break;
            }
        }


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

        ///
        /// UpdateView
        ///   
        public void  UpdateViewNhaSanXuat()
        {
            dgView.DataSource = _ctrlNhaSanXuat.GetData();
        }
        public void UpdateViewNganhSanPham()
        {
            dgView.DataSource = _ctrlNganhSanPham.GetData();
        }
        public void UpdateViewSanPham()
        {
            dgView.DataSource = _ctrlSanPham.GetData();
        }

        public void UpdateViewLoaiSanPham()
        {
            dgView.DataSource = _ctrlLoaiSanPham.GetData();
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
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
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

        private void tSBtnThem_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem.PerformClick();
        }

        private void tsBtnXoa_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.PerformClick();
        }

        private void tsBtnSua_Click(object sender, EventArgs e)
        {
            updateToolStripMenuItem.PerformClick();
        }
    }
}

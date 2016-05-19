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
using System.Collections;
using System.Threading;

namespace QLBanHang.Views
{
    public partial class FrmDanhMucSP : Form,ISanPhamView,IMaVachSanPhamView
    {

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        DataTable _sanPhamDT = new DataTable();

        int _idSanPham;

        /// 
        /// 
        /// 
        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        DataTable _maVachSanPhamDT = new DataTable();

        int _idMaVachSanPham;

        /// 
        /// SanPhamCuaHang
        /// 
        ctrlSanPhamCuaHang _ctrlSanPhamCuaHang = new ctrlSanPhamCuaHang();

        DataTable _sanPhamCuaHangDT = new DataTable();

        int _idSanPhamCuaHang;

        int _idCuaHang;

        public FrmDanhMucSP()
        {
            InitializeComponent();
            _ctrlSanPham.SetView(this);
            _ctrlMaVachSanPham.SetView(this);
            LoadSanPham();
            LoadSanPhamCuaHang();
            LoadMaVachSanPham();
        }
        ///
        /// SANPHAM
        ///
        private void LoadSanPham()
        {
            _sanPhamDT = _ctrlSanPham.GetData();
            dgViewSanPham.DataSource = _sanPhamDT;
            _idSanPham = Convert.ToInt32(dgViewSanPham.Rows[0].Cells[0].Value.ToString());
        }

        private void dgViewSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgViewSanPham.Columns["id"].Visible = false;

            dgViewSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgViewSanPham.Columns["MaSanPham"].DefaultCellStyle.ForeColor = Color.Red;

            dgViewSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgViewSanPham.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;


            dgViewSanPham.Columns["TenNhaSanXuat"].HeaderText = "Nhà Sản Xuất";
            dgViewSanPham.Columns["LoaiSanPham"].HeaderText = "Loại Sản Phẩm";
            dgViewSanPham.Columns["DonVi"].HeaderText = "Đơn Vị";
            dgViewSanPham.Columns["MoTa"].HeaderText = "Mô Tả";

            dgViewSanPham.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _sanPhamDT.Rows.Count)
                return;
            _idSanPham = Convert.ToInt32(dgViewSanPham.CurrentRow.Cells[0].Value.ToString());
            LoadSanPhamCuaHang();
            LoadMaVachSanPham();
            //dgViewMaVachSanPham.Invalidate();
        }


    
        ///
        ///SanPhamCuaHang
        ///

        private void LoadSanPhamCuaHang()
        {
            _sanPhamCuaHangDT = new DataTable();
            _sanPhamCuaHangDT = _ctrlSanPhamCuaHang.GetThongTinByIdSanPham(_idSanPham);

            dgViewSanPhamCuaHang.DataSource = _sanPhamCuaHangDT;

            _idSanPhamCuaHang = Convert.ToInt32(dgViewSanPhamCuaHang.Rows[0].Cells[0].Value.ToString());
            _idCuaHang = Convert.ToInt32(dgViewSanPhamCuaHang.Rows[0].Cells[1].Value.ToString());
        }        

        private void dgViewSanPhamCuaHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgViewSanPhamCuaHang.Columns["id"].Visible = false;
            dgViewSanPhamCuaHang.Columns["idCuaHang"].Visible = false;
        }


        private void dgViewSanPhamCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _sanPhamCuaHangDT.Rows.Count)
                return;
            _idSanPhamCuaHang = Convert.ToInt32(dgViewSanPhamCuaHang.CurrentRow.Cells[0].Value.ToString());
            _idCuaHang = Convert.ToInt32(dgViewSanPhamCuaHang.CurrentRow.Cells[1].Value.ToString());
            LoadMaVachSanPham();
            //dgViewMaVachSanPham.Invalidate();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            AddSanPhamDlg dlg = new AddSanPhamDlg(_ctrlSanPham);
            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.CenterParent;
            var dialogResult = dlg.ShowDialog();
        }

     
        /// <summary>
        /// MAVACHSANPHAM
        /// </summary>
        private void LoadMaVachSanPham()
        {
            _maVachSanPhamDT = new DataTable();
            _maVachSanPhamDT = _ctrlMaVachSanPham.GetData(_idCuaHang, _idSanPhamCuaHang);
            dgViewMaVachSanPham.DataSource = _maVachSanPhamDT;
            if (_maVachSanPhamDT.Rows.Count > 0)
            _idMaVachSanPham = Convert.ToInt32(dgViewMaVachSanPham.Rows[0].Cells[0].Value.ToString());
        }

        private void dgViewMaVachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _maVachSanPhamDT.Rows.Count)
                return;
            _idMaVachSanPham = Convert.ToInt32(dgViewMaVachSanPham.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgViewMaVachSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgViewMaVachSanPham.Columns["id"].Visible = false;



            dgViewMaVachSanPham.Columns["MaVach"].HeaderText = "Mã Vạch";
            dgViewMaVachSanPham.Columns["MaVach"].DefaultCellStyle.ForeColor = Color.Red;

            dgViewMaVachSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgViewMaVachSanPham.Columns["MaSanPham"].DefaultCellStyle.ForeColor = Color.Blue;

            dgViewMaVachSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgViewMaVachSanPham.Columns["TenSanPham"].Width = 150;

            dgViewMaVachSanPham.Columns["SoLuong"].HeaderText = "SL";
            dgViewMaVachSanPham.Columns["SoLuong"].Width = 150;

            dgViewMaVachSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgViewMaVachSanPham.Columns["GiaBan"].Width = 150;

            dgViewMaVachSanPham.Columns["GiaSi"].HeaderText = "Giá Sỉ";
            dgViewMaVachSanPham.Columns["GiaSi"].Width = 150;

            dgViewMaVachSanPham.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgViewMaVachSanPham.Columns["GiaNhap"].Width = 150;

            dgViewMaVachSanPham.Columns["TenNhaSanXuat"].HeaderText = "Tên Nhà Sản Xuất";
            dgViewMaVachSanPham.Columns["TenNhaSanXuat"].Width = 150;
            dgViewMaVachSanPham.Columns["LoaiSanPham"].HeaderText = "Loại Sản Phẩm";
            dgViewMaVachSanPham.Columns["LoaiSanPham"].Width = 150;
            dgViewMaVachSanPham.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgViewMaVachSanPham.Columns["TenNhaCungCap"].Width = 150;

        }



        public void UpdateView()
        {
            LoadSanPham();
        }

        public void UpdateMaVachSanPhamView()
        {
            LoadSanPhamCuaHang();
            LoadMaVachSanPham();
        }

        private void dgViewSanPham_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ImprovePerfomance.RowPostPaint(sender, e, this);
        }

        private void btnAddMaVach_Click(object sender, EventArgs e)
        {
            AddMaVachSanPhamDlg dlg = new AddMaVachSanPhamDlg(_ctrlMaVachSanPham,_idSanPham);
            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.CenterParent;
            var dialogResult = dlg.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMaVachSanPhamDlg dlg = new UpdateMaVachSanPhamDlg(_ctrlMaVachSanPham,_idMaVachSanPham);
            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.CenterParent;
            var dialogResult = dlg.ShowDialog();
        }


    }
}

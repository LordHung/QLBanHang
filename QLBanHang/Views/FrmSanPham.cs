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
    public partial class FrmSanPham : Frm_Them_Xoa_Sua_Base,ISanPhamView
    {
        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        clsSanPham _sanPham = new clsSanPham();

        DataTable _sanPhamDT = new DataTable();

        DataTable _nhaSanXuatDT = new DataTable();

        DataTable _loaiSanPhamDT = new DataTable();

        int _idSanPham;

        int _idNhaSanXuat;

        int _idLoaiSanPham;


        public FrmSanPham()
        {
            InitializeComponent();
            _ctrlSanPham.SetView(this);
        }



        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadNhaSanXuat();
            LoadLoaiSanPham();
            Binding();
            EnableItems();
        }
        //Sản phẩm
        private void LoadSanPham()
        {
            _sanPhamDT = _ctrlSanPham.GetData();
            dgView.DataSource = _sanPhamDT;
            dgView.Columns["id"].Visible = false;
            _idSanPham = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString());
            dgView.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }
        /// <summary>
        /// Nhà sản xuất
        /// </summary>
        private void LoadNhaSanXuat()
        {
            _nhaSanXuatDT = _ctrlNhaSanXuat.GetNhaSanXuat();

            cmbNhaSanXuat.DataSource = _nhaSanXuatDT;

            cmbNhaSanXuat.DisplayMember = "TenNhaSanXuat";

            ///LoadIdCuahang
            LoadIdNhaSanXuat();
        }

        private void LoadIdNhaSanXuat()
        {
            int index = cmbNhaSanXuat.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nhaSanXuatDT.Rows[index];//Lấy row tương ứng với index
                _idNhaSanXuat = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNhaSanXuat = 0;
        }

        private void cmbNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhaSanXuat();
            DisplayMaSanPham();
        }

        private void DisplayMaSanPham()
        {
            txtMaSanPham.Text = _ctrlSanPham.GenerateMaSanPham
                (_ctrlNhaSanXuat.GetMaNhaSanXuat(_idNhaSanXuat), _ctrlSanPham.GetCodeSanPhamById(_idSanPham));
            txtMaSanPham.Invalidate();
        }
        /// <summary>
        /// Loại sản phẩm
        /// </summary>
        private void LoadLoaiSanPham()
        {
            _loaiSanPhamDT = _ctrlLoaiSanPham.GetLoaiSanPham();

            cmbLoaiSanPham.DataSource = _loaiSanPhamDT;

            cmbLoaiSanPham.DisplayMember = "LoaiSanPham";

            ///LoadIdCuahang
            LoadIdLoaiSanPham();
        }

        private void LoadIdLoaiSanPham()
        {
            int index = cmbLoaiSanPham.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _loaiSanPhamDT.Rows[index];//Lấy row tương ứng với index
                _idLoaiSanPham = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idLoaiSanPham = 0;
        }

        private void cmbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdLoaiSanPham();
        }

        ///Binding
        private void Binding()
        {
            ///MaSanPham
            txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.Add("Text",dgView.DataSource,"MaSanPham");
            ///TenSanPham
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", dgView.DataSource, "TenSanPham");
            ///DonVI
            txtDonVi.DataBindings.Clear();
            txtDonVi.DataBindings.Add("Text", dgView.DataSource, "DonVi");
            ///MoTa
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgView.DataSource, "MoTa");
        }
        ////

        protected override void tsBtnLuu_Click(object sender, EventArgs e)
        {
            base.tsBtnLuu_Click(sender, e);
        }

        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            base.tsBtnSua_Click(sender, e);
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddSanPhamDlg dlg = new AddSanPhamDlg(_ctrlSanPham);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlSanPham.DeleteData(_idSanPham);
        }


        public void UpdateView()
        {
            LoadSanPham();
            LoadNhaSanXuat();
            LoadLoaiSanPham();
            dgView.Invalidate();
            if (index == _sanPhamDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            GetIdSanPham();
            Binding();
            EnableItems();
        }

        public void GetIdSanPham()
        {
            _idSanPham = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString());
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _sanPhamDT.Rows.Count)
                return;

            index = e.RowIndex;

            GetIdSanPham();

            BindingLoaiSanPham();

            BindingNhaSanXuat();

        }

        private void BindingNhaSanXuat()
        {
            foreach (DataRow row in _nhaSanXuatDT.Rows)
            {
                if (row["TenNhaSanXuat"].ToString() == dgView.SelectedRows[0].Cells[3].Value.ToString())
                {
                    cmbNhaSanXuat.SelectedIndex = _nhaSanXuatDT.Rows.IndexOf(row);
                    LoadIdNhaSanXuat();
                    cmbNhaSanXuat.Invalidate();
                    return;
                }
            }
        }

        private void BindingLoaiSanPham()
        {
            foreach (DataRow row in _loaiSanPhamDT.Rows)
            {
                if (row["LoaiSanPham"].ToString() == dgView.SelectedRows[0].Cells[4].Value.ToString())
                {

                    cmbLoaiSanPham.SelectedIndex = _loaiSanPhamDT.Rows.IndexOf(row);
                    LoadIdLoaiSanPham();
                    cmbLoaiSanPham.Invalidate();
                    return;
                }
            }
        }


        private bool AssignData()
        {
            string Error;
            //idSanPham
            _sanPham.Id = _idSanPham;
            ///CodeSanPham
            _sanPham.CodeSanPham = _ctrlSanPham.GetCodeSanPhamById(_idSanPham);
            //idNhaSanXuat
            _sanPham.IdNhaSanXuat = _idNhaSanXuat;
            //idLoaiSanPham
            _sanPham.IdLoaiSanPham = _idLoaiSanPham;

            //TenSanPham
            if (txtTenSanPham.Text.Trim().Length > 0)
            {
                _sanPham.TenSanPham = txtTenSanPham.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập tên sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //DonVi
            if (txtDonVi.Text.Trim().Length > 0)
            {
                _sanPham.DonVi = txtDonVi.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập đơn vị sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //MoTa
            _sanPham.MoTa = txtMoTa.Text.Trim();

            return true;
        }

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlSanPham.UpdateData(_sanPham);
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }
    
    }
}

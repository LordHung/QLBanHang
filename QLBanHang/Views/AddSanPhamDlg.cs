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
    public partial class AddSanPhamDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        clsSanPham _sanPham = new clsSanPham();

        DataTable _nhaSanXuatDT = new DataTable();

        DataTable _loaiSanPhamDT = new DataTable();

        int _idNhaSanXuat;

        int _idLoaiSanPham;

        public AddSanPhamDlg()
        {
            InitializeComponent();
            LoadData();
        }


        public AddSanPhamDlg(ctrlSanPham ctrl)
        {
            InitializeComponent();
            LoadData();
            _ctrlSanPham = ctrl;
        }

        private void LoadData()
        {
            _sanPham.CodeSanPham = _ctrlSanPham.GetNewMaSanPham();
            LoadLoaiSanPham();
            LoadNhaSanXuat();
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

        /// <summary>
        /// Loại sản phẩm
        /// </summary>
        private void LoadLoaiSanPham()
        {
            _loaiSanPhamDT = _ctrlLoaiSanPham.GetLoaiSanPham() ;

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

        /// <summary>
        /// 
        /// </summary>

        private void DisplayMaSanPham()
        {
            txtMaSanPham.Text = _ctrlSanPham.GenerateMaSanPham
                (_ctrlNhaSanXuat.GetMaNhaSanXuat(_idNhaSanXuat),_sanPham.CodeSanPham);
            txtMaSanPham.Invalidate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AssignData();
            _ctrlSanPham.AddData(_sanPham);
            
        }

        private bool AssignData()
        {
            string Error;
            
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
                MessageBox.Show(this,Error,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void AddSanPhamDlg_Load(object sender, EventArgs e)
        {
            //DisplayMaSanPham();
        }

        private void AddData()
        {
            if (AssignData())
            {
                _ctrlSanPham.AddData(_sanPham);
            }
        }
    }
}

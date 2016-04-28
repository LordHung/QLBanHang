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
    public partial class AddSanPhamDlg : Form
    {
        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        clsSanPham _sanPham = new clsSanPham();

        DataTable nhaSanXuatTable = new DataTable();

        DataTable loaiSanPhamTable = new DataTable();

        public AddSanPhamDlg()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _sanPham.CodeSanPham = _ctrlSanPham.GetNewMaSanPham();

            nhaSanXuatTable = _ctrlNhaSanXuat.GetNhaSanXuat();
            cmbNhaSanXuat.DataSource = nhaSanXuatTable;
            cmbNhaSanXuat.DisplayMember = "TenNhaSanXuat";

            loaiSanPhamTable = _ctrlLoaiSanPham.GetLoaiSanPham();
            cmbLoaiSanPham.DataSource = loaiSanPhamTable;
            cmbLoaiSanPham.DisplayMember = "LoaiSanPham";
        }

        private void DisplayMaSanPham()
        {
            string maNhaSanXuat = _ctrlNhaSanXuat.GetMaNhaSanXuat(cmbNhaSanXuat.Text);
            int length = _sanPham.CodeSanPham.ToString().Length;
            string tmp ="";
            for (int i = 0; i < 6 - length; i++)
            {
                tmp += "0";
            }
            txtMaSanPham.Text = maNhaSanXuat + tmp + _sanPham.CodeSanPham;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AssignData();
            _ctrlSanPham.AddData(_sanPham);
            
        }

        private void AssignData()
        {
            _sanPham.DonVi = txtDonVi.Text.Trim();
            _sanPham.IdNhaSanXuat = _ctrlNhaSanXuat.GetIdNhaSanXuat(cmbNhaSanXuat.Text);
            _sanPham.IdLoaiSanPham = _ctrlLoaiSanPham.GetIdLoaiSanPham(cmbLoaiSanPham.Text);
            _sanPham.MoTa = txtMoTa.Text.Trim();
            _sanPham.TenSanPham = txtTenSanPham.Text.Trim();
        }

        private void AddSanPhamDlg_Load(object sender, EventArgs e)
        {
            //DisplayMaSanPham();
        }

        private void cmbNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMaSanPham();
        }


    }
}

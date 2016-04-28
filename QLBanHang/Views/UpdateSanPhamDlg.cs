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
    public partial class UpdateSanPhamDlg : Form
    {
        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        clsSanPham _sanPham = new clsSanPham();

        DataTable nhaSanXuatTable = new DataTable();

        DataTable loaiSanPhamTable = new DataTable();

        /// <summary>
        /// Constructor
        /// </summary>
        public UpdateSanPhamDlg()
        {
            InitializeComponent();
        }

        public UpdateSanPhamDlg(string maSanPham)
        {
            InitializeComponent();
            LoadData(maSanPham);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void LoadData(string maSanPham)
        {
            ///Lấy dữ liệu từ database 
            DataRow row = _ctrlSanPham.GetSanPhamByCode(maSanPham).Rows[0];
            ///gửi id cho _nhaSanXuat
            _sanPham.Id = Convert.ToInt32(row["id"].ToString());
            _sanPham.CodeSanPham = Convert.ToInt32(row["CodeSanPham"].ToString());
            ///Gán dữ liệu vào textbox 
            txtMaSanPham.Text = maSanPham;
            txtDonVi.Text = row["DonVi"].ToString();
            txtMoTa.Text = row["MoTa"].ToString();
            txtTenSanPham.Text = row["TenSanPham"].ToString();


            nhaSanXuatTable = _ctrlNhaSanXuat.GetNhaSanXuat();
            cmbNhaSanXuat.DataSource = nhaSanXuatTable;
            cmbNhaSanXuat.DisplayMember = "TenNhaSanXuat";
            cmbNhaSanXuat.Text = row["TenNhaSanXuat"].ToString();

            loaiSanPhamTable = _ctrlLoaiSanPham.GetLoaiSanPham();
            cmbLoaiSanPham.DataSource = loaiSanPhamTable;
            cmbLoaiSanPham.DisplayMember = "LoaiSanPham";
            cmbLoaiSanPham.Text = row["LoaiSanPham"].ToString();
        }

        private void AssignData()
        {
            _sanPham.DonVi = txtDonVi.Text.Trim();
            _sanPham.IdNhaSanXuat = _ctrlNhaSanXuat.GetIdNhaSanXuat(cmbNhaSanXuat.Text);
            _sanPham.IdLoaiSanPham = _ctrlLoaiSanPham.GetIdLoaiSanPham(cmbLoaiSanPham.Text);
            _sanPham.MoTa = txtMoTa.Text.Trim();
            _sanPham.TenSanPham = txtTenSanPham.Text.Trim();
        }

        private void UpdateData()
        {
            AssignData();

           _ctrlSanPham.UpdateData(_sanPham);
        }

        private void DisplayMaSanPham()
        {
            string maNhaSanXuat = _ctrlNhaSanXuat.GetMaNhaSanXuat(cmbNhaSanXuat.Text);
            int length = _sanPham.CodeSanPham.ToString().Length;
            string tmp = "";
            for (int i = 0; i < 6 - length; i++)
            {
                tmp += "0";
            }
            txtMaSanPham.Text = maNhaSanXuat + tmp + _sanPham.CodeSanPham;
        }

        private void cmbNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMaSanPham();
        }
    }
}

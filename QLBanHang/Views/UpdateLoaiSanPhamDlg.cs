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
    public partial class UpdateLoaiSanPhamDlg : Form
    {
        public UpdateLoaiSanPhamDlg()
        {
            InitializeComponent();
        }

        public UpdateLoaiSanPhamDlg(string maLoaiSanPham)
        {
            InitializeComponent();
            LoadData(maLoaiSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsNganhSanPham _nganhSanPham = new clsNganhSanPham();

        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        clsLoaiSanPham _loaiSanPham = new clsLoaiSanPham();

        /// <summary>
        /// Lấy dữ liệu từ databse lên
        /// </summary>
        private void LoadData(string maLoaiSanPham)
        {
            ///Lấy dữ liệu từ database 
            DataRow row = _ctrlLoaiSanPham.GetLoaiSanPhamByCode(maLoaiSanPham).Rows[0];
            ///gửi id cho _nhaSanXuat
            _loaiSanPham.Id = Convert.ToInt32(row["id"].ToString());
            ///Gán dữ liệu vào textbox 
            txtMaLoai.Text = row["MaLoaiSanPham"].ToString();
            txtTenLoai.Text = row["TenLoaiSanPham"].ToString();
            txtMoTa.Text = row["MoTa"].ToString();
            cmbNganh.DataSource = _ctrlNganhSanPham.GetNganhSanPham().DefaultView;
            cmbNganh.DisplayMember = "NganhSanPham";
        }

        /// <summary>
        /// Click events
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// Gán dữ liệu từ textbox vào clsNganhSanPham
        /// </summary>
        private void AssignData()
        {
            _loaiSanPham.MaLoaiSanPham = txtMaLoai.Text.Trim();
            _loaiSanPham.TenLoaiSanPham = txtTenLoai.Text.Trim();
            _loaiSanPham.MoTa = txtMoTa.Text.Trim();
            _loaiSanPham.IdNganhSanPham = _ctrlNganhSanPham.GetIdNganhSanPham(cmbNganh.Text);
        }

        /// <summary>
        /// Cập nhập nhà sản xuất vào databse 
        /// </summary>
        private void UpdateData()
        {
            AssignData();
            _ctrlLoaiSanPham.UpdateData(_loaiSanPham);
        }

     
    }
}

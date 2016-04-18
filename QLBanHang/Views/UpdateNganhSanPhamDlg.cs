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
    public partial class UpdateNganhSanPhamDlg : Form
    {
        /// <summary>
        /// Constructor 
        /// </summary>
  
        public UpdateNganhSanPhamDlg()
        {
            InitializeComponent();
        }

        public UpdateNganhSanPhamDlg(string maNganhSanPham)
        {
            InitializeComponent();
            LoadData(maNganhSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsNganhSanPham _nganhSanPham = new clsNganhSanPham();

        /// <summary>
        /// Lấy dữ liệu từ databse lên
        /// </summary>
        private void LoadData(string maNganhSanPham)
        {
            ///Lấy dữ liệu từ database 
            DataRow row = _ctrlNganhSanPham.GetNganhSanPhamByCode(maNganhSanPham).Rows[0];
            ///gửi id cho _nhaSanXuat
            _nganhSanPham.Id = Convert.ToInt32(row["id"].ToString());
            ///Gán dữ liệu vào textbox 
            txtMaNganh.Text = row["MaNganhSanPham"].ToString();
            txtTenNganh.Text = row["TenNganhSanPham"].ToString();
            txtMoTa.Text = row["MoTa"].ToString();
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
            _nganhSanPham.MaNganhSanPham = txtMaNganh.Text.Trim();
            _nganhSanPham.TenNganhSanPham = txtTenNganh.Text.Trim();
            _nganhSanPham.MoTa = txtMoTa.Text.Trim();
        }

        /// <summary>
        /// Cập nhập nhà sản xuất vào databse 
        /// </summary>
        private void UpdateData()
        {
            AssignData();

            if (_ctrlNganhSanPham.UpdateData(_nganhSanPham))
            {
                MessageBox.Show(this, "Sửa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show(this, "Sửa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }   
    }
}

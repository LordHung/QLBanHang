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
    public partial class UpdateNhaSanXuatDlg : Form
    {

        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        clsNhaSanXuat _nhaSanXuat = new clsNhaSanXuat();
        /// <summary>
        /// Constructor 
        /// </summary>
        public UpdateNhaSanXuatDlg()
        {
            InitializeComponent();
        }

        public UpdateNhaSanXuatDlg(string maNhaSanXuat)
        {
            InitializeComponent();
            LoadData(maNhaSanXuat);
        }

        ///
        /// Lấy dữ liệu từ databse lên
        ///
        private void LoadData(string maNhaSanXuat)
        {
            ///Lấy dữ liệu từ database 
            DataRow row = _ctrlNhaSanXuat.GetNhaSanXuatByCode(maNhaSanXuat).Rows[0];
            ///gửi id cho _nhaSanXuat
            _nhaSanXuat.Id = Convert.ToInt32(row["id"].ToString());
            ///Gán dữ liệu vào textbox 
            txtMaNSX.Text = row["MaNhaSanXuat"].ToString();
            txtTenNSX.Text = row["TenNhaSanXuat"].ToString();
            txtGhiChu.Text = row["GhiChu"].ToString();
            txtDiaChi.Text = row["DiaChi"].ToString();
        }

        /// 
        /// Click events
        ///
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// 
        /// Gán dữ liệu từ textbox vào clsNhaSanXuat
        /// 
        private void AssignData()
        {
            _nhaSanXuat.MaNhaSanXuat = txtMaNSX.Text.Trim();
            _nhaSanXuat.TenNhaSanXuat = txtTenNSX.Text.Trim();
            _nhaSanXuat.DiaChi = txtDiaChi.Text.Trim();
            _nhaSanXuat.GhiChu = txtGhiChu.Text.Trim();
        }

        ///
        /// Cập nhập nhà sản xuất vào databse 
        ///
        private void UpdateData()
        {
            AssignData();

            if (_ctrlNhaSanXuat.UpdateData(_nhaSanXuat))
            {
                MessageBox.Show(this, "Sửa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show(this, "Sửa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

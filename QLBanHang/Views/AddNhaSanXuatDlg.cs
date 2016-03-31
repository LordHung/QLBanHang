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
    public partial class AddNhaSanXuatDlg : Form
    {
        public AddNhaSanXuatDlg()
        {
            InitializeComponent();
        }

        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        clsNhaSanXuat _nhaSanXuat = new clsNhaSanXuat();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNhaSanXuat = txtMaNSX.Text.Trim();
            ///Kiểm tra nhasanxuat đã có trong databse chưa?
            if (!_ctrlNhaSanXuat.IsExist(maNhaSanXuat))
            {
                AssignData();
                if (_ctrlNhaSanXuat.AddData(_nhaSanXuat))
                {
                    MessageBox.Show(this, "Thêm thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show(this, "Thêm thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(this, "Đã có trong databse ", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AssignData()
        {
            _nhaSanXuat.MaNhaSanXuat = txtMaNSX.Text.Trim();
            _nhaSanXuat.TenNhaSanXuat = txtTenNSX.Text.Trim();
            _nhaSanXuat.DiaChi = txtDiaChi.Text.Trim();
            _nhaSanXuat.GhiChu = txtGhiChu.Text.Trim();
        }
    }
}

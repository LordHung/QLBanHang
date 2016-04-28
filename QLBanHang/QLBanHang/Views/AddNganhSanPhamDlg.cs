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

namespace QLBanHang.Views
{
    public partial class AddNganhSanPhamDlg : Form
    {
        public AddNganhSanPhamDlg()
        {
            InitializeComponent();
        }

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsNganhSanPham _nganhSanPham = new clsNganhSanPham();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNganhSanPham = txtMaNganh.Text.Trim();
            ///Kiểm tra nhasanxuat đã có trong databse chưa?
            if (!_ctrlNganhSanPham.IsExist(maNganhSanPham))
            {
                AssignData();
                if (_ctrlNganhSanPham.AddData(_nganhSanPham))
                {
                    MessageBox.Show(this, "Thêm thành công", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show(this, "Thêm thất bại", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(this, "Đã có trong databse ", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AssignData()
        {
            _nganhSanPham.MaNganhSanPham = txtMaNganh.Text.Trim();
            _nganhSanPham.TenNganhSanPham = txtTenNganh.Text.Trim();
            _nganhSanPham.MoTa = txtMoTa.Text.Trim();
        }
    }
}

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
    public partial class AddNganhSanPhamDlg : Dlg_Them_Xoa_Sua_base
    {

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsNganhSanPham _nganhSanPham = new clsNganhSanPham();

        public AddNganhSanPhamDlg()
        {
            InitializeComponent();
        }

        public AddNganhSanPhamDlg(ctrlNganhSanPham ctrl)
        {
            InitializeComponent();
            _ctrlNganhSanPham = ctrl;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNganhSanPham = txtMaNganh.Text.Trim();
            ///Kiểm tra nhasanxuat đã có trong databse chưa?
            AssignData();
           _ctrlNganhSanPham.AddData(_nganhSanPham);
        }

        private bool AssignData()
        {
            string Error = "";
            ///MaNganhSanPham
            if (txtMaNganh.Text.Trim().Length > 0)
            {
                _nganhSanPham.MaNganhSanPham = txtMaNganh.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập mã ngành sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            ///TenNganhSanPham
            if (txtTenNganh.Text.Trim().Length > 0)
            {
                _nganhSanPham.TenNganhSanPham = txtTenNganh.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập tên ngành sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            ///MoTa
            _nganhSanPham.MoTa = txtMoTa.Text.Trim();
            return true;
        }
        private void AddData()
        {
            if (AssignData())
                _ctrlNganhSanPham.AddData(_nganhSanPham);
        }
    }
}

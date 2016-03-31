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
    public partial class AddNhomHangDlg : Form
    {
        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsLoaiSanPham _loaiSanPham = new clsLoaiSanPham();

        DataTable nganhTable = new DataTable();


        public AddNhomHangDlg()
        {
            InitializeComponent();
            nganhTable = _ctrlNganhSanPham.GetNganhSanPham();
            cmbNganh.DataSource = nganhTable.DefaultView;
            cmbNganh.DisplayMember = "NganhSanPham";
            //cmbNganh.DisplayMember = "MaLoaiSanPham";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLoaiSanPham = txtMaLoai.Text.Trim();
            ///Kiểm tra nhasanxuat đã có trong databse chưa?
            if (!_ctrlLoaiSanPham.IsExist(maLoaiSanPham))
            {
                AssignData();
                if (_ctrlLoaiSanPham.AddData(_loaiSanPham))
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
            _loaiSanPham.IdNganhSanPham = _ctrlNganhSanPham.GetIdNganhSanPham(cmbNganh.Text);
            _loaiSanPham.MaLoaiSanPham = txtMaLoai.Text.Trim();
            _loaiSanPham.TenLoaiSanPham = txtTenLoai.Text.Trim();
            _loaiSanPham.MoTa = txtMoTa.Text.Trim();
        }

    }
}

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
using System.Collections;
using System.Threading;

namespace QLBanHang.Views
{
    public partial class FrmDanhMucSP : Form
    {

        ctrlSanPham _ctrlSanPham = new ctrlSanPham();

        DataTable _sanPhamDT = new DataTable();

        int _idSanPham;

        public FrmDanhMucSP()
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            _sanPhamDT = _ctrlSanPham.GetData();
            dgViewSanPham.DataSource = _sanPhamDT;
            dgViewSanPham.Columns["id"].Visible = false;
            _idSanPham = Convert.ToInt32(dgViewSanPham.Rows[0].Cells[0].Value.ToString());
            dgViewSanPham.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgViewSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgViewSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgViewSanPham.Columns["MaSanPham"].DefaultCellStyle.ForeColor = Color.Red;

            dgViewSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgViewSanPham.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;


            dgViewSanPham.Columns["TenNhaSanXuat"].HeaderText = "Nhà Sản Xuất";
            dgViewSanPham.Columns["LoaiSanPham"].HeaderText = "Loại Sản Phẩm";
            dgViewSanPham.Columns["DonVi"].HeaderText = "Đơn Vị";
            dgViewSanPham.Columns["MoTa"].HeaderText = "Mô Tả";

        }

    }
}

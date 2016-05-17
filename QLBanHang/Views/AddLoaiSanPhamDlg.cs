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
    public partial class AddLoaiSanPhamDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsLoaiSanPham _loaiSanPham = new clsLoaiSanPham();

        DataTable _nganhSanPhamDT = new DataTable();

        int _idNganhSanPham;

        public AddLoaiSanPhamDlg()
        {
            InitializeComponent();
        }


        public AddLoaiSanPhamDlg(ctrlLoaiSanPham ctrl)
        {
            InitializeComponent();
            _ctrlLoaiSanPham = ctrl;
            LoadNganhSanPhamDT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private bool AssignData()
        {
            string Error;
            //idNganhSanPham
            _loaiSanPham.IdNganhSanPham = _idNganhSanPham;
            //MaloaiSanPham
            if (txtMaLoai.Text.Trim().Length > 0)
            {
                _loaiSanPham.MaLoaiSanPham = txtMaLoai.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập mã nhóm ngành!";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //TenLoaiSanPham
            if (txtTenLoai.Text.Trim().Length > 0)
            {
                _loaiSanPham.TenLoaiSanPham = txtTenLoai.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập tên nhóm ngành!";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //MoTa
            _loaiSanPham.MoTa = txtMoTa.Text.Trim();

            return true;
        }

        private void AddData()
        {
            if (AssignData())
                _ctrlLoaiSanPham.AddData(_loaiSanPham);
        }

        private void LoadNganhSanPhamDT()
        {
            _nganhSanPhamDT = _ctrlNganhSanPham.GetNganhSanPham();

            ///Hiển thị tên các cửa hàng lên combobox

            cmbNganh.DataSource = _nganhSanPhamDT;

            cmbNganh.DisplayMember = "NganhSanPham";

            ///LoadIdCuahang
            LoadIdNganhSanPham();
        }

        private void LoadIdNganhSanPham()
        {
            int index = cmbNganh.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nganhSanPhamDT.Rows[index];//Lấy row tương ứng với index
                _idNganhSanPham = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNganhSanPham = 0;
        }

        private void cmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNganhSanPham();
        }


    }
}

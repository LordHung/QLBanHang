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
    public partial class AddNhaSanXuatDlg : Dlg_Them_Xoa_Sua_base
    {

        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        clsNhaSanXuat _nhaSanXuat = new clsNhaSanXuat();

        public AddNhaSanXuatDlg()
        {
            InitializeComponent();
        }

        public AddNhaSanXuatDlg(ctrlNhaSanXuat ctrl)
        {
            InitializeComponent();
            _ctrlNhaSanXuat = ctrl;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private bool AssignData()
        {
            string Error = "";
            ///Ma
            //MaNSX
            if (txtMaNSX.Text.Trim().Length == 3)
            {
                _nhaSanXuat.MaNhaSanXuat = txtMaNSX.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập mã nhà sản xuất\n Định dạng theo 3 kí tự vd : 'NSX','001','I02'";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //TenNhaSanXuat
            if (txtTenNSX.Text.Trim().Length > 0)
            {
                _nhaSanXuat.TenNhaSanXuat = txtTenNSX.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập tên nhà sản xuất";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //DiaChiNhaSanXuat
            _nhaSanXuat.DiaChi = txtDiaChi.Text.Trim();
            //GhiChu
            _nhaSanXuat.GhiChu = txtGhiChu.Text.Trim();

            return true;
        }


        private void AddData()
        {
            if (AssignData())
                _ctrlNhaSanXuat.AddData(_nhaSanXuat);
        }
    }
}

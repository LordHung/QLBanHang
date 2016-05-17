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
    public partial class AddNhaCungCapDlg : Dlg_Them_Xoa_Sua_base
    {
        private clsNhaCungCap _nhaCungCap = new clsNhaCungCap();

        private ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        public AddNhaCungCapDlg()
        {
            InitializeComponent();
        }

        public AddNhaCungCapDlg(ctrlNhaCungCap ctrl)
        {
            InitializeComponent();
            _ctrlNhaCungCap = ctrl;
            LoadCongNo();
        }

        private void LoadCongNo()
        {
            txtCongNoDauKi.Text = "0";
            txtCongNo.Text = "0";
        }

        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            ///Ma
            if (txtCodeNhaCungCap.Text.Trim().Length > 0)
            {
                _nhaCungCap.CodeNhaCungCap = txtCodeNhaCungCap.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa nhập mã nhà cung cấp";
            }
            ///Ten
            if (txtTenNhaCungCap.Text.Trim().Length > 0)
            {
                _nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa nhập tên nhà cung cấp";
            }
            ///Cong No Dau Ky
            _nhaCungCap.CongNoDauKy = Convert.ToDecimal(txtCongNoDauKi.Text.Trim());
            ///SDT
            _nhaCungCap.SoDienThoai = txtSDT.Text.Trim();
            ///DiaChi
            _nhaCungCap.DiaChi = txtDiaChi.Text.Trim();
            ///idCuaHang
            _nhaCungCap.IDCuahang = 9;

            if (!Valid) MessageBox.Show(this,Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private void AddData()
        {
            if(AssignData())
             _ctrlNhaCungCap.AddData(_nhaCungCap);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void txtCongNoDauKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }

        private void AddNhaCungCapDlg_Load(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }

        private void txtCongNoDauKi_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void txtCongNo_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void txtCongNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }
    }
}

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
    public partial class AddNhaCungCapDlg : Form
    {
        public AddNhaCungCapDlg()
        {
            InitializeComponent();
        }

        private clsNhaCungCap _nhaCungCap = new clsNhaCungCap();

        private ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        private void AssignData()
        {
            _nhaCungCap.CodeNhaCungCap = txtCodeNhaCungCap.Text.Trim();
            _nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            if (txtCongNoDauKi.Text.Length == 0)
                _nhaCungCap.CongNoDauKy = 0;
            else
            _nhaCungCap.CongNoDauKy = Convert.ToDecimal(txtCongNoDauKi.Text.Trim());
            _nhaCungCap.SoDienThoai = txtSDT.Text.Trim();
            _nhaCungCap.DiaChi = txtDiaChi.Text.Trim();
            _nhaCungCap.IDCuahang = 9;
        }

        private void AddData()
        {
            AssignData();
            if (!_ctrlNhaCungCap.IsExist(_nhaCungCap.CodeNhaCungCap))
            {
                if (_ctrlNhaCungCap.AddData(_nhaCungCap))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Đã có nhà cung cấp trong databse ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

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
    public partial class UpdateNhaCungCapDlg : Form
    {
        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        clsNhaCungCap _nhaCungCap = new clsNhaCungCap();

        public UpdateNhaCungCapDlg()
        {
            InitializeComponent();
        }


        public UpdateNhaCungCapDlg(string maNhaCungCap)
        {
            InitializeComponent();
            LoadData(maNhaCungCap);
        }

        ///
        /// Lấy dữ liệu từ databse lên
        /// 
        private void LoadData(string maNhaCungCap)
        {
            //Lấy dữ liệu từ database
            DataRow row = _ctrlNhaCungCap.GetNhaCungCapByCode(maNhaCungCap).Rows[0];
            //Gửi id cho nhacungcap
            _nhaCungCap.Id = Convert.ToInt32(row["Id"].ToString());
            //Gán dữ liệu vào textbox 
            txtCodeNhaCungCap.Text = row["CodeNhaCungCap"].ToString();
            txtCongNoDauKi.Text = row["CongNoDauKy"].ToString();
            txtTenNhaCungCap.Text = row["TenNhaCungCap"].ToString();
            txtDiaChi.Text = row["DiaChi"].ToString();
            txtSDT.Text = row["SoDienThoai"].ToString();
        }

        /// 
        /// Gán dữ liệu từ textbox vào clsNhaCungCap
        /// 
        private void AssignData()
        {
            _nhaCungCap.CodeNhaCungCap = txtCodeNhaCungCap.Text.Trim();
            _nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            _nhaCungCap.DiaChi = txtDiaChi.Text.Trim();
            if (txtCongNoDauKi.Text.Length == 0)
                _nhaCungCap.CongNoDauKy = 0;
            else
                _nhaCungCap.CongNoDauKy = Convert.ToDecimal(txtCongNoDauKi.Text.Trim());
            _nhaCungCap.SoDienThoai = txtSDT.Text.Trim();
        }

        private void UpdateData()
        {
            AssignData();
            _ctrlNhaCungCap.UpdateData(_nhaCungCap);
    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }

        private void txtCongNoDauKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }
    }
}

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
    public partial class UpdateCuaHangDlg : Form
    {
        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        clsCuaHang _cuaHang = new clsCuaHang();

        public UpdateCuaHangDlg()
        {
            InitializeComponent();
        }

        public UpdateCuaHangDlg(string maCuaHang)
        {
            InitializeComponent();
            LoadData(maCuaHang);
        }

        private void LoadData(string maCuaHang)
        {
            DataRow row = _ctrlCuaHang.GetCuaHangByCode(maCuaHang).Rows[0];

            _cuaHang.Id = Convert.ToInt32(row["id"].ToString());

            txtMa.Text = maCuaHang;
            txtTen.Text = row["TenCuaHang"].ToString();
            txtSDT.Text = row["SoDienThoai"].ToString();
            txtQuanLy.Text = row["NguoiQuanLy"].ToString();
            txtDiaChi.Text = row["DiaChiCuaHang"].ToString();
            txtTenCuaHangTrenBill.Text = row["TenCuaHangTrenBill"].ToString();
            txtThongTinTrenBill.Text = row["ThongTinLienHeTrenBill"].ToString();

        }

        private void AssignData()
        {
            _cuaHang.MaCuaHang = txtMa.Text.Trim();
            _cuaHang.TenCuaHang = txtTen.Text.Trim();
            _cuaHang.NguoiQuanLy = txtQuanLy.Text.Trim();
            _cuaHang.DiaChiCuaHang = txtDiaChi.Text.Trim();
            _cuaHang.SoDienThoai = txtSDT.Text.Trim();
            _cuaHang.TenCuaHangTrenBill = txtTenCuaHangTrenBill.Text.Trim();
            _cuaHang.ThongTinLienHeTrenBill = txtThongTinTrenBill.Text.Trim();
            _cuaHang.LogoTrenBill = null;
        }

        private void UpdateData()
        {
            AssignData();
            if (_ctrlCuaHang.UpdateData(_cuaHang))
            {
                MessageBox.Show(this, "Sửa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(this, "Sửa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}

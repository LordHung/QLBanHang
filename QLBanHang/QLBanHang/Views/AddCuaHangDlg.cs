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
    public partial class AddCuaHangDlg : Form
    {
        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        clsCuaHang _cuaHang = new clsCuaHang();

        public AddCuaHangDlg()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();       
        }

        private void AddData()
        {
            ///Kiểm tra nhasanxuat đã có trong databse chưa?
            if (!_ctrlCuaHang.IsExist(_cuaHang.MaCuaHang))
            {
                AssignData();
                if (_ctrlCuaHang.AddData(_cuaHang))
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
            _cuaHang.MaCuaHang = txtMa.Text.Trim();
            _cuaHang.TenCuaHang = txtTen.Text.Trim();
            _cuaHang.NguoiQuanLy = txtQuanLy.Text.Trim();
            _cuaHang.DiaChiCuaHang = txtDiaChi.Text.Trim();
            _cuaHang.SoDienThoai = txtSDT.Text.Trim();
            _cuaHang.TenCuaHangTrenBill = txtTenCuaHangTrenBill.Text.Trim();
            _cuaHang.ThongTinLienHeTrenBill = txtThongTinTrenBill.Text.Trim();
            _cuaHang.LogoTrenBill = null;
        }

    }
}

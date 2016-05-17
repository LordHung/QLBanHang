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
    public partial class AddCuaHangDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        clsCuaHang _cuaHang = new clsCuaHang();

        public AddCuaHangDlg()
        {
            InitializeComponent();
        }

        public AddCuaHangDlg(ctrlCuaHang ctrl)
        {
            InitializeComponent();
            _ctrlCuaHang = ctrl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();       
        }

        private void AddData()
        {
            if (AssignData())
                _ctrlCuaHang.AddData(_cuaHang);
        }

        private bool AssignData()
        {

            bool Valid = true;
            string Error = "";
            ///MaCuaHang
            if (txtMa.Text.Trim().Length > 0)
            {
                _cuaHang.MaCuaHang = txtMa.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa thêm mã cửa hàng,";
            }
            ///TenCuaHang
            if (txtTen.Text.Trim().Length > 0)
            {
                _cuaHang.TenCuaHang = txtTen.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa thêm tên cửa hàng,";
            }
            ///Ten Nguoi Quan Ly
            _cuaHang.NguoiQuanLy = txtQuanLy.Text.Trim();
            ///Dia CHi Cua Hang
            _cuaHang.DiaChiCuaHang = txtDiaChi.Text.Trim();
            //SDT
            _cuaHang.SoDienThoai = txtSDT.Text.Trim();
            ///TenCUaHangTrenBIll
            _cuaHang.TenCuaHangTrenBill = txtTenCuaHangTrenBill.Text.Trim();
            ///ThongTinLienHeTrenBill
            _cuaHang.ThongTinLienHeTrenBill = txtThongTinTrenBill.Text.Trim();
            ///LogoTrenBill
            _cuaHang.LogoTrenBill = null;



            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

    }
}

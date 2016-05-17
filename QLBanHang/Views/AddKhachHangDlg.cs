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
using System.Reflection;

namespace QLBanHang.Views
{
    public partial class AddKhachHangDlg : Dlg_Them_Xoa_Sua_base
    {
        /// <summary>
        /// Cửa hàng
        /// </summary>
        DataTable _cuaHangDT = new DataTable();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        int _idCuaHang = 0;

        /// <summary>
        /// Loại khách hàng
        /// </summary>
        DataTable _loaiKhachHangDT = new DataTable();

        ctrlLoaiKhachHang _ctrlLoaiKhachHang = new ctrlLoaiKhachHang();

        int _idLoaiKhachHang = 0;

        ctrlKhachHang _ctrlKhachHang;

        clsKhachHang _khachHang = new clsKhachHang();
        /// <summary>
        /// Constructor
        /// </summary>
        public AddKhachHangDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SetController
        /// </summary>
        public AddKhachHangDlg(ctrlKhachHang ctrl)
        {
            InitializeComponent();
            _ctrlKhachHang = ctrl;
        }

        private void AddKhachHangDlg_Load(object sender, EventArgs e)
        {
            LoadCuaHang();
            LoadLoaiKhachHang();
            txtCongNo.Text = "0";
            txtCongNoDauKy.Text = "0";
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy hh:ss");
        }
        /// <summary>
        /// LoaiKhachHang
        /// </summary>
        private void LoadLoaiKhachHang()
        {
            _loaiKhachHangDT = _ctrlLoaiKhachHang.GetLoaiKhachHang();

            ///Hiển thị tên các cửa hàng lên combobox

            cmbLoaiKhachHang.DataSource = _loaiKhachHangDT;

            cmbLoaiKhachHang.DisplayMember = "LoaiThe";

            ///LoadIdCuahang
            LoadIdCuaHang();
        }

        private void LoadIdLoaiKhachHang()
        {
            int index = cmbLoaiKhachHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _loaiKhachHangDT.Rows[index];//Lấy row tương ứng với index
                _idLoaiKhachHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idLoaiKhachHang = 0;
        }

        private void cmbLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdLoaiKhachHang();
        }

        ///
        ///Cua Hang
        ///
        private void LoadCuaHang()
        {
            _cuaHangDT = _ctrlCuaHang.GetCuaHang();

            ///Hiển thị tên các cửa hàng lên combobox
            cmbCuaHang.DataSource = _cuaHangDT;

            cmbCuaHang.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            LoadIdCuaHang();
        }

        private void LoadIdCuaHang()
        {
            int index = cmbCuaHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _cuaHangDT.Rows[index];//Lấy row tương ứng với index
                _idCuaHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idCuaHang = 0;
        }

        private void cmbCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHang();
        }

        /// <summary>
        /// Gán dữ liệu
        /// </summary>
        /// <returns></returns>
        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            ///CuaHang
            _khachHang.IdCuaHang = _idCuaHang;
            ///MaKhachHang
            if (txtMaKhachHang.Text.Trim().Length > 0)
            {
                _khachHang.MaKhachHang = txtMaKhachHang.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập mã khách hàng,";
                Valid = false;
            }
            ///TenKhachHang
            if (txtTenKhachHang.Text.Trim().Length > 0)
            {
                _khachHang.TenKhachHang = txtTenKhachHang.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập tên khách hàng,";
                Valid = false;
            }
            ///DiaChi
            _khachHang.DiaChi = txtDiaChi.Text.Trim();
            ///SoDIenThoai
            _khachHang.SoDienThoai = txtDienThoai.Text.Trim();
            //Email
            _khachHang.Email = txtEmail.Text.Trim();
            ///CongNoDauKy
            _khachHang.CongNoDauKi = Convert.ToDecimal(txtCongNoDauKy.Text.ToString());
            ///NgayNhap
            _khachHang.NgayNhap = DateTime.Now;
            //idCuaHang
            _khachHang.IdCuaHang = _idCuaHang;
            //GioTinh
            _khachHang.GioiTinh = cBNam.Checked;
            //idLoaiKhachHang
            _khachHang.IdLoaiKhachHang = _idLoaiKhachHang;
            ///DiemTichLuy
            _khachHang.DiemTichLuy = 0;
            //TongDiemTichLuy
            _khachHang.DiemTichLuyAll = 0;
            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private void AddData()
        {
            if (AssignData())
                _ctrlKhachHang.AddData(_khachHang);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void txtCongNoDauKy_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
    }
}

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
    public partial class AddNhanVienDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        clsNhanVien _nhanVien = new clsNhanVien();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        DataTable _cuaHangDT = new DataTable();

        int _idCuaHang;

        public AddNhanVienDlg()
        {
            InitializeComponent();
        }

        public AddNhanVienDlg(ctrlNhanVien ctrl)
        {
            InitializeComponent();
            _ctrlNhanVien = ctrl;
            LoadCuaHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            if (AssignData())
                _ctrlNhanVien.AddData(_nhanVien);
        }

        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            //Ten Dnag nhap
            if (txtTenDangNhap.Text.Trim().Length > 0)
            {
                _nhanVien.TenDangNhap = txtTenDangNhap.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Tên đăng nhập không được để trống,";
            }
            ///MatKhau
            if (txtMatKhau.Text.Trim().Length > 0)
            {
                _nhanVien.MatKhau = txtMatKhau.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Mật khẩu không được để trống,";
            }
            //HoTen
            if (txtHoTen.Text.Trim().Length > 0)
            {
                _nhanVien.TenNhanVien = txtHoTen.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Họ tên không được để trống,";
            }
            //Chức vụ
            if (txtChucVu.Text.Trim().Length > 0)
            {
                _nhanVien.ChucVu = txtChucVu.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chức vụ không được để trống,";
            }
            //istoanquyen
            _nhanVien.IsToanQuyen = ckToanQuyen.Checked;
            //isvalid
            _nhanVien.HopLe = ckValid.Checked;
            //IdCuaHang
            _nhanVien.IdCuaHang = _idCuaHang;
            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private void LoadCuaHang()
        {
            _cuaHangDT = _ctrlCuaHang.GetCuaHang();

            ///Hiển thị tên các cửa hàng lên combobox
            cmbCuaHang.DataSource = _cuaHangDT;

            cmbCuaHang.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            //LoadIdCuaHang();
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
    }
}

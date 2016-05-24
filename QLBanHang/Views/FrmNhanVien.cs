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
using QLBanHang.Reports;

namespace QLBanHang.Views
{
    public partial class FrmNhanVien : Frm_Them_Xoa_Sua_Base,INhanVienView
    {
        rptDanhSachNV _rptDanhSachNV = new rptDanhSachNV();

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        clsNhanVien _nhanVien = new clsNhanVien();

        DataTable _nhanVienDT = new DataTable();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        DataTable _cuaHangDT = new DataTable();

        int _idCuaHang;

        int _idNhanVien;

        public FrmNhanVien()
        {
            InitializeComponent();
            _ctrlNhanVien.SetView(this);
            LoadNhanVienDT();
            Binding();
            EnableItems();
            LoadCuaHang();
        }

        private void LoadNhanVienDT()
        {
            _nhanVienDT = _ctrlNhanVien.GetData();
            dgView.DataSource = _nhanVienDT;
            dgView.Columns["id"].Visible = false;
        }

        private void Binding()
        {
            //TenDangNhap
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dgView.DataSource, "TenDangNhap");
            ///MatKhau
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgView.DataSource, "MatKhau");
            ///HoTen
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgView.DataSource, "TenNhanVien");
            ///txtChucVu
            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", dgView.DataSource, "ChucVu");
            ///
            ckToanQuyen.DataBindings.Clear();
            ckToanQuyen.DataBindings.Add("Checked", dgView.DataSource, "isToanQuyen");
            ///
            ckValid.DataBindings.Clear();
            ckValid.DataBindings.Add("Checked", dgView.DataSource, "HopLe");
        }

        public void UpdateView()
        {
            LoadNhanVienDT();
            dgView.Invalidate();
            if (index == _nhanVienDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            LoadIdNhanVien();
            Binding();
        }

        private void LoadIdNhanVien()
        {
            _idNhanVien = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddNhanVienDlg dlg = new AddNhanVienDlg(_ctrlNhanVien);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _nhanVienDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdNhanVien();
            BindingCuaHang();
        }

        private void BindingCuaHang()
        {
            foreach (DataRow row in _cuaHangDT.Rows)
            {
                if (row["TenCuaHang"].ToString() == dgView.SelectedRows[0].Cells[1].Value.ToString())
                {
                    cmbCuaHang.SelectedIndex = _cuaHangDT.Rows.IndexOf(row);
                    LoadIdCuaHang();
                    cmbCuaHang.Invalidate();
                    return;
                }
            }
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlNhanVien.DeleteData(_idNhanVien);
        }

        protected override void tsBtnLuu_Click(object sender, EventArgs e)
        {
            base.tsBtnLuu_Click(sender, e);
        }

        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            base.tsBtnSua_Click(sender, e);
        }

        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            //Id
            _nhanVien.Id = _idNhanVien;
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

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlNhanVien.UpdateData(_nhanVien);
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

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _nhanVienDT); 
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            _rptDanhSachNV.Show();
        }
    }
}

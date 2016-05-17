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
    public partial class FrmKhachHang : Frm_Them_Xoa_Sua_Base,IKhachHangView
    {
        /// <summary>
        /// Khách hàng
        /// </summary>
        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        DataTable _khachHangDT = new DataTable();

        /// <summary>
        /// Cửa hàng
        /// </summary>
        DataTable _cuaHangDT = new DataTable();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        int _idCuaHang = 0;

        int _idKhachHang = 0;

       

        clsKhachHang _khachHang = new clsKhachHang();
        /// <summary>
        /// Loại khách hàng
        /// </summary>
        DataTable _loaiKhachHangDT = new DataTable();

        ctrlLoaiKhachHang _ctrlLoaiKhachHang = new ctrlLoaiKhachHang();

        int _idLoaiKhachHang = 0;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadKhachHangDB()
        {
            _khachHangDT = _ctrlKhachHang.GetData();
            dgView.DataSource = _khachHangDT;
            _ctrlKhachHang.SetView(this);
            dgView.Columns["id"].Visible = false;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangDB();
            LoadCuaHang();
            LoadLoaiKhachHang();
            LoadNumericBoxes();
            Binding();
            EnableItems();
        }

        private void LoadNumericBoxes()
        {
            txtCongNo.Text = "0";
            //txtCongNoDauKy.Text = "0";
        }

        protected override void tsBtnLuu_Click(object sender, EventArgs e)
        {
            base.tsBtnLuu_Click(sender, e);
        }

        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            base.tsBtnSua_Click(sender, e);
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddKhachHangDlg dlg = new AddKhachHangDlg(_ctrlKhachHang);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlKhachHang.DeleteData(_idKhachHang);
        }

        public void UpdateView()
        {
            LoadKhachHangDB();
            LoadCuaHang();
            LoadLoaiKhachHang();
            LoadNumericBoxes();
            dgView.Invalidate();
            if (index == _khachHangDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            GetIdKhachHang();
            Binding();
            EnableItems();
        }
        public void GetIdKhachHang()
        {
            _idKhachHang = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString());
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

        /// <summary>
        /// Bindingdata
        /// </summary>
        private void Binding()
        {
            ///MaKhachHang
            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text",dgView.DataSource,"MaKhachHang");
            ///TenKhachHang
            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text",dgView.DataSource,"TenKhachHang");
            ///DiaChi
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text",dgView.DataSource,"DiaChi");
            ///SoDienThoai
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgView.DataSource, "SoDienThoai");
            ///Email
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgView.DataSource, "Email");
            ///DiaCHi
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgView.DataSource, "DiaChi");
            ///CongNoDauKy
            txtCongNoDauKy.DataBindings.Clear();
            txtCongNoDauKy.DataBindings.Add("Text", dgView.DataSource, "CongNoDauKy");
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _khachHangDT.Rows.Count)
                return;

            index = e.RowIndex;

            GetIdKhachHang();

            BindingCuaHang();

            BindingLoaiKhachHang();
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

        private void BindingLoaiKhachHang()
        {

            foreach (DataRow row in _loaiKhachHangDT.Rows)
            {
                if (row["id"].ToString() == _ctrlKhachHang.GetIdLoaiKhachHang(_idKhachHang).ToString())
                {
                    cmbLoaiKhachHang.SelectedIndex = _loaiKhachHangDT.Rows.IndexOf(row);
                    cmbLoaiKhachHang.Invalidate();
                    return;
                }
            }
        }

        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            ///
            _khachHang.Id = _idKhachHang;
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

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlKhachHang.UpdateData(_khachHang);
        }

        private void txtCongNoDauKy_Validated(object sender, EventArgs e)
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

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _khachHangDT);
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }
    
    }
}

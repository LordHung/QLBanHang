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
    public partial class FrmCuaHang : Frm_Them_Xoa_Sua_Base,ICuaHangView
    {

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        clsCuaHang _cuaHang = new clsCuaHang();

        DataTable _cuaHangDT = new DataTable();

        int _idCuaHang;

        public FrmCuaHang()
        {
            InitializeComponent();
            _ctrlCuaHang.SetView(this);
            LoadCuaHangDT();
            Binding();
            EnableItems();
        }

        private void LoadCuaHangDT()
        {
            _cuaHangDT = _ctrlCuaHang.GetData();
            dgView.DataSource = _cuaHangDT;
            dgView.Columns["id"].Visible = false;
        }

        private void Binding()
        {
            //MaCuaHang
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text",dgView.DataSource,"MaCuaHang");
            ///TenCuaHang
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgView.DataSource, "TenCuaHang");
            ///DiaChiCuaHang
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgView.DataSource, "DiaChiCuaHang");
            ///NguoiQuanLy
            txtQuanLy.DataBindings.Clear();
            txtQuanLy.DataBindings.Add("Text", dgView.DataSource, "NguoiQuanLy");
            ///SDT
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgView.DataSource, "SoDienThoai");
            ///TenCuaHangTrenBIll
            txtTenCuaHangTrenBill.DataBindings.Clear();
            txtTenCuaHangTrenBill.DataBindings.Add("Text", dgView.DataSource, "ThongTinLienHeTrenBill");
            ///ThongTInCuaHangTrenBIll
            txtThongTinTrenBill.DataBindings.Clear();
            txtThongTinTrenBill.DataBindings.Add("Text", dgView.DataSource, "MaCuaHang");
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            
        }

        public void UpdateView()
        {
            LoadCuaHangDT();
            dgView.Invalidate();
            if (index == _cuaHangDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            LoadIdCuaHang();
            Binding();
        }

        private void LoadIdCuaHang()
        {
            _idCuaHang = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddCuaHangDlg dlg = new AddCuaHangDlg(_ctrlCuaHang);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _cuaHangDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdCuaHang();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlCuaHang.DeleteData(_idCuaHang);
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
            //IdCuaHang
            _cuaHang.Id = _idCuaHang;
            ///MaCuaHang
            if (txtMa.Text.Trim().Length > 0)
            {
                _cuaHang.MaCuaHang = txtMa.Text.Trim();
            }
            else
            {
                Error += "Chưa thêm mã cửa hàng,";
            }
            ///TenCuaHang
            if (txtTen.Text.Trim().Length > 0)
            {
                _cuaHang.TenCuaHang = txtTen.Text.Trim();
            }
            else
            {
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

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlCuaHang.UpdateData(_cuaHang);
        }

    }
}

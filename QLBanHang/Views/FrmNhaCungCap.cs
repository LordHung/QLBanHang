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
    public partial class FrmNhaCungCap : Frm_Them_Xoa_Sua_Base,INhaCungCapView
    {
        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        clsNhaCungCap _nhaCungCap = new clsNhaCungCap();

        DataTable _nhaCungCapDT = new DataTable();

        int _idNhaCungCap;


        public FrmNhaCungCap()
        {
            InitializeComponent();
            _ctrlNhaCungCap.SetView(this);
            LoadNhaCungCapDT();
            Binding();
            EnableItems();
            _idNhaCungCap = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString().Trim());
        }
        private void LoadNhaCungCapDT()
        {
            _nhaCungCapDT = _ctrlNhaCungCap.GetData();
            dgView.DataSource = _nhaCungCapDT;
            dgView.Columns["id"].Visible = false;
            dgView.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Binding()
        {

            txtCodeNhaCungCap.DataBindings.Clear();
            txtCodeNhaCungCap.DataBindings.Add("Text", dgView.DataSource, "CodeNhaCungCap");
            
            txtTenNhaCungCap.DataBindings.Clear();
            txtTenNhaCungCap.DataBindings.Add("Text", dgView.DataSource, "TenNhaCungCap");


            txtCongNoDauKi.DataBindings.Clear();
            txtCongNoDauKi.DataBindings.Add("Text", dgView.DataSource, "CongNoDauKy");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgView.DataSource, "SoDienThoai");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgView.DataSource, "DiaChi");

        }


        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;

        }
    

        public void UpdateView()
        {
            LoadNhaCungCapDT();
            dgView.Invalidate();
            if (index == _nhaCungCapDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            Binding();
            LoadIdNhacCungCap();
        }

        private void LoadIdNhacCungCap()
        {
            _idNhaCungCap = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddNhaCungCapDlg dlg = new AddNhaCungCapDlg(_ctrlNhaCungCap);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _nhaCungCapDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdNhacCungCap();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlNhaCungCap.DeleteData(_idNhaCungCap);
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
            _nhaCungCap.Id = _idNhaCungCap;
            ///Ma
            if (txtCodeNhaCungCap.Text.Trim().Length > 0)
            {
                _nhaCungCap.CodeNhaCungCap = txtCodeNhaCungCap.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa nhập mã nhà cung cấp";
            }
            ///Ten
            if (txtTenNhaCungCap.Text.Trim().Length > 0)
            {
                _nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            }
            else
            {
                Valid = false;
                Error += "Chưa nhập tên nhà cung cấp";
            }
            ///Cong No Dau Ky
            _nhaCungCap.CongNoDauKy = Convert.ToDecimal(txtCongNoDauKi.Text.Trim());
            ///SDT
            _nhaCungCap.SoDienThoai = txtSDT.Text.Trim();
            ///DiaChi
            _nhaCungCap.DiaChi = txtDiaChi.Text.Trim();
            ///idCuaHang
            _nhaCungCap.IDCuahang = 9;

            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlNhaCungCap.UpdateData(_nhaCungCap);
        }

        private void txtCongNo_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void txtCongNoDauKi_Validated(object sender, EventArgs e)
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

        private void txtCongNoDauKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlKeyPress.KeyPressOnlyDigits(sender, e);
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _nhaCungCapDT);
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }

    }
}

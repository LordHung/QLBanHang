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
    public partial class FrmNhaSanXuat : Frm_Them_Xoa_Sua_Base,INhaSanXuatView
    {

        ctrlNhaSanXuat _ctrlNhaSanXuat = new ctrlNhaSanXuat();

        clsNhaSanXuat _nhaSanXuat = new clsNhaSanXuat();

        DataTable _nhaSanXuatDT = new DataTable();

        int _idNhaSanXuat;

        public FrmNhaSanXuat()
        {
            InitializeComponent();
            _ctrlNhaSanXuat.SetView(this);
  
        }

        private void FrmNhaSanXuat_Load(object sender, EventArgs e)
        {
            LoadNhaSanXuatDT();
            Binding();
            EnableItems();
            _idNhaSanXuat = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString().Trim());
        }

      


        private void LoadNhaSanXuatDT()
        {
            _nhaSanXuatDT = _ctrlNhaSanXuat.GetData();
            dgView.DataSource = _nhaSanXuatDT;

            dgView.Columns["GhiChu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }

        private void Binding()
        {
            ///MaNSX
            txtMaNSX.DataBindings.Clear();
            txtMaNSX.DataBindings.Add("Text",dgView.DataSource,"MaNhaSanXuat");
            ///TenNSX
            txtTenNSX.DataBindings.Clear();
            txtTenNSX.DataBindings.Add("Text", dgView.DataSource, "TenNhaSanXuat");
            ///DiaChi
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgView.DataSource, "DiaChi");
            ///GhiChu
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgView.DataSource, "GhiChu");
        }


        public void UpdateView()
        {
            LoadNhaSanXuatDT();
            dgView.Invalidate();
            if (index == _nhaSanXuatDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            Binding();
            LoadIdNhaSanXuat();
        }

        private void LoadIdNhaSanXuat()
        {
            _idNhaSanXuat = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddNhaSanXuatDlg dlg = new AddNhaSanXuatDlg(_ctrlNhaSanXuat);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _nhaSanXuatDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdNhaSanXuat();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlNhaSanXuat.DeleteData(_idNhaSanXuat);
        }

        protected override void tsBtnLuu_Click(object sender, EventArgs e)
        {
            base.tsBtnLuu_Click(sender, e);
        }

        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            base.tsBtnSua_Click(sender, e);
        }

        private bool AsssignData()
        {
            string Error = "";
            ///Id
            _nhaSanXuat.Id = _idNhaSanXuat;
            //MaNSX
            if (txtMaNSX.Text.Trim().Length == 3)
            {
                _nhaSanXuat.MaNhaSanXuat = txtMaNSX.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập mã nhà sản xuất\n Định dạng theo 3 kí tự vd : 'NSX','001','I02'";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //TenNhaSanXuat
            if (txtTenNSX.Text.Trim().Length > 0)
            {
                _nhaSanXuat.TenNhaSanXuat = txtTenNSX.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập tên nhà sản xuất";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //DiaChiNhaSanXuat
            _nhaSanXuat.DiaChi = txtDiaChi.Text.Trim();
            //GhiChu
            _nhaSanXuat.GhiChu = txtGhiChu.Text.Trim();

            return true;
        }

        protected override void UpdateData()
        {
            if (AsssignData())
                _ctrlNhaSanXuat.UpdateData(_nhaSanXuat);
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender,e, _nhaSanXuatDT);
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }
    
    }
}

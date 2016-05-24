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
    public partial class FrmNganhHang : Frm_Them_Xoa_Sua_Base,INganhSanPhamView
    {
        rptDanhSachNganhSP _rptDanhSachNganhSP = new rptDanhSachNganhSP();

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsNganhSanPham _nganhSanPham = new clsNganhSanPham();

        DataTable _nganhSanPhamDT = new DataTable();

        int _idNganhSanPham;

        public FrmNganhHang()
        {
            InitializeComponent();
            _ctrlNganhSanPham.SetView(this);
        }

        private void FrmNganhHang_Load(object sender, EventArgs e)
        {
            LoadNganhSanPhamDT();
            Binding();
            EnableItems();
            _idNganhSanPham = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString().Trim());
        }

        private void LoadNganhSanPhamDT()
        {
            _nganhSanPhamDT = _ctrlNganhSanPham.GetData();
            dgView.DataSource = _nganhSanPhamDT;

            dgView.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgView.Columns.Add(new DataGridViewColumn("STT",typeof(int)));
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }

        private void Binding()
        {
          
            ///MaNganhSanPham
            txtMaNganh.DataBindings.Clear();
            txtMaNganh.DataBindings.Add("Text", dgView.DataSource, "MaNganhSanPham");
            ///TenNganhSanPham
            txtTenNganh.DataBindings.Clear();
            txtTenNganh.DataBindings.Add("Text", dgView.DataSource, "TenNganhSanPham");
            ///MoTa
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgView.DataSource, "MoTa");
        }

        public void UpdateView()
        {
            LoadNganhSanPhamDT();
            dgView.Invalidate();
            if (index == _nganhSanPhamDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            Binding();
            LoadIdNhacCungCap();
        }

        private void LoadIdNhacCungCap()
        {
            _idNganhSanPham = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddNganhSanPhamDlg dlg = new AddNganhSanPhamDlg(_ctrlNganhSanPham);
            dlg.Owner = this;
            dlg.ShowDialog();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _nganhSanPhamDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdNhacCungCap();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlNganhSanPham.DeleteData(_idNganhSanPham);
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
            string Error = "";
            //Id
            _nganhSanPham.Id = _idNganhSanPham;
            ///MaNganhSanPham
            if (txtMaNganh.Text.Trim().Length > 0)
            {
                _nganhSanPham.MaNganhSanPham = txtMaNganh.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập mã ngành sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            ///TenNganhSanPham
            if (txtTenNganh.Text.Trim().Length > 0)
            {
                _nganhSanPham.TenNganhSanPham = txtTenNganh.Text.Trim();
            }
            else
            {
                Error = "Vui lòng nhập tên ngành sản phẩm";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            ///MoTa
            _nganhSanPham.MoTa = txtMoTa.Text.Trim();
            return true;
        }

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlNganhSanPham.UpdateData(_nganhSanPham);
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _nganhSanPhamDT); 
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            _rptDanhSachNganhSP.Show();
        }
    }
}

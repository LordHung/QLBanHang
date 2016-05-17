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
    /// <summary>
    /// Form cho LOAISANPHAM
    /// </summary>
    public partial class FrmNhomHang : Frm_Them_Xoa_Sua_Base,ILoaiSanPhamView
    {
        ctrlLoaiSanPham _ctrlLoaiSanPham = new ctrlLoaiSanPham();

        ctrlNganhSanPham _ctrlNganhSanPham = new ctrlNganhSanPham();

        clsLoaiSanPham _loaiSanPham = new clsLoaiSanPham();

        DataTable _nganhSanPhamDT = new DataTable();

        DataTable _loaiSanPhamDT = new DataTable();

        int _idLoaiSanPham;

        int _idNganhSanPham;

        public FrmNhomHang()
        {
            InitializeComponent();
            _ctrlLoaiSanPham.SetView(this);
        }

        private void FrmNhomHang_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPhamDT();
            LoadNganhSanPhamDT();
            Binding();
            EnableItems();
            _idLoaiSanPham = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString().Trim());
        }

        public void HideId()
        {
            dgView.Columns["id"].Visible = false;
        }

        private void LoadLoaiSanPhamDT()
        {
            _loaiSanPhamDT = _ctrlLoaiSanPham.GetData();
            dgView.DataSource = _loaiSanPhamDT;
            dgView.Columns["id"].Visible = false;
            dgView.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgView.Columns["MaLoaiSanPham"].DefaultCellStyle.ForeColor = Color.Red;
        }

        private void LoadNganhSanPhamDT()
        {
            _nganhSanPhamDT = _ctrlNganhSanPham.GetNganhSanPham();
            cmbNganh.DataSource = _nganhSanPhamDT;
            cmbNganh.DisplayMember = "NganhSanPham";
            LoadIdNganhSanPham();
        }

        private void LoadIdNganhSanPham()
        {
            int index = cmbNganh.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nganhSanPhamDT.Rows[index];//Lấy row tương ứng với index
                _idNganhSanPham = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNganhSanPham = 0;
        }

        private void cmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNganhSanPham();
        }


        public void UpdateView()
        {
            LoadLoaiSanPhamDT();
            LoadNganhSanPhamDT();
            dgView.Invalidate();
            if (index == _loaiSanPhamDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            Binding();
            LoadIdNganhSanPham();
            LoadIdLoaiSanPham();
        }

        private void Binding()
        {
            //MaLoaiSanPham
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text",dgView.DataSource,"MaLoaiSanPham");
            //TenLoaiSanPham
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dgView.DataSource, "TenLoaiSanPham");
            //MoTa
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgView.DataSource, "MoTa");
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
            AddLoaiSanPhamDlg dlg = new AddLoaiSanPhamDlg(_ctrlLoaiSanPham);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlLoaiSanPham.DeleteData(_idLoaiSanPham);
        }

        public void LoadIdLoaiSanPham()
        {
            _idLoaiSanPham = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString());
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _loaiSanPhamDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdLoaiSanPham();
            BindingNganhSanPham();
        }

        private void BindingNganhSanPham()
        {
            foreach (DataRow row in _nganhSanPhamDT.Rows)
            {
                if (row["NganhSanPham"].ToString() == dgView.SelectedRows[0].Cells[1].Value.ToString())
                {
                    cmbNganh.SelectedIndex = _nganhSanPhamDT.Rows.IndexOf(row);
                    LoadIdNganhSanPham();
                    cmbNganh.Invalidate();
                    return;
                }
            }
        }


        private bool AssignData()
        {
            string Error;
            //idLoaiSanPha
            _loaiSanPham.Id = _idLoaiSanPham;
            //idNganhSanPham
            _loaiSanPham.IdNganhSanPham = _idNganhSanPham;
            //MaloaiSanPham
            if (txtMaLoai.Text.Trim().Length > 0)
            {
                _loaiSanPham.MaLoaiSanPham = txtMaLoai.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập mã nhóm ngành!";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //TenLoaiSanPham
            if (txtTenLoai.Text.Trim().Length > 0)
            {
                _loaiSanPham.TenLoaiSanPham = txtTenLoai.Text.Trim();
            }
            else
            {
                Error = "Chưa nhập tên nhóm ngành!";
                MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //MoTa
            _loaiSanPham.MoTa = txtMoTa.Text.Trim();

            return true;
        }

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlLoaiSanPham.UpdateData(_loaiSanPham);
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _loaiSanPhamDT);
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {
            dgView.Columns["id"].Visible = false;
        }
    
     
    }
}

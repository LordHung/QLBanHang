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
    public partial class FrmLoaiKhachHang : Frm_Them_Xoa_Sua_Base,ILoaiKhachHangView
    {
        ctrlLoaiKhachHang _ctrlLoaikhachHang = new ctrlLoaiKhachHang();

        DataTable _loaiKhachHangDT = new DataTable();

        clsLoaiKhachHang _loaiKhachHang = new clsLoaiKhachHang();

        int _idLoaiKhachHang;

        public FrmLoaiKhachHang()
        {
            InitializeComponent();
            _ctrlLoaikhachHang.setView(this);
         
        }

        private void FrmLoaiKhachHang_Load(object sender, EventArgs e)
        {
            LoadLoaiKhachHangDT();
            Binding();
            EnableItems();
        }

        private void LoadLoaiKhachHangDT()
        {
            _loaiKhachHangDT = _ctrlLoaikhachHang.GetData();
            dgView.DataSource = _loaiKhachHangDT;
            dgView.Columns["id"].Visible = false;
            dgView.Columns["NguongQuyDoi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Binding()
        {
            txtLoaiThe.DataBindings.Clear();
            txtLoaiThe.DataBindings.Add("Text",dgView.DataSource,"LoaiThe");

            numNguong.DataBindings.Clear();
            numNguong.DataBindings.Add("Text", dgView.DataSource, "NguongQuyDoi");

            numTiLeQuyDoi.DataBindings.Clear();
            numTiLeQuyDoi.DataBindings.Add("Text", dgView.DataSource, "TiTeQuyDoiDiem");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgView.DataSource, "MoTa");

        }

        public void UpdateView()
        {
            LoadLoaiKhachHangDT();
            dgView.Invalidate();
            if (index == _loaiKhachHangDT.Rows.Count)
                dgView.Rows[index - 1].Selected = true;
            else dgView.Rows[index].Selected = true;
            Binding();
            LoadIdLoaiKhachHang();
        }

        private void LoadIdLoaiKhachHang()
        {
            _idLoaiKhachHang = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddLoaiKhachHangDlg dlg = new AddLoaiKhachHangDlg(_ctrlLoaikhachHang);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _loaiKhachHangDT.Rows.Count)
                return;
            index = e.RowIndex;
            LoadIdLoaiKhachHang();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlLoaikhachHang.DeleteData(_idLoaiKhachHang);
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
            ///id
            _loaiKhachHang.Id = _idLoaiKhachHang;
            ///LoaiThe

            if (txtLoaiThe.Text.Trim().Length > 0)
            {
                _loaiKhachHang.LoaiThe = txtLoaiThe.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập loại thẻ,";
                Valid = false;
            }
            ///Ngưỡng quy đỏio
            _loaiKhachHang.NguongQuyDoi = (int)numNguong.Value;
            ///Tĩ lệ quy đổi
            _loaiKhachHang.TiLeQuyDoiDiem = (double)numTiLeQuyDoi.Value;
            ///MoTa
            _loaiKhachHang.MoTa = txtMoTa.Text.Trim();
            return Valid;
        }

        protected override void UpdateData()
        {
            if (AssignData())
                _ctrlLoaikhachHang.UpdateData(_loaiKhachHang);
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _loaiKhachHangDT);
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

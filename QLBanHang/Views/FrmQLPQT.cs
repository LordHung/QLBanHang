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
    public partial class FrmQLPQT : Frm_Them_Xoa_Sua_Base,IPhieuQuaTangView
    {
        ctrlPhieuQuaTang _ctrlPhieuQuaTang = new ctrlPhieuQuaTang();

        clsPhieuQuaTang _phieuQuaTang = new clsPhieuQuaTang();

        DataTable _phieuQuaTangDT = new DataTable();

        int _idPhieuQuaTang;

        int _idKhachHang = 0;

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        DataTable _khachHangDT = new DataTable();

        public FrmQLPQT()
        {
            InitializeComponent();
            ///LoadPhieuQuaTangDT gán vào dgview
            LoadPhieuQuaTangDT();
            ///Set view cho control phiếu quà tặng
            _ctrlPhieuQuaTang.SetView(this);
            ///LoadKhachHang vào combobox
            LoadKhachHang();
            ///Disable các items
            EnableItems();
            //Bindgin items trên dgview và panel
            Binding();
          
        }

        private void FrmQLPQT_Load(object sender, EventArgs e)
        {
          
        }
        private void LoadPhieuQuaTangDT()
        {
            _phieuQuaTangDT = _ctrlPhieuQuaTang.GetData(100);
            dgView.DataSource = _phieuQuaTangDT;
        }

     
        private void Binding()
        {
           ///MaVach
            txtMaVach.DataBindings.Clear();
            txtMaVach.DataBindings.Add("Text",dgView.DataSource,"SoPhieu");
           ///TriGia
            numTriGia.DataBindings.Clear();
            numTriGia.DataBindings.Add("Value", dgView.DataSource, "TriGia");
            ///Ngaytao
            dtpNgayTao.DataBindings.Clear();
            dtpNgayTao.DataBindings.Add("Value", dgView.DataSource, "NgayTao");
           ///HanSUDung 
            dtpHSD.DataBindings.Clear();
            dtpHSD.DataBindings.Add("Value", dgView.DataSource, "HanSuDung");
           ///KhachHang
           ///GhiChu
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgView.DataSource, "GhiChu");
        }


        public void UpdateViewPhieuQuaTang()
        {
            LoadPhieuQuaTangDT();
            dgView.Invalidate();
            //if (index == _phieuQuaTangDT.Rows.Count)
            //    dgView.Rows[index - 1].Selected = true;
            //else dgView.Rows[index].Selected = true;
            LoadIdPhieuQuaTang();
            Binding();
        }

        private void LoadIdPhieuQuaTang()
        {
           
            _idPhieuQuaTang = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value.ToString().Trim());
        }

        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddPhieuQuaTangDlg dlg = new AddPhieuQuaTangDlg(_ctrlPhieuQuaTang);
            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        protected override void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= _phieuQuaTangDT.Rows.Count)
                return;
            index = e.RowIndex;
            txtMaVach.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
            //load lại idphieuqatuang
            LoadIdPhieuQuaTang();
            ///ckbox
            LoadCkBoxes();
            //binding giá tringj lên combobox
            BindingKhachHang();
            LoadNgaySD();
        }


        private void BindingKhachHang()
        {
            if (ckPhieuDoiDiem.Checked)
            foreach (DataRow row in _khachHangDT.Rows)
            {
                if (row["id"].ToString() == dgView.SelectedRows[0].Cells[7].Value.ToString())
                {
                    cmbKhachHang.SelectedIndex = _khachHangDT.Rows.IndexOf(row);
                    LoadIdKhachHang();
                    cmbKhachHang.Invalidate();
                    return;
                }
            }
        }

        private void LoadCkBoxes()
        {
            if (dgView.SelectedRows[0].Cells[7].Value.ToString().Trim().Length > 0)
            {
                ckPhieuDoiDiem.Checked = true;
                ckPhieuQuaTang.Checked = false;
            }
            else 
            {
                ckPhieuDoiDiem.Checked = false;
                ckPhieuQuaTang.Checked = true;
            }
            LoadKhachHang();
        }

        private void LoadNgaySD()
        {
            if (dgView.SelectedRows[0].Cells[5].Value.ToString().Length > 0)
            {
                dtpNgaySD.Value = Convert.ToDateTime(dgView.SelectedRows[0].Cells[5].Value.ToString());
                dtpNgaySD.Checked = true;
            }
            else
            {
                dtpNgaySD.Checked = false;
            }
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _ctrlPhieuQuaTang.DeleteData(_idPhieuQuaTang);
        }

        protected override void tsBtnLuu_Click(object sender, EventArgs e)
        {
            base.tsBtnLuu_Click(sender, e);
        }

        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            base.tsBtnSua_Click(sender, e);
        }
        /// <summary>
        /// Gán dữ liệu vào clsPhieuQuaTang để update
        /// </summary>
        private bool AssignData()
        {
            //id
            _phieuQuaTang.Id = _idPhieuQuaTang;
            //MaVach
            _phieuQuaTang.MaVach = Convert.ToInt32(txtMaVach.Text);
            //idKhachHang
            _phieuQuaTang.IdKhachHang = _idKhachHang;
            //NgayTao
            _phieuQuaTang.NgayTao = dtpNgayTao.Value;
            //TriGia
            if ((int)numTriGia.Value > 0)
            {
                _phieuQuaTang.TriGia = (int)numTriGia.Value;
            }
            else
            {
                MessageBox.Show("Trị Giá phải lớn hơn 0", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //NgaySuDung
            if (dtpNgaySD.Checked)
                _phieuQuaTang.NgaySuDung = dtpNgaySD.Value;
            else _phieuQuaTang.NgaySuDung = DateTime.MinValue;
            //HSD
            _phieuQuaTang.HanSuDung = dtpHSD.Value;
            //MoTa
            _phieuQuaTang.GhiChu = txtMoTa.Text;
            if (dtpHSD.Value < dtpNgayTao.Value)
            {
                MessageBox.Show("Ngày tạo phải nhỏ hơn ngày sử dụng", "Thông báo"
                                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        protected override void UpdateData()
        {
            if(AssignData())
                _ctrlPhieuQuaTang.UpdateData(_phieuQuaTang);
        }
        /// 
        /// Khách Hàng
        ///
        private void LoadKhachHang()
        {
            _khachHangDT = _ctrlKhachHang.GetKhachHang();
            if (ckPhieuDoiDiem.Checked)
            {
                cmbKhachHang.DataSource = _khachHangDT;
                cmbKhachHang.DisplayMember = "KhachHang";
                LoadIdKhachHang();
            }
            else if (!ckPhieuDoiDiem.Checked)
            {
                cmbKhachHang.DataSource = null;
                _idKhachHang = 0;
            }
           
            cmbKhachHang.Invalidate();
        }

        private void LoadIdKhachHang()
        {
            int index = cmbKhachHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _khachHangDT.Rows[index];//Lấy row tương ứng với index
                _idKhachHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idKhachHang = 0;
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdKhachHang();
        }

        protected override void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _phieuQuaTangDT);
        }

        protected override void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs ex)
        {

            lblSoLuong.Text = (dgView.Rows.Count - 1).ToString() + " phiếu.";
            dgView.Columns["id"].Visible = false;
            dgView.Columns["HanSuDung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgView.Columns["MaVach"].HeaderText = "Mã vạch";
            dgView.Columns["TriGia"].HeaderText = "Trị Giá";
            dgView.Columns["SoPhieu"].Visible = false;
            dgView.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgView.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
            dgView.Columns["NgaySuDung"].Width = 150;
            dgView.Columns["HanSuDung"].HeaderText = "HSD";
            dgView.Columns["GhiChu"].HeaderText = "Ghi chú";

            txtMaVach.Text = dgView.Rows[0].Cells[2].Value.ToString().Trim();
            if (dgView.Rows[0].Cells[7].Value.ToString().Trim().Length > 0)
                ckPhieuQuaTang.Checked = true;
            ckPhieuQuaTang.Invalidate();
            _idPhieuQuaTang = Convert.ToInt32(dgView.Rows[0].Cells[0].Value.ToString().Trim());


            
        }

        private void ckPhieuDoiDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPhieuDoiDiem.Checked)
                ckPhieuQuaTang.Checked = false;
            LoadKhachHang();
        }

        private void ckPhieuQuaTang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPhieuQuaTang.Checked)
                ckPhieuDoiDiem.Checked = false;
            LoadKhachHang();
        }

    
    }
}

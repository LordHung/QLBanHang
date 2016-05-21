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
    public partial class AddPhieuQuaTangDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlPhieuQuaTang _ctrlPhieuQuaTang = new ctrlPhieuQuaTang();

        clsPhieuQuaTang _phieuQuaTang = new clsPhieuQuaTang();

        DataTable _phieuQuaTangDT = new DataTable();

        int _idKhachHang = 0;

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        DataTable _khachHangDT = new DataTable();

        public AddPhieuQuaTangDlg()
        {
            InitializeComponent();
        }

        public AddPhieuQuaTangDlg(ctrlPhieuQuaTang ctrl)
        {
            InitializeComponent();
            _ctrlPhieuQuaTang = ctrl;
            txtMaVach.Text = _ctrlPhieuQuaTang.GetNewSoPhieu().ToString();
            dtpHSD.Value = dtpHSD.Value.AddMonths(8);
            ckPhieuDoiDiem.Checked = true;
            LoadKhachHang();
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


        private bool AssignData()
        {
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

        private void AddData()
        {
            if (AssignData())
            {
                _ctrlPhieuQuaTang.AddData(_phieuQuaTang);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
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

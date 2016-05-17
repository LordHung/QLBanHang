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
    public partial class FrmPhieuChi : FrmPhieuThuChiBase,IPhieuChiView
    {

        ctrlPhieuChi _ctrlPhieuChi = new ctrlPhieuChi();


        DataTable _phieuChiDT = new DataTable();

        string _maPhieuChi;

        public FrmPhieuChi()
        {
            InitializeComponent();
            LoadPhieuChiDT();
            _ctrlPhieuChi.SetView(this);
        }


        private void LoadPhieuChiDT()
        {
            ///Lấy dữ liệu các phiếu thu trong database vào datatable 
            _phieuChiDT = _ctrlPhieuChi.GetData();

            ///gán dữ liệu từ datatable lên datagridview 
            dgViewPhieu.DataSource = _phieuChiDT;

            dgViewPhieu.Columns["ChungTyKemTheo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ///Hiển thị lại datagriview 
            dgViewPhieu.Invalidate();
        }

        /// <summary>
        /// Clicked event của btnthem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tSBtnThem_Click(object sender, EventArgs e)
        {
            AddPhieuChiDlg dlg = new AddPhieuChiDlg(_ctrlPhieuChi);
            dlg.Owner = this;
            dlg.Show();
        }


        /// <summary>
        /// Implement hàm UpdateView cho IPhieuThuView
        /// </summary>
        public void UpdateView()
        {
            _phieuChiDT = _ctrlPhieuChi.GetData();

            dgViewPhieu.DataSource = _phieuChiDT;

            dgViewPhieu.Invalidate();
        }

        /// <summary>
        /// Clicked event của btnSua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            _maPhieuChi = dgViewPhieu.CurrentRow.Cells[2].Value.ToString();
            UpdatePhieuChiDlg dlg = new UpdatePhieuChiDlg(_ctrlPhieuChi, _maPhieuChi);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _maPhieuChi = dgViewPhieu.CurrentRow.Cells[2].Value.ToString();
            _ctrlPhieuChi.DeleteData(_maPhieuChi);
        }
    }
}

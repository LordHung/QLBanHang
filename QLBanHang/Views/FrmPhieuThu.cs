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
    public partial class FrmPhieuThu : FrmPhieuThuChiBase, IPhieuThuView
    {
        ctrlPhieuThu _ctrlPhieuThu = new ctrlPhieuThu();
        /// <summary>
        /// Delegate to addData
        /// </summary>

        //AddPhieuThuDelegate Add = new AddPhieuThuDelegate(new ctrlPhieuThu().AddData);

        DataTable _phieuThuDT = new DataTable();

       
        string _maPhieuThu;

        public FrmPhieuThu()
        {
            InitializeComponent();
            LoadPhieuThuDT();
            _ctrlPhieuThu.SetView(this);
        }

        private void LoadPhieuThuDT()
        {
            ///Lấy dữ liệu các phiếu thu trong database vào datatable 
            _phieuThuDT = _ctrlPhieuThu.GetData();

            ///gán dữ liệu từ datatable lên datagridview 
            dgViewPhieu.DataSource = _phieuThuDT;

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
            AddPhieuThuDlg dlg = new AddPhieuThuDlg(_ctrlPhieuThu);
            dlg.Owner = this;
            dlg.Show();
        }

        /// <summary>
        /// Implement hàm UpdateView cho IPhieuThuView
        /// </summary>
        public void UpdateView()
        {
            _phieuThuDT = _ctrlPhieuThu.GetData();

            dgViewPhieu.DataSource = _phieuThuDT;

            dgViewPhieu.Invalidate();
        }

        ///
        ///AddPhieuThu
        ///
        public void AddPhieuThu(clsPhieuThu _phieuThu)
        {
            _ctrlPhieuThu.AddData(_phieuThu);
        }


        
        /// <summary>
        /// Clicked event của btnSua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tsBtnSua_Click(object sender, EventArgs e)
        {
            _maPhieuThu = dgViewPhieu.CurrentRow.Cells[2].Value.ToString();
            UpdatePhieuThuDlg dlg = new UpdatePhieuThuDlg(_ctrlPhieuThu, _maPhieuThu);
            dlg.Owner = this;
            dlg.Show();
        }

        protected override void tsBtnXoa_Click(object sender, EventArgs e)
        {
            _maPhieuThu = dgViewPhieu.CurrentRow.Cells[2].Value.ToString();
            _ctrlPhieuThu.DeleteData(_maPhieuThu);
        }
    }
}

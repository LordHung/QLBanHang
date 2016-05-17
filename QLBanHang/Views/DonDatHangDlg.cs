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
    public partial class DonDatHangDlg : Form
    {
        ctrlDonDatHang _ctrlDonDatHang;

        DataTable _donDatHangDT = new DataTable();

        public DonDatHangDlg()
        {
            InitializeComponent();
            DoubleBuffering();
        }

        public DonDatHangDlg(ctrlDonDatHang ctrl)
        {
            InitializeComponent();
            _ctrlDonDatHang = ctrl;
            _donDatHangDT = _ctrlDonDatHang.GetDonDatHang();
            dgViewDonDatHang.DataSource = _donDatHangDT;
        }

        private void DoubleBuffering()
        {
            ImprovePerfomance.SetDoubleBuffering(dgViewDonDatHang);
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            string _maHoaDon = dgViewDonDatHang.CurrentRow.Cells[1].Value.ToString();

            _ctrlDonDatHang.IdDonDatHang = _ctrlDonDatHang.GetIdDonDatHangTheoSoDon(_maHoaDon);

            this.DialogResult = DialogResult.OK;
        }

        private void dgViewDonDatHang_DoubleClick(object sender, EventArgs e)
        {
            btnChon.PerformClick();
        }

        private void dgViewDonDatHang_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _donDatHangDT);
        }



    }
}

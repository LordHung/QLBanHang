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
    public partial class TimKiemHoaDonDlg : Form
    {
        ctrlHoaDon _ctrlHoaDon;

        DataTable thongKeHoaDonDT = new DataTable();

        public TimKiemHoaDonDlg()
        {
            InitializeComponent();
            DoubleBuffering();
        }


        public TimKiemHoaDonDlg(ctrlHoaDon ctrlHoaDon)
        {
            InitializeComponent();
            _ctrlHoaDon = ctrlHoaDon;
            thongKeHoaDonDT = _ctrlHoaDon.TimKiemHoaDon();
            dgViewHoaDon.DataSource = thongKeHoaDonDT;
        }

        private void DoubleBuffering()
        {
            ImprovePerfomance.SetDoubleBuffering(dgViewHoaDon);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string _maHoaDon = dgViewHoaDon.CurrentRow.Cells[2].Value.ToString();

            _ctrlHoaDon.IdHoaDon = _ctrlHoaDon.GetIdHoaDon(_maHoaDon);

            this.DialogResult = DialogResult.OK;
        }

        private void dgViewHoaDon_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, thongKeHoaDonDT);
        }
    }
}

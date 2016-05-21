using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.Views
{
    public partial class FrmTaoPQT_PDD_Base : Form
    {
        public FrmTaoPQT_PDD_Base()
        {
            InitializeComponent();
        }

        private void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tsLblSoLuong.Text = (dgView.Rows.Count - 1).ToString() + " phiếu.";
        }
    }
}

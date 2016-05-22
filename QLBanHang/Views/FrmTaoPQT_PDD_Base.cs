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

namespace QLBanHang.Views
{
    public partial class FrmTaoPQT_PDD_Base : Form
    {
        public FrmTaoPQT_PDD_Base()
        {
            InitializeComponent();

            splitContainer1.Panel1.BackColor = GlobalValues.GlobalBackGroundColor;
            dgView.BackgroundColor = GlobalValues.GlobalBackGroundColor;
            toolStrip1.BackColor = GlobalValues.GlobalBackGroundColor;
            splitContainer1.Panel2.BackColor = GlobalValues.GlobalBackGroundColor;
            dgView.BorderStyle = BorderStyle.None;
            
        }

        private void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tsLblSoLuong.Text = (dgView.Rows.Count - 1).ToString() + " phiếu.";
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
        }
    }
}

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
    public partial class FrmTaoPhieuQuaTang: FrmTaoPQT_PDD_Base,IPhieuQuaTangView
    {

        ctrlPhieuQuaTang _ctrlPhieuQuaTang = new ctrlPhieuQuaTang();

        clsPhieuQuaTang _phieuQuaTang = new clsPhieuQuaTang();

        DataTable _daTaoPhieuQuaTangDT = new DataTable();

        public FrmTaoPhieuQuaTang()
        {
            InitializeComponent();
            _ctrlPhieuQuaTang.SetView(this);
            dtpHSD.Value = dtpHSD.Value.AddMonths(8);
        }


        private void AddData()
        {
            for (int i = 0; i < (int)numSoPhieu.Value; i++)
            {
                if (!AssignData())
                    return;
                else
                    _ctrlPhieuQuaTang.AddData(_phieuQuaTang,false);
            }
        }

        private bool AssignData()
        {
            //MaVach
            _phieuQuaTang.MaVach = _ctrlPhieuQuaTang.GetNewSoPhieu();
            //idKhachHang
            _phieuQuaTang.IdKhachHang = 0;
            //NgayTao
            _phieuQuaTang.NgayTao = dtpNgayLap.Value;
            //TriGia
            if ((int)numTriGiaPhieu.Value > 0)
            {
                _phieuQuaTang.TriGia = (int)numTriGiaPhieu.Value;
            }
            else
            {
                MessageBox.Show("Trị Giá phải lớn hơn 0", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //NgaySuDung
            _phieuQuaTang.NgaySuDung = DateTime.MinValue;
            //HSD
            _phieuQuaTang.HanSuDung = dtpHSD.Value;
            //MoTa
            _phieuQuaTang.GhiChu = txtGhiChu.Text;

            if (dtpHSD.Value < dtpNgayLap.Value)
            {
                MessageBox.Show("Ngày tạo phải nhỏ hơn ngày sử dụng", "Thông báo"
                                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        public void UpdateViewPhieuQuaTang()
        {
            _daTaoPhieuQuaTangDT = _ctrlPhieuQuaTang.GetData((int)numSoPhieu.Value);
            dgView.DataSource = _daTaoPhieuQuaTangDT;
            dgView.Invalidate();
        }
    }
}

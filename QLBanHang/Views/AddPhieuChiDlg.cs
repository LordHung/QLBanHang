using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Controls;
using QLBanHang.Objects;


namespace QLBanHang.Views
{
    public partial class AddPhieuChiDlg : BaseAddUpdatePhieuChi
    {
        public AddPhieuChiDlg()
        {
            InitializeComponent();
        }


        ctrlPhieuChi _ctrlPhieuChi = new ctrlPhieuChi();

        clsPhieuChi _phieuChi = new clsPhieuChi();

        int _idNhanVien = 7;

        int _idCuaHang = 9;


        public AddPhieuChiDlg(ctrlPhieuChi _ctrl)
        {
            InitializeComponent();
            txtMaPhieu.Text = _ctrlPhieuChi.GetNewMaPhieuChi();
            _ctrlPhieuChi = _ctrl;
        }

        private bool AssignData()
        {
            bool Valid = true;

            string Error = "";
            ///idNhanVien
            _phieuChi.IdNhanVien = _idNhanVien;
            //Ten Nguoi Nop

            if (txtTenNguoiNhan.Text.Trim().Length > 0)
            {
                _phieuChi.TenNguoiNhan = txtTenNguoiNhan.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập tên người nộp, ";
                Valid = false;
            }
            ///DiaCHi
            _phieuChi.DiaChi = txtDiaChi.Text;

            ///Ly do

            if (txtLyDo.Text.Trim().Length > 0)
            {
                _phieuChi.LyDo = txtLyDo.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập lý do, ";
                Valid = false;
            }

            ///So Tiem
            if (numSoTien.Value != 0)
            {
                _phieuChi.SoTien = numSoTien.Value;
            }
            else
            {
                Error += "Chưa nhập số tiền, ";
                Valid = false;
            }
            //Chung tu kem theo
            _phieuChi.ChungTyKemTheo = txtChungTuKem.Text.Trim();
            //idCuaHang
            _phieuChi.IdCuaHang = _idCuaHang;
            //SoPhieu
            _phieuChi.SoPhieu = _phieuChi.SoPhieu = _ctrlPhieuChi.GetNewSoPhieuChi();
            //NgayLap

            _phieuChi.NgayLap = dtpNgayChi.Value;

            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private bool AddData()
        {
            if (AssignData())
                return _ctrlPhieuChi.AddData(_phieuChi);
            return false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddData();
        }

    }
}

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
    public partial class AddPhieuThuDlg : BaseAddUpdatePhieuThu
    {

        ctrlPhieuThu _ctrlPhieuThu = new ctrlPhieuThu();

        clsPhieuThu _phieuThu = new clsPhieuThu();

        int _idNhanVien = 7;

        int _idCuaHang = 9;

        //AddPhieuThuDelegate Add = new AddPhieuThuDelegate(new ctrlPhieuThu().AddData);

        public AddPhieuThuDlg()
        {
            InitializeComponent();
            txtMaPhieu.Text = _ctrlPhieuThu.GetNewMaPhieuThu();
        }

        public AddPhieuThuDlg(ctrlPhieuThu _ctrl)
        {
            InitializeComponent();
            txtMaPhieu.Text = _ctrlPhieuThu.GetNewMaPhieuThu();
            _ctrlPhieuThu = _ctrl;
        }


        private bool AssignData()
        {
            bool Valid = true;

            string Error = "";
            ///idNhanVien
            _phieuThu.IdNhanVien = _idNhanVien;
            //Ten Nguoi Nop

            if (txtTenNguoiNop.Text.Trim().Length > 0)
            {
                _phieuThu.TenNguoiNop = txtTenNguoiNop.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập tên người nộp, ";
                Valid = false;
            }
            ///DiaCHi
            _phieuThu.DiaChi = txtDiaChi.Text;

            ///Ly do

            if (txtLyDo.Text.Trim().Length > 0)
            {
                _phieuThu.LyDo = txtLyDo.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập lý do, ";
                Valid = false;
            }

            ///So Tiem
            if (numSoTien.Value != 0)
            {
                _phieuThu.SoTien = numSoTien.Value;
            }
            else
            {
                Error += "Chưa nhập số tiền, ";
                Valid = false;
            }
            //Chung tu kem theo
            _phieuThu.ChungTyKemTheo = txtChungTuKem.Text.Trim();
            //idCuaHang
            _phieuThu.IdCuaHang = _idCuaHang;
            //SoPhieu
            _phieuThu.SoPhieu = _phieuThu.SoPhieu = _ctrlPhieuThu.GetNewSoPhieuThu();
            //NgayLap
            _phieuThu.NgayLap = dtpNgayThu.Value;

            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private bool AddData()
        {
            if (AssignData())
                return _ctrlPhieuThu.AddData(_phieuThu);
            return false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddData();
        }
    }
}

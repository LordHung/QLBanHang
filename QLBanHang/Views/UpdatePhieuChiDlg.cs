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
    public partial class UpdatePhieuChiDlg : BaseAddUpdatePhieuChi
    {
        public UpdatePhieuChiDlg()
        {
            InitializeComponent();
        }

        ctrlPhieuChi _ctrlPhieuChi = new ctrlPhieuChi();

        clsPhieuChi _phieuChi = new clsPhieuChi();

        /// <summary>
        /// Mã phiếu thu được truyền từ FrmQuanLyPhieuThu
        /// </summary>
        /// <param name="maPhieuChi"></param>
        public UpdatePhieuChiDlg(ctrlPhieuChi _ctrl, string maPhieuChi)
        {
            InitializeComponent();
            ///Gán controller cho Dlg
            _ctrlPhieuChi = _ctrl;
            ///Load Dữ liệu của mã phieu thu
            LoadData(maPhieuChi);
            //_maPhieuThu = maPhieuThu;
        }

        public void LoadData(string maPhieuChi)
        {
            ///Lấy Id từ mã phiếu thu trên view
            _phieuChi.Id = _ctrlPhieuChi.GetIdByMaPhieu(maPhieuChi);
            //Lấy row dữ liệu tương ứng với id trong databse 
            DataRow row = _ctrlPhieuChi.GetPhieuThuById(_phieuChi.Id).Rows[0];
            //Gán các giá trị mặc định vào _phieuthu
            _phieuChi.IdNhanVien = Convert.ToInt32(row["idNhanVien"].ToString());

            _phieuChi.IdCuaHang = Convert.ToInt32(row["idCuaHang"].ToString());

            _phieuChi.SoPhieu = Convert.ToInt32(row["SoPhieu"].ToString());
            //Gán giá trị lên view
            //NgayLap
            dtpNgayChi.Value = Convert.ToDateTime(row["NgayLap"].ToString());

            ///Ma Phieu
            txtMaPhieu.Text = maPhieuChi;
            //Ten nguoi nop
            txtTenNguoiNhan.Text = row["TenNguoiNhan"].ToString();
            ///DiaChi
            txtDiaChi.Text = row["DiaChi"].ToString();
            ///SoTien
            numSoTien.Value = Convert.ToDecimal(row["SoTien"].ToString());
            ///LyDo
            txtLyDo.Text = row["LyDo"].ToString();
            ///Chung tu kem
            txtChungTuKem.Text = row["ChungTyKemTheo"].ToString();
        }

        public bool AssignData()
        {
            ///Kiểm tra xem đã điền đầy đủ thông tin chưa
            bool Valid = true;

            string Error = "";
            ///idNhanVien

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

            //SoPhieu
            
            //NgayLap

            _phieuChi.NgayLap = dtpNgayChi.Value;

            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private bool UpDateData()
        {
            if (AssignData())
                return _ctrlPhieuChi.UpdateData(_phieuChi);
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDateData();
        }
    }
}

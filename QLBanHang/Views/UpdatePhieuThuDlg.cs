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
    public partial class UpdatePhieuThuDlg : Form
    {

        ctrlPhieuThu _ctrlPhieuThu = new ctrlPhieuThu();

        clsPhieuThu _phieuThu = new clsPhieuThu();

        public UpdatePhieuThuDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mã phiếu thu được truyền từ FrmQuanLyPhieuThu
        /// </summary>
        /// <param name="maPhieuThu"></param>
        public UpdatePhieuThuDlg(ctrlPhieuThu _ctrl,string maPhieuThu)
        {
            InitializeComponent();
            ///Gán controller cho Dlg
            _ctrlPhieuThu = _ctrl;
            ///Load Dữ liệu của mã phieu thu
            LoadData(maPhieuThu);
            //_maPhieuThu = maPhieuThu;
        }

        private void UpdatePhieuThuDlg_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadData(string maPhieuThu)
        {
            ///Lấy Id từ mã phiếu thu trên view
            _phieuThu.Id = _ctrlPhieuThu.GetIdByMaPhieu(maPhieuThu);
            //Lấy row dữ liệu tương ứng với id trong databse 
            DataRow row = _ctrlPhieuThu.GetPhieuThuById(_phieuThu.Id).Rows[0];
            //Gán các giá trị mặc định vào _phieuthu
            _phieuThu.IdNhanVien = Convert.ToInt32(row["idNhanVien"].ToString());

            _phieuThu.IdCuaHang = Convert.ToInt32(row["idCuaHang"].ToString());

            _phieuThu.SoPhieu = Convert.ToInt32(row["SoPhieu"].ToString());
            //Gán giá trị lên view
            //ngaythu
            dtpNgayThu.Value = Convert.ToDateTime(row["NgayLap"].ToString());
            ///Ma Phieu
            txtMaPhieu.Text = maPhieuThu;
            //Ten nguoi nop
            txtTenNguoiNop.Text = row["TenNguoiNop"].ToString();
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
            bool Valid = true;

            string Error = "";
            ///idNhanVien

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

            //SoPhieu
            
            //NgayLap
            _phieuThu.NgayLap = dtpNgayThu.Value;

            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private bool UpDateData()
        {
            if (AssignData())
                return _ctrlPhieuThu.UpdateData(_phieuThu);
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDateData();
        }
    }
}

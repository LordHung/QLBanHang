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
    public partial class FrmThongKePhieuQuaTang : Frm_Them_Xoa_Sua_Base,IPhieuQuaTangView
    {
        bool _theoPhieuQuaTang = true;

        bool _theoPhieuDoiDiem = true;

        int _idKhachHang = 0;

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        DataTable _khachHangDT = new DataTable();

        ctrlPhieuQuaTang _ctrlPhieuQuaTang = new ctrlPhieuQuaTang();

        DataTable _phieuQuaTangDT = new DataTable();

        public FrmThongKePhieuQuaTang()
        {
            InitializeComponent();
            LoadData();
            _ctrlPhieuQuaTang.SetView(this);
        }


        private void LoadData()
        {
            ///Ẩn thanh menu thêm xóa sửa từ frm chính
            toolStrip1.Visible = false;
            ///Giảm từ ngày xuống 1 tháng
            ///tăng đến ngày lên 1 ngày so với thời điểm hiện tại
            dtpTuNgay.Value = dtpTuNgay.Value.AddMonths(-1);
            dtpDenNgay.Value = dtpDenNgay.Value.AddDays(1);
            ///CkRadiTaoPhieu
            ckTaoPhieu.Checked = true;
            //KhachHang
            LoadKhachHang();
            //btngs
            CustomButtons();
            LoadColorButtons();

            cmbKhachHang.Enabled = false;

            _idKhachHang = 0;
        }

        /// <summary>
        /// Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckDaSD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDaSD.Checked)
            {
                ckTaoPhieu.Checked = false;
                ckChuaSD.Visible = false;
                ckNgayHetHan.Checked = false;
                ckChuaSD.Checked = false;
            }
        }

        private void ckChuaSD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckNgayHetHan_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNgayHetHan.Checked)
            {
                ckTaoPhieu.Checked = false;
                ckDaSD.Checked = false;
                ckChuaSD.Visible = true;
            }
        }

        private void ckTaoPhieu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTaoPhieu.Checked)
            {
                ckNgayHetHan.Checked = false;
                ckDaSD.Checked = false;
                ckChuaSD.Visible = true;
            }
        }

        /// <summary>
        /// Custome cho btnTheo phieu doi diem va btn theophieuquatang
        /// </summary>
        private void CustomButtons()
        {
            
            btnPhieuDoiDiem.TabStop = false;
            btnPhieuDoiDiem.FlatStyle = FlatStyle.Flat;
            btnPhieuDoiDiem.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhieuDoiDiem.FlatAppearance.BorderSize = 0;
            //btnNhapKho.ForeColor

            btnPhieuQuaTang.TabStop = false;
            btnPhieuQuaTang.FlatStyle = FlatStyle.Flat;
            btnPhieuQuaTang.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhieuQuaTang.FlatAppearance.BorderSize = 0;
        }

        private void btnPhieuQuaTang_Click(object sender, EventArgs e)
        {
            if (_theoPhieuQuaTang == true)
            {
                _theoPhieuQuaTang = false;
            }
            else
                _theoPhieuQuaTang = true;
            LoadColorButtons();
            CheckCombKhachHang();
        }

        private void btnPhieuDoiDiem_Click(object sender, EventArgs e)
        {
            if (_theoPhieuDoiDiem == true)
            {
                _theoPhieuDoiDiem = false;
            }
            else
                _theoPhieuDoiDiem = true;
            LoadColorButtons();
            CheckCombKhachHang();
        }
        /// <summary>
        /// đỏi màu btn tùy theo có được chọn hay không
        /// </summary>
        private void LoadColorButtons()
        {
            if (_theoPhieuDoiDiem)
            {
                btnPhieuDoiDiem.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
            }
            else
                btnPhieuDoiDiem.BackColor = GlobalValues.BackGroundMenu_NonColor;

            if (_theoPhieuQuaTang)
            {
                btnPhieuQuaTang.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
            }
            else
                btnPhieuQuaTang.BackColor = GlobalValues.BackGroundMenu_NonColor;
        }

        /// 
        /// Khách Hàng
        ///
        private void LoadKhachHang()
        {
            _khachHangDT = _ctrlKhachHang.GetKhachHang();

            cmbKhachHang.DataSource = _khachHangDT;

            cmbKhachHang.DisplayMember = "KhachHang";

            //LoadIdKhachHang();
        }

        private void LoadIdKhachHang()
        {
            int index = cmbKhachHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _khachHangDT.Rows[index];//Lấy row tương ứng với index
                _idKhachHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idKhachHang = 0;
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdKhachHang();
            return;
        }

        private void ckBoxTheoKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxTheoKhachHang.Checked == true)
            {
                LoadIdKhachHang();
                cmbKhachHang.Enabled = true;
            }
            else if (ckBoxTheoKhachHang.Checked == false)
            {
                _idKhachHang = 0;
                cmbKhachHang.Enabled = false;
            }
        }

        private void CheckCombKhachHang()
        {
            if (_theoPhieuQuaTang && !_theoPhieuDoiDiem)
            {
                _idKhachHang = 0;
                ckBoxTheoKhachHang.Enabled = false;
                ckBoxTheoKhachHang.Checked = false;
                cmbKhachHang.Enabled = false;
            }
            else
            {
                ckBoxTheoKhachHang.Enabled = true;
                //cmbKhachHang.Enabled = true;
                //LoadIdKhachHang();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!_theoPhieuDoiDiem && !_theoPhieuQuaTang)
            {
                MessageBox.Show(this, "Phải chọn ít nhất một loại phiếu", "thông báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            else
            {
             
                _phieuQuaTangDT = _ctrlPhieuQuaTang.ThongKeDuLieu(dtpTuNgay.Value,dtpDenNgay.Value
                    ,ckTaoPhieu.Checked,
                    ckChuaSD.Checked,
                    ckDaSD.Checked,
                    _theoPhieuQuaTang,_theoPhieuDoiDiem
                    ,_idKhachHang);

                //_phieuQuaTangDT = _ctrlPhieuQuaTang.GetData();
                dgView.DataSource = _phieuQuaTangDT;
                UpdateViewPhieuQuaTang();
            }
        }


        public void UpdateViewPhieuQuaTang()
        {
            dgView.Invalidate();
        }
    }
}

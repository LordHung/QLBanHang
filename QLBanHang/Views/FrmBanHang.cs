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
using System.Collections;
using System.Reflection;

namespace QLBanHang.Views
{
    public partial class FrmBanHang : Frm_KinhDoanh_Base, IHoaDonView
    {
        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        clsNhanVien _nhanVien = new clsNhanVien();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();
        ///
        /// dùng để hiển thị các sản phẩm bán được tại cửa hàng
        ///


        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        ctrlHoaDon _ctrlHoaDon = new ctrlHoaDon();
        ///
        /// Lưu thông tin hóa đơn
        /// 
        clsHoaDon _hoaDon = new clsHoaDon();

        ///
        ///
        /// 
        ctrlDonDatHang _ctrlDonDatHang = new ctrlDonDatHang();

        clsDonDatHang _donDatHang = new clsDonDatHang();
        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 
        //DataTable _maVachDT = new DataTable();
        //ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        DataTable _maVachBanHangDT = new DataTable();
        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = GlobalValues.IdNhanVien;

        int _idKhachHang;

        DataTable _cuaHangDT = new DataTable();

        ///
        /// 
        ///
        ctrlChiTietHoaDon _ctrlChiTietHoaDon = new ctrlChiTietHoaDon();

        clsChiTietHoaDon _chiTietHoaDon = new clsChiTietHoaDon();

        /// <summary>
        /// 
        /// </summary>
        ctrlThuNoKhachHang _ctrlThuNoKhachHang = new ctrlThuNoKhachHang();

        clsThuNoKhachHang _thuNoKhachHang = new clsThuNoKhachHang();

        public FrmBanHang()
        {
            InitializeComponent();

            _ctrlHoaDon.SetView(this);

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadControlBanHang();
            LoadMaVachSanPham();
            LoadMaVachSanPhamBanHang();
        }
        /// <summary>
        /// Load Mã vạch sản phẩm lê dgViewMaVach
        /// </summary>
        //protected override void LoadMaVachSanPham()
        //{
        //    _maVachDT = new DataTable();

        //    _maVachDT = _ctrlMaVachSanPham.GetData(_idCuaHang);

        //    dgViewMaVach.DataSource = _maVachDT;


        //}


        /// 
        /// Tạo các cột dữ lieeujc cho MaVachDuocCHon Datattable 


        private void LoadMaVachSanPhamBanHang()
        {
            initMaVachDuocChon();
            dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
        }


        private void initMaVachDuocChon()
        {

            _maVachBanHangDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("id", typeof(string));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("MaSanPham", typeof(string));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("TenSanPham", typeof(string));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("DonVi", typeof(string));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(int));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("VAT", typeof(int));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(int));
            _maVachBanHangDT.Columns.Add(dc);

            dc = new DataColumn("GhiChu", typeof(int));
            _maVachBanHangDT.Columns.Add(dc);
        }


        #region HoaDonBanHang

        private DataTable _khachHangDT = new DataTable();
        /// 
        /// load dữ liệu vào control
        /// 
        private void LoadControlBanHang()
        {
            ///hiển thị mã hóa đơn
            DateTime now = DateTime.Now;
            txtMaHoaDon.Text = _ctrlHoaDon.GetNewMaHoaDonByNow();
            txtMaHoaDon.Invalidate();
            ///KhachHang
            LoadKhachHang();
            ///NhanVien
            txtNhanVienLapHoaDon.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            txtNhanVienLapHoaDon.Invalidate();
        }
        /// 
        /// Khách Hàng
        ///
        private void LoadKhachHang()
        {
            _khachHangDT = _ctrlKhachHang.GetKhachHang();
            cmbKhachHangMuaHoaDon.DataSource = _khachHangDT;

            cmbKhachHangMuaHoaDon.DisplayMember = "KhachHang";
            LoadIdKhachHang();
            cmbKhachHangMuaHoaDon.Invalidate();
        }

        private void LoadIdKhachHang()
        {
            int index = cmbKhachHangMuaHoaDon.SelectedIndex;//Lấy index trên comboBox
            DataTable table = _ctrlKhachHang.GetIdKhachHang();//Get Id các cửa hàng
            DataRow row = table.Rows[index];//Lấy row tương ứng với index
            _idKhachHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdKhachHang();
        }

        #endregion

        #region xử lý trên datagridview

        protected override void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamBanHang();
        }

        public void ChonSanPhamBanHang()
        {
            ///Lấy mã vạch từ mavachdgView
            int idMaVachSanPham = Convert.ToInt32(dgViewMaVach.CurrentRow.Cells[0].Value.ToString());
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row =  _ctrlMaVachSanPham.GetRowMaVachSanPham(_idCuaHang,idMaVachSanPham).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            if (!PlusSelectedMaVach(idMaVachSanPham, _maVachBanHangDT) && Convert.ToInt32(row["SoLuong"].ToString()) > 0)
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachBanHangDT.NewRow();
                newRow["id"] = row["id"].ToString();
                newRow["MaSanPham"] = row["MaSanPham"].ToString();
                newRow["TenSanPham"] = row["TenSanPham"].ToString();
                newRow["DonVi"] = row["DonVi"].ToString();
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = Convert.ToInt32(row["GiaBan"].ToString());
                newRow["VAT"] = Convert.ToInt32(row["VAT"].ToString());
                newRow["ThanhTien"] = Convert.ToInt32(row["GiaBan"].ToString());

                _maVachBanHangDT.Rows.Add(newRow);
            }
            else if (Convert.ToInt32(row["SoLuong"].ToString()) <= 0)
            {
                MessageBox.Show(this, "Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ///Gán dữ liệu vào dgView
            dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
            LoadNumericBoxes();
            dgViewMaVachDaChon.Invalidate();
        }


      
        #endregion

        protected override void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongMaVachBanHang();
        }

        protected override void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongMaVachBanHang();
        }


        public void TangSoLuongMaVachBanHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null 
                && PlusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()),_maVachBanHangDT)) 
            {
                dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        public void GiamSoLuongMaVachBanHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null 
                && MinusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()),_maVachBanHangDT))
            {
                dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        private void LoadNumericBoxes()
        {
            int congTien = 0;
            foreach (DataRow row in _maVachBanHangDT.Rows)
            {
                congTien += Convert.ToInt32(row["ThanhTien"].ToString());
            }
            numCongTien.Value = (decimal)congTien;
            int tongTien = congTien - congTien * (int)numCK.Value / 100;
            numTongTien.Value = (decimal)tongTien;
            numSoTienKhachDua.Value = (decimal)tongTien;
        }

        private void numCK_ValueChanged(object sender, EventArgs e)
        {
            LoadNumericBoxes();
        }

        /// 
        /// Lưu dữ liệu vào _hoaDon
        /// 
        private void AssignHoaDon()
        {
            DateTime now = DateTime.Now;

            _hoaDon.ChietKhau = (int)numCK.Value;

            _hoaDon.SoHoaDon = _ctrlHoaDon.GetNewSoHoaDonByNow();

            _hoaDon.SoTienKhachDua = numSoTienKhachDua.Value;

            _hoaDon.GhiChu = txtGhiChuHoaDon.Text;

            _hoaDon.IdNhanVien = _idNhanVien;

            _hoaDon.IdCuaHang = _idCuaHang;

            _hoaDon.IdKhachHang = _idKhachHang;

            _hoaDon.NgayLap = dtpNgayLapHoaDon.Value;

            _hoaDon.SiLe = false;
        }

        private void AssignThuNoKhachHang()
        {
            DateTime now = DateTime.Now;

            _thuNoKhachHang.IdKhachHang = _idKhachHang;

            _thuNoKhachHang.NgayThu = dtpNgayLapHoaDon.Value;

            _thuNoKhachHang.SoTien = numSoTienKhachDua.Value;

            _thuNoKhachHang.IdHoaDon = _ctrlHoaDon.GetIdHoaDon();

            _thuNoKhachHang.GhiChu = "Thu tiền hóa đơn " + txtMaHoaDon.Text;

            _thuNoKhachHang.IdNhanVien = _idNhanVien;

            _thuNoKhachHang.IdCuaHang = _idCuaHang;

            _thuNoKhachHang.SoPhieu = _ctrlThuNoKhachHang.GetNewSoPhieuByNow();

            _thuNoKhachHang.IdPhieuNhap = 0;

        }


        private void AssignChiTietHoaDon(DataRow row)
        {
            _chiTietHoaDon = new clsChiTietHoaDon();

            int idMaVach = Convert.ToInt32(row["id"].ToString());

            //ChiTietHoaDon
            _chiTietHoaDon.IdMaVachSanPham = idMaVach;

            _chiTietHoaDon.IdHoaDon = _ctrlHoaDon.GetIdHoaDon();

            _chiTietHoaDon.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());

            _chiTietHoaDon.ThoiGianBaoHanh = 12;

            _chiTietHoaDon.ChietKhau = 0;

            _chiTietHoaDon.VAT = Convert.ToInt32(row["VAT"].ToString());

            _chiTietHoaDon.DonGia = Convert.ToInt32(row["DonGia"].ToString());

            _chiTietHoaDon.SanPhamComBo = 0;

            _chiTietHoaDon.GiaVon = _ctrlMaVachSanPham.GetGiaVonBanLe(idMaVach, 1);

            _chiTietHoaDon.GhiChu = txtGhiChuHoaDon.Text;
        }

        public void AddChiTietHoaDon()
        {
            foreach (DataRow row in _maVachBanHangDT.Rows)
            {
                AssignChiTietHoaDon(row);
                if (_ctrlChiTietHoaDon.AddData(_chiTietHoaDon))
                {
                    ///Giảm số lượng sản phẩm có trong database 
                    int idMaVach = Convert.ToInt32(row["id"].ToString());
                    _ctrlMaVachSanPham.GiamSoLuong(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));
                }
            }
        }

        public bool AddHoaDon()
        {
            AssignHoaDon();
            return _ctrlHoaDon.AddData(_hoaDon);
        }

        public void AddThuNoKhachHang()
        {
            AssignThuNoKhachHang();
            _ctrlThuNoKhachHang.AddData(_thuNoKhachHang);
        }

        protected override void tSbBtnDongY_Click(object sender, EventArgs e)
        {
            if (_maVachBanHangDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (AddHoaDon())
            {
                //dgViewMaVachDaChon.DataSource = null;
                AddChiTietHoaDon();
                AddThuNoKhachHang();
            }
            ResetViewHoaDon();
        }

        protected override void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {

            txtGhiChuHoaDon.Text = _idCuaHang.ToString();
        }

        public void ResetViewHoaDon()
        {
            LoadControlBanHang();
            LoadMaVachSanPham();
            LoadMaVachSanPhamBanHang();
            LoadNumericBoxes();
        }

        protected override void dgViewMaVach_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= _maVachDT.Rows.Count)
                return;

            if (e.ColumnIndex >= _maVachDT.Columns.Count)
                return;
            e.Value = _maVachDT.Rows[e.RowIndex][e.ColumnIndex];
        }
    ///Support cho hàm custom datagridview hiển thị dữ liệu khác nhau trên từng Form
        protected override void UpdateCustomDataGridView()
        {
            dgViewMaVach.Columns["GiaSi"].Visible = false;
            //GiaNhap
            dgViewMaVach.Columns["GiaNhap"].Visible = false;
            //GiaBan
            dgViewMaVach.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgViewMaVach.Columns["GiaBan"].DefaultCellStyle.ForeColor = Color.Red;
        }
    }
}

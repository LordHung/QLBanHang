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
using QLBanHang.Models;


namespace QLBanHang.Views
{
    public partial class FrmXuatKho : Frm_KinhDoanh_Base
    {

        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        ctrlDangNhap _ctrlDangNhap = new ctrlDangNhap();

        FrmDangNhapDlg _dangNhapDlg = new FrmDangNhapDlg();

        clsNhanVien _nhanVien = new clsNhanVien();


        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();
        ///
        /// dùng để hiển thị các sản phẩm bán được tại cửa hàng
        ///
        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        ctrlChiTietDonDatHang _ctrlChiTietDonDatHang = new ctrlChiTietDonDatHang();

        ctrlTraNoNhaCungCap _ctrlTraNoNhaCungCap = new ctrlTraNoNhaCungCap();
        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 
        DataTable _maVachDT = new DataTable();

        DataTable _maVachXuatKhoDT = new DataTable();

        DataTable _cuaHangDT = new DataTable();


        enum DisplayMaPhieu
        {
            TraNhaCungCap,
            ChuyenKho,
            Huy

        }

        DisplayMaPhieu _displayMaPhieu = DisplayMaPhieu.ChuyenKho;

        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = GlobalValues.IdNhanVien;

        int _idLoaiPhieuXuat;

        int _idNhaCungCap = 0;

        int _idChuyenHang = 0;

        int _idPhieuChuyen = 0;
        ///
        /// 
        ///
        ctrlChiTietHoaDon _ctrlChiTietHoaDon = new ctrlChiTietHoaDon();

        clsChiTietHoaDon _chiTietHoaDon = new clsChiTietHoaDon();

        /// <summary>
        /// 
        /// </summary>
        //ctrlThuNoKhachHang _ctrlThuNoKhachHang = new ctrlThuNoKhachHang();

        clsTraNoNhaCungCap _traNoNhaCungCap = new clsTraNoNhaCungCap();
        /// <summary>
        /// 
        /// </summary>
        ctrlPhieuXuat _ctrlPhieuXuat = new ctrlPhieuXuat();

        ctrlLoaiPhieuXuat _ctrlLoaiPhieuXuat = new ctrlLoaiPhieuXuat();

        clsPhieuXuat _phieuXuat = new clsPhieuXuat();

        DataTable _loaiPhieuXuatDT = new DataTable();

        DataTable _nhaCungCapDT = new DataTable();

        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        clsChiTietPhieuXuat _chiTietPhieuXuat = new clsChiTietPhieuXuat();

        ctrlChiTietPhieuXuat _ctrlChiTietPhieuXuat = new ctrlChiTietPhieuXuat();
        /// <summary>
        /// Constructor
        /// </summary>

        public FrmXuatKho()
        {
            InitializeComponent();

            LoadMaVachSanPham();

            LoadControlXuatKho();

            LoadMaVachSanPhamXuatKho();

            ResetViewPhieuXuat();

            tSTxtMain.Text = "Xuất kho";
        }

        /// <summary>
        /// Load Mã vạch sản phẩm lê dgViewMaVach
        /// </summary>
        protected override void LoadMaVachSanPham()
        {
            _maVachDT = new DataTable();

            _maVachDT = _ctrlMaVachSanPham.GetData(_idCuaHang);

            dgViewMaVach.DataSource = _maVachDT;

            dgViewMaVach.Columns["MaVach"].DefaultCellStyle.ForeColor = Color.Red;
            dgViewMaVach.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.BackColor = Color.Yellow;
            dgViewMaVach.Columns["GiaBan"].DefaultCellStyle.ForeColor = Color.Green;
        }


        /// 
        /// Tạo các cột dữ lieeujc cho MaVachDuocCHon Datattable 
        #region MaVachSanPhamDuocChon

        private void LoadMaVachSanPhamXuatKho()
        {
            initMaVachNhapKhoDT();

            dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;

            AlterDgViewMaVachNhapKho();
        }


        private void initMaVachNhapKhoDT()
        {

            _maVachXuatKhoDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("id", typeof(string));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("idChiTietPhieuChuyen", typeof(string));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("MaSanPham", typeof(string));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("TenSanPham", typeof(string));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("DonVi", typeof(string));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(int));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(int));
            _maVachXuatKhoDT.Columns.Add(dc);

            dc = new DataColumn("GhiChu", typeof(int));
            _maVachXuatKhoDT.Columns.Add(dc);

        }

        private void AlterDgViewMaVachNhapKho()
        {
            dgViewMaVachDaChon.Columns["idChiTietPhieuChuyen"].Visible = false;
        }
        #endregion


        #region HoaDonXuat

        /// 
        /// load dữ liệu vào control
        /// 
        private void LoadControlXuatKho()
        {
            ///hiển thị mã phiếu nhập
            LoadMaPhieuXuat();
            ///NhanVien
            txtNhanVienLap.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            txtNhanVienLap.Invalidate();
            ///LoaiPhieuXuat
            LoadLoaiPhieuXuat();
            ///NhaCunCap
            LoadNhaCungCap();
        }
        private void LoadMaPhieuXuat()
        {
            switch (_displayMaPhieu)
            {
                case DisplayMaPhieu.ChuyenKho:
                    txtMaPhieu.Text = _ctrlPhieuXuat.GetNewMaPhieuXuatChuyenKho();
                    break;
                case DisplayMaPhieu.TraNhaCungCap:
                    txtMaPhieu.Text = _ctrlPhieuXuat.GetNewMaPhieuXuatTraNhaCungCap();
                    break;
                case DisplayMaPhieu.Huy:
                    txtMaPhieu.Text = _ctrlPhieuXuat.GetNewMaPhieuXuatHuy();
                    break;
                default:
                    txtMaPhieu.Text = _ctrlPhieuXuat.GetNewMaPhieuXuatChuyenKho();
                    break;
            }
            txtMaPhieu.Invalidate();
        }


        #region LoaiPhieuXuat
        /// 
        /// Loại phiếu nhập
        /// 
        private void LoadLoaiPhieuXuat()
        {
            _loaiPhieuXuatDT = _ctrlLoaiPhieuXuat.GetLoaiPhieuXuat();

            cmbLoaiPhieu.DataSource = _loaiPhieuXuatDT;

            cmbLoaiPhieu.DisplayMember = "LoaiPhieuXuat";

            LoadIdLoaiPhieuXuat();

            cmbLoaiPhieu.Invalidate();
        }


        private void LoadIdLoaiPhieuXuat()
        {
            int index = cmbLoaiPhieu.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _loaiPhieuXuatDT.Rows[index];//Lấy row tương ứng với index
                _idLoaiPhieuXuat = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else if (index < 0)
            {
                DataRow row = _loaiPhieuXuatDT.Rows[0];//Lấy row tương ứng với index
                _idLoaiPhieuXuat = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void cmbLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdLoaiPhieuXuat();
            _displayMaPhieu = (DisplayMaPhieu)cmbLoaiPhieu.SelectedIndex;
            LoadMaPhieuXuat();
            EnableItems();
        }


        #endregion

        #region NhaCungCap
        /// 
        /// Nhà cung cấp
        /// 
        private void LoadNhaCungCap()
        {
            _nhaCungCapDT = _ctrlNhaCungCap.GetNhaCungCap();

            cmbNhaCungCap.DataSource = _nhaCungCapDT;

            cmbNhaCungCap.DisplayMember = "NhaCungCap";

            LoadIdNhaCungCap();

            cmbNhaCungCap.Invalidate();
        }


        private void LoadIdNhaCungCap()
        {
            int index = cmbNhaCungCap.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nhaCungCapDT.Rows[index];//Lấy row tương ứng với index
                _idNhaCungCap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else if (index < 0)
            {
                DataRow row = _nhaCungCapDT.Rows[0];//Lấy row tương ứng với index
                _idNhaCungCap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void tSCmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhaCungCap();
        }

        private void cmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhaCungCap();
        }

        #endregion

        #endregion
        #region xử lý trên datagridview

        protected override void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamPhieuNhap();
        }

        public void ChonSanPhamPhieuNhap()
        {
            AlterDgViewMaVachNhapKho();
            int idMaVachSanPham = Convert.ToInt32(dgViewMaVach.CurrentRow.Cells[0].Value.ToString());
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(idMaVachSanPham).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            if (!PlusSelectedMaVach(idMaVachSanPham, _maVachXuatKhoDT))
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachXuatKhoDT.NewRow();
                newRow["id"] = row["id"].ToString();
                newRow["MaSanPham"] = row["MaSanPham"].ToString();
                newRow["TenSanPham"] = row["TenSanPham"].ToString();
                newRow["DonVi"] = row["DonVi"].ToString();
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = Convert.ToInt32(row["GiaNhap"].ToString());
                newRow["ThanhTien"] = Convert.ToInt32(row["GiaNhap"].ToString());

                _maVachXuatKhoDT.Rows.Add(newRow);
            }
            ///Gán dữ liệu vào dgView
            dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;

            LoadNumericBoxes();

            AlterDgViewMaVachNhapKho();

            dgViewMaVachDaChon.Invalidate();
        }


        #endregion

        protected override void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongMaVachPhieuNhap();
        }

        protected override void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongMaVachPhieuNhap();
        }


        public void TangSoLuongMaVachPhieuNhap()
        {
            if (dgViewMaVachDaChon.CurrentRow != null
                  && PlusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachXuatKhoDT)) 
            {
                dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        public void GiamSoLuongMaVachPhieuNhap()
        {
            if (dgViewMaVachDaChon.CurrentRow != null  
                 && MinusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachXuatKhoDT)) 
            {
                dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        private void LoadNumericBoxes()
        {
            int congTien = 0;
            foreach (DataRow row in _maVachXuatKhoDT.Rows)
            {
                congTien += Convert.ToInt32(row["ThanhTien"].ToString());
            }

            numTongTien.Value = (decimal)congTien;
        }
        /// <summary>
        /// Gán các giá trị theo các trường hợp hiển thị của loại mã phiếu
        /// </summary>
        private void SetValues()
        {
            switch (_displayMaPhieu)
            {
                case (DisplayMaPhieu.ChuyenKho):
                    _idNhaCungCap = 0;
                    break;
                case (DisplayMaPhieu.TraNhaCungCap):
                    break;
                case (DisplayMaPhieu.Huy):
                    _idNhaCungCap = 0;
                    break;
            }
        }

        /// 
        /// Lưu dữ liệu vào _hoaDon
        /// 
        private void AssignPhieuXuat()
        {
            SetValues();

            DateTime now = DateTime.Now;

            _phieuXuat.NgayLap = now;

            _phieuXuat.IdCuaHang = _idCuaHang;

            _phieuXuat.IdNhanVien = _idNhanVien;

            _phieuXuat.GhiChu = "";

            _phieuXuat.SoPhieuXuat = _ctrlPhieuXuat.GetNewSoPhieuXuatByNow();

            _phieuXuat.IdLoaiPhieuXuat = _idLoaiPhieuXuat;

            _phieuXuat.GhiChu = txtGhiChu.Text;

            _phieuXuat.IdChuyenHang = _idChuyenHang;

            _phieuXuat.IdNhaCungCap = _idNhaCungCap;

        }


        private void AssignChiTietPhieuXuat(DataRow row)
        {
            _chiTietPhieuXuat = new clsChiTietPhieuXuat();
            ///Lấy id mã vạch sản phẩm
            int idMaVach = Convert.ToInt32(row["id"].ToString());

            _chiTietPhieuXuat.IdPhieuXuat = _ctrlPhieuXuat.GetIdPhieuXuat();

            _chiTietPhieuXuat.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());

            _chiTietPhieuXuat.DonGia = Convert.ToDecimal(row["DonGia"].ToString());

            _chiTietPhieuXuat.IdMaVachSanPham = idMaVach;

            _chiTietPhieuXuat.GiaVon = Convert.ToInt32(row["DonGia"].ToString());
            //_chiTietPhieuNhap.GiaBan = 0;

        }

        public void AddChiTietPhieuXuat()
        {
            foreach (DataRow row in _maVachXuatKhoDT.Rows)
            {
                AssignChiTietPhieuXuat(row);
                if (_ctrlChiTietPhieuXuat.AddData(_chiTietPhieuXuat))
                {
                    ///Lấy id mã vạch sản phẩm
                    int idMaVach = Convert.ToInt32(row["id"].ToString());

                    _ctrlMaVachSanPham.GiamSoLuong(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));
                }
            }
        }

        private void AssignTraNoNhaCungCap()
        {
            _traNoNhaCungCap.IdNhaCungCap = _idNhaCungCap;

            _traNoNhaCungCap.NgayTra = dtpNgayLap.Value;

            _traNoNhaCungCap.SoTien = (-1) * numTongTien.Value;

            _traNoNhaCungCap.IdNhanVien = _idNhanVien;

            _traNoNhaCungCap.GhiChu = "";

            _traNoNhaCungCap.IdCuaHang = _idCuaHang;

            _traNoNhaCungCap.IdPhieuNhap = 0;

            _traNoNhaCungCap.SoPhieu = _ctrlTraNoNhaCungCap.GetNewSoPhieuByNow();

            _traNoNhaCungCap.IdPhieuXuat = _ctrlPhieuXuat.GetIdPhieuXuat();

        }

        public void AddTraNoNhaCungCap()
        {
            AssignTraNoNhaCungCap();
            _ctrlTraNoNhaCungCap.AddData(_traNoNhaCungCap);
        }

        public bool AddPhieuXuat()
        {
            AssignPhieuXuat();
            return _ctrlPhieuXuat.AddData(_phieuXuat);
        }


        protected override void tSbBtnDongY_Click(object sender, System.EventArgs e)
        {
            if (_maVachXuatKhoDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (AddPhieuXuat())
            {
                //dgViewMaVachDaChon.DataSource = null;
                AddChiTietPhieuXuat();
                if (_displayMaPhieu == DisplayMaPhieu.TraNhaCungCap)
                    AddTraNoNhaCungCap();
            }
            ResetViewPhieuXuat();
        }

        protected override void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {

        }

        public void ResetViewPhieuXuat()
        {
            LoadControlXuatKho();
            LoadMaVachSanPham();
            LoadMaVachSanPhamXuatKho();
            LoadNumericBoxes();
        }

        private void EnableItems()
        {
            cmbNhaCungCap.Enabled = false;
            tSPhieuChuyen.Enabled = false;

            dgViewMaVach.Enabled = true;
            tSBtnChonMaVach.Enabled = true;
            tSBtnPlusMaVach.Enabled = true;
            tSbtnMinusMaVach.Enabled = true;



            if (_displayMaPhieu == DisplayMaPhieu.ChuyenKho && _idPhieuChuyen != 0)
            {
                dgViewMaVach.Enabled = false;
                tSBtnChonMaVach.Enabled = false;
                tSBtnPlusMaVach.Enabled = false;
                tSbtnMinusMaVach.Enabled = false;
                dgViewMaVachDaChon.Invalidate();

            }
            else
            {
                //dgViewMaVachDaChon.DataSource = null;
                dgViewMaVachDaChon.Invalidate();
                tSBtnChonMaVach.Enabled = true;
                tSBtnPlusMaVach.Enabled = true;
                tSbtnMinusMaVach.Enabled = true;
            }

            switch (_displayMaPhieu)
            {
                case DisplayMaPhieu.ChuyenKho:
                    tSPhieuChuyen.Enabled = true;
                    break;
                case DisplayMaPhieu.Huy:
                    break;
                case DisplayMaPhieu.TraNhaCungCap:
                    cmbNhaCungCap.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        protected override void dgViewMaVach_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _maVachDT);
        }


        private void tsBtnHuyPhieuChuyen_Click(object sender, System.EventArgs e)
        {
            _idPhieuChuyen = 0;
            tsTxtMaPhieuChuyen.TextBox.Text = "";
            EnableItems();
        }
    }
}

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
    public partial class FrmNhapKho : Frm_KinhDoanh_Base, IPhieuNhapView
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

        ctrlChiTietDonDatHang _ctrlChiTietDonDatHang = new ctrlChiTietDonDatHang();

        ctrlThuNoKhachHang _ctrlThuNoKhachHang = new ctrlThuNoKhachHang();
        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 

        DataTable _maVachXuatKhoDT = new DataTable();

        DataTable _cuaHangDT = new DataTable();


        enum DisplayMaPhieu
        {
            ChuyenKho,
            ThuHoiSanPham,
            NhaCungCap
        }

        DisplayMaPhieu _displayMaPhieu = DisplayMaPhieu.ChuyenKho;

        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = GlobalValues.IdNhanVien;


        int _idKhachHang;

        int _idLoaiPhieuNhap;

        int _idNhaCungCap = 0;

        int _idDonDatHang = 0;

        decimal _idHoaDon = 0;

        int _idChuyenHang = 0;

        int _idChiTietHoaDon = 0;

        ///
        /// 
        ///
        ctrlChiTietHoaDon _ctrlChiTietHoaDon = new ctrlChiTietHoaDon();

        clsChiTietHoaDon _chiTietHoaDon = new clsChiTietHoaDon();

        /// <summary>
        /// 
        /// </summary>
        //ctrlThuNoKhachHang _ctrlThuNoKhachHang = new ctrlThuNoKhachHang();

        clsThuNoKhachHang _thuNoKhachHang = new clsThuNoKhachHang();
        /// <summary>
        /// 
        /// </summary>
        ctrlPhieuNhap _ctrlPhieuNhap = new ctrlPhieuNhap();

        ctrlLoaiPhieuNhap _ctrlLoaiPhieuNhap = new ctrlLoaiPhieuNhap();

        clsPhieuNhap _phieuNhap = new clsPhieuNhap();

        DataTable _loaiPhieuNhapDT = new DataTable();

        DataTable _nhaCungCapDT = new DataTable();

        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        clsChiTietPhieuNhap _chiTietPhieuNhap = new clsChiTietPhieuNhap();

        ctrlChiTietPhieuNhap _ctrlChiTietPhieuNhap = new ctrlChiTietPhieuNhap();
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmNhapKho()
        {
            InitializeComponent();

            LoadMaVachSanPham();

            LoadControlNhapKho();

            LoadMaVachSanPhamNhapKho();
            ////
            //ResetViewPhieuNhap();
            this.tSDonDatHang.Renderer = new ToolStripOverride();

            tSTxtMain.Text = "Nhập kho";
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {

        }

        /// 
        /// Tạo các cột dữ lieeujc cho MaVachDuocCHon Datattable 
        #region MaVachSanPhamDuocChon

        private void LoadMaVachSanPhamNhapKho()
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

            dc = new DataColumn("idChiTietHoaDon", typeof(string));
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
            dgViewMaVachDaChon.Columns["idChiTietHoaDon"].Visible = false;
        }
        #endregion


        #region HoaDonBanHang

        private DataTable _khachHangDT = new DataTable();
        /// 
        /// load dữ liệu vào control
        /// 
        private void LoadControlNhapKho()
        {
            ///hiển thị mã phiếu nhập
            LoadMaPhieuNhap();
            ///KhachHang
            LoadKhachHang();
            ///NhanVien
            txtNhanVienLap.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            txtNhanVienLap.Invalidate();
            ///LoaiPhieuNhap
            LoadLoaiPhieuNhap();
            ///NhaCunCap
            LoadNhaCungCap();
        }

        private void LoadMaPhieuNhap()
        {
            switch (_displayMaPhieu)
            {
                case DisplayMaPhieu.ChuyenKho:
                    txtMaPhieu.Text = _ctrlPhieuNhap.GetNewMaPhieuNhapChuyenKho();
                    break;
                case DisplayMaPhieu.NhaCungCap:
                    txtMaPhieu.Text = _ctrlPhieuNhap.GetNewMaPhieuNhapTuNhaCungCapByNow();
                    break;
                case DisplayMaPhieu.ThuHoiSanPham:
                    txtMaPhieu.Text = _ctrlPhieuNhap.GetNewMaPhieuNhapThuHoiSanPham();
                    break;
                default:
                    txtMaPhieu.Text = _ctrlPhieuNhap.GetNewMaPhieuNhapChuyenKho();
                    break;
            }
            txtMaPhieu.Invalidate();
        }



        #region KhachHang
        /// 
        /// Khách Hàng
        ///
        private void LoadKhachHang()
        {
            _khachHangDT = _ctrlKhachHang.GetKhachHang();

            cmbKhachHang.DataSource = _khachHangDT;

            cmbKhachHang.DisplayMember = "KhachHang";

            LoadIdKhachHang();

            cmbKhachHang.Invalidate();
        }

        private void LoadIdKhachHang()
        {
            int index = cmbKhachHang.SelectedIndex;//Lấy index trên comboBox
            DataTable table = _ctrlKhachHang.GetIdKhachHang();//Get Id các cửa hàng
            DataRow row = table.Rows[index];//Lấy row tương ứng với index
            _idKhachHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdKhachHang();
        }
        #endregion

        #region LoaiPhieuNhap
        /// 
        /// Loại phiếu nhập
        /// 
        private void LoadLoaiPhieuNhap()
        {
            _loaiPhieuNhapDT = _ctrlLoaiPhieuNhap.GetLoaiPhieuNhap();

            cmbLoaiPhieu.DataSource = _loaiPhieuNhapDT;

            cmbLoaiPhieu.DisplayMember = "LoaiPhieuNhap";

            LoadIdLoaiPhieuNhap();

            cmbLoaiPhieu.Invalidate();
        }


        private void LoadIdLoaiPhieuNhap()
        {
            int index = cmbLoaiPhieu.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _loaiPhieuNhapDT.Rows[index];//Lấy row tương ứng với index
                _idLoaiPhieuNhap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else if (index < 0)
            {
                DataRow row = _loaiPhieuNhapDT.Rows[0];//Lấy row tương ứng với index
                _idLoaiPhieuNhap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void cmbLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdLoaiPhieuNhap();
            _displayMaPhieu = (DisplayMaPhieu)cmbLoaiPhieu.SelectedIndex;
            LoadMaPhieuNhap();
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
            int idMaVachSanPham = Convert.ToInt32(dgViewMaVach.CurrentRow.Cells[0].Value.ToString());
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(_idCuaHang,idMaVachSanPham).Rows[0];
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
            //Current row trên datagridview của mã vạch được chọn rỗng và có thể tăng số lượng
            if (dgViewMaVachDaChon.CurrentRow != null 
                && PlusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()),_maVachXuatKhoDT)) 
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
            numSoTienTra.Value = (decimal)congTien;
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
                    _idDonDatHang = 0;
                    _idKhachHang = 0;
                    _idHoaDon = 0;
                    break;
                case (DisplayMaPhieu.NhaCungCap):
                    _idKhachHang = 0;
                    _idHoaDon = 0;
                    break;
                case (DisplayMaPhieu.ThuHoiSanPham):
                    _idNhaCungCap = 0;
                    _idDonDatHang = 0;
                    break;
            }
        }

        /// 
        /// Lưu dữ liệu vào _hoaDon
        /// 
        private void AssignPhieuNhap()
        {
            SetValues();

            DateTime now = DateTime.Now;

            _phieuNhap.NgayLap = now;

            _phieuNhap.IdCuaHang = _idCuaHang;

            _phieuNhap.IdNhanVien = _idNhanVien;

            _phieuNhap.GhiChu = "";

            _phieuNhap.SoPhieuNhap = _ctrlPhieuNhap.GetNewSoPhieuNhapByNow();

            _phieuNhap.IdLoaiPhieuNhap = _idLoaiPhieuNhap;

            _phieuNhap.GhiChu = txtGhiChu.Text;

            _phieuNhap.IdDonDatHang = _idDonDatHang;

            _phieuNhap.IdChuyenHang = _idChuyenHang;

            _phieuNhap.IdNhaCungCap = _idNhaCungCap;

            _phieuNhap.IdHoaDon = _idHoaDon;

        }


        private void AssignChiTietPhieuNhap(DataRow row)
        {
            _chiTietPhieuNhap = new clsChiTietPhieuNhap();
            ///Lấy id mã vạch sản phẩm
            int idMaVach = Convert.ToInt32(row["id"].ToString());

            _chiTietPhieuNhap.IdPhieuNhap = _ctrlPhieuNhap.GetIdPhieuNhap();

            _chiTietPhieuNhap.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());

            _chiTietPhieuNhap.DonGia = Convert.ToInt32(row["DonGia"].ToString());

            _chiTietPhieuNhap.IdMaVachSanPham = idMaVach;

            if (_displayMaPhieu == DisplayMaPhieu.ThuHoiSanPham)
                _chiTietPhieuNhap.IdChiTietHoaDon = Convert.ToInt32(row["idChiTietHoaDon"].ToString());
            else _chiTietPhieuNhap.IdChiTietHoaDon = 0;
            //_chiTietPhieuNhap.GiaBan = 0;

        }

        public void AddChiTietPhieuNhap()
        {
            foreach (DataRow row in _maVachXuatKhoDT.Rows)
            {
                AssignChiTietPhieuNhap(row);
                if (_ctrlChiTietPhieuNhap.AddData(_chiTietPhieuNhap))
                {
                    ///Lấy id mã vạch sản phẩm
                    int idMaVach = Convert.ToInt32(row["id"].ToString());

                    _ctrlMaVachSanPham.TangSoLuong(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));
                }
            }
        }

        private void AssignThuNoKhachHang()
        {
            _thuNoKhachHang.IdKhachHang = _idKhachHang;

            _thuNoKhachHang.NgayThu = dtpNgayLap.Value;

            _thuNoKhachHang.SoTien = (-1) * numSoTienTra.Value;

            _thuNoKhachHang.IdHoaDon = 0;

            _thuNoKhachHang.GhiChu = "";

            _thuNoKhachHang.IdCuaHang = _idCuaHang;

            _thuNoKhachHang.IdNhanVien = _idNhanVien;

            _thuNoKhachHang.SoPhieu = _ctrlThuNoKhachHang.GetNewSoPhieuByNow();

            _thuNoKhachHang.IdPhieuNhap = _ctrlPhieuNhap.GetIdPhieuNhap();
        }

        public void AddThuNoKhachHang()
        {
            AssignThuNoKhachHang();
            _ctrlThuNoKhachHang.AddData(_thuNoKhachHang);
        }

        public bool AddPhieuNhap()
        {
            AssignPhieuNhap();
            return _ctrlPhieuNhap.AddData(_phieuNhap);
        }


        protected override void tSbBtnDongY_Click(object sender, EventArgs e)
        {
            if (_maVachXuatKhoDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (!AddPhieuNhap())
                {
                    return;
                }
            else
                {
                    //dgViewMaVachDaChon.DataSource = null;
                    AddChiTietPhieuNhap();
                    if (_displayMaPhieu == DisplayMaPhieu.ThuHoiSanPham)
                        AddThuNoKhachHang();
                }
            ResetViewPhieuNhap();
        }

        protected override void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {

        }

        public void ResetViewPhieuNhap()
        {
            LoadControlNhapKho();
            LoadMaVachSanPham();
            LoadMaVachSanPhamNhapKho();
            LoadNumericBoxes();
        }

        private void EnableItems()
        {
            cmbNhaCungCap.Enabled = false;
            cmbKhachHang.Enabled = false;
            tSDonDatHang.Enabled = false;
            tSHoaDonBanHang.Enabled = false;
            dgViewMaVach.Enabled = true;
            tSBtnChonMaVach.Enabled = true;
            tSBtnPlusMaVach.Enabled = true;
            tSbtnMinusMaVach.Enabled = true;



            if (_displayMaPhieu == DisplayMaPhieu.ChuyenKho || (_displayMaPhieu == DisplayMaPhieu.NhaCungCap && _idDonDatHang == 0))
            {
                //dgViewMaVachDaChon.DataSource = null;
                dgViewMaVachDaChon.Invalidate();
                tSBtnChonMaVach.Enabled = true;
                tSBtnPlusMaVach.Enabled = true;
                tSbtnMinusMaVach.Enabled = true;
            }
            else
            {
                dgViewMaVach.Enabled = false;
                dgViewMaVach.ReadOnly = true;
                tSBtnChonMaVach.Enabled = false;
                tSBtnPlusMaVach.Enabled = false;
                tSbtnMinusMaVach.Enabled = false;
                dgViewMaVachDaChon.Invalidate();
            }

            switch (_displayMaPhieu)
            {
                case DisplayMaPhieu.ChuyenKho:
                    break;
                case DisplayMaPhieu.NhaCungCap:
                    cmbNhaCungCap.Enabled = true;
                    tSDonDatHang.Enabled = true;
                    break;
                case DisplayMaPhieu.ThuHoiSanPham:
                    cmbKhachHang.Enabled = true;
                    tSHoaDonBanHang.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        protected override void dgViewMaVach_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _maVachDT);
        }

        private void btnViewDonDatHang_Click(object sender, EventArgs e)
        {
            using (DonDatHangDlg _donDatHangDlg = new DonDatHangDlg(_ctrlDonDatHang))
            {
                if (_donDatHangDlg.ShowDialog() == DialogResult.OK)
                {
                    _idDonDatHang = _ctrlDonDatHang.IdDonDatHang;
                }
            }
            if (_idDonDatHang != 0)
            {
                tsTxtDonDatHang.TextBox.Text = _ctrlDonDatHang.GetMaDonDatHangById(_idDonDatHang);
                _maVachXuatKhoDT = _ctrlChiTietDonDatHang.GetChiTietDonDatHang(_idDonDatHang);
                dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;
                dgViewMaVachDaChon.Columns["id"].Visible = false;
                EnableItems();
                //dgViewMaVachDaChon.Invalidate();
            }
            LoadNumericBoxes();
        }

        private void tSHuyDonDatHang_Click(object sender, EventArgs e)
        {
            _idDonDatHang = 0;
            tsTxtDonDatHang.TextBox.Text = "";
            EnableItems();
        }

        private void tSBtnXemHoaDon_Click(object sender, EventArgs e)
        {
            using (TimKiemHoaDonDlg _timKiemHoaDonDlg = new TimKiemHoaDonDlg(_ctrlHoaDon))
            {
                if (_timKiemHoaDonDlg.ShowDialog() == DialogResult.OK)
                {
                    //Mở hóa đơn dlg xong trả về idHoaDon
                    _idHoaDon = _ctrlHoaDon.IdHoaDon;
                }
            }
            if (_idHoaDon != 0)
            {
                tsTxtHoaDon.TextBox.Text = _ctrlHoaDon.GetMaHoaDonById(_idHoaDon);
                _maVachXuatKhoDT = _ctrlChiTietHoaDon.GetChiTietHoaDon(_idHoaDon);
                dgViewMaVachDaChon.DataSource = _maVachXuatKhoDT;
                dgViewMaVachDaChon.Columns["id"].Visible = false;
                dgViewMaVachDaChon.Columns["idChiTietHoaDon"].Visible = false;
                EnableItems();
            }
            LoadNumericBoxes();

        }

        private void tSBtnHuyHoaDon_Click(object sender, EventArgs e)
        {
            _idHoaDon = 0;
            tsTxtDonDatHang.TextBox.Text = "";
            EnableItems();
        }


        ///Support cho hàm custom datagridview hiển thị dữ liệu khác nhau trên từng Form
        protected override void UpdateCustomDataGridView()
        {
            dgViewMaVach.Columns["GiaSi"].Visible = false;
            dgViewMaVach.Columns["GiaBan"].Visible = false;

            dgViewMaVach.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgViewMaVach.Columns["GiaNhap"].DefaultCellStyle.ForeColor = Color.Red;
        }
       
    }
}

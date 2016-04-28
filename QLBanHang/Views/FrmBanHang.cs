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

namespace QLBanHang.Views
{
    public partial class FrmBanHang : Form, IHoaDonView
    {
        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        ctrlDangNhap _ctrlDangNhap = new ctrlDangNhap();
        FrmDangNhapDlg _dangNhapDlg = new FrmDangNhapDlg();

        clsNhanVien _nhanVien = new clsNhanVien();

        /// 
        /// quản lý bán hàng
        /// 
        FormQuanLyBanHang _FrmQLBH = new FormQuanLyBanHang();

        /// 
        /// quản lý cửa hàng
        /// 
        FrmCuaHang _FrmCuaHang = new FrmCuaHang();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();
        /// 
        /// quản lý khách hàng và nhà cung cấp
        ///
        FormQLKH_NCC _FrmQLKH_NCC = new FormQLKH_NCC();

        ///
        ///Form thống kê 
        ///
        FrmThongKeHoaDon _FrmThongKeHoaDon = new FrmThongKeHoaDon();
        ///
        /// dùng để hiển thị các sản phẩm bán được tại cửa hàng
        ///
        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

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
        DataTable _maVachDT = new DataTable();

        DataTable _maVachBanHangDT = new DataTable();
        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = 7;

        int _idCuaHang = 9;

        int _idKhachHang;

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
            _ctrlDangNhap.SetView(_dangNhapDlg);
            _ctrlHoaDon.SetView(this);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
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
        private void LoadMaVachSanPham()
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


        private void LoadMaVachSanPhamBanHang()
        {
            initMaVachBanHangDT();
            AlterDgViewMaVachBanHang();
            dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
        }


        private void initMaVachBanHangDT()
        {

            _maVachBanHangDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("MaVach", typeof(string));
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

        }

        private void AlterDgViewMaVachBanHang()
        {
            dgViewMaVachDaChon.Columns["MaVach"].Visible = false;
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
            ///CuaHang
            LoadCuaHang();
        }
        /// 
        /// Cửa hàng
        /// 
        private void LoadCuaHang()
        {
            ///Hiển thị tên các cửa hàng lên combobox
            tSCmbCuaHang.ComboBox.DataSource = _ctrlCuaHang.GetTenCuaHang();
            tSCmbCuaHang.ComboBox.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            LoadIdCuaHang();

            tSCmbCuaHang.ComboBox.Invalidate();
        }

        private void LoadIdCuaHang()
        {
            int index = tSCmbCuaHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataTable table = _ctrlCuaHang.GetIdCuaHang();//Get Id các cửa hàng
                DataRow row = table.Rows[index];//Lấy row tương ứng với index
                _idCuaHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void tSCmbCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHang();
            //Load lại sản phẩm tương ứng với cửa hàng
            LoadMaVachSanPham();
            dgViewMaVach.Invalidate();
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
        /// 
        /// Số hóa đơn
        /// 
        /// 
        /// Lấy mã hóa đơn mới nhất trong ngày
        /// 




        #endregion

        #region xử lý trên datagridview

        private void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamBanHang();
        }

        public void ChonSanPhamBanHang()
        {
            ///Lấy mã vạch từ mavachdgView
            string maVach = dgViewMaVach.CurrentRow.Cells[0].Value.ToString();
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(maVach).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            if (!PlusSelectedBanHang(row["MaSanPham"].ToString()) && Convert.ToInt32(row["SoLuong"].ToString()) > 0)
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachBanHangDT.NewRow();
                newRow["MaVach"] = maVach;
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

            AlterDgViewMaVachBanHang();

            dgViewMaVachDaChon.Invalidate();
        }


        /// 
        /// Tăng số lượng sản phẩm đã được chọn
        /// 
        private bool PlusSelectedBanHang(string MaSanPham)
        {
            foreach (DataRow row in _maVachBanHangDT.Rows)
            {
                //tăng số lượng
                int soLuong = Convert.ToInt32(row["SoLuong"].ToString()) + 1;
                int donGia = Convert.ToInt32(row["DonGia"].ToString());
                if (row["MaSanPham"].ToString() == MaSanPham)
                {
                    row["SoLuong"] = soLuong;
                    row["ThanhTien"] = soLuong * donGia;
                    return true;
                }
            }
            return false;
        }
        /// 
        /// Giảm số lượng sản phẩm đã đưuọc chọn
        /// 

        private bool MinusSelectedBanHang(string MaSanPham)
        {
            foreach (DataRow row in _maVachBanHangDT.Rows)
            {
                //giảm số lượng
                int soLuong = Convert.ToInt32(row["SoLuong"].ToString()) - 1;
                int donGia = Convert.ToInt32(row["DonGia"]);
                if (row["MaSanPham"].ToString() == MaSanPham)
                {
                    if (soLuong > 0)
                    {
                        row["SoLuong"] = soLuong;
                        row["ThanhTien"] = soLuong * donGia;
                        return true;
                    }
                    else
                    {
                        _maVachBanHangDT.Rows.Remove(row);
                        return true;
                    }
                }

            }
            return false;
        }

        #endregion

        private void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongMaVachBanHang();
        }

        private void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongMaVachBanHang();
        }


        public void TangSoLuongMaVachBanHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null && PlusSelectedBanHang(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
            {
                dgViewMaVachDaChon.DataSource = _maVachBanHangDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        public void GiamSoLuongMaVachBanHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null && MinusSelectedBanHang(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
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

            _thuNoKhachHang.GhiChu = "";

            _thuNoKhachHang.IdNhanVien = _idNhanVien;

            _thuNoKhachHang.IdCuaHang = _idCuaHang;

            _thuNoKhachHang.SoPhieu = _ctrlThuNoKhachHang.GetNewSoPhieuByNow();

            //_thuNoKhachHang.IdPhieuNhap =

        }


        private void AssignChiTietHoaDon(DataRow row)
        {
            _chiTietHoaDon = new clsChiTietHoaDon();
            string maVachSanPham = row["MaVach"].ToString();
            int idMaVach = _ctrlMaVachSanPham.GetIdByMaVach(maVachSanPham);

            _ctrlMaVachSanPham.GiamSoLuong(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));

            //ChiTietHoaDon
            _chiTietHoaDon.IdMaVachSanPham = idMaVach;

            _chiTietHoaDon.IdHoaDon = _ctrlHoaDon.GetIdHoaDon();

            _chiTietHoaDon.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());

            _chiTietHoaDon.ThoiGianBaoHanh = 12;

            _chiTietHoaDon.ChietKhau = (int)numCK.Value;

            _chiTietHoaDon.VAT = Convert.ToInt32(row["VAT"].ToString());

            _chiTietHoaDon.DonGia = Convert.ToInt32(row["DonGia"].ToString());

            _chiTietHoaDon.SanPhamComBo = 0;

            _chiTietHoaDon.GiaVon = _ctrlMaVachSanPham.GetGiaVonBanLe(idMaVach,1);

            txtGhiChuHoaDon.Text = _chiTietHoaDon.GiaVon.ToString();

            _chiTietHoaDon.GhiChu = txtGhiChuHoaDon.Text;
        }

        public void AddChiTietHoaDon()
        {
            foreach (DataRow row in _maVachBanHangDT.Rows)
            {
                AssignChiTietHoaDon(row);
                _ctrlChiTietHoaDon.AddData(_chiTietHoaDon);
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

        private void tSBtnDongYBanHang(object sender, EventArgs e)
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

        private void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {
            //THong Ke HoaDon
            //decimal tmp = 148634;
            //tmp /= 100;
            //txtGhiChu.Text = Convert.ToString(Math.Round(tmp)*100);
            foreach(DataRow row in _maVachBanHangDT.Rows)
            {
                string maVachSanPham = row["MaVach"].ToString();
                int idMaVach = _ctrlMaVachSanPham.GetIdByMaVach(maVachSanPham);

                int GiaVon = _ctrlMaVachSanPham.GetGiaVonBanLe(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));
                txtGhiChuHoaDon.Text += GiaVon.ToString() +"\n";
            }
        }

        public void ResetViewHoaDon()
        {
            LoadControlBanHang();
            LoadMaVachSanPham();
            LoadMaVachSanPhamBanHang();
            LoadNumericBoxes();
        }

    }
}

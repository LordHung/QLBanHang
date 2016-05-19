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
    public partial class FrmChuyenKho : Frm_KinhDoanh_Base,IChuyenHangView
    {
        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        /// 
        /// quản lý cửa hàng
        /// 

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        DataTable _cuaHangTuDT = new DataTable();

        DataTable _cuaHangDenDT = new DataTable();

        ctrlChuyenHang _ctrlChuyenHang = new ctrlChuyenHang();

        clsChuyenHang _chuyenHang = new clsChuyenHang();

        ctrlChiTietChuyenHang _ctrlChiTietChuyenHang = new ctrlChiTietChuyenHang();

        clsChiTietChuyenHang _chiTietChuyenHang = new clsChiTietChuyenHang();


        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 

        DataTable _maVachChuyenKhoDT = new DataTable();
        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = GlobalValues.IdNhanVien;

        int _idCuaHangDen;
        
        /// <summary>
        /// Nhập kho đến cửa hàng
        /// </summary>
        ctrlPhieuNhap _ctrlPhieuNhap = new ctrlPhieuNhap();
        clsPhieuNhap _phieuNhap = new clsPhieuNhap();
        ctrlChiTietPhieuNhap _ctrlChiTietPhieuNhap = new ctrlChiTietPhieuNhap();
        clsChiTietPhieuNhap _chiTietPhieuNhap = new clsChiTietPhieuNhap();
        /// <summary>
        /// Xuất kho từ cửa hàng
        /// </summary>
        ctrlPhieuXuat _ctrlPhieuXuat = new ctrlPhieuXuat();
        clsPhieuXuat _phieuXuat = new clsPhieuXuat();
        ctrlChiTietPhieuXuat _ctrlChiTietPhieuXuat = new ctrlChiTietPhieuXuat();
        clsChiTietPhieuXuat _chiTietPhieuXuat = new clsChiTietPhieuXuat();

        /// <summary>
        /// Contructor
        /// </summary>
        public FrmChuyenKho()
        {
            InitializeComponent();
            _ctrlChuyenHang.SetView(this);
            //LoadControl
            LoadControlChuyenKho();
            ///Load MaVachSanPham
            LoadMaVachSanPham();
            ///
            LoadMaVachChuyenKho();
        }

        private void LoadControlChuyenKho()
        {
            ///Ma
            txtMaDonChuyenKho.Text = _ctrlChuyenHang.GetNew_MaDatHangByNow();
            ///NhaVien
            txtNhanVien.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            ///CuaHangDen
            LoadCuaHangDen();

        }
        /// <summary>
        /// Đến Cửa hàng
        /// </summary>
        private void LoadCuaHangDen()
        {
            _cuaHangDenDT = _ctrlCuaHang.GetCuaHang();
            ///Hiển thị tên các cửa hàng lên combobox
            cmbCuaHangDen.DataSource = _cuaHangDenDT;
            cmbCuaHangDen.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            LoadIdCuaHangDen();

            cmbCuaHangDen.Invalidate();
        }

        private void LoadIdCuaHangDen()
        {
            int index = cmbCuaHangDen.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _cuaHangDenDT.Rows[index];//Lấy row tương ứng với index
                _idCuaHangDen = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void cmbCuaHangDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHangDen();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void LoadMaVachChuyenKho()
        {
            initMaVachChuyenKho();
            dgViewMaVachDaChon.DataSource = _maVachChuyenKhoDT;
        }


        private void initMaVachChuyenKho()
        {

            _maVachChuyenKhoDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("id", typeof(string));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("MaSanPham", typeof(string));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("TenSanPham", typeof(string));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("DonVi", typeof(string));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(int));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(int));
            _maVachChuyenKhoDT.Columns.Add(dc);

            dc = new DataColumn("GhiChu", typeof(int));
            _maVachChuyenKhoDT.Columns.Add(dc);

        }
        /// <summary>
        /// Button CHọn click,chọn MV mói hoặc tăng MVSP đã có sẵn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamChuyenHang();
        }

        public void ChonSanPhamChuyenHang()
        {
            ///Lấy mã vạch từ mavachdgView
            int idMaVachSanPham = Convert.ToInt32(dgViewMaVach.CurrentRow.Cells[0].Value.ToString());
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(_idCuaHang,idMaVachSanPham).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            //không được trùng id giữa cửa hàng chuyển và nhận
            if (_idCuaHang == _idCuaHangDen)
            {
                MessageBox.Show("Cửa hàng chuyển và nhận không được trùng nhau", "Thông báo", MessageBoxButtons.OK
                                  , MessageBoxIcon.Information);
                return;
            }
            ///kiểm tra xem mã vạch có tồn tại trong cả 2 cửa hàng hay không
            if (!_ctrlMaVachSanPham.IsExist(dgViewMaVach.CurrentRow.Cells[1].Value.ToString(), _idCuaHangDen))
            {
                MessageBox.Show("Mã vạch không có bên cửa hàng nhận", "Thông báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }

            if (!PlusSelectedMaVach(idMaVachSanPham, _maVachChuyenKhoDT) 
                && Convert.ToInt32(row["SoLuong"].ToString()) > 0)
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachChuyenKhoDT.NewRow();
                newRow["id"] = row["id"].ToString();
                newRow["MaSanPham"] = row["MaSanPham"].ToString();
                newRow["TenSanPham"] = row["TenSanPham"].ToString();
                newRow["DonVi"] = row["DonVi"].ToString();
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = Convert.ToInt32(row["GiaNhap"].ToString());
                newRow["ThanhTien"] = Convert.ToInt32(row["GiaNhap"].ToString());
                _maVachChuyenKhoDT.Rows.Add(newRow);
            }
            else if (Convert.ToInt32(row["SoLuong"].ToString()) <= 0)
            {
                MessageBox.Show(this, "Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ///Gán dữ liệu vào dgView
            dgViewMaVachDaChon.DataSource = _maVachChuyenKhoDT;

            dgViewMaVachDaChon.Invalidate();
        }
        /// <summary>
        /// Nếu btn plus được nhấn thì thực hiện hàm tăng số lương sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongSanPhamChuyenHang();
        }

        public void TangSoLuongSanPhamChuyenHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null
                 && PlusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachChuyenKhoDT))
            {
                dgViewMaVachDaChon.DataSource = _maVachChuyenKhoDT;
                dgViewMaVachDaChon.Invalidate();
            }
        }
        /// <summary>
        /// Nếu btn minus được nhấn thì thực hiện hàm giảm số lương sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongSanPhamChuyenHang();
        }

        public void GiamSoLuongSanPhamChuyenHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null
                 && MinusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachChuyenKhoDT))
            {
                dgViewMaVachDaChon.DataSource = _maVachChuyenKhoDT;
                dgViewMaVachDaChon.Invalidate();
            }
        }

        /// <summary>
        /// Gán dữ liệu cho phiếu chuyển hàng 
        /// </summary>
        private void AssignChuyenHang()
        {
            //SoPhieuChuyen
            _chuyenHang.SoChuyenHang = _ctrlChuyenHang.GetNew_SoPhieuChuyenByNow();
            //NgayChuyen
            _chuyenHang.NgayChuyen = dtpNgayNhap.Value;
            //idCuaHangTu
            _chuyenHang.IdCuaHangTu = _idCuaHang;
            //idCuaHangDen
            _chuyenHang.IdCuaHangDen = _idCuaHangDen;
            //GhiCHu
            _chuyenHang.GhiChu = txtGhiChu.Text;
            //idNhanVien
            _chuyenHang.IdNhanVien = _idNhanVien;
        }
        /// <summary>
        /// Gán dữ liệu cho chi tiết chuyển hàng
        /// </summary>
        private void AssignChiTietChuyenHang(DataRow row)
        {
            //idPhieuChuyen
            _chiTietChuyenHang.IdChuyenHang = _ctrlChuyenHang.GetIdPhieuChuyenMoiNhat();
            //idMaVcahSanPham
            _chiTietChuyenHang.IdMaVachSanPham = Convert.ToInt32(row["id"].ToString());
            //SoLuong
            _chiTietChuyenHang.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());
            //DonGia
            _chiTietChuyenHang.DonGia = 0;
        }

        /// <summary>
        /// Gán dữ liệu cho phiếu nhập
        /// </summary>
        private void AssignPhieuNhap()
        {
            //NgayLap
            _phieuNhap.NgayLap = dtpNgayNhap.Value;
            //idCuaHang
            _phieuNhap.IdCuaHang = _idCuaHangDen;
            //idNhanVien
            _phieuNhap.IdNhanVien = GlobalValues.IdNhanVien;
            //GhiCHu
            _phieuNhap.GhiChu = "Nhập hàng theo phiếu chuyển hàng " + txtMaDonChuyenKho.Text;
            //SoPhieuNhap
            _phieuNhap.SoPhieuNhap = _ctrlPhieuNhap.GetNewSoPhieuNhapByNow();
            //idLoaiPhieuNhap
            _phieuNhap.IdLoaiPhieuNhap = 4;
            //idDonDatHang
            _phieuNhap.IdDonDatHang = 0;
            //idDOnChuyenHang
            _phieuNhap.IdChuyenHang = _ctrlChuyenHang.GetIdPhieuChuyenMoiNhat();
            //idNhaCungCap
            _phieuNhap.IdNhaCungCap = 0;
            //idHoaDon
            _phieuNhap.IdHoaDon = 0;
        }

        /// <summary>
        /// Gán dữ liệu cho chi tiết phiếu nhập
        /// </summary>
        private void AssignChiTietPhieuNhap(DataRow row)
        {
            ///Gán giá trị dựa trên idMaVachNhap và idMaVachNhap do tìm từ mã vạch
            ///và cửa hàng đến đển nhập
            ///
           
            //idPhieuNhap
            _chiTietPhieuNhap = new clsChiTietPhieuNhap();
            ///Lấy id mã vạch sản phẩm
            int idMaVach = Convert.ToInt32(row["id"].ToString());
            //lay Ma
            string maVach = _ctrlMaVachSanPham.GetMaVachById(idMaVach);
            //idPhieuNhap
            _chiTietPhieuNhap.IdPhieuNhap = _ctrlPhieuNhap.GetIdPhieuNhap();
            //Soluong
            _chiTietPhieuNhap.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());
            //DonGia
            _chiTietPhieuNhap.DonGia = 0;
            //idMaVachSanPham
            _chiTietPhieuNhap.IdMaVachSanPham = _ctrlMaVachSanPham.GetIdByCuaHang_MaVach(maVach,_idCuaHangDen);
            //idCHiTietHoaDon
            _chiTietPhieuNhap.IdChiTietHoaDon = 0;
        }

        /// <summary>
        /// Gán dữ liệu cho phiếu xuất
        /// </summary>
        private void AssignPhieuXuat()
        {
            ///Gán giá trị bình thương,giá trị trên dgview tương ứng với phiếu xuất
            ///và idCuaHang tương ứng với _idCuaHang
            //NgayLap
            _phieuXuat.NgayLap = dtpNgayNhap.Value;
            //idCuaHang
            _phieuXuat.IdCuaHang = _idCuaHang;
            //idNhanVien
            _phieuXuat.IdNhanVien = GlobalValues.IdNhanVien;
            //GhiCHu
            _phieuXuat.GhiChu = "Xuất hàng theo phiếu chuyển hàng " + txtMaDonChuyenKho.Text;
            //SoPhieuNhap
            _phieuXuat.SoPhieuXuat = _ctrlPhieuXuat.GetNewSoPhieuXuatByNow();
            //idLoaiPhieuNhap
            _phieuXuat.IdLoaiPhieuXuat = 4;
            //idKhachHang
            _phieuXuat.IdKhachHang = 0;
            //idDOnChuyenHang
            _phieuXuat.IdChuyenHang = _ctrlChuyenHang.GetIdPhieuChuyenMoiNhat();
            //idNhaCungCap
            _phieuXuat.IdNhaCungCap = 0;
        }

        /// <summary>
        /// Gán dữ liệu cho chi tiết phiếu xuất
        /// </summary>
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
        }

        /// <summary>
        /// Add Phiếu xuất
        /// </summary>
        /// <returns></returns>
        public bool AddPhieuXuat()
        {
            AssignPhieuXuat();
            return _ctrlPhieuXuat.AddData(_phieuXuat);
        }
        /// <summary>
        /// Với mỗi mã vạch trong maVachDT add chi tiết phiếu xuất
        /// </summary>
        public void AddChiTietPhieuXuat()
        {
            foreach (DataRow row in _maVachChuyenKhoDT.Rows)
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

        /// <summary>
        /// Add phiếu nhập
        /// </summary>
        /// <returns></returns>
        public bool AddPhieuNhap()
        {
            AssignPhieuNhap();
            return _ctrlPhieuNhap.AddData(_phieuNhap);
        }
        /// <summary>
        /// với mỗi mã vạch trong maVachDT add chi tiết phiếu nhập
        /// </summary>
        public void AddChiTietPhieuNhap()
        {
            foreach (DataRow row in _maVachChuyenKhoDT.Rows)
            {
                AssignChiTietPhieuNhap(row);
                if (_ctrlChiTietPhieuNhap.AddData(_chiTietPhieuNhap))
                {
                    ///Lấy id mã vạch sản phẩm
                    int idMaVach = _ctrlMaVachSanPham.GetIdByCuaHang_MaVach(
                        _ctrlMaVachSanPham.GetMaVachById(Convert.ToInt32(row["id"].ToString())), _idCuaHangDen);

                    _ctrlMaVachSanPham.TangSoLuong(idMaVach, Convert.ToInt32(row["SoLuong"].ToString()));
                }
            }
        }
        /// <summary>
        /// Add Phiếu chuyển hàng
        /// </summary>
        /// <returns></returns>
        public bool AddPhieuPhuyenHang()
        {
            AssignChuyenHang();
            return _ctrlChuyenHang.AddData(_chuyenHang);
        }

        /// <summary>
        /// Với mỗi dòng trong DT ADD chi tiết chuyển hàng
        /// </summary>
        public void AddChiTietChuyenHang()
        {
            foreach (DataRow row in _maVachChuyenKhoDT.Rows)
            {
                AssignChiTietChuyenHang(row);
                _ctrlChiTietChuyenHang.AddData(_chiTietChuyenHang);
            }
        }

        public void ResetViewChuyenHang()
        {
            LoadMaVachSanPham();
            LoadMaVachChuyenKho();
        }


        protected override void tSbBtnDongY_Click(object sender, EventArgs e)
        {
            if (_maVachChuyenKhoDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            ///AddPhieuCHuyenHang va chitiet
            if (!AddPhieuPhuyenHang())
            {
                return;
            }
            else
            {
                AddChiTietChuyenHang();
            }
            ///addphieuxuat va chi tiet
            if (!AddPhieuXuat())
            {
                return;
            }
            else
            {
                AddChiTietPhieuXuat();
            }
            //add phieunhap va chi tiet
            if (!AddPhieuNhap())
            {
                return;
            }
            else
            {
                AddChiTietPhieuNhap();
            }

            ResetViewChuyenHang();
        }
    }
}

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
    public partial class FrmDatHang : Frm_KinhDoanh_Base,IDonDatHangView
    {
        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();
        clsNhanVien _nhanVien = new clsNhanVien();

        /// 
        /// quản lý bán hàng
        /// 
        //FormQuanLyBanHang _FrmQLBH = new FormQuanLyBanHang();

        /// 
        /// quản lý cửa hàng
        /// 

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        DataTable _cuaHangDT = new DataTable();
 
        ///
        /// dùng để hiển thị các sản phẩm bán được tại cửa hàng
        ///
        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        ///
        ///
        /// 
        ctrlDonDatHang _ctrlDonDatHang = new ctrlDonDatHang();

        clsDonDatHang _donDatHang = new clsDonDatHang();
        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 
        DataTable _maVachDT = new DataTable();

        DataTable _maVachDatHangDT = new DataTable();
        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = GlobalValues.IdNhanVien;

        ///
        /// 
        ///
        ctrlChiTietHoaDon _ctrlChiTietHoaDon = new ctrlChiTietHoaDon();

        clsChiTietHoaDon _chiTietHoaDon = new clsChiTietHoaDon();

        ///
        ///Thêm control
        ///
        //DataTable _maVachDatHangDT = new DataTable();

        DataTable _nhaCungCapDT = new DataTable();

        ctrlChiTietDonDatHang _ctrlChiTietDonDatHang = new ctrlChiTietDonDatHang();

        clsChiTietDonDatHang _chiTietDonDatHang = new clsChiTietDonDatHang();

        /// <summary>
        /// ctrl Nha Cung Cap
        /// </summary>
        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        int _idNhaCungCap = 7;

        /// <summary>
        /// Contructor
        /// </summary>
        public FrmDatHang()
        {
            InitializeComponent();
            ///Load các khối control textbox và combobox
            LoadControlDonDatHang();
            ///Load Mã Vạch sản phẩm
            LoadMaVachSanPham();
            ///DoubleBuffer cho cac control

            _ctrlDonDatHang.SetView(this);

            tSTxtMain.Text = "Đặt hàng";
        }

        private void FromDatHang_Load(object sender, EventArgs e)
        {
            ///Load Mã vạch đặt hàng
            ///
            LoadMaVachDatHang();
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadControlDonDatHang()
        {
            ///hiển thị mã hóa đơn
            DateTime now = DateTime.Now;
            txtMaDonDatHang.Text = _ctrlDonDatHang.GetNewMaDatHangByNow();
            txtMaDonDatHang.Invalidate();
            ///NhanVien
            txtNhanVienLapDonDatHang.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            txtNhanVienLapDonDatHang.Invalidate();
            ///NhaCungCap
            LoadNhaCungCap();
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
        /// Tạo các cột dữ liệu cho MaVachDuocCHon Datattable 
        ///

        private void LoadMaVachDatHang()
        {
            initMaVachDatHang();
            dgViewMaVachDaChon.DataSource = _maVachDatHangDT;
        }


        private void initMaVachDatHang()
        {

            _maVachDatHangDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("id", typeof(string));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("MaSanPham", typeof(string));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("TenSanPham", typeof(string));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("DonVi", typeof(string));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(int));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(int));
            _maVachDatHangDT.Columns.Add(dc);

            dc = new DataColumn("GhiChu", typeof(int));
            _maVachDatHangDT.Columns.Add(dc);

        }

        #region HoaDonDatHang

        private DataTable _khachHangDT = new DataTable();
        /// 
        /// load dữ liệu vào control
        /// 

        /// 
        /// Nhà cung cấp
        /// 
        private void LoadNhaCungCap()
        {
            _nhaCungCapDT = _ctrlNhaCungCap.GetNhaCungCap();
            cmbNhaCungCapDatHang.DataSource = _nhaCungCapDT;
            cmbNhaCungCapDatHang.DisplayMember = "NhaCungCap";

            ///LoadIdCuahang
            LoadIdNhaCungCap();

            tSCmbCuaHang.ComboBox.Invalidate();
        }

        private void LoadIdNhaCungCap()
        {
            int index = cmbNhaCungCapDatHang.SelectedIndex;//Lấy index trên comboBox
            if (index > 0)
            {
                DataRow row = _nhaCungCapDT.Rows[index];//Lấy row tương ứng với index
                _idNhaCungCap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }

        private void cmbNhaCungCapDatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhaCungCap();

        }

        #endregion


        #region xử lý trên datagridview

        protected override void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamDatHang();
        }

        public void ChonSanPhamDatHang()
        {
            ///Lấy mã vạch từ mavachdgView
            int idMaVachSanPham = Convert.ToInt32(dgViewMaVach.CurrentRow.Cells[0].Value.ToString());
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(idMaVachSanPham).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            if (!PlusSelectedMaVach(idMaVachSanPham, _maVachDatHangDT))
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachDatHangDT.NewRow();
                newRow["id"] = row["id"].ToString();
                newRow["MaSanPham"] = row["MaSanPham"].ToString();
                newRow["TenSanPham"] = row["TenSanPham"].ToString();
                newRow["DonVi"] = row["DonVi"].ToString();
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = Convert.ToInt32(row["GiaNhap"].ToString());
                newRow["ThanhTien"] = Convert.ToInt32(row["GiaNhap"].ToString());
                _maVachDatHangDT.Rows.Add(newRow);
            }
            ///Gán dữ liệu vào dgView
            dgViewMaVachDaChon.DataSource = _maVachDatHangDT;

            dgViewMaVachDaChon.Invalidate();
        }


        #endregion

        protected override void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongSanPhamDatHang();
        }

        protected override void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongSanPhamDatHang();
        }

        public void TangSoLuongSanPhamDatHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null
                 && PlusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachDatHangDT)) 
            {
                dgViewMaVachDaChon.DataSource = _maVachDatHangDT;
                dgViewMaVachDaChon.Invalidate();
            }
        }

        public void GiamSoLuongSanPhamDatHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null
                 && MinusSelectedMaVach(Convert.ToInt32(dgViewMaVachDaChon.CurrentRow.Cells[0].Value.ToString()), _maVachDatHangDT)) 
            {
                dgViewMaVachDaChon.DataSource = _maVachDatHangDT;
                dgViewMaVachDaChon.Invalidate();
            }
        }


        /// 
        /// Lưu dữ liệu vào _hoaDon
        /// 
        private void AssignDonDatHang()
        {
            DateTime now = DateTime.Now;

            _donDatHang.SoDonDatHang = _ctrlDonDatHang.GetNewSoDonDatHangByNow();

            _donDatHang.IdCuaHang = _idCuaHang;

            _donDatHang.IdNhanVien = _idNhanVien;

            _donDatHang.GhiChu = txtGhiChuDonDatHang.Text;

            _donDatHang.NgayLap = dtpNgayNhapDonDatHang.Value;

            _donDatHang.IdNhaCungCap = _idNhaCungCap;
        }

        private void AssignChiTietDonDatHang(DataRow row)
        {
            _chiTietDonDatHang = new clsChiTietDonDatHang();

            ///lấy id MaVach SanPham từ view
            int idMaVach = Convert.ToInt32(row["id"].ToString());

            //ChiTietDonDatHang
            _chiTietDonDatHang.IdMaVachSanPham = idMaVach;

            _chiTietDonDatHang.IdDonDatHang = _ctrlDonDatHang.GetIdDonDatHang();

            _chiTietDonDatHang.SoLuong = Convert.ToInt32(row["SoLuong"].ToString());

            _chiTietDonDatHang.DonGia = Convert.ToInt32(row["DonGia"].ToString());

            _chiTietDonDatHang.GhiChu = txtGhiChuDonDatHang.Text;
        }

        public void AddChiTietDonDatHang()
        {
            foreach (DataRow row in _maVachDatHangDT.Rows)
            {
                AssignChiTietDonDatHang(row);
                _ctrlChiTietDonDatHang.AddData(_chiTietDonDatHang);
            }
        }

        public bool AddDonDatHang()
        {
            AssignDonDatHang();
            return _ctrlDonDatHang.AddData(_donDatHang);
        }

        protected override void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {
            txtGhiChuDonDatHang.Text = _ctrlDonDatHang.GetNewSoDonDatHangByNow().ToString();
        }

        public void ResetViewDonDatHang()
        {
            LoadControlDonDatHang();
            LoadMaVachSanPham();
            LoadMaVachDatHang();
        }
            
        protected override void tSbBtnDongY_Click(object sender, EventArgs e)
        {
            if (_maVachDatHangDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (AddDonDatHang())
                //dgViewMaVachDaChon.DataSource = null;
                AddChiTietDonDatHang();
            ResetViewDonDatHang();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void dgViewMaVach_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ImprovePerfomance.CellValueNeeded(sender, e, _maVachDT);
        }

    }

}

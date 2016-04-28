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
    public partial class FrmDatHang : Form,IDonDatHangView
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FromDatHang_Load(object sender, EventArgs e)
        {
            ///Load các khối control textbox và combobox
            LoadControlDonDatHang();
            ///Load Mã Vạch sản phẩm
            LoadMaVachSanPham();
            ///Load Mã vạch đặt hàng
            LoadMaVachDatHang();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
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
   
        ///
        ///
        /// 
        ctrlDonDatHang _ctrlDonDatHang = new ctrlDonDatHang();

        clsDonDatHang _donDatHang = new clsDonDatHang();
        /// 
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 
        DataTable _maVachDT = new DataTable();

      
        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = 7;

        int _idCuaHang = 9;

        ///
        /// 
        ///
        ctrlChiTietHoaDon _ctrlChiTietHoaDon = new ctrlChiTietHoaDon();

        clsChiTietHoaDon _chiTietHoaDon = new clsChiTietHoaDon();

        ///
        ///Thêm control
        ///
        DataTable _maVachDatHangDT = new DataTable();

        DataTable _nhaCungCapDT = new DataTable();

        ctrlChiTietDonDatHang _ctrlChiTietDonDatHang = new ctrlChiTietDonDatHang();

        clsChiTietDonDatHang _chiTietDonDatHang = new clsChiTietDonDatHang();

        /// <summary>
        /// ctrl Nha Cung Cap
        /// </summary>
        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();
        int _idNhaCungCap = 7;
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
            ///CuaHang
            LoadCuaHang();
            ///NhaCungCap
            LoadNhaCungCap();
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
        /// Tạo các cột dữ liệu cho MaVachDuocCHon Datattable 
        ///

        private void LoadMaVachDatHang()
        {
            initMaVachDatHang();
            AlterDgViewMaVachDatHang();
            dgViewMaVachDaChon.DataSource = _maVachDatHangDT;
        }


        private void initMaVachDatHang()
        {

            _maVachDatHangDT = new DataTable();

            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("MaVach", typeof(string));
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

        }

        private void AlterDgViewMaVachDatHang()
        {
            dgViewMaVachDaChon.Columns["MaVach"].Visible = false;
        }

        #region HoaDonBanHang

        private DataTable _khachHangDT = new DataTable();
        /// 
        /// load dữ liệu vào control
        /// 

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
            DataTable table = _ctrlCuaHang.GetIdCuaHang();//Get Id các cửa hàng
            DataRow row = table.Rows[index];//Lấy row tương ứng với index
            _idCuaHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
        }

        private void tSCmbCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHang();
            //Load lại sản phẩm tương ứng với cửa hàng
            LoadMaVachSanPham();
            dgViewMaVach.Invalidate();
        }

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

        private void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            this.ChonSanPhamDatHang();
        }

        public void ChonSanPhamDatHang()
        {
            ///Lấy mã vạch từ mavachdgView
            string maVach = dgViewMaVach.CurrentRow.Cells[0].Value.ToString();
            ///Lấy dữ liệu mã vạch từ database 
            DataRow row = _ctrlMaVachSanPham.GetRowMaVachSanPham(maVach).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
            if (!PlusSelectedMaVachDatHang(row["MaSanPham"].ToString()) && Convert.ToInt32(row["SoLuong"].ToString()) > 0)
            {
                ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
                DataRow newRow = _maVachDatHangDT.NewRow();
                newRow["MaVach"] = maVach;
                newRow["MaSanPham"] = row["MaSanPham"].ToString();
                newRow["TenSanPham"] = row["TenSanPham"].ToString();
                newRow["DonVi"] = row["DonVi"].ToString();
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = Convert.ToInt32(row["GiaNhap"].ToString());
                newRow["ThanhTien"] = Convert.ToInt32(row["GiaNhap"].ToString());
                _maVachDatHangDT.Rows.Add(newRow);
            }
            else if (Convert.ToInt32(row["SoLuong"].ToString()) <= 0)
            {
                MessageBox.Show(this, "Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ///Gán dữ liệu vào dgView
            dgViewMaVachDaChon.DataSource = _maVachDatHangDT;

            AlterDgViewMaVachDatHang();

            dgViewMaVachDaChon.Invalidate();
        }

        /// 
        /// Tăng số lượng sản phẩm đã được chọn
        /// 
        private bool PlusSelectedMaVachDatHang(string MaSanPham)
        {
            foreach (DataRow row in _maVachDatHangDT.Rows)
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

        private bool MinusSelectedMaVachDatHang(string MaSanPham)
        {
            foreach (DataRow row in _maVachDatHangDT.Rows)
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
                        _maVachDatHangDT.Rows.Remove(row);
                        return true;
                    }
                }
                
            }
            return false;
        }

        #endregion

        private void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            this.TangSoLuongSanPhamDatHang();
        }

        private void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            this.GiamSoLuongSanPhamDatHang();
        }

        public void TangSoLuongSanPhamDatHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null && PlusSelectedMaVachDatHang(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
            {
                dgViewMaVachDaChon.DataSource = _maVachDatHangDT;
                dgViewMaVachDaChon.Invalidate();
            }
        }

        public void GiamSoLuongSanPhamDatHang()
        {
            if (dgViewMaVachDaChon.CurrentRow != null && MinusSelectedMaVachDatHang(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
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

            string maVachSanPham = row["MaVach"].ToString();

            ///lấy id MaVach SanPham từ view
            int idMaVach = _ctrlMaVachSanPham.GetIdByMaVach(maVachSanPham);

            

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

        private void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {
            txtGhiChuDonDatHang.Text = _ctrlDonDatHang.GetNewSoDonDatHangByNow().ToString();
        }

        public void ResetViewDonDatHang()
        {
            LoadControlDonDatHang();
            LoadMaVachSanPham();
            LoadMaVachDatHang();  
        }

        private void tSbBtnDongYDatHang_Click(object sender, EventArgs e)
        {
            if (_maVachDatHangDT.Rows.Count == 0)
            {
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (AddDonDatHang())
                //dgViewMaVachDaChon.DataSource = null;
                AddChiTietDonDatHang();
            //ResetViewHoaDon();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

#region DonDatHang
    
    }
#endregion
}

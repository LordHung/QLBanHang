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
    public partial class MainForm : Form
    {
        /// 
        /// Dùng để quản lý nhân viên đăng nhập
        /// 
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

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
        /// DataTable dùng để thao tác dữ liệu trên 2 datagridview chính
        /// 
        DataTable _maVachDT = new DataTable();

        DataTable _maVachDuocChonDT = new DataTable();
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadControlBanHang();
            LoadMaVachSanPham();   
            initMaVachDuocChonDT();
            AlterDgViewMaVacDuocChon();
        }

        /// <summary>
        /// Load Mã vạch sản phẩm lê dgViewMaVach
        /// </summary>
        private void LoadMaVachSanPham()
        {
            _maVachDT = _ctrlMaVachSanPham.GetData(_idCuaHang);
            dgViewMaVach.DataSource = _maVachDT;
            dgViewMaVach.Columns["MaVach"].DefaultCellStyle.ForeColor = Color.Red;
            dgViewMaVach.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.BackColor = Color.Yellow;
            dgViewMaVach.Columns["GiaBan"].DefaultCellStyle.ForeColor = Color.Green;
            //dgViewMaVachDaChon.DataSource = _maVachDuocChonDT;
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
            txtMaHoaDon.Text = "IV02" + GetNewSoHoaDon(now.ToString("yyyy-MM-dd")).ToString() + now.ToString("ddMMyyyy");
            txtMaHoaDon.Invalidate();
            ///KhachHang
            LoadKhachHang();
            ///NhanVien
            txtNhanVien.Text = _ctrlNhanVien.GetTenNhaVienById(_idNhanVien);
            txtNhanVien.Invalidate();
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
        /// 
        /// Số hóa đơn
        /// 
        /// 
        /// Lấy mã hóa đơn mới nhất trong ngày
        /// 

        private string GetNewSoHoaDon(string date)
        {
            int SHD =  _ctrlHoaDon.GetNewSoHoaDon(date);//SoHoaDon
            string sSHD = SHD.ToString();//String SoHoaDon
            int sSHDLength = sSHD.Length;
            string result = "";
            for (int i = 0; i < 5 - sSHDLength; i++)
            {
                result += "0";
            }
            result += sSHD;
            return result;
        }

       
        #endregion


        #region ToolMenuStripItem Click
        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmQLBH = new FormQuanLyBanHang();
            _FrmQLBH.Show();
        }

        private void khachHangNhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmQLKH_NCC = new FormQLKH_NCC();
            _FrmQLKH_NCC.Show();
        }

        private void cuaHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmCuaHang = new FrmCuaHang();
            _FrmCuaHang.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }
        #endregion

        #region xử lý trên datagridview 

        private void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {
            ///Lấy mã vạch từ mavachdgView
           string maVach = dgViewMaVach.CurrentRow.Cells[0].Value.ToString();
            ///Lấy dữ liệu mã vạch từ database 
           DataRow row =  _ctrlMaVachSanPham.GetRowMaVachSanPham(maVach).Rows[0];
            //.copy dữ liệu vào _mavachDuowcCHon
           if (!PlusSelected(row["MaSanPham"].ToString()) && Convert.ToInt32(row["SoLuong"].ToString()) > 0)
           {
               ///Nếu sản phẩm chưa được chọn và có số lượng tồn lớn hơn 0
               DataRow newRow = _maVachDuocChonDT.NewRow();
               newRow["MaVach"] = maVach;
               newRow["MaSanPham"] = row["MaSanPham"].ToString();
               newRow["TenSanPham"] = row["TenSanPham"].ToString();
               newRow["DonVi"] = row["DonVi"].ToString();
               newRow["SoLuong"] = 1;
               newRow["DonGia"] =Convert.ToInt32(row["GiaBan"].ToString());
               newRow["VAT"] = Convert.ToInt32(row["VAT"].ToString());
               newRow["ThanhTien"] = Convert.ToInt32(row["GiaBan"].ToString());

               _maVachDuocChonDT.Rows.Add(newRow);
           }
           else if (Convert.ToInt32(row["SoLuong"].ToString()) <= 0)
           {
               MessageBox.Show(this,"Số lượng không đủ","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           ///Gán dữ liệu vào dgView
           dgViewMaVachDaChon.DataSource =  _maVachDuocChonDT;

           LoadNumericBoxes();

           AlterDgViewMaVacDuocChon();

           dgViewMaVachDaChon.Invalidate();
        }
        /// 
        /// Tăng số lượng sản phẩm đã được chọn
        /// 
        private bool PlusSelected(string MaSanPham)
        {
            foreach(DataRow row in _maVachDuocChonDT.Rows)
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

        private bool MinusSelected(string MaSanPham)
        {
            foreach (DataRow row in _maVachDuocChonDT.Rows)
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
                        _maVachDuocChonDT.Rows.Remove(row);
                        return true;
                    }
                }
                
            }
            return false;
        }

        /// 
        /// Tạo các cột dữ lieeujc cho MaVachDuocCHon Datattable 
        /// 
        private void initMaVachDuocChonDT()
        {
            //|MaSanPham|TenSanPham|DonVi|SoLuong|VAT
            DataColumn dc = new DataColumn("MaVach", typeof(string));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("MaSanPham", typeof(string));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("TenSanPham", typeof(string));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("DonVi", typeof(string));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(int));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("VAT", typeof(int));
            _maVachDuocChonDT.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(int));
            _maVachDuocChonDT.Columns.Add(dc);
            
        }

        private void AlterDgViewMaVacDuocChon()
        {
            dgViewMaVachDaChon.Columns["MaVach"].Visible = false;
        }
        #endregion

        private void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {
            if (dgViewMaVachDaChon.CurrentRow != null && PlusSelected(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
            {
                dgViewMaVachDaChon.DataSource = _maVachDuocChonDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        private void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {
            if (dgViewMaVachDaChon.CurrentRow != null && MinusSelected(dgViewMaVachDaChon.CurrentRow.Cells[1].Value.ToString()))
            {
                dgViewMaVachDaChon.DataSource = _maVachDuocChonDT;
                dgViewMaVachDaChon.Invalidate();
                LoadNumericBoxes();
            }
        }

        
        private void LoadNumericBoxes()
        {
            int congTien = 0;
            foreach (DataRow row in _maVachDuocChonDT.Rows)
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
            _hoaDon.SoHoaDon = (decimal)_ctrlHoaDon.GetNewSoHoaDon(now.ToString("yyyy-MM-dd"));
           
            _hoaDon.SoTienKhachDua = numSoTienKhachDua.Value;
            _hoaDon.GhiChu = txtGhiChu.Text;
            _hoaDon.IdNhanVien = _idNhanVien;
            _hoaDon.IdCuaHang = _idCuaHang;
            _hoaDon.IdKhachHang = _idKhachHang;
            _hoaDon.NgayLap = dtpNgayLap.Value;
            _hoaDon.SiLe = false;
        }

        private void UpdateChiTietHoaDon()
        {
            foreach(DataRow row in _maVachDuocChonDT.Rows)
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
                _chiTietHoaDon.SanPhamComBo = 806;
                _chiTietHoaDon.GiaVon = Convert.ToInt32(row["DonGia"].ToString());
                _chiTietHoaDon.GhiChu = txtGhiChu.Text;

                if (_ctrlChiTietHoaDon.AddData(_chiTietHoaDon))
                {
                    MessageBox.Show(this, "Thêm thành công", "Thêm chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "Thêm thất bại", "Thêm chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tSBtnDongY(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this,"Xác nhận","Xác nhận tạo hóa đơn " + txtMaHoaDon.Text + " ?",
                                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            if (_maVachDuocChonDT.Rows.Count == 0)
                MessageBox.Show(this, "Danh Sách xuất rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            ///them hoa don
            AssignHoaDon();
            if (_ctrlHoaDon.AddData(_hoaDon))
            {
                MessageBox.Show(this, "Thêm thành công", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateChiTietHoaDon();
            }
            else
                MessageBox.Show(this, "Thêm thất bại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);


            ///them chi tiet hoa don
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.FFF");
            txtGhiChu.Invalidate();
        }

        
    }
}

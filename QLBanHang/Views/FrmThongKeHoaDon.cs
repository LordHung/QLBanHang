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
    public partial class FrmThongKeHoaDon : Form
    {
        ctrlHoaDon _ctrlHoaDon = new ctrlHoaDon();

        DataTable _thongKeHoaDonDT = new DataTable();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        ctrlKhachHang _ctrlKhachHang = new ctrlKhachHang();

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        DataTable _cuaHangDT = new DataTable();

        DataTable _khachHangDT = new DataTable();

        DataTable _nhanVienDT = new DataTable();

        DataTable _loaiHoaDonDT = new DataTable();

        int _idKhachHang = 0;

        int _idCuaHang = 0;

        int _idNhanVien = 0;

        LoaiHoaDon _loaiHoaDon = LoaiHoaDon.TatCa;

        public FrmThongKeHoaDon()
        {
            InitializeComponent();
            LoadControls();
            panel1.BackColor = GlobalValues.GlobalBackGroundColor;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _thongKeHoaDonDT = _ctrlHoaDon.ThongKeHoaDon(dtpFromDate.Value,dtpToDate.Value,_idKhachHang,_idCuaHang,_idNhanVien,_loaiHoaDon);

            dgViewThongKe.DataSource = _thongKeHoaDonDT;

            dgViewThongKe.Invalidate();


        }


        private void LoadControls()
        {
            LoadCuaHang();
            LoadKhachHang();
            LoadNhanVien();
            LoadControlLoaiHoaDon();
            LoadDTP();
        }
        ///
        ///LoadDTP
        ///
        private void LoadDTP()
        {
            dtpToDate.Value = DateTime.Today.AddDays(1);
        }
        /// 
        /// Cửa hàng
        /// 
        private void LoadCuaHang()
        {
            _cuaHangDT = _ctrlCuaHang.GetCuaHang();

            ///Hiển thị tên các cửa hàng lên combobox
            cmbCuaHang.DataSource = _cuaHangDT;

            cmbCuaHang.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            //LoadIdCuaHang();
        }

        private void LoadIdCuaHang()
        {
            int index = cmbCuaHang.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _cuaHangDT.Rows[index];//Lấy row tương ứng với index
                _idCuaHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idCuaHang = 0;
        }

        private void cmbCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHang();
        }


        private void ckBoxTheoCuaHang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxTheoCuaHang.Checked == true)
            {
                LoadIdCuaHang();
                cmbCuaHang.Enabled = true;
            }
            else if (ckBoxTheoKhachHang.Checked == false)
            {
                _idCuaHang = 0;
                cmbCuaHang.Enabled = false;
            }
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

        /// 
        /// Nhân viên
        ///
        private void LoadNhanVien()
        {
            _nhanVienDT = _ctrlNhanVien.GetNhanVien();

            cmbNhanVien.DataSource = _nhanVienDT;

            cmbNhanVien.DisplayMember = "TenNhanVien";

            //LoadIdNhanVien();
        }

        private void LoadIdNhanVien()
        {
            int index = cmbNhanVien.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nhanVienDT.Rows[index];//Lấy row tương ứng với index
                _idNhanVien = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNhanVien = 0;
        }

        private void ckBoxTheoNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxTheoNhanVien.Checked == true)
            {
                LoadIdNhanVien();
                cmbNhanVien.Enabled = true;
            }
            else if (ckBoxTheoNhanVien.Checked == false)
            {
                _idNhanVien = 0;
                cmbNhanVien.Enabled = false;
            }
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhanVien();
        }

        private void LoadControlLoaiHoaDon()
        {
            LoadDataTableLoaiHoaDon();

            cmbLoaiHoaDon.DataSource = _loaiHoaDonDT;

            cmbLoaiHoaDon.DisplayMember = "Name";
        }

        private void LoadGiaTriLoaiHoaDon()
        {
            int index = cmbLoaiHoaDon.SelectedIndex;
            if (index >= 0)
            {
                DataRow row = _loaiHoaDonDT.Rows[index];//Lấy row tương ứng với index
                _loaiHoaDon = (LoaiHoaDon)Convert.ToInt32(row["Value"].ToString());//gán vào _idCuaHang
            }
            else _loaiHoaDon = LoaiHoaDon.TatCa;
        }

        private void LoadDataTableLoaiHoaDon()
        {
            DataColumn dc = new DataColumn("Name", typeof(string));
            _loaiHoaDonDT.Columns.Add(dc);

            dc = new DataColumn("Value", typeof(LoaiHoaDon));
            _loaiHoaDonDT.Columns.Add(dc);

            DataRow TatCa = _loaiHoaDonDT.NewRow();
            TatCa["Name"] = "Tất cả";
            TatCa["Value"] = LoaiHoaDon.TatCa;
            

            DataRow BanLe = _loaiHoaDonDT.NewRow();
            BanLe["Name"] = "Bán lẽ";
            BanLe["Value"] = LoaiHoaDon.BanLe;

            DataRow BanSi = _loaiHoaDonDT.NewRow();
            BanSi["Name"] = "Bán sĩ";
            BanSi["Value"] = LoaiHoaDon.BanSi;

            _loaiHoaDonDT.Rows.Add(TatCa);
            _loaiHoaDonDT.Rows.Add(BanLe);
            _loaiHoaDonDT.Rows.Add(BanSi);
        }

        private void cmbLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaTriLoaiHoaDon();
        }

        private void FrmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            _idCuaHang = 0;
            _idKhachHang = 0;
            _idNhanVien = 0;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

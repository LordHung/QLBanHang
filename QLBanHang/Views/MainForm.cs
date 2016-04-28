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
        /// quản lý bán hàng
        /// 
        FormQuanLyBanHang _FrmQLBH = new FormQuanLyBanHang();

        /// 
        /// quản lý cửa hàng
        /// 
        FrmCuaHang _FrmCuaHang = new FrmCuaHang();

        /// 
        /// quản lý khách hàng và nhà cung cấp
        ///
        FormQLKH_NCC _FrmQLKH_NCC = new FormQLKH_NCC();

        ///
        ///Form thống kê 
        ///
        FrmThongKeHoaDon _FrmThongKeHoaDon = new FrmThongKeHoaDon();

        ///
        /// ID Nhan Vien Va Cua Hang
        /// 
        int _idNhanVien = 7;

        int _idCuaHang = 9;

        int _idKhachHang;


        /// 
        /// Form dùng cho control
        /// 
        FrmBanHang _FrmBanHang = new FrmBanHang(); 

        FrmDatHang _FrmDatHang = new FrmDatHang();

        enum DisplayFlag
        {
            BanHang,
            DatHang
        }

        DisplayFlag _displayFlag = DisplayFlag.BanHang;

        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadControllers();
            DisplayForm();
        }


        ///
        ///Load Controllers
        ///
        private void LoadControllers()
        {
            LoadBanHangController();
            LoadDatHangController();
        }

        private void LoadBanHangController()
        {
            _FrmBanHang.MdiParent = this;
            _FrmBanHang.Dock = DockStyle.Fill;
            _FrmBanHang.Show();
        }

        private void LoadDatHangController()
        {
            _FrmDatHang.MdiParent = this;
            _FrmDatHang.Dock = DockStyle.Fill;
            _FrmDatHang.Show();
        }
        /// <summary>
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

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmThongKeHoaDon = new FrmThongKeHoaDon();
            _FrmThongKeHoaDon.Show();
        }
        #endregion

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.BanHang;
            DisplayForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.DatHang;
            DisplayForm();
        }

        private void HideAllForms()
        {
            _FrmBanHang.BringToFront();
            _FrmDatHang.BringToFront();
        }

        private void DisplayForm()
        {
            HideAllForms();
            switch (_displayFlag)
            {
                case DisplayFlag.BanHang:
                    _FrmBanHang.BringToFront();
                    break;
                case DisplayFlag.DatHang:
                    _FrmDatHang.BringToFront();
                    break;
                default:
                    _FrmBanHang.BringToFront();
                    break;
            }
        }
    }
}

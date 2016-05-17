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
using System.Threading;

namespace QLBanHang.Views
{
    public partial class MainForm : Form
    {
        ///
        /// Quản lý
        ///
        
        /// 
        /// quản lý bán hàng
        /// 
        //FormQuanLyBanHang _FrmQLBH = new FormQuanLyBanHang();

        /// 
        /// quản lý cửa hàng
        /// 
        FrmCuaHang _FrmCuaHang;
        ///
        ///Quản lý thi-chi
        ///
        FormQLPT_C _FrmQuanLyThuChi;

        /// 
        /// quản lý khách hàng và nhà cung cấp
        ///
        FormQLKH_NCC _FrmQLKH_NCC;


        /// 
        /// quản lý nhân viên phân quyền
        ///
        FormQLNV_PQ _FrmQLNV_PQ;
        ///
        /// quản lý sản phẩm - chương trình khuyến mãi
        ///
        FormQLSNP_CTKM _FrmQLSP_CTKM;

        ///
        ///Form thống kê 
        ///
        FrmThongKeHoaDon _FrmThongKeHoaDon = new FrmThongKeHoaDon();

        /// Frm Bán hàng

        FrmBanHang _FrmBanHang = new FrmBanHang(); 
        //Đặt hàng
        FrmDatHang _FrmDatHang = new FrmDatHang();
        //Nhập kho
        FrmNhapKho _FrmNhapKho = new FrmNhapKho();
        //Xuất kho
        FrmXuatKho _FrmXuatKho = new FrmXuatKho();

        enum DisplayFlag
        {
            BanHang,
            DatHang,
            NhapKho,
            XuatKho,
            ThongKe
        }

        DisplayFlag _displayFlag = DisplayFlag.BanHang;

        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            MDIClientSupport.SetBevel(this, false);
            ImprovePerfomance.SetDoubleBuffering(this);
            panel1.BackColor = GlobalValues.BackGroundMenu_NonColor;
            CustomButtons();
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
            LoadNhapKhoController();
            LoadXuatKhoController();
            LoadThongKeController();
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

        private void LoadNhapKhoController()
        {
            _FrmNhapKho.MdiParent = this;
            _FrmNhapKho.Dock = DockStyle.Fill;
            _FrmNhapKho.Show();
        }

        private void LoadXuatKhoController()
        {
            _FrmXuatKho.MdiParent = this;
            _FrmXuatKho.Dock = DockStyle.Fill;
            _FrmXuatKho.Show();
        }

        private void LoadThongKeController()
        {
            _FrmThongKeHoaDon.MdiParent = this;
            _FrmThongKeHoaDon.Dock = DockStyle.Fill;
            _FrmThongKeHoaDon.Show();
        }
        /// <summary>
        #region ToolMenuStripItem Click
        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmQLSP_CTKM = new FormQLSNP_CTKM();
            _FrmQLSP_CTKM.Show();
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

        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmThongKeHoaDon = new FrmThongKeHoaDon();
            _FrmThongKeHoaDon.Show();
        }

        private void thuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmQuanLyThuChi = new FormQLPT_C();
            _FrmQuanLyThuChi.Show();
        }

        private void nhanVienPhanQuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FrmQLNV_PQ = new FormQLNV_PQ();
            _FrmQLNV_PQ.Show();
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

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.XuatKho;
            DisplayForm();
        }


        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhapKho;
            DisplayForm();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.ThongKe;
            DisplayForm();
        }
        
        //private void HideAllForms()
        //{
        //    _FrmBanHang.BringToFront();
        //    _FrmDatHang.BringToFront();
        //}

        private void DisplayForm()
        {
            ResetColors();
            switch (_displayFlag)
            {
                case DisplayFlag.BanHang:
                    _FrmBanHang.BringToFront();
                    this.Invalidate();
                    break;
                case DisplayFlag.DatHang:
                    _FrmDatHang.BringToFront();
                    this.Invalidate();
                    break;
                case DisplayFlag.NhapKho:
                      _FrmNhapKho.BringToFront();
                    this.Invalidate();
                    break;
                case DisplayFlag.XuatKho:
                      _FrmXuatKho.BringToFront();
                    this.Invalidate();
                    break;
                case DisplayFlag.ThongKe:
                    _FrmThongKeHoaDon.BringToFront();
                    this.Invalidate();
                    break;
                default:
                    _FrmBanHang.BringToFront();
                    this.Invalidate();
                    break;
            }
        }

        private void ResetColors()
        {
            btnBanHang.BackColor = panel1.BackColor;

            btnDatHang.BackColor = panel1.BackColor;

            btnNhapKho.BackColor = panel1.BackColor;

            btnXuatKho.BackColor = panel1.BackColor;

            btnThongKe.BackColor = panel1.BackColor;

            switch (_displayFlag)
            {
                case DisplayFlag.BanHang:
                    btnBanHang.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
                case DisplayFlag.DatHang:
                    btnDatHang.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
                case DisplayFlag.NhapKho:
                    btnNhapKho.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
                case DisplayFlag.XuatKho:
                    btnXuatKho.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
                case DisplayFlag.ThongKe:
                    btnThongKe.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
                default:
                    btnDatHang.BackColor = GlobalValues.BackGroundMenu_SelectedColor;
                    break;
            }
        }

        private void CustomButtons()
        {
            btnNhapKho.TabStop = false;
            btnNhapKho.FlatStyle = FlatStyle.Flat;
            btnNhapKho.FlatAppearance.BorderColor = panel1.BackColor;
            btnNhapKho.FlatAppearance.BorderSize = 0;
            //btnNhapKho.ForeColor

            btnBanHang.TabStop = false;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnBanHang.FlatAppearance.BorderSize = 0;

            btnDatHang.TabStop = false;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnDatHang.FlatAppearance.BorderSize = 0;

            btnXuatKho.TabStop = false;
            btnXuatKho.FlatStyle = FlatStyle.Flat;
            btnXuatKho.FlatAppearance.BorderColor = panel1.BackColor;
            btnXuatKho.FlatAppearance.BorderSize = 0;

            btnThongKe.TabStop = false;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.FlatAppearance.BorderColor = panel1.BackColor;
            btnThongKe.FlatAppearance.BorderSize = 0;
        }

    

    
    }
}

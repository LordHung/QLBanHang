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

namespace QLBanHang.Views
{
    public partial class FormQLSNP_CTKM : Form
    {
        FrmNhaSanXuat _FrmNhaSanXuat = new FrmNhaSanXuat();

        FrmNganhHang _FrmNganhHang = new FrmNganhHang();

        FrmNhomHang _FrmNhomHang = new FrmNhomHang();

        FrmSanPham _FrmSanPham = new FrmSanPham();

        FrmDanhMucSP _FrmDanhMucSP = new FrmDanhMucSP();

        Color normalColor = GlobalValues.BackGroundMenu_NonColor;

        Color selectedColor = GlobalValues.BackGroundMenu_SelectedColor;

        public FormQLSNP_CTKM()
        {
            InitializeComponent();
            MDIClientSupport.SetBevel(this, false);

            ImprovePerfomance.SetDoubleBuffering(this);
            SetStyleButtons();
            ///
            panel1.BackColor = GlobalValues.BackGroundMenu_NonColor;

            imageList1.TransparentColor = GlobalValues.BackGroundMenu_NonColor;

            SetColorButtons();
        }


        enum DisplayFlag 
        {
            NhaSanXuat,
            NganhHang,
            NhomHang,
            SanPham,
            DanhMucSP
        }

        private DisplayFlag _displayFlag = DisplayFlag.NhaSanXuat;


        private void SetStyleButtons()
        {
            ///nhasanxuat
            btnNhaSanXuat.FlatAppearance.BorderColor = panel1.BackColor;
            btnNhaSanXuat.FlatAppearance.BorderSize = 0;
            ///nganhhang
            btnNganhHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnNganhHang.FlatAppearance.BorderSize = 0;
            ///nhomhang
            btnNhomHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnNhomHang.FlatAppearance.BorderSize = 0;
            ///sanpham
            btnSanPham.FlatAppearance.BorderColor = panel1.BackColor;
            btnSanPham.FlatAppearance.BorderSize = 0;
        }

        private void SetColorButtons()
        {
            btnNhaSanXuat.BackColor = normalColor;
            btnNganhHang.BackColor =normalColor;
            btnNhomHang.BackColor = normalColor;
            btnSanPham.BackColor =normalColor;
            btnDanhMucSP.BackColor = normalColor;

            switch(_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    btnNhaSanXuat.BackColor = selectedColor;
                    break;
                case DisplayFlag.NganhHang:
                    btnNganhHang.BackColor = selectedColor;
                    break;
                case DisplayFlag.NhomHang:
                    btnNhomHang.BackColor = selectedColor;
                    break;
                case DisplayFlag.SanPham:
                    btnSanPham.BackColor = selectedColor;
                    break;
                case DisplayFlag.DanhMucSP:
                    btnDanhMucSP.BackColor = selectedColor;
                    break;
            }
        }

        private void FormQLSNP_CTKM_Load(object sender, EventArgs e)
        {
            LoadController();
            DisplayItems();
        }

        private void LoadController()
        {
            LoadSanPhamController();
            LoadNganhHangController();
            LoadNhanSanXuatController();
            LoadNhomHangController();
            LoadDanhMucSPController();
        }

        private void LoadNhanSanXuatController()
        {
            _FrmNhaSanXuat = new FrmNhaSanXuat();
            _FrmNhaSanXuat.MdiParent = this;
            _FrmNhaSanXuat.Dock = DockStyle.Fill;
            _FrmNhaSanXuat.Show();
        }
        private void LoadNganhHangController()
        {
            _FrmNganhHang = new FrmNganhHang();
            _FrmNganhHang.MdiParent = this;
            _FrmNganhHang.Dock = DockStyle.Fill;
            _FrmNganhHang.Show();
        }
        private void LoadNhomHangController()
        {
            _FrmNhomHang = new FrmNhomHang();
            //Application.Run(_FrmNhomHang);
            _FrmNhomHang.MdiParent = this;
            _FrmNhomHang.Dock = DockStyle.Fill;
            _FrmNhomHang.Show();
        }
        private void LoadSanPhamController()
        {
            _FrmSanPham = new FrmSanPham();
  
            _FrmSanPham.MdiParent = this;
            _FrmSanPham.Dock = DockStyle.Fill;
            _FrmSanPham.Show();
        }

        private void LoadDanhMucSPController()
        {
            _FrmDanhMucSP = new FrmDanhMucSP();

            _FrmDanhMucSP.MdiParent = this;
            _FrmDanhMucSP.Dock = DockStyle.Fill;
            _FrmDanhMucSP.Show();
        }

   
        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhaSanXuat;
            SetColorButtons();
            DisplayItems();
        }

        private void btnNganhHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NganhHang;
            SetColorButtons();
            DisplayItems();
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhomHang;
            SetColorButtons();
            DisplayItems();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.SanPham;
            SetColorButtons();
            DisplayItems();
        }

        private void btnDanhMucSP_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.DanhMucSP;
            SetColorButtons();
            DisplayItems();
        }

        private void DisplayItems()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhaSanXuat:
                    _FrmNhaSanXuat.BringToFront();
                    break;
                case DisplayFlag.NganhHang:
                    _FrmNganhHang.BringToFront();
                    break;
                case DisplayFlag.NhomHang:
                    _FrmNhomHang.BringToFront();
                    break;
                case DisplayFlag.SanPham:
                    _FrmSanPham.BringToFront();
                    break;
                case DisplayFlag.DanhMucSP:
                    _FrmDanhMucSP.BringToFront();
                    break;
            }
        }

     
    }
}

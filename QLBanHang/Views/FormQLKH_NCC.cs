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
    public partial class FormQLKH_NCC : Form
    {
      
        Color normalColor = GlobalValues.BackGroundMenu_NonColor;

        Color selectedColor = GlobalValues.BackGroundMenu_SelectedColor;

        FrmKhachHang _FrmKhachHang;

        FrmNhaCungCap _FrmNhaCungCap;

        FrmLoaiKhachHang _FrmLoaiKhachHang;


        enum DisplayFlag
        {
            KhachHang,
            NhaCungCap,
            LoaiKhachHang,
            PhieuQuaTang,
            ThangHangThe,
        }

        private DisplayFlag _displayFlag = DisplayFlag.KhachHang;

        public FormQLKH_NCC()
        {
            InitializeComponent();
            MDIClientSupport.SetBevel(this, false);
            ImprovePerfomance.SetDoubleBuffering(this);
            panel1.BackColor = normalColor;
            LoadData();
            SetStyleButtons();
        }


        private void FormQLKH_NCC_Load(object sender, EventArgs e)
        {
            LoadData();
            DisplayItems();
        }

        private void SetStyleButtons()
        {
            ///nhasanxuat
            btnKhachHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            ///nganhhang
            btnNhaCungCap.FlatAppearance.BorderColor = panel1.BackColor;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            ///nhomhang
            btnLoaiKhacHang.FlatAppearance.BorderColor = panel1.BackColor;
            btnLoaiKhacHang.FlatAppearance.BorderSize = 0;
            ///sanpham
            btnPhieuQuaTang.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhieuQuaTang.FlatAppearance.BorderSize = 0;
            //ThangHangThe
            btnTangHangThe.FlatAppearance.BorderColor = panel1.BackColor;
            btnTangHangThe.FlatAppearance.BorderSize = 0;
        }

        private void LoadData()
        {
            LoadKhachHang();
            LoadLoaiKhachHang();
            LoadNhacCungCap();
        }

        private void LoadKhachHang()
        {
            _FrmKhachHang = new FrmKhachHang();
            _FrmKhachHang.MdiParent = this;
            _FrmKhachHang.Dock = DockStyle.Fill;
            _FrmKhachHang.Show();
        }

        private void LoadLoaiKhachHang()
        {
            _FrmLoaiKhachHang = new FrmLoaiKhachHang();
            _FrmLoaiKhachHang.MdiParent = this;
            _FrmLoaiKhachHang.Dock = DockStyle.Fill;
            _FrmLoaiKhachHang.Show();
        }

        private void LoadNhacCungCap()
        {
            _FrmNhaCungCap = new FrmNhaCungCap();
            _FrmNhaCungCap.MdiParent = this;
            _FrmNhaCungCap.Dock = DockStyle.Fill;
            _FrmNhaCungCap.Show();
        }


        private void DisplayItems()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.KhachHang:
                    _FrmKhachHang.BringToFront();

                    break;
                case DisplayFlag.LoaiKhachHang:
                    _FrmLoaiKhachHang.BringToFront();

                    break;
                case DisplayFlag.NhaCungCap:
                    _FrmNhaCungCap.BringToFront();
                    break;
                case DisplayFlag.PhieuQuaTang:
                    break;
                case DisplayFlag.ThangHangThe:                  
                    break;
            }
            SetColorButtons();
        }


        private void SetColorButtons()
        {
            btnKhachHang.BackColor = normalColor;
            btnNhaCungCap.BackColor = normalColor;
            btnLoaiKhacHang.BackColor = normalColor;
            btnPhieuQuaTang.BackColor = normalColor;
            btnTangHangThe.BackColor = normalColor;

            switch (_displayFlag)
            {
                case DisplayFlag.KhachHang:
                    btnKhachHang.BackColor = selectedColor;
                    break;
                case DisplayFlag.LoaiKhachHang:
                    btnLoaiKhacHang.BackColor = selectedColor;
                    break;
                case DisplayFlag.NhaCungCap:
                    btnNhaCungCap.BackColor = selectedColor;
                    break;
                case DisplayFlag.PhieuQuaTang:
                    btnPhieuQuaTang.BackColor = selectedColor;
                    break;
                case DisplayFlag.ThangHangThe:
                    btnTangHangThe.BackColor = selectedColor;
                    break;

            }
        }
        /// 
        /// CHọn tùy chỉnh hiển thị
        /// 

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.KhachHang;
            DisplayItems();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhaCungCap;
            DisplayItems();
        }

        private void btnLoaiKhacHang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.LoaiKhachHang;
            DisplayItems();

        }

        private void btnPhieuQuaTang_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.PhieuQuaTang;
            DisplayItems();
        }

        private void btnTangHangThe_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhaCungCap;
            DisplayItems();
        }
    }
}

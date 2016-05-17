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
    public partial class FormQLNV_PQ : Form
    {
        FrmPhanQuyen _FrmPhanQuyen = new FrmPhanQuyen();

        FrmNhanVien _FrmNhanVien = new FrmNhanVien();

        Color normalColor = GlobalValues.BackGroundMenu_NonColor;

        Color selectedColor = GlobalValues.BackGroundMenu_SelectedColor;


        public FormQLNV_PQ()
        {
            InitializeComponent();
            MDIClientSupport.SetBevel(this, false);
            LoadData();
            panel1.BackColor = GlobalValues.BackGroundMenu_NonColor;
            SetStyleButtons();
        }

        private void FormQLNV_PQ_Load(object sender, EventArgs e)
        {
            DisplayItems();
        }
        enum DisplayFlag
        {
            NhanVien,
            PhanQuyen
        }

        private DisplayFlag _displayFlag = DisplayFlag.NhanVien;

        private void LoadData()
        {
            LoadNhanVien();
            LoadPhanQuyen();
        }

        private void LoadNhanVien()
        {
            _FrmNhanVien.MdiParent = this;
            _FrmNhanVien.Dock = DockStyle.Fill;
            _FrmNhanVien.Show();
        }

        private void LoadPhanQuyen()
        {
            _FrmPhanQuyen.MdiParent = this;
            _FrmPhanQuyen.Dock = DockStyle.Fill;
            _FrmPhanQuyen.Show();
        }

        private void SetColorButtons()
        {
            btnNhanVien.BackColor = normalColor;

            btnPhanQuyen.BackColor = normalColor;

            switch (_displayFlag)
            {
                case DisplayFlag.NhanVien:
                    btnNhanVien.BackColor = selectedColor;
                    break;
                case DisplayFlag.PhanQuyen:
                    btnPhanQuyen.BackColor = selectedColor;
                    break;
            }
        }



        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.NhanVien;
            DisplayItems();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.PhanQuyen;
            DisplayItems();
        }

        private void DisplayItems()
        {
            switch (_displayFlag)
            {
                case DisplayFlag.NhanVien:
                    _FrmNhanVien.BringToFront();
                    break;
                case DisplayFlag.PhanQuyen:
                    _FrmPhanQuyen.BringToFront();
                    break;

            }
            SetColorButtons();
        }

        private void SetStyleButtons()
        {
            ///nhasanxuat
            btnNhanVien.FlatAppearance.BorderColor = panel1.BackColor;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            ///nganhhang
            btnPhanQuyen.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhanQuyen.FlatAppearance.BorderSize = 0;

        }

    

    }
}

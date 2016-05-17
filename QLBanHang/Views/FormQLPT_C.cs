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
    public partial class FormQLPT_C : Form
    {
        ctrlPhieuChi _ctrlPhieuChi = new ctrlPhieuChi();

        ctrlPhieuThu _ctrlPhieuThu = new ctrlPhieuThu();

        FrmPhieuChi _FrmPhieuChi = new FrmPhieuChi();

        FrmPhieuThu _FrmPhieuThu = new FrmPhieuThu();

        Color normalColor = GlobalValues.BackGroundMenu_NonColor;

        Color selectedColor = GlobalValues.BackGroundMenu_SelectedColor;


        enum DisplayFlag
        {
            PhieuThu,
            PhieuChi
        }

        private DisplayFlag _displayFlag = DisplayFlag.PhieuThu;

        public FormQLPT_C()
        {
            InitializeComponent();
            MDIClientSupport.SetBevel(this, false);
            panel1.BackColor = GlobalValues.BackGroundMenu_NonColor;
            LoadControllers();
            SetStyleButtons();
        }


        private void FrmQuanLyPhieuThuChi_Load(object sender, EventArgs e)
        {
            DisplayForm();
        }

        private void LoadControllers()
        {
            LoadPhieuThuConller();
            LoadPhieuChiConller();
        }

        private void LoadPhieuThuConller()
        {
            _FrmPhieuThu.MdiParent = this;
            _FrmPhieuThu.Dock = DockStyle.Fill;
            _FrmPhieuThu.Show();
        }

        private void LoadPhieuChiConller()
        {
            _FrmPhieuChi.MdiParent = this;
            _FrmPhieuChi.Dock = DockStyle.Fill;
            _FrmPhieuChi.Show();
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.PhieuThu;
            DisplayForm();
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            _displayFlag = DisplayFlag.PhieuChi;
            DisplayForm();
        }

        private void DisplayForm()
        {  
            switch (_displayFlag)
            {
                case DisplayFlag.PhieuThu:
                    _FrmPhieuThu.BringToFront();
                    this.Invalidate();
                    break;
                case DisplayFlag.PhieuChi:
                    _FrmPhieuChi.BringToFront();
                    this.Invalidate();
                    break;
                default:
                    _FrmPhieuThu.BringToFront();
                    this.Invalidate();
                    break;
            }
            ResetColors();
        }

        private void ResetColors()
        {
            btnPhieuChi.BackColor = normalColor;

            btnPhieuThu.BackColor = normalColor;

            switch (_displayFlag)
            {
                case DisplayFlag.PhieuThu:
                    btnPhieuThu.BackColor = selectedColor;
                    break;
                case DisplayFlag.PhieuChi:
                    btnPhieuChi.BackColor = selectedColor;
                    break;
                default:
                    btnPhieuThu.BackColor = selectedColor;
                    break;
            }
        }

        private void SetStyleButtons()
        {
            ///nhasanxuat
            btnPhieuChi.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhieuChi.FlatAppearance.BorderSize = 0;
            ///nganhhang
            btnPhieuThu.FlatAppearance.BorderColor = panel1.BackColor;
            btnPhieuThu.FlatAppearance.BorderSize = 0;
        }

    }
}

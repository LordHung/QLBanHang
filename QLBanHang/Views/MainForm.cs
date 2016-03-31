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
    public partial class MainForm : Form
    {
        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        clsNhanVien _nhanVien = new clsNhanVien();

        FormQuanLyBanHang _FrmQLBH = new FormQuanLyBanHang();

        FrmCuaHang _FrmCuaHang = new FrmCuaHang();

        FormQLKH_NCC _FrmQLKH_NCC = new FormQLKH_NCC();

        /// <summary>
        /// Kiểm tra xem đã đăng nhập chưa
        /// </summary>
        private bool _isDangNhap = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            while(!_isDangNhap)
            {
                using (FrmDangNhapDlg dlg = new FrmDangNhapDlg())
                {
                    if (dlg.ShowDialog() == DialogResult.OK && DangNhap(dlg))
                    {
                        _nhanVien.TenDangNhap = dlg.TenDangNhap;
                        _isDangNhap = true;
                        MainForm_Load(sender, e);
                        _nhanVien.TenDangNhap = dlg.TenDangNhap;
                        _nhanVien.Id = _ctrlNhanVien.GetIdNhanVien(dlg.TenDangNhap);
                    }
                    else
                        MessageBox.Show("ko thể đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool DangNhap(FrmDangNhapDlg dlg)
        {
            string _tenDangNhap = dlg.TenDangNhap;
            if (_ctrlNhanVien.IsExist(_tenDangNhap))
            {
               string  _matKhau = _ctrlNhanVien.GetMatKhauNhanVien(_tenDangNhap);
                if (_matKhau == dlg.MatKhau)
                {
                    return true;
                }
            }
            return false;
        }

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
            _isDangNhap = false;
            MainForm_Load(sender, e);
        }
    }
}

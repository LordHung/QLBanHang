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
    public partial class AddLoaiKhachHangDlg : Dlg_Them_Xoa_Sua_base
    {
        ctrlLoaiKhachHang _ctrlLoaiKhachHang = new ctrlLoaiKhachHang();

        clsLoaiKhachHang _loaiKhachHang = new clsLoaiKhachHang();

        public AddLoaiKhachHangDlg()
        {
            InitializeComponent();
        }

        public AddLoaiKhachHangDlg(ctrlLoaiKhachHang ctrl)
        {
            InitializeComponent();
            _ctrlLoaiKhachHang = ctrl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private bool AssignData()
        {
            bool Valid = true;
            string Error = "";
            ///LoaiThe

            if (txtLoaiThe.Text.Trim().Length > 0)
            {
                _loaiKhachHang.LoaiThe = txtLoaiThe.Text.Trim();
            }
            else
            {
                Error += "Chưa nhập loại thẻ,";
                Valid = false;
            }
            ///Ngưỡng quy đỏio
            _loaiKhachHang.NguongQuyDoi = (int)numNguong.Value;
            ///Tĩ lệ quy đổi
            _loaiKhachHang.TiLeQuyDoiDiem = (double)numTiLeQuyDoi.Value;    
            ///MoTa
            _loaiKhachHang.MoTa = txtMoTa.Text.Trim();
            if (!Valid) MessageBox.Show(this, Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return Valid;
        }

        private void AddData()
        {
            if (AssignData())
                _ctrlLoaiKhachHang.AddData(_loaiKhachHang);
        }
        
    }
}

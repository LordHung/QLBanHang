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
    public partial class AddMaVachSanPhamDlg : DlgMaVachSanPhamBse
    {
        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        DataTable _nhaCungCapDT = new DataTable();

        int _idNhaCungCap;

        int _idSanPham;

        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        clsMaVachSanPham _maVachSanPham = new clsMaVachSanPham();

        public AddMaVachSanPhamDlg()
        {
            InitializeComponent();
        }

        public AddMaVachSanPhamDlg(ctrlMaVachSanPham ctrl,int idSanPham)
        {
            InitializeComponent();
            _ctrlMaVachSanPham = ctrl;
            _idSanPham = idSanPham;
            LoadData();
        }

        private void LoadData()
        {
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            LoadNhaCungCap();
            ckSuDung.Checked = true;
        }

        /// 
        /// Nhà cung cấp
        /// 
        private void LoadNhaCungCap()
        {
            _nhaCungCapDT = _ctrlNhaCungCap.GetNhaCungCap();

            cmbNhaCungCap.DataSource = _nhaCungCapDT;

            cmbNhaCungCap.DisplayMember = "NhaCungCap";

            LoadIdNhaCungCap();

            cmbNhaCungCap.Invalidate();
        }


        private void LoadIdNhaCungCap()
        {
            int index = cmbNhaCungCap.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nhaCungCapDT.Rows[index];//Lấy row tương ứng với index
                _idNhaCungCap = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNhaCungCap = 0;
        }

        private void cmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhaCungCap();
        }

        ///
        ///AssignData
        ///
        private bool AsssignData()
        {
            ///IdNhanVien
            _maVachSanPham.IdNhanVien = GlobalValues.IdNhanVien;
           
            ///idNhaCungCap
            _maVachSanPham.IdNhaCungCap = _idNhaCungCap;
            ///MaVach
            if (txtMaVach.Text.Trim().Length > 0)
            {
                _maVachSanPham.MaVach = txtMaVach.Text;
            }
            else
            {
                MessageBox.Show("Chưa nhập mã vạch sản phẩm", "Thiếu thông tin", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return false;
            }
            ///NgayTao
            _maVachSanPham.NgayTao = DateTime.Now;
            ///GiaLe
            _maVachSanPham.GiaBan = (int)numGiaLe.Value;
            ///GiaSi
            _maVachSanPham.GiaSi = (int)numGiaSi.Value;
            ///GiaNhap
            _maVachSanPham.GiaNhap = (int)numGiaNhap.Value;
            ///GiaBQGQ
            _maVachSanPham.GiaBQGQ = (int)numGiaBQGQ.Value;
            ///VAT
            _maVachSanPham.VAT = (int)numVAT.Value;
            ///KhongTichLuyDiem
            _maVachSanPham.KhongTichLuyDiem = ckKhongLTD.Checked;
            ///SuDung
            _maVachSanPham.SuDung = ckSuDung.Checked;

            return true;
        }

        private void AddData()
        {
            if (AsssignData())
                _ctrlMaVachSanPham.AddData(_maVachSanPham,_idSanPham);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}

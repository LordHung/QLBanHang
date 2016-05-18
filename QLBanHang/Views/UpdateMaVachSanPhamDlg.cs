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
    public partial class UpdateMaVachSanPhamDlg : DlgMaVachSanPhamBse
    {
        ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        clsMaVachSanPham _maVachSanPham = new clsMaVachSanPham();

        int _idMaVachSanPham;

        ctrlNhaCungCap _ctrlNhaCungCap = new ctrlNhaCungCap();

        DataTable _nhaCungCapDT = new DataTable();

        int _idNhaCungCap;

        public UpdateMaVachSanPhamDlg()
        {
            InitializeComponent();
        }

        public UpdateMaVachSanPhamDlg(ctrlMaVachSanPham ctrl,int idMaVachSanPham)
        {
            InitializeComponent();
            _idMaVachSanPham = idMaVachSanPham;
            _ctrlMaVachSanPham = ctrl;
            LoadNhaCungCap();
            LoadData();
        }

        private void LoadData()
        {
            DataRow row = _ctrlMaVachSanPham.GetDataByIdMaVach(_idMaVachSanPham).Rows[0];
            //CuaHang
            txtCuaHang.Text = row["TenCuaHang"].ToString();
            //MaSanPham
            txtMaSanPham.Text = row["MaSanPham"].ToString();
            //TenSanPham
            txtTenSanPham.Text = row["TenSanPham"].ToString();
            //MaVach
            txtMaVach.Text = row["MaVach"].ToString();
            //NgayTao
            txtNgayTao.Text = row["NgayTao"].ToString();
            //GiaLE
            numGiaLe.Value = Convert.ToDecimal(row["GiaBan"].ToString());
            //GiaSi
            numGiaSi.Value = Convert.ToDecimal(row["GiaSi"].ToString());
            //GiaNhap
            numGiaBQGQ.Value = Convert.ToDecimal(row["GiaBQGQ"].ToString());
            //GiaBQGQ
            numGiaNhap.Value = Convert.ToDecimal(row["GiaNhap"].ToString());
            //VAT
            numVAT.Value = Convert.ToInt32(row["VAT"].ToString());
            //KhongTLD
            ckKhongLTD.Checked = Convert.ToBoolean(row["KhongTichLuyDiem"].ToString());
            //SuDung
            ckSuDung.Checked = Convert.ToBoolean(row["SuDung"].ToString());
            //NhaCungCap
            _idNhaCungCap = Convert.ToInt32(row["idNhaCungCap"].ToString());
            foreach (DataRow rowNCC in _nhaCungCapDT.Rows)
            {
                if (rowNCC["id"].ToString() == _idNhaCungCap.ToString())
                {
                    cmbNhaCungCap.SelectedIndex = _nhaCungCapDT.Rows.IndexOf(rowNCC);
                    LoadIdNhaCungCap();
                    cmbNhaCungCap.Invalidate();
                    return;
                }
            }
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
        /// Assign Data
        /// 
        private bool AssignData()
        {
            _maVachSanPham.Id = _idMaVachSanPham;
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
            ///VAT
            _maVachSanPham.VAT = (int)numVAT.Value;
            ///SuDung
            _maVachSanPham.SuDung = ckSuDung.Checked;
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AssignData())
                _ctrlMaVachSanPham.UpdateData(_maVachSanPham);
        }
    }
}

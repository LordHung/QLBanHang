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

namespace QLBanHang.Views
{
    public partial class Frm_KinhDoanh_Base : Form
    {
        public Frm_KinhDoanh_Base()
        {
            InitializeComponent();
            DoubleBuffering();
            SetColor();
            LoadCuaHang();
            LoadSoLuongMaVach();

        }

        protected void DoubleBuffering()
        {
            ImprovePerfomance.SetDoubleBuffering(dgViewMaVach);
            ImprovePerfomance.SetDoubleBuffering(dgViewMaVachDaChon);
            ImprovePerfomance.SetDoubleBuffering(panelMain);
        }

        protected void SetColor()
        {
            dgViewMaVach.BackgroundColor = GlobalValues.GlobalBackGroundColor;
            dgViewMaVachDaChon.BackgroundColor = GlobalValues.GlobalBackGroundColor;
            panelMain.BackColor = GlobalValues.GlobalBackGroundColor;
            tsSoLuongMaVachSanPham.BackColor = GlobalValues.GlobalBackGroundColor;
            tsSoLuongSanPhamDuocChon.BackColor = GlobalValues.GlobalBackGroundColor;
        }

        protected int _idCuaHang;

        DataTable _cuaHangDT = new DataTable();

        ctrlCuaHang _ctrlCuaHang = new ctrlCuaHang();

        protected ctrlMaVachSanPham _ctrlMaVachSanPham = new ctrlMaVachSanPham();

        protected DataTable _maVachDT = new DataTable();

        //private void AlterDgViewMaVachDatHang()
        //{
        //    dgViewMaVachDaChon.Columns["MaVach"].Visible = false;
        //}

        private void LoadCuaHang()
        {
            _cuaHangDT = _ctrlCuaHang.GetCuaHang();
            ///Hiển thị tên các cửa hàng lên combobox
            tSCmbCuaHang.ComboBox.DataSource = _cuaHangDT;
            tSCmbCuaHang.ComboBox.DisplayMember = "TenCuaHang";

            ///LoadIdCuahang
            LoadIdCuaHang();

            tSCmbCuaHang.ComboBox.Invalidate();
        }

        private void LoadIdCuaHang()
        {
            int index = tSCmbCuaHang.ComboBox.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _cuaHangDT.Rows[index];//Lấy row tương ứng với index
                _idCuaHang = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
        }


        protected  void LoadMaVachSanPham()
        {
            _maVachDT = new DataTable();

            _maVachDT = _ctrlMaVachSanPham.GetData(_idCuaHang);

            dgViewMaVach.DataSource = _maVachDT;
        }

        protected virtual void tSBtnChonMaVach_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tSBtnPlusMaVach_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tSbtnMinusMaVach_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tSBtnXemTruoc_Click(object sender, EventArgs e)
        {

        }

        protected virtual void tSCmbCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdCuaHang();
            //Load lại sản phẩm tương ứng với cửa hàng
            LoadMaVachSanPham();
            dgViewMaVach.Invalidate();
        }

        protected virtual void dgViewMaVach_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        protected virtual void tSbBtnDongY_Click(object sender, EventArgs e)
        {

        }
        ///
        ///ChonSanPham
        ///


        /// 
        /// Tăng số lượng sản phẩm đã được chọn
        /// 
        protected bool PlusSelectedMaVach(int idMaVachSanPham,DataTable _maVachDuocChonDT)
        {
            if (_maVachDuocChonDT.Rows.Count == 0)
                return false;
            foreach (DataRow row in _maVachDuocChonDT.Rows)
            {
                //tăng số lượng
                int soLuong = Convert.ToInt32(row["SoLuong"].ToString()) + 1;
                int donGia = Convert.ToInt32(row["DonGia"].ToString());
                if (row["id"].ToString() == idMaVachSanPham.ToString())
                {
                    row["SoLuong"] = soLuong;
                    row["ThanhTien"] = soLuong * donGia;
                    return true;
                }
            }
            return false;
        }
        /// 
        /// Giảm số lượng sản phẩm đã đưuọc chọn
        /// 

        protected bool MinusSelectedMaVach(int idMaVachSanPham, DataTable _maVachDuocChonDT)
        {
            if (_maVachDuocChonDT.Rows.Count == 0)
                return false;
            foreach (DataRow row in _maVachDuocChonDT.Rows)
            {
                //giảm số lượng
                int soLuong = Convert.ToInt32(row["SoLuong"].ToString()) - 1;
                int donGia = Convert.ToInt32(row["DonGia"]);
                if (row["id"].ToString() == idMaVachSanPham.ToString())
                {
                    if (soLuong > 0)
                    {
                        row["SoLuong"] = soLuong;
                        row["ThanhTien"] = soLuong * donGia;
                        return true;
                    }
                    else
                    {
                        _maVachDuocChonDT.Rows.Remove(row);
                        return true;
                    }
                }

            }
            return false;
        }


        private void dgViewMaVach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ImprovePerfomance.RowPostPaint(sender, e, this);
        }

        private void dgViewMaVach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ///Dữ liệu có chung trên tất cả các datagridview kế thừa từ this
            dgViewMaVach.Columns["id"].Visible = false;
            ///MaVach
            dgViewMaVach.Columns["MaVach"].HeaderText = "Mã Vạch";
            dgViewMaVach.Columns["MaVach"].DefaultCellStyle.ForeColor = Color.Red;
            dgViewMaVach.Columns["MaVach"].Width = 150;
            ///MaSanPham
            dgViewMaVach.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgViewMaVach.Columns["MaSanPham"].Width = 150;
            ///TenSanPham
            dgViewMaVach.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgViewMaVach.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["TenSanPham"].Width = 150;
            //SoLuong
            dgViewMaVach.Columns["SoLuong"].HeaderText = "SL";
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVach.Columns["SoLuong"].DefaultCellStyle.BackColor = Color.Yellow;
            dgViewMaVach.Columns["SoLuong"].Width = 60;
            //DonVi
            dgViewMaVach.Columns["DonVi"].HeaderText = "Đơn Vị";
            dgViewMaVach.Columns["DonVi"].Width = 100;
            //TenNhaSanXuat
            dgViewMaVach.Columns["TenNhaSanxuat"].HeaderText = "Nhà Sản Xuất";
            dgViewMaVach.Columns["TenNhaSanxuat"].Width = 150;
            ///NganhSanPham
            dgViewMaVach.Columns["TenNganhSanPham"].HeaderText = "Ngành Sản Phẩm";
            dgViewMaVach.Columns["TenNganhSanPham"].Width = 150;
            //LoaiSanPham
            dgViewMaVach.Columns["LoaiSanPham"].HeaderText = "Loại Sản Phẩm";
            dgViewMaVach.Columns["LoaiSanPham"].Width = 150;
            //TenNhaCungCap
            dgViewMaVach.Columns["TenNhaCungCap"].HeaderText = "Nhà Cung Cấp";
            dgViewMaVach.Columns["TenNhaCungCap"].Width = 150;
            ///GiaBan
            dgViewMaVach.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgViewMaVach.Columns["GiaBan"].DefaultCellStyle.ForeColor = Color.Green;
            dgViewMaVach.Columns["GiaBan"].Width = 100;

            //Dùng cho từng Form riêng biệt
            UpdateCustomDataGridView();

        }

        protected virtual void UpdateCustomDataGridView()
        { }


        private void dgViewMaVachDaChon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgViewMaVachDaChon.Columns["id"].Visible = false;

            dgViewMaVachDaChon.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgViewMaVachDaChon.Columns["MaSanPham"].Width = 150;

            dgViewMaVachDaChon.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgViewMaVachDaChon.Columns["TenSanPham"].DefaultCellStyle.ForeColor = Color.Blue;
            dgViewMaVachDaChon.Columns["TenSanPham"].Width = 150;

            dgViewMaVachDaChon.Columns["SoLuong"].HeaderText = "SL";
            dgViewMaVachDaChon.Columns["SoLuong"].Width = 60;

            dgViewMaVachDaChon.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgViewMaVachDaChon.Columns["DonGia"].Width = 100;

            dgViewMaVachDaChon.Columns["DonVi"].HeaderText = "Đơn Vị";
            dgViewMaVachDaChon.Columns["DonVi"].Width = 100;

            //dgViewMaVachDaChon.Columns["VAT"].HeaderText = "VAT";
            //dgViewMaVachDaChon.Columns["VAT"].Width = 100;

            dgViewMaVachDaChon.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgViewMaVachDaChon.Columns["ThanhTien"].Width = 100;

            dgViewMaVachDaChon.Columns["GhiChu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgViewMaVachDaChon.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }

        protected void LoadSoLuongMaVach()
        {
            lblSoLuongMaVach.Text = dgViewMaVach.Rows.Count.ToString() + " sản phẩm.";
        }

        private void dgViewMaVachDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblSoLuongMaVachDuocChon.Text = (dgViewMaVachDaChon.Rows.Count - 1).ToString() + " sản phẩm.";
        }

        private void dgViewMaVachDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblSoLuongMaVachDuocChon.Text = (dgViewMaVachDaChon.Rows.Count - 1).ToString() + " sản phẩm.";
        }

        private void dgViewMaVachDaChon_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void Frm_KinhDoanh_Base_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanHang.Models;
using QLBanHang.Objects;
using System.Windows.Forms;
using QLBanHang.Views;

namespace QLBanHang.Controls
{
    public interface INganhSanPhamView
    {
        void UpdateView();
    }


    public class ctrlNganhSanPham
    {

        mdlNganhSanPham _mdlNganhSanPham = new mdlNganhSanPham();

        INganhSanPhamView _viewNganhSanPham;

        public ctrlNganhSanPham()
        {
        }

        public void SetView(INganhSanPhamView view)
        {
            _viewNganhSanPham = view;
        }


        /// <summary>
        /// GetData
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _mdlNganhSanPham.GetData();
        }

        /// <summary>
        /// Dùng để sửa hoặc xóa dữ liệu
        /// </summary>
        public DataTable GetNganhSanPhamByCode(string code)
        {
            return _mdlNganhSanPham.GetNganhSanPhamByCode(code);
        }

        /// <summary>
        /// Dùng để liệt kê ngành sản phẩm theo MaaNganh/TenNganh
        /// </summary>
        public DataTable GetNganhSanPham()
        {
            return _mdlNganhSanPham.GetNganhSanPham();
        }

        public int GetIdNganhSanPham(string maNganh_TenNganh)
        {
            return _mdlNganhSanPham.GetIdNganhSanPham(maNganh_TenNganh);
        }
        /// <summary>
        /// kiểm tra xem manganh đã có hay chưa?
        /// </summary>
        public bool IsExist(string maNganhSanPham)
        {
            return _mdlNganhSanPham.IsExist(maNganhSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        public bool AddData(clsNganhSanPham nganhSanPham)
        {
            if (IsExist(nganhSanPham.MaNganhSanPham))
            {
                MessageBox.Show("Ngành sản phẩm" + nganhSanPham.MaNganhSanPham + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm nhà cung cấp " + nganhSanPham.MaNganhSanPham + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNganhSanPham.AddData(nganhSanPham))
            {
                MessageBox.Show("Thêm thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _viewNganhSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool UpdateData(clsNganhSanPham nganhSanPham)
        {
            if (IsExist(nganhSanPham.MaNganhSanPham) 
                && nganhSanPham.Id != _mdlNganhSanPham.GetIdNganhSanPhamByMa(nganhSanPham.MaNganhSanPham))
            {
                MessageBox.Show("Mã ngành sản phẩm đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewNganhSanPham.UpdateView();
                return false;
            }

            if (_mdlNganhSanPham.UpdateData(nganhSanPham))
            {
                //MessageBox.Show("Sửa thành công", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_viewNganhSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa ngành sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool DeleteData(int idNganhSanPham)
        {

            DialogResult result = MessageBox.Show("Xác nhận xóa ngành sản phẩm " + _mdlNganhSanPham.GetMaNganhSanPhamById(idNganhSanPham)
              + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNganhSanPham.DeleteData(idNganhSanPham))
            {
                _viewNganhSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa ngành sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

      
    }
}

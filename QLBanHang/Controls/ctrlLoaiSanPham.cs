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
    public interface ILoaiSanPhamView
    {
        void UpdateView();
    }


    public class ctrlLoaiSanPham
    {
        mdlLoaiSanPham _mdlLoaiSanPham = new mdlLoaiSanPham();

        ILoaiSanPhamView _viewLoaiSanPham;

        public ctrlLoaiSanPham()
        {
        }

        public void SetView(ILoaiSanPhamView view)
        {
            _viewLoaiSanPham = view;
        }


        /// <summary>
        /// Lấy dữ liệu từ databse 
        /// </summary>
        /// <returns>DATATABLE </returns>
        public DataTable GetData()
        {
            return _mdlLoaiSanPham.GetData();
        }

        /// <summary>
        /// Get loại sảm phẩm
        /// </summary>
        public DataTable GetLoaiSanPham()
        {
            return _mdlLoaiSanPham.GetLoaiSanPham();
        }

        public int GetIdLoaiSanPham(string maLoaiSanPham_TenLoaiSanPham)
        {
            return _mdlLoaiSanPham.GetIdLoaiSanPham(maLoaiSanPham_TenLoaiSanPham);
        }

        /// <summary>
        /// Get loại sản phẩm bằng mã 
        /// </summary>
        public DataTable GetLoaiSanPhamByCode(string maLoaiSanPham)
        {
            return _mdlLoaiSanPham.GetLoaiSanPhamByCode(maLoaiSanPham);
        }

        public bool AddData(clsLoaiSanPham loaiSanPham)
        {
            if (IsExist(loaiSanPham.MaLoaiSanPham))
            {
                MessageBox.Show("Mã nhóm hàng đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm nhóm hàng " + loaiSanPham.MaLoaiSanPham + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlLoaiSanPham.AddData(loaiSanPham))
            {
                MessageBox.Show("Thêm thành công", "Thêm nhóm hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _viewLoaiSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm nhóm hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Cập nhập,sửa thông tin loại sản phẩm
        /// </summary>
        public bool UpdateData(clsLoaiSanPham loaiSanPham)
        {
            if (IsExist(loaiSanPham.MaLoaiSanPham) && 
                loaiSanPham.Id != _mdlLoaiSanPham.GetIdLoaiSanPhamByMa(loaiSanPham.MaLoaiSanPham))
            {
                MessageBox.Show("Mã nhóm hàng " + loaiSanPham.MaLoaiSanPham + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_mdlLoaiSanPham.UpdateData(loaiSanPham))
            {
                //MessageBox.Show("Sửa thành công", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_viewLoaiSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa nhóm hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Xóa loại sản phẩm
        /// </summary>
        public bool DeleteData(int idLoaiSanPham)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhóm hàng " + _mdlLoaiSanPham.GetMaLoaiSanPhamById(idLoaiSanPham)
            + " ?", "Xác nhận",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlLoaiSanPham.DeleteData(idLoaiSanPham))
            {
                _viewLoaiSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa nhóm hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
      
        /// <summary>
        /// Kiểm tra xem loại sản phẩm có trong databse chưa?
        /// </summary>
        public bool IsExist(string maLoaiSanPham)
        {
            return _mdlLoaiSanPham.IsExist(maLoaiSanPham);
        }
    }
}

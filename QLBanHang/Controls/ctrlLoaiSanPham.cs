using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanHang.Models;
using QLBanHang.Objects;
using System.Windows.Forms;


namespace QLBanHang.Controls
{
    class ctrlLoaiSanPham
    {
        mdlLoaiSanPham _mdlLoaiSanPham = new mdlLoaiSanPham();

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
            return _mdlLoaiSanPham.AddData(loaiSanPham);
        }

        /// <summary>
        /// Cập nhập,sửa thông tin loại sản phẩm
        /// </summary>
        public bool UpdateData(clsLoaiSanPham loaiSanPham)
        {
            return _mdlLoaiSanPham.UpdateData(loaiSanPham);
        }

        /// <summary>
        /// Xóa loại sản phẩm
        /// </summary>
        public bool DeleteData(string maLoaiSanPham)
        {
            return _mdlLoaiSanPham.DeleteData(maLoaiSanPham);
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

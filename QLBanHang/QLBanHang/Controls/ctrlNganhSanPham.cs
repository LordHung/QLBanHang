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
    class ctrlNganhSanPham
    {
        mdlNganhSanPham _mdlNganhSanPham = new mdlNganhSanPham();
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
            return _mdlNganhSanPham.AddData(nganhSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        public bool UpdateData(clsNganhSanPham nganhSanPham)
        {
            return _mdlNganhSanPham.UpdateData(nganhSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        public bool DeleteData(string maNganhSanPham)
        {
            return _mdlNganhSanPham.DeleteData(maNganhSanPham);
        }

      
    }
}

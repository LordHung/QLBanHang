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
    class ctrlSanPham
    {
        mdlSanPham _mdlSanPham = new mdlSanPham();
        /// <summary>
        /// Get Data
        /// </summary>
        public DataTable GetData()
        {
            return _mdlSanPham.GetData();
        }

        /// <summary>
        /// 
        /// </summary>
        public DataTable GetSanPhamByCode(string code)
        {
            return _mdlSanPham.GetSanPhamByCode(code);
        }

        /// <summary>
        /// Sinh mã sản phẩm mới
        /// </summary>
        public int GetNewMaSanPham()
        {
            return _mdlSanPham.GetNewMaSanPham();
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AddData(clsSanPham sanPham)
        {
            return _mdlSanPham.AddData(sanPham);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool UpdateData(clsSanPham sanPham)
        {
            return _mdlSanPham.UpdateData(sanPham);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool DeleteData(string maSanPham)
        {
            return _mdlSanPham.DeleteData(maSanPham);
        }
    }
}

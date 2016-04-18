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
    class ctrlNhaSanXuat
    {
        mdlNhaSanXuat _mdlNhaSanXuat = new mdlNhaSanXuat();
        /// <summary>
        /// Lấy dữ liệu từ databse 
        /// </summary>
        /// <returns>DATATABLE </returns>
        public DataTable GetData()
        {
            return _mdlNhaSanXuat.GetData();
        }

        /// <summary>
        /// Lấy mã nhà sản xuất từ tên
        /// </summary>
        public string GetMaNhaSanXuat(string  tenNhaSanXuat)
        {
            return _mdlNhaSanXuat.GetMaNhaSanXuat(tenNhaSanXuat);
        }

        /// <summary>
        /// Liệt kê tên các nhà sản xuất
        /// </summary>
        public DataTable GetNhaSanXuat()
        {
            return _mdlNhaSanXuat.GetNhaSanXuat();
        }

        /// <summary>
        /// Lấy id nhà sản xuất bằng tên
        /// </summary>
        public int GetIdNhaSanXuat(string tenNhaSanXuat)
        {
            return _mdlNhaSanXuat.GetIdNhaSanXuat(tenNhaSanXuat);
        }

        /// <summary>
        /// Get nhà sản xuất bằng mã 
        /// </summary>
        public DataTable GetNhaSanXuatByCode(string maNhaSanXuat)
        {
            return _mdlNhaSanXuat.GetNhaSanXuatByCode(maNhaSanXuat);
        }

        /// <summary>
        /// Thêm nhà sản xuất
        /// </summary>
        public bool AddData(clsNhaSanXuat nhaSanXuat)
        {
            return _mdlNhaSanXuat.AddData(nhaSanXuat);
        }

        /// <summary>
        /// Cập nhập,sửa thông tin nhà sản xuất
        /// </summary>
        public bool UpdateData(clsNhaSanXuat nhaSanXuat)
        {
            return _mdlNhaSanXuat.UpdateData(nhaSanXuat);
        }

        /// <summary>
        /// Xóa nhà sản xuất
        /// </summary>
        public bool DeleteData(string maNhaSanXuat)
        {
            return _mdlNhaSanXuat.DeleteData(maNhaSanXuat);
        }

        /// <summary>
        /// Kiểm tra xem nhà sản xuất có trong databse chưa?
        /// </summary>
        public bool IsExist(string maNhaSanXuat)
        {
            return _mdlNhaSanXuat.IsExist(maNhaSanXuat);
        }
    }
}

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
    public interface INhaSanXuatView
    {
        void UpdateView();
    }


    public class ctrlNhaSanXuat
    {
        mdlNhaSanXuat _mdlNhaSanXuat = new mdlNhaSanXuat();

        INhaSanXuatView _viewNhaSanXuat;

        public ctrlNhaSanXuat()
        {
        }

        public void SetView(INhaSanXuatView view)
        {
            _viewNhaSanXuat = view;
        }
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
        public string GetMaNhaSanXuat(int idNhaSanXuat)
        {
            return _mdlNhaSanXuat.GetMaNhaSanXuat(idNhaSanXuat);
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
            if (IsExist(nhaSanXuat.MaNhaSanXuat))
            {
                MessageBox.Show("Nhà sản xuất " + nhaSanXuat.MaNhaSanXuat + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm nhà cung cấp " + nhaSanXuat.MaNhaSanXuat + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhaSanXuat.AddData(nhaSanXuat))
            {
                MessageBox.Show("Thêm thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _viewNhaSanXuat.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Cập nhập,sửa thông tin nhà sản xuất
        /// </summary>
        public bool UpdateData(clsNhaSanXuat nhaSanXuat)
        {
            if (IsExist(nhaSanXuat.MaNhaSanXuat) && nhaSanXuat.Id != _mdlNhaSanXuat.GetIdNhaSanXuat(nhaSanXuat.MaNhaSanXuat))
            {
                MessageBox.Show("Mã nhà cung cấp đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewNhaSanXuat.UpdateView();
                return false;
            }

            if (_mdlNhaSanXuat.UpdateData(nhaSanXuat))
            {
                //MessageBox.Show("Sửa thành công", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_viewNhaSanXuat.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Xóa nhà sản xuất
        /// </summary>
        public bool DeleteData(int idNhaSanXuat)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhà cung cấp " + _mdlNhaSanXuat.GetMaNhaSanXuatById(idNhaSanXuat)
             + " ?", "Xác nhận",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhaSanXuat.DeleteData(idNhaSanXuat))
            {
                _viewNhaSanXuat.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
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

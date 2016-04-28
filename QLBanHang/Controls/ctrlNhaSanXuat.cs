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
        void AddNhaSanXuat();
        void UpdateNhaSanXuat();
        void DeleteNhaSanXuat();
        void UpdateViewNhaSanXuat();
    }


    class ctrlNhaSanXuat
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

        public void UpdateNhaSanXuatFromView(string _codeForUpdate)
        {
            using (UpdateNhaSanXuatDlg dlg = new UpdateNhaSanXuatDlg(_codeForUpdate))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNhaSanXuat.UpdateViewNhaSanXuat();
                }
            }
        }

        public void AddNhaSanXuatFromView()
        {
            using (AddNhaSanXuatDlg dlg = new AddNhaSanXuatDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNhaSanXuat.UpdateViewNhaSanXuat();
                }
            }
        }

        public void DeleteNhaSanXuatFromView(string _codeForDelete)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa nhà sản xuất\n" + _codeForDelete + "?"
               , "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteData(_codeForDelete))
                    MessageBox.Show("Xóa thành công", "Xóa nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa thất bại", "Xóa nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _viewNhaSanXuat.UpdateViewNhaSanXuat();
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

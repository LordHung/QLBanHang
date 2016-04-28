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
        void AddLoaiSanPham();
        void UpdateLoaiSanPham();
        void DeleteLoaiSanPham();
        void UpdateViewLoaiSanPham();
    }


    class ctrlLoaiSanPham
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

        public void UpdateLoaiSanPhamFromView(string _codeForUpdate)
        {
            using (UpdateLoaiSanPhamDlg dlg = new UpdateLoaiSanPhamDlg(_codeForUpdate))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewLoaiSanPham.UpdateViewLoaiSanPham();
                }
            }
        }

        public void AddLoaiSanPhamFromView()
        {
            using (AddLoaiSanPhamDlg dlg = new AddLoaiSanPhamDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewLoaiSanPham.UpdateViewLoaiSanPham();
                }
            }
        }

        public void DeleteLoaiSanPhamFromView(string _codeForDelete)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa ngành hàng\n" + _codeForDelete + "?"
               , "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_mdlLoaiSanPham.DeleteData(_codeForDelete))
                    MessageBox.Show("Xóa thành công", "Xóa ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa thất bại", "Xóa ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _viewLoaiSanPham.UpdateViewLoaiSanPham();
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

        public void AddData(clsLoaiSanPham loaiSanPham)
        {
            if (!IsExist(loaiSanPham.MaLoaiSanPham))
            {
                if (_mdlLoaiSanPham.AddData(loaiSanPham))
                {
                    MessageBox.Show("Thêm thành công", "Thêm ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Thêm thất bại", "Thêm ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show( "Đã có trong databse ", "Thêm ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Cập nhập,sửa thông tin loại sản phẩm
        /// </summary>
        public void UpdateData(clsLoaiSanPham loaiSanPham)
        {
            if (_mdlLoaiSanPham.UpdateData(loaiSanPham))
            {
                MessageBox.Show("Sửa thành công", "Cập nhật ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Sửa thất bại", "Cập nhập ngành hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

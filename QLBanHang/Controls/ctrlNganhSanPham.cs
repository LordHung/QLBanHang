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
        void AddNganhSanPham();
        void UpdateNganhSanPham();
        void DeleteNganhSanPham();
        void UpdateViewNganhSanPham();
    }


    class ctrlNganhSanPham
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

        public void UpdateNganhSanPhamFromView(string _codeForUpdate)
        {
            using (UpdateNganhSanPhamDlg dlg = new UpdateNganhSanPhamDlg(_codeForUpdate))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNganhSanPham.UpdateViewNganhSanPham();
                }
            }
        }

        public void AddNganhSanPhamFromView()
        {
            using (AddNganhSanPhamDlg dlg = new AddNganhSanPhamDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNganhSanPham.UpdateViewNganhSanPham();
                }
            }
        }

        public void DeleteNganhSanPhamFromView(string _codeForDelete)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa ngành sản phẩm\n" + _codeForDelete + "?"
               , "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteData(_codeForDelete))
                    MessageBox.Show("Xóa thành công", "Xóa ngành sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa thất bại", "Xóa ngành sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _viewNganhSanPham.UpdateViewNganhSanPham();
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
        public void AddData(clsNganhSanPham nganhSanPham)
        {
            if (!IsExist(nganhSanPham.MaNganhSanPham))
            {
                if (_mdlNganhSanPham.AddData(nganhSanPham))
                {
                    MessageBox.Show("Thêm thành công", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Thêm thất bại", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Đã có trong databse ", "Thêm ngành sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateData(clsNganhSanPham nganhSanPham)
        {
            if (_mdlNganhSanPham.UpdateData(nganhSanPham))
            {
                MessageBox.Show("Sửa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Sửa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

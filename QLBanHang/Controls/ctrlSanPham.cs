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

    public interface ISanPhamView
    {
        void AddSanPham();
        void UpdateSanPham();
        void DeleteSanPham();
        void UpdateViewSanPham();
    }


    class ctrlSanPham
    {
        mdlSanPham _mdlSanPham = new mdlSanPham();

        ISanPhamView _viewSanPham;

        public ctrlSanPham()
        {
        }

        public void SetView(ISanPhamView view)
        {
            _viewSanPham = view;
        }

        public void UpdateSanPhamFromView(string _codeForUpdate)
        {
            using (UpdateSanPhamDlg dlg = new UpdateSanPhamDlg(_codeForUpdate))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewSanPham.UpdateViewSanPham();
                }
            }
        }

        public void AddSanPhamFromView()
        {
            using (AddSanPhamDlg dlg = new AddSanPhamDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewSanPham.UpdateViewSanPham();
                }
            }
        }

        public void DeleteSanPhamFromView(string _codeForDelete)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa sản phẩm\n" + _codeForDelete + "?"
               , "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_mdlSanPham.DeleteData(_codeForDelete))
                    MessageBox.Show("Xóa thành công", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _viewSanPham.UpdateViewSanPham();
        }

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
        public void AddData(clsSanPham sanPham)
        {
            if (_mdlSanPham.AddData(sanPham))
            {
                MessageBox.Show("Thêm thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateData(clsSanPham sanPham)
        {

            if (_mdlSanPham.UpdateData(sanPham))
            {
                MessageBox.Show( "Sửa thành công", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Sửa thất bại", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

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
        void UpdateView();
    }


    public class ctrlSanPham
    {
        mdlSanPham _mdlSanPham = new mdlSanPham();

        mdlSanPhamCuaHang _mdlSanPhamCuaHang = new mdlSanPhamCuaHang();

        ISanPhamView _viewSanPham;

        public ctrlSanPham()
        {
        }

        public void SetView(ISanPhamView view)
        {
            _viewSanPham = view;
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
        /// 
        public int GetNewMaSanPham()
        {
            return _mdlSanPham.GetNewMaSanPham();
        }

        public string GenerateMaSanPham(string maNhaSanXuat,int CodeSanPham)
        {
            return _mdlSanPham.GenerateMaSanPham(maNhaSanXuat, CodeSanPham);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AddData(clsSanPham sanPham)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm sản phẩm " + sanPham.CodeSanPham + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlSanPham.AddData(sanPham))
            {
                MessageBox.Show("Thêm thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _viewSanPham.UpdateView();
                if (!this.AddCuaHangTheoSanPham())
                    MessageBox.Show("Thêm cửa hàng theo sản phẩm thất bại", "Thêm sản phẩm cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool AddCuaHangTheoSanPham()
        {
            return _mdlSanPhamCuaHang.AddCuaHangTheoSanPham(_mdlSanPham.GetMaxIdSanPham());
        }

        /// <summary>
        /// 
        /// </summary>
        public bool UpdateData(clsSanPham sanPham)
        {
            if (_mdlSanPham.UpdateData(sanPham))
            {
                //MessageBox.Show("Sửa thành công", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_viewSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool DeleteData(int idSanPham)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa sản phẩm "
           + " ?", "Xác nhận",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlSanPham.DeleletDataById(idSanPham))
            {
                _viewSanPham.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public DataTable GetIdSanPham()
        {
            return _mdlSanPham.GetIdSanPham();
        }

        public int GetCodeSanPhamById(int idSanPham)
        {
            return _mdlSanPham.GetCodeSanPhamById(idSanPham);
        }
    }
}

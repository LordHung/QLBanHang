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
    public interface IMaVachSanPhamView
    {
        void UpdateMaVachSanPhamView();
    }


    public class ctrlMaVachSanPham
    {
        mdlMaVachSanPham _mdlMaVachSanPham = new mdlMaVachSanPham();

        mdlSanPhamCuaHang _mdlSanPhamCuaHang = new mdlSanPhamCuaHang();

        IMaVachSanPhamView _view;

        public void SetView(IMaVachSanPhamView view)
        {
            _view = view;
        }

        /// <summary>
        /// lấy về dữ liệu của tất cả mã vạch sản phẩm có trong cửa hàng
        /// nế có thêm idSanPhamCuaHang thì lấy ra các giá trị có liên quan đến sản phẩm cửa hàng đó
        /// </summary>
        /// <param name="idCuaHang">id của cửa hàng</param>
        /// <param name="idSanPhamCuaHang">id SanPhamCuaHang</param>
        /// <returns></returns>
        public DataTable GetData(int idCuaHang,int idSanPhamCuaHang = 0)
        {
            return _mdlMaVachSanPham.GetData(idCuaHang, idSanPhamCuaHang);
        }

        public int GetIdByMaVach(string maVach)
        {
            return _mdlMaVachSanPham.GetIdByMaVach(maVach);
        }

        /// <summary>
        /// Lấy ra mã vạch sản phẩm dựa trên idMaVach
        /// </summary>

        public DataTable GetRowMaVachSanPham(int idMaVachSanPham)
        {
            return _mdlMaVachSanPham.GetRowMaVachSanPham(idMaVachSanPham);
        }
        ///
        ///Lấy tất cả dữ liệu liên quan đến MaVach
        ///
        public DataTable GetDataByIdMaVach(int idMaVachSanPham)
        {
            return _mdlMaVachSanPham.GetDataByIdMaVach(idMaVachSanPham);
        }
        /// <summary>
        /// Giảm số lượng sản phẩm
        /// </summary>

        public bool GiamSoLuong(int id, int soLuong)
        {
            return _mdlMaVachSanPham.GiamSoLuong(id,soLuong);
        }
        /// <summary>
        /// Tăng số lượng sản phẩm
        /// </summary>
        public bool TangSoLuong(int id, int soLuong)
        {
            return _mdlMaVachSanPham.TangSoLuong(id, soLuong);
        }
        /// <summary>
        /// Lấy giá vốn bán lẽ sản phẩm
        /// </summary>
        public int GetGiaVonBanLe(int id, int soLuong)
        {
            return _mdlMaVachSanPham.GetGiaVonBanLe(id, soLuong);
        }

        /// <summary>
        /// Add data
        /// </summary>
        /// <param name="maVachSanPham"></param>
        /// <returns></returns>
        public bool AddData(clsMaVachSanPham maVachSanPham,int idSanPham)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm mã " + maVachSanPham.MaVach  + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlMaVachSanPham.AddMaVachTheoIdSanPham(maVachSanPham,idSanPham))
            {
                MessageBox.Show("Thêm thành công", "Thêm mã vạch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _view.UpdateMaVachSanPhamView();
                //if (!this.AddCuaHangTheoSanPham())
                //    MessageBox.Show("Thêm cửa hàng theo sản phẩm thất bại", "Thêm sản phẩm cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm mã vạch", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// Update Data
        /// </summary>
        /// <param name="sanPham"></param>
        /// <returns></returns>
        public bool UpdateData(clsMaVachSanPham maVachSanPham)
        {
            if (_mdlMaVachSanPham.UpdateData(maVachSanPham))
            {
                MessageBox.Show("Sửa thành công", "Sửa mã vạch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _view.UpdateMaVachSanPhamView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa mã vạch", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// DeleteData
        /// </summary>
        /// <param name="idSanPham"></param>
        /// <returns></returns>
        //public bool DeleteData(int idSanPham)
        //{
        //    DialogResult result = MessageBox.Show("Xác nhận xóa sản phẩm "
        //   + " ?", "Xác nhận",
        //                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.No) return false;
        //    ///them hoa don

        //    if (_mdlSanPham.DeleletDataById(idSanPham))
        //    {
        //        _viewSanPham.UpdateView();
        //        return true;
        //    }
        //    else
        //        MessageBox.Show("Xóa thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    return false;
        //}
    }
}

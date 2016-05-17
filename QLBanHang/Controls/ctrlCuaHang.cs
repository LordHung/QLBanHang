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
    public interface ICuaHangView
    {
        void UpdateView();
    }


    public class ctrlCuaHang
    {
        mdlCuaHang _mdlCuaHang = new mdlCuaHang();

        mdlSanPhamCuaHang _mdlSanPhamCuaHang = new mdlSanPhamCuaHang();

        private ICuaHangView _cuaHangView;

        public void SetView(ICuaHangView view)
        {
            _cuaHangView = view;
        }

        public DataTable GetData()
        {
            return _mdlCuaHang.GetData();
        }

        public DataTable GetTenCuaHang()
        {
            return _mdlCuaHang.GetTenCuaHang();
        }

        public DataTable GetIdCuaHang()
        {
            return _mdlCuaHang.GetIdCuaHang();
        }

        public DataTable GetCuaHangByCode(string maCuaHang)
        {
            return _mdlCuaHang.GetCuaHangByCode(maCuaHang);
        }

        public int GetIdCuaHangByCode(string maCuaHang)
        {
            return _mdlCuaHang.GetIdCuaHangByCode(maCuaHang);
        }

        public int GetIdCuaHangByTen(string tenCuaHang)
        {
            return _mdlCuaHang.GetIdCuaHangByTen(tenCuaHang);
        }
        /// <summary>
        /// Thêm cửa hàng
        /// </summary>
        /// <param name="cuaHang"></param>
        /// <returns></returns>
        public bool AddData(clsCuaHang cuaHang)
        {
            if (IsExist(cuaHang.MaCuaHang))
            {
                MessageBox.Show("Mã cửa hàng" + cuaHang.MaCuaHang + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm cửa hàng " + cuaHang.MaCuaHang + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlCuaHang.AddData(cuaHang))
            {
                MessageBox.Show("Thêm thành công", "Thêm cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _cuaHangView.UpdateView();
                if (!this.AddSanPhamCuaHang())
                    MessageBox.Show("Thêm sản phẩm vào cửa hàng thất bại", "Thêm sản phẩm cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        ///Thêm sản phẩm cho cửa hàng
        public bool AddSanPhamCuaHang()
        {
            return _mdlSanPhamCuaHang.AddSanPhamVaoCuaHang(_mdlCuaHang.GetMaxIdCuaHang());
        }

        /// <summary>
        /// Kiểm tra xem mã cửa hàng có tồn tại hay chưa?
        /// </summary>
        /// <param name="maCuaHang"></param>
        /// <returns></returns>
        public bool IsExist(string maCuaHang)
        {
            return _mdlCuaHang.IsExist(maCuaHang);
        }
        /// <summary>
        /// Cập nhập dữ liệu cho cửa hàng
        /// </summary>
        /// <param name="cuaHang"></param>
        /// <returns></returns>
        public bool UpdateData(clsCuaHang cuaHang)
        {
            if (IsExist(cuaHang.MaCuaHang) && cuaHang.Id != this.GetIdCuaHangByCode(cuaHang.MaCuaHang))
            {
                MessageBox.Show("Mã cửa hàng " +cuaHang.MaCuaHang + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _cuaHangView.UpdateView();
                return false;
            }

            if (_mdlCuaHang.UpdateData(cuaHang))
            {
                //MessageBox.Show("Sửa thành công", "Sửa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_cuaHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool DeleteData(int idCuaHang)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa cửa hàng " + _mdlCuaHang.GetTenCuaHangById(idCuaHang)
           + " ?", "Xác nhận",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///Xoa SanPham lien quan den cua hang
            //if (!this.DeleteSanPhamCuaHang(idCuaHang))
            //    MessageBox.Show("Xóa sản phẩm cửa hàng thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ///Xoa Cua Hang

            if (_mdlCuaHang.DeleteData(idCuaHang))
            {
                _cuaHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        //public bool DeleteSanPhamCuaHang(int idCuaHang)
        //{
        //    return _mdlSanPhamCuaHang.DeleteSanPhamTheoCuaHang(idCuaHang);
        //}


        public DataTable GetCuaHang()
        {
            return _mdlCuaHang.GetCuaHang();
        }

     

    }
}

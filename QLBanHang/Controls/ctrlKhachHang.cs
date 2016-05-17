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
    public interface IKhachHangView
    {
        void UpdateView();
    }

    public class ctrlKhachHang
    {
        mdlKhachHang _mdlKhacHang = new mdlKhachHang();

        IKhachHangView _khachHangView;

        public void SetView(IKhachHangView view)
        {
            _khachHangView = view;
        }
        /// <summary>
        /// Lấy tên khách hàng
        /// </summary>
        /// <returns></returns>

        public DataTable GetTenKhachHang()
        {
            return _mdlKhacHang.GetTenKhachHang();
        }
        /// <summary>
        /// Lấy hết dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _mdlKhacHang.GetData();
        }
        /// <summary>
        /// lấy idKhachHang mới nhất
        /// </summary>
        /// <returns></returns>
        public DataTable GetIdKhachHang()
        {
            return _mdlKhacHang.GetIdKhachHang();
        }
        /// <summary>
        /// Lấy khách hàng từ database by Code
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public DataTable GetKhachHangByCode(string maKhachHang)
        {
            return _mdlKhacHang.GetKhachHangByCode(maKhachHang);
        }

        public bool AddData(clsKhachHang khachHang)
        {
            if (IsExist(khachHang.MaKhachHang))
            {
                MessageBox.Show("Mã khách hàng đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm khách hàng " + khachHang.MaKhachHang + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlKhacHang.AddData(khachHang))
            {
                MessageBox.Show("Thêm thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _khachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public DataTable GetKhachHang()
        {
            return _mdlKhacHang.GetKhachHang(); ;
        }

        ///
        ///Kiểm tra khách hàng đã tồn tại trong DC hay chưa
        ///
        public bool IsExist(string maKhachHang)
        {
            return _mdlKhacHang.IsExist(maKhachHang);
        }
        ///
        public int GetIdKhachHangByCode(string maKhachHang)
        {
            return _mdlKhacHang.GetIdKhachHangByCode(maKhachHang);
        }

        public bool DeleteData(int idKhachHang)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa khách hàng "
             + " ?", "Xác nhận",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlKhacHang.DeleteData(idKhachHang))
            {
                _khachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        ///Lấy idCuaHang
        public int GetIdCuaHang(int idKhachHang)
        {
            return _mdlKhacHang.GetIdCuaHang(idKhachHang);
        }

        public int GetIdLoaiKhachHang(int idKhachHang)
        {
            return _mdlKhacHang.GetIdLoaiKhachHang(idKhachHang);
        }

        public bool UpdateData(clsKhachHang khachHang)
        {
            if (IsExist(khachHang.MaKhachHang) && khachHang.Id != this.GetIdKhachHangByCode(khachHang.MaKhachHang))
            {
                MessageBox.Show("Mã khách hàng " + khachHang.MaKhachHang + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_mdlKhacHang.UpdateData(khachHang))
            {
                //MessageBox.Show("Sửa thành công", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_khachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}

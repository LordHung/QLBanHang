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
    public interface ILoaiKhachHangView
    {
        void UpdateView();
    }


    public class ctrlLoaiKhachHang
    {

        mdlLoaiKhachHang _mdlLoaiKhachHang = new mdlLoaiKhachHang();

        ILoaiKhachHangView _loaiKhachHangView;

        public void setView(ILoaiKhachHangView view)
        {
            _loaiKhachHangView = view;
        }

        public bool IsExist(string loaiThe)
        {
            return _mdlLoaiKhachHang.IsExist(loaiThe);
        }

        public DataTable GetData()
        {
            return _mdlLoaiKhachHang.GetData();
        }

        public bool AddData(clsLoaiKhachHang loaiKhachHang)
        {
            if (IsExist(loaiKhachHang.LoaiThe))
            {
                MessageBox.Show("Loại khách hàng "+loaiKhachHang.LoaiThe+" đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm loại khách hàng " + loaiKhachHang.LoaiThe + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlLoaiKhachHang.AddData(loaiKhachHang))
            {
                MessageBox.Show("Thêm thành công", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _loaiKhachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool UpdateData(clsLoaiKhachHang loaiKhachHang)
        {
            if (IsExist(loaiKhachHang.LoaiThe) && loaiKhachHang.Id != this.GetIdLoaiKhachHangByLoai(loaiKhachHang.LoaiThe))
            {
                MessageBox.Show("Loại khách hàng " + loaiKhachHang.LoaiThe + " đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _loaiKhachHangView.UpdateView();
                return false;
            }

            if (_mdlLoaiKhachHang.UpdateData(loaiKhachHang))
            {
                //MessageBox.Show("Sửa thành công", "Sửa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_loaiKhachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool DeleteData(int idLoaiKhachHang)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa loại khách hàng " + _mdlLoaiKhachHang.GetLoaiKhachHangById(idLoaiKhachHang)
            + " ?", "Xác nhận",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlLoaiKhachHang.DeleteData(idLoaiKhachHang))
            {
                _loaiKhachHangView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public int GetIdLoaiKhachHangByLoai(string loaiThe)
        {
            return _mdlLoaiKhachHang.GetIdLoaiKhachHangByLoai(loaiThe);
        }

        public DataTable GetLoaiKhachHang()
        {
            return _mdlLoaiKhachHang.GetLoaiKhachHang();
        }

    }
}

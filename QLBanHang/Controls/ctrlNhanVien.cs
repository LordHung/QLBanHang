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
    public interface INhanVienView
    {
        void UpdateView();
    }

    public class ctrlNhanVien
    {
        mdlNhanVien _mdlNhanVien = new mdlNhanVien();

        INhanVienView _nhanVienView;

        public DataTable GetData()
        {
            return _mdlNhanVien.GetData();
        }

        public void SetView(INhanVienView view)
        {
            _nhanVienView = view;
        }

        public int GetIdNhanVien(string tenDangNhap)
        {
            return _mdlNhanVien.GetIdNhanVien(tenDangNhap);
        }

        public string GetTenNhaVienById(int id)
        {
            return _mdlNhanVien.GetTenNhaVienById(id);
        }


        public string GetMatKhauNhanVien(string tenDangNhap)
        {
            return _mdlNhanVien.GetMatKhauNhanVien(tenDangNhap);
        }

        public bool AddData(clsNhanVien nhanVien)
        {
            if (IsExist(nhanVien.TenDangNhap))
            {
                MessageBox.Show("Nhà cung cấp " + nhanVien.TenDangNhap +" đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm nhân viên " + nhanVien.TenDangNhap+" ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhanVien.AddData(nhanVien))
            {
                MessageBox.Show("Thêm thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _nhanVienView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool IsExist(string tenDangNhap)
        {
            return _mdlNhanVien.IsExist(tenDangNhap);
        }

        public bool UpdateData(clsNhanVien nhanVien)
        {
            if (IsExist(nhanVien.TenDangNhap) && nhanVien.Id != _mdlNhanVien.GetIdNhanVien(nhanVien.TenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nhanVienView.UpdateView();
                return false;
            }

            if (_mdlNhanVien.UpdateData(nhanVien))
            {
                //MessageBox.Show("Sửa thành công", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_nhanVienView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool DeleteData(int idNhanVien)
        {

            DialogResult result = MessageBox.Show("Xác nhận xóa nhân viên " + _mdlNhanVien.GetTenNhanVienById(idNhanVien)
              + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhanVien.DeleteData(idNhanVien))
            {
                _nhanVienView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public DataTable GetNhanVien()
        {
            return _mdlNhanVien.GetNhanVien();
        }

        public bool IsToanQuyen(int idNhanVien)
        {
            return _mdlNhanVien.IsToanQuyen(idNhanVien);
        }

    }
}

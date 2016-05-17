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
    public interface INhaCungCapView
    {
        void UpdateView();
    }

    public class ctrlNhaCungCap
    {
        mdlNhaCungCap _mdlNhaCungCap = new mdlNhaCungCap();

        INhaCungCapView _viewNhaCungCap;

        public ctrlNhaCungCap()
        {
        }

        public void SetView(INhaCungCapView view)
        {
            _viewNhaCungCap = view;
        }

        public DataTable GetNhaCungCap()
        {
            return _mdlNhaCungCap.GetNhaCungCap();
        }


        public bool DeleteData(int idNhaCungCap)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhà cung cấp " + _mdlNhaCungCap.GetMaNhaCungCapById(idNhaCungCap)
              + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhaCungCap.DeleteData(idNhaCungCap))
            {
                _viewNhaCungCap.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public DataTable GetData()
        {
            return _mdlNhaCungCap.GetData();
        }

        public DataTable GetNhaCungCapByCode(string maNhaCungCap)
        {
            return _mdlNhaCungCap.GetNhaCungCapByCode(maNhaCungCap);
        }

        public bool AddData(clsNhaCungCap nhaCungCap)
        {
            if (IsExist(nhaCungCap.CodeNhaCungCap))
            {
                MessageBox.Show("Nhà cung cấp " + nhaCungCap.CodeNhaCungCap +" đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult result = MessageBox.Show("Xác nhận thêm nhà cung cấp " + nhaCungCap.CodeNhaCungCap + " ?", "Xác nhận",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlNhaCungCap.AddData(nhaCungCap))
            {
                MessageBox.Show("Thêm thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _viewNhaCungCap.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public bool IsExist(string maNhaCungCap)
        {
            return _mdlNhaCungCap.IsExist(maNhaCungCap);
        }


        public bool UpdateData(clsNhaCungCap nhaCungCap)
        {
            if (IsExist(nhaCungCap.CodeNhaCungCap) && nhaCungCap.Id != this.GetIdNhaCungCapByCode(nhaCungCap.CodeNhaCungCap))
            {
                MessageBox.Show("Mã nhà cung cấp đã có trong Database "
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewNhaCungCap.UpdateView();
                return false;
            }

            if (_mdlNhaCungCap.UpdateData(nhaCungCap))
            {
                //MessageBox.Show("Sửa thành công", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                //_viewNhaCungCap.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public int GetIdNhaCungCapByCode(string maNhaCungCap)
        {
            return _mdlNhaCungCap.GetIdNhaCungCapByCode(maNhaCungCap);
        }

    }
}

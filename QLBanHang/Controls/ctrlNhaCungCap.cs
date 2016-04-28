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
        void AddNhaCungCap();
        void UpdateNhaCungCap();
        void DeleteNhaCungCap();
        void UpdateViewNhaCungCap();
    }

    class ctrlNhaCungCap
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

        public void UpdateNhaCungCapFromView(string _codeForUpdate)
        {
            using (UpdateNhaCungCapDlg dlg = new UpdateNhaCungCapDlg(_codeForUpdate))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNhaCungCap.UpdateViewNhaCungCap();
                }
            }
        }

        public DataTable GetNhaCungCap()
        {
            return _mdlNhaCungCap.GetNhaCungCap();
        }

        public void AddNhaSanXuatFromView()
        {
            using (AddNhaCungCapDlg dlg = new AddNhaCungCapDlg())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _viewNhaCungCap.UpdateViewNhaCungCap();
                }
            }
        }

        public void DeleteNhaSanXuatFromView(string _codeForDelete)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa nhà cung cấp\n" + _codeForDelete + "?"
               , "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_mdlNhaCungCap.DeleteData(_codeForDelete))
                    MessageBox.Show("Xóa thành công", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa thất bại", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _viewNhaCungCap.UpdateViewNhaCungCap();
        }


        public DataTable GetData()
        {
            return _mdlNhaCungCap.GetData();
        }

        public DataTable GetNhaCungCapByCode(string maNhaCungCap)
        {
            return _mdlNhaCungCap.GetNhaCungCapByCode(maNhaCungCap);
        }

        public void AddData(clsNhaCungCap nhaCungCap)
        {
            if (!IsExist(nhaCungCap.CodeNhaCungCap))
            {
                if (_mdlNhaCungCap.AddData(nhaCungCap))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Đã có nhà cung cấp trong databse ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool IsExist(string maNhaCungCap)
        {
            return _mdlNhaCungCap.IsExist(maNhaCungCap);
        }


        public void UpdateData(clsNhaCungCap nhaCungCap)
        {
            if (_mdlNhaCungCap.UpdateData(nhaCungCap))
            {
                MessageBox.Show("Sửa thành công", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Sửa thất bại", "Thêm nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

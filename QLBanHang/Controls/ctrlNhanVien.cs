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
    class ctrlNhanVien
    {
        mdlNhanVien _mdlNhanVien = new mdlNhanVien();

        public DataTable GetData()
        {
            return _mdlNhanVien.GetData();
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
            return _mdlNhanVien.AddData(nhanVien);
        }

        public bool IsExist(string tenDangNhap)
        {
            return _mdlNhanVien.IsExist(tenDangNhap);
        }

        public bool UpdateData(clsNhanVien nhanVien)
        {
            return _mdlNhanVien.UpdateData(nhanVien);
        }

        public bool DeleteData(string tenDangNhap)
        {
            return _mdlNhanVien.DeleteData(tenDangNhap);
        }
    }
}

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
    class ctrlLoaiKhachHang
    {

        mdlLoaiKhachHang _mdlLoaiKhachHang = new mdlLoaiKhachHang();
        public DataTable GetData()
        {
            return _mdlLoaiKhachHang.GetData();
        }

        public bool AddData(clsLoaiKhachHang loaiKhachHang)
        {
            return _mdlLoaiKhachHang.AddData(loaiKhachHang);
        }
    }
}

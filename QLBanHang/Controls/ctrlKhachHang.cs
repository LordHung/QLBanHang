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
    class ctrlKhachHang
    {
        mdlKhachHang _mdlKhacHang = new mdlKhachHang();
        public DataTable GetData()
        {
            return _mdlKhacHang.GetData();
        }
        public DataTable GetKhachHangByCode(string maKhachHang)
        {
            return _mdlKhacHang.GetKhachHangByCode(maKhachHang);
        }

        public bool AddData(clsKhachHang khachHang)
        {
            return _mdlKhacHang.AddData(khachHang);
        }
    }
}

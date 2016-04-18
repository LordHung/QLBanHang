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

        public DataTable GetTenKhachHang()
        {
            return _mdlKhacHang.GetTenKhachHang();
        }

        public DataTable GetData()
        {
            return _mdlKhacHang.GetData();
        }

        public DataTable GetIdKhachHang()
        {
            return _mdlKhacHang.GetIdKhachHang();
        }

        public DataTable GetKhachHangByCode(string maKhachHang)
        {
            return _mdlKhacHang.GetKhachHangByCode(maKhachHang);
        }

        public bool AddData(clsKhachHang khachHang)
        {
            return _mdlKhacHang.AddData(khachHang);
        }

        public DataTable GetKhachHang()
        {
            return _mdlKhacHang.GetKhachHang(); ;
        }


    }
}

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
    class ctrlChiTietChuyenHang
    {
        mdlChiTietChuyenHang _mdlChiTietChuyenHang = new mdlChiTietChuyenHang();


        public bool AddData(clsChiTietChuyenHang chiTietChuyenHang)
        {
            return _mdlChiTietChuyenHang.AddData(chiTietChuyenHang);
        }
    }
}

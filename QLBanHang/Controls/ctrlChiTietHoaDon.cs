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
    class ctrlChiTietHoaDon
    {
        mdlChiTietHoaDon _mdlChiTietHoaDon = new mdlChiTietHoaDon();
        public bool AddData(clsChiTietHoaDon chiTietHoaDon)
        {
            return _mdlChiTietHoaDon.AddData(chiTietHoaDon);
        }
    }
}

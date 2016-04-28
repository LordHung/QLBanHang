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

        public void AddData(clsChiTietHoaDon chiTietHoaDon)
        {
            if (!_mdlChiTietHoaDon.AddData(chiTietHoaDon))
            
                MessageBox.Show( "Thêm chi tiết hóa đơn lỗi", "Thêm chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

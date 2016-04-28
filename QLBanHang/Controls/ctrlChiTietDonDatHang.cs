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
    class ctrlChiTietDonDatHang
    {
        mdlChiTietDonDatHang _mdlChiTietDonDatHang = new mdlChiTietDonDatHang();

        public void AddData(clsChiTietDonDatHang chiTietDonDatHang)
        {
            if (!_mdlChiTietDonDatHang.AddData(chiTietDonDatHang))

                MessageBox.Show("Thêm chi tiết hóa đơn lỗi", "Thêm chi tiết đơn đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

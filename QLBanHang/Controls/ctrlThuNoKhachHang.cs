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
    class ctrlThuNoKhachHang
    {
        mdlThuNoKhachHang _mdlThuNoKhachHang = new mdlThuNoKhachHang();

        public void AddData(clsThuNoKhachHang thuNoKhachHang)
        {
            if (!_mdlThuNoKhachHang.AddData(thuNoKhachHang))
            {
                MessageBox.Show("Thêm thu nợ hóa đơn lỗi", "Thêm thu nợ hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GenerateNewSoPhieu(DateTime date)
        {
            return _mdlThuNoKhachHang.GenerateNewSoPhieu(date.ToString("yyyy-MM-dd"));
        }

        public int GetNewSoPhieuByNow()
        {
            return this.GenerateNewSoPhieu(DateTime.Now);
        }


    }
}

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
    class ctrlChiTietPhieuXuat
    {
        mdlChiTietPhieuXuat _mdlChiTietPhieuXuat = new mdlChiTietPhieuXuat();

        public bool AddData(clsChiTietPhieuXuat chiTietPhieuXuat)
        {
            if (!_mdlChiTietPhieuXuat.AddData(chiTietPhieuXuat))
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập lỗi", "Thêm chi tiết phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }   
}

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
    class ctrlLoaiPhieuXuat
    {
        mdlLoaiPhieuXuat _mdlLoaiPhieuXuat = new mdlLoaiPhieuXuat();
        public DataTable GetLoaiPhieuXuat()
        {
            return _mdlLoaiPhieuXuat.GetLoaiPhieuXuat();
        }
    }
}

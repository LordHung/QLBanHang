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
    class ctrlPhanQuyen
    {
        mdlPhanQuyen _mdlPhanQuyen = new mdlPhanQuyen();

        public DataTable GetQuyen(int idNhanVien)
        {
            return _mdlPhanQuyen.GetQuyen(idNhanVien);
        }

        public bool GetTrangThai(int idNhanVien, int idQuyen)
        {
            return _mdlPhanQuyen.GetTrangThai(idNhanVien, idQuyen);
        }

        public bool SetTrangThai(int idNhanVien, int idQuyen, bool trangThai)
        {
            if(!_mdlPhanQuyen.SetTrangThai(idNhanVien,idQuyen,trangThai))
            {
                MessageBox.Show("Sữa trạng thái lỗi", "Sữa trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

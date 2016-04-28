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
<<<<<<< HEAD

        public DataTable GetTenKhachHang()
        {
            return _mdlKhacHang.GetTenKhachHang();
        }

=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        public DataTable GetData()
        {
            return _mdlKhacHang.GetData();
        }
<<<<<<< HEAD

        public DataTable GetIdKhachHang()
        {
            return _mdlKhacHang.GetIdKhachHang();
        }

=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
        public DataTable GetKhachHangByCode(string maKhachHang)
        {
            return _mdlKhacHang.GetKhachHangByCode(maKhachHang);
        }

        public bool AddData(clsKhachHang khachHang)
        {
            return _mdlKhacHang.AddData(khachHang);
        }
<<<<<<< HEAD

        public DataTable GetKhachHang()
        {
            return _mdlKhacHang.GetKhachHang(); ;
        }


=======
>>>>>>> d13b728f740a2b50431497e2003f7ade782790b5
    }
}

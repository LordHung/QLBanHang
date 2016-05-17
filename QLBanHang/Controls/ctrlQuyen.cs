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
    class ctrlQuyen
    {
        mdlQuyen _mdlQuyen = new mdlQuyen();

        public DataTable GetQuyenCha()
        {
            return _mdlQuyen.GetQuyenCha();
        }

        public DataTable GetQuyenCha(int idQuyenCha)
        {
            return _mdlQuyen.GetSubQuyen(idQuyenCha);
        }
    }
}

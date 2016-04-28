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
    class ctrlNhaCungCap
    {
        mdlNhaCungCap _mdlNhaCungCap = new mdlNhaCungCap();
        public DataTable GetData()
        {
            return _mdlNhaCungCap.GetData();
        }

        public DataTable GetNhaCungCapByCode(string maNhaCungCap)
        {
            return _mdlNhaCungCap.GetNhaCungCapByCode(maNhaCungCap);
        }

        public bool AddData(clsNhaCungCap nhaCungCap)
        {
            return _mdlNhaCungCap.AddData(nhaCungCap);
        }

        public bool IsExist(string maNhaCungCap)
        {
            return _mdlNhaCungCap.IsExist(maNhaCungCap);
        }

        public bool UpdateData(clsNhaCungCap nhaCungCap)
        {
            return _mdlNhaCungCap.UpdateData(nhaCungCap);
        }
    }
}

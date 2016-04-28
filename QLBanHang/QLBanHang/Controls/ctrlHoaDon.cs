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
    class ctrlHoaDon
    {
        mdlHoaDon _mdlHoaDon = new mdlHoaDon();
        public int GetNewSoHoaDon(string date)
        {
            return _mdlHoaDon.GetNewSoHoaDon(date);
        }

        public decimal GetIdHoaDon()
        {
            return _mdlHoaDon.GetIdHoaDon();
        }

        public bool AddData(clsHoaDon hoaDon)
        {
            return _mdlHoaDon.AddData(hoaDon);
        }
    }
}

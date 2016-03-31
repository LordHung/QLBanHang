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
    class ctrlCuaHang
    {
        mdlCuaHang _mdlCuaHang = new mdlCuaHang();

        public DataTable GetData()
        {
            return _mdlCuaHang.GetData();
        }

        public DataTable GetCuaHangByCode(string maCuaHang)
        {
            return _mdlCuaHang.GetCuaHangByCode(maCuaHang);
        }

        public int GetIdCuaHang(string maCuaHang)
        {
            return _mdlCuaHang.GetIdCuaHang(maCuaHang);
        }

        public bool AddData(clsCuaHang cuaHang)
        {
            return _mdlCuaHang.AddData(cuaHang);
        }

        public bool IsExist(string maCuaHang)
        {
            return _mdlCuaHang.IsExist(maCuaHang);
        }

        public bool UpdateData(clsCuaHang cuaHang)
        {
            return _mdlCuaHang.UpdateData(cuaHang);
        }

        public bool DeleteData(string maCuaHang)
        {
            return _mdlCuaHang.DeleteData(maCuaHang);
        }
    }
}

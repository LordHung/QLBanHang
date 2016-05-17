using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanHang.Models;
using QLBanHang.Objects;
using System.Windows.Forms;
using QLBanHang.Views;


namespace QLBanHang.Controls
{
    class ctrlSanPhamCuaHang
    {

        mdlSanPhamCuaHang _mdlSanPhamCuaHang = new mdlSanPhamCuaHang();

        public bool AddSanPhamVaoCuaHang(int idCuaHang)
        {
            return _mdlSanPhamCuaHang.AddSanPhamVaoCuaHang(idCuaHang);
        }
    }
}

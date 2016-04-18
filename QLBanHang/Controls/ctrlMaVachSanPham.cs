﻿using System;
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
    class ctrlMaVachSanPham
    {
        mdlMaVachSanPham _mdlMaVachSanPham = new mdlMaVachSanPham();

        public DataTable GetData(int idCuaHang)
        {
            return _mdlMaVachSanPham.GetData(idCuaHang);
        }

        public int GetIdByMaVach(string maVach)
        {
            return _mdlMaVachSanPham.GetIdByMaVach(maVach);
        }

        public DataTable GetRowMaVachSanPham(string maVach)
        {
            return _mdlMaVachSanPham.GetRowMaVachSanPham(maVach);
        }

        public bool GiamSoLuong(int id, int soLuong)
        {
            return _mdlMaVachSanPham.GiamSoLuong(id,soLuong);
        }
    }
}
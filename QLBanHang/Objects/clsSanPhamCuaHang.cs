using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Models
{
    class clsSanPhamCuaHang
    {
        /// Chứ thông tin về sản phẩm thuộc cửa hàng nào
        /// 
        /// 
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        int _idSanPham;

        public int IdSanPham
        {
            get { return _idSanPham; }
            set { _idSanPham = value; }
        }

        int _idCuaHang;

        public int IdCuaHang
        {
            get { return _idCuaHang; }
            set { _idCuaHang = value; }
        }
    }
}

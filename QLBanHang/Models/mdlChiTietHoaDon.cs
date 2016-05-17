using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBanHang.Objects;
using System.Windows.Forms;

namespace QLBanHang.Models
{
    class mdlChiTietHoaDon
    {

        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietHoaDon chiTietHoaDon)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietHoaDon] (idHoaDon,SoLuong,ChietKhau,DonGia,GhiChu,"
                +"idMaVachSanPham,ThoiGianBaoHanh,GiaVon,VAT,SanPhamComBo)"
            + "VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')"
                 ,chiTietHoaDon.IdHoaDon,chiTietHoaDon.SoLuong,chiTietHoaDon.ChietKhau,chiTietHoaDon.DonGia,chiTietHoaDon.GhiChu
                 ,chiTietHoaDon.IdMaVachSanPham,chiTietHoaDon.ThoiGianBaoHanh,chiTietHoaDon.GiaVon,chiTietHoaDon.VAT,chiTietHoaDon.SanPhamComBo);
            return _conn.ExecuteCMD();
        }


        public DataTable GetChiTietHoaDon(decimal idHoaDon)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select tbMaVachSanPham.id as id,tbChiTietHoaDon.id as idChiTietHoaDon,tbNhaSanXuat.MaNhaSanXuat"
                +" + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') as MaSanPham,"
		    +"TenSanPham,tbSanPham.DonVi,tbChiTietHoaDon.SoLuong "
		    +",tbChiTietHoaDon.DonGia,(tbChiTietHoaDon.DonGia * tbChiTietHoaDon.SoLuong) as ThanhTien,tbChiTietHoaDon.GhiChu "
            +"from tbChiTietHoaDon,tbHoaDon ,tbMaVachSanPham,tbSanPham,tbSanPhamCuaHang,tbNhaSanXuat "
            +"where tbChiTietHoaDon.idHoaDon =  tbHoaDon.id and tbHoaDon.id = '{0}' "
	        +"and tbNhaSanXuat.id = tbSanPham.idNhaSanXuat "
		    +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id "
		    +"and tbSanPhamCuaHang.idSanPham = tbSanPham.id "
            + "and tbMaVachSanPham.id = tbChiTietHoaDon.idMaVachSanPham", idHoaDon);
            _conn.FillData(table);
            return table;
        }
    }
}

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
    class mdlChiTietDonDatHang
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class

        public bool AddData(clsChiTietDonDatHang chiTietDonDatHang)
        {
            _conn.CMD.CommandText = String.Format("INSERT [dbo].[tbChiTietDonDatHang] (idDonDatHang,idMaVachSanPham,SoLuong,DonGia,GhiChu)"
            + " VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')"
                 ,chiTietDonDatHang.IdDonDatHang,chiTietDonDatHang.IdMaVachSanPham,chiTietDonDatHang.SoLuong
                 ,chiTietDonDatHang.DonGia,chiTietDonDatHang.GhiChu);
            return _conn.ExecuteCMD();
        }

        public DataTable GetChiTietDonDatHang(int idDonDatHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select tbMaVachSanPham.id,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') as MaSanPham,TenSanPham,tbSanPham.DonVi,tbChiTietDonDatHang.SoLuong"
		            +",tbChiTietDonDatHang.DonGia,(tbChiTietDonDatHang.DonGia * tbChiTietDonDatHang.SoLuong) as ThanhTien,tbChiTietDonDatHang.GhiChu "
                    +"from tbSanPham,tbNhaSanXuat,tbDonDatHang,tbChiTietDonDatHang,tbMaVachSanPham,tbSanPhamCuaHang "
                    +"where tbDonDatHang.id = idDonDatHang and idDonDatHang = '{0}' "
		            +"and tbNhaSanXuat.id = tbSanPham.idNhaSanXuat "
		            +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id  "
		            +"and tbSanPhamCuaHang.idSanPham = tbSanPham.id "
		            +"and tbMaVachSanPham.id = tbChiTietDonDatHang.idMaVachSanPham",idDonDatHang);
            _conn.FillData(table);
            return table;
        }
    }
}

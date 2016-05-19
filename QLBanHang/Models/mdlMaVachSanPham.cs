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
    class mdlMaVachSanPham
    {
        ConnectToSQL _conn = new ConnectToSQL();//Initialize connectoSQl class


        public DataTable GetData(int idCuaHang = 9,int idSanPhamCuaHang = 0)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT tbMaVachSanPham.id,tbMaVachSanPham.MaVach,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
	                                +",tbSanPham.TenSanPham,DonVi,SoLuong,GiaBan,GiaSi,GiaNhap,tbNhaSanXuat.TenNhaSanxuat,TenLoaiSanPham as LoaiSanPham,tbNganhSanPham.TenNganhSanPham,tbNhaCungCap.TenNhaCungCap "
                                    +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham,tbNganhSanPham,tbMaVachSanPham,tbSanPhamCuaHang,tbNhaCungCap "
                                    +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham and tbLoaiSanPham.idNganhSanPham = tbNganhSanPham.id "
	                                +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id and tbSanPham.id = tbSanPhamCuaHang.idSanPham and tbSanPhamCuaHang.idCuaHang = '{0}' "
	                                +"and tbMaVachSanPham.SuDung = '1' "
	                                +"and tbNhaCungCap.id = tbMaVachSanPham.idNhaCungCap ",idCuaHang);
            if (idSanPhamCuaHang != 0)
            {
                _conn.CMD.CommandText += String.Format("and idSanPhamCuaHang = '{0}' ", idSanPhamCuaHang);
            }
            _conn.FillData(table);
            return table;
        }

        public DataTable GetDataByIdMaVach(int idMaVachSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham ,* "
                                    + "from tbNhaSanXuat,tbSanPham,tbLoaiSanPham,tbNganhSanPham,tbMaVachSanPham,tbSanPhamCuaHang,tbNhaCungCap,tbCuaHang "
                                    + "where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham and tbLoaiSanPham.idNganhSanPham = tbNganhSanPham.id  "
                                    + "and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id and tbSanPham.id = tbSanPhamCuaHang.idSanPham  "
                                    + "and tbMaVachSanPham.SuDung = '1'  "
                                    + "and tbNhaCungCap.id = tbMaVachSanPham.idNhaCungCap "
                                    + "and tbCuaHang.id = tbSanPhamCuaHang.idCuaHang "
                                    + "and tbMaVachSanPham.id = '{0}'", idMaVachSanPham);
        
            _conn.FillData(table);
            return table;
        }


        public int GetIdByMaVach(string maVach)
        { 
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select isnull(id,0) as ID from tbMaVachSanPham where MaVach ='{0}'", maVach);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["ID"].ToString());
        }

        public DataTable GetRowMaVachSanPham(int idCuaHang,int idMaVachSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("SELECT tbMaVachSanPham.id,dbo.tbNhaSanXuat.MaNhaSanXuat + REPLACE(STR(dbo.tbSanPham.CodeSanPham, 6), SPACE(1), '0') AS MaSanPham "
                                        + ",tbSanPham.TenSanPham,tbSanPham.DonVi,tbMaVachSanPham.SoLuong,tbMaVachSanPham.GiaBan,tbMaVachSanPham.GiaNhap,tbMaVachSanPham.VAT "
                                        +"from tbNhaSanXuat,tbSanPham,tbLoaiSanPham,tbNganhSanPham,tbMaVachSanPham,tbSanPhamCuaHang,tbNhaCungCap "
                                        +"where tbNhaSanXuat.id = tbSanPham.idNhaSanXuat and tbLoaiSanPham.id = tbSanPham.idLoaiSanPham and tbLoaiSanPham.idNganhSanPham = tbNganhSanPham.id "
	                                    +"and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id and tbSanPham.id = tbSanPhamCuaHang.idSanPham and tbSanPhamCuaHang.idCuaHang = '{0}' "
	                                    +"and tbMaVachSanPham.SuDung = '1' "
	                                    +"and tbNhaCungCap.id = tbMaVachSanPham.idNhaCungCap "
	                                    +"and tbMaVachSanPham.id = '{1}' ",idCuaHang,idMaVachSanPham);
            _conn.FillData(table);
            return table;
        }


        public bool GiamSoLuong(int id, int soLuong)
        {
            _conn.CMD.CommandText = String.Format("Update  tbMaVachSanPham set SoLuong = SoLuong - {0} " +
                "where id = '{1}'"
                ,soLuong,id);
            return _conn.ExecuteCMD();
        }

        public bool TangSoLuong(int id, int soLuong)
        {
            _conn.CMD.CommandText = String.Format("Update  tbMaVachSanPham set SoLuong = SoLuong + {0} " +
                "where id = '{1}'"
                , soLuong, id);
            return _conn.ExecuteCMD();
        }

        /// 
        /// Bán lẽ 
        ///

        public int GetGiaVonBanLe(int id,int soLuong)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select  {0}*GiaNhap as GN from  tbMaVachSanPham " +
               "where id = '{1}'"
               , soLuong,id);
            _conn.FillData(table);
            return Convert.ToInt32(table.Rows[0]["GN"].ToString());
        }
        //("select  {0}*Round(GiaNhap,-2) as GN from  tbMaVachSanPham 
        mdlSanPhamCuaHang _mdlSanPhamCuaHang = new mdlSanPhamCuaHang();

        public bool AddMaVachTheoIdSanPham(clsMaVachSanPham maVachSanPham,int idSanPham)
        {
            DataTable tbSanPhamCuaHang = _mdlSanPhamCuaHang.GetThongTinByIdSanPham(idSanPham);
            foreach (DataRow row in tbSanPhamCuaHang.Rows)
            {
                maVachSanPham.IdSanPhamCuaHang = Convert.ToInt32(row["id"].ToString());
                if (!AddData(maVachSanPham))
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        public bool AddData(clsMaVachSanPham maVachSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("insert tbMaVachSanPham (MaVach,idNhaCungCap,SoLuong,SuDung,GiaBan,"
            +"idNhanVien,GiaNhap,GiaBQGQ,VAT,HetBan,KhongTichLuyDiem,GiaSi,idSanPhamCuaHang,NgayTao) "
            + "VALUES ('{0}', '{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}', cast('{13}' as datetime))"
            ,maVachSanPham.MaVach
            ,maVachSanPham.IdNhaCungCap
            ,0
            ,maVachSanPham.SuDung
            ,maVachSanPham.GiaBan
            ,maVachSanPham.IdNhanVien
            ,maVachSanPham.GiaNhap
            ,maVachSanPham.GiaBQGQ
            ,maVachSanPham.VAT
            ,false
            ,maVachSanPham.KhongTichLuyDiem
            ,maVachSanPham.GiaSi
            ,maVachSanPham.IdSanPhamCuaHang
            ,maVachSanPham.NgayTao.ToString("yyyy-MM-dd hh:mm:ss.FFF")
            );
            return _conn.ExecuteCMD();
        }


        public bool UpdateData(clsMaVachSanPham maVachSanPham)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("update tbMaVachSanPham set MaVach ='{0}' "
                +",idNhaCungCap = '{1}'"
                +",VAT = '{2}' "
                +" where id = '{3}'"
            , maVachSanPham.MaVach
            , maVachSanPham.IdNhaCungCap
            , maVachSanPham.VAT
            , maVachSanPham.Id
            );
            return _conn.ExecuteCMD();
        }

        string layIdByCuaHang_MaVach = "select tbMaVachSanPham.id "
            + "from tbMaVachSanPham,tbCuaHang,tbSanPhamCuaHang "
            + "where MaVach = '{0}' and tbCuaHang.id = '{1}' "
                    + "and tbMaVachSanPham.idSanPhamCuaHang = tbSanPhamCuaHang.id "
                    + "and tbSanPhamCuaHang.idCuaHang = tbCuaHang.id";


        public bool IsExist(string maVachSanPham,int idCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format(layIdByCuaHang_MaVach,maVachSanPham,idCuaHang);
            _conn.FillData(table);
            return (table.Rows.Count > 0);
        }

        public int GetIdByCuaHang_MaVach(string maVachSanPham, int idCuaHang)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format(layIdByCuaHang_MaVach, maVachSanPham, idCuaHang);
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["id"].ToString());
            else return 0;
        }

        public string GetMaVachById(int idMaVach)
        {
            DataTable table = new DataTable();//Create template table to get data from database
            _conn.CMD.CommandText = String.Format("select MaVach "
                    +"from tbMaVachSanPham where id =  '{0}' ",idMaVach); 
            _conn.FillData(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["MaVach"].ToString();
            else return null;
        }
    }
}

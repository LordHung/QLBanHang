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

    public interface IPhieuXuatView
    {
        bool AddPhieuXuat();

        void ChonSanPhamPhieuXuat();

        void TangSoLuongMaVachPhieuXuat();

        void GiamSoLuongMaVachPhieuXuat();

        void ResetViewPhieuXuat();
    }


    class ctrlPhieuXuat
    {
        mdlPhieuXuat _mdlPhieuXuat = new mdlPhieuXuat();


        IPhieuNhapView _viewPhieuNhap;

        public void SetView(IPhieuNhapView view)
        {
            _viewPhieuNhap = view;
        }

        public decimal GenerateNewSoPhieuXuat(DateTime date)
        {
            return _mdlPhieuXuat.GenerateNewSoPhieuXuat(date.ToString("yyyy-MM-dd"));
        }

        public decimal GetNewSoPhieuXuatByNow()
        {
            return this.GenerateNewSoPhieuXuat(DateTime.Now);
        }

        public int GetIdPhieuXuat()
        {
            return _mdlPhieuXuat.GetIdPhieuXuat();
        }

        public bool AddData(clsPhieuXuat phieuXuat)
        {
            DialogResult result = MessageBox.Show("Xác nhận tạo phiếu nhập " + GetNewMaPhieuXuatTraNhaCungCap() + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuXuat.AddData(phieuXuat))
            {
                MessageBox.Show("Thêm thành công", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public string GenerateMaPhieuXuat(decimal soPhieuXuat, DateTime date, string result)
        {
            string maPhieuXuat = soPhieuXuat.ToString();//String maHoaDon
            int maPhieuNhapLength = maPhieuXuat.Length;
            for (int i = 0; i < 5 - maPhieuNhapLength; i++)
            {
                result += "0";
            }
            result += maPhieuXuat + date.ToString("ddMMyyyy");
            return result;
        }

        public string GetNewMaPhieuXuatTraNhaCungCap()
        {
            return this.GenerateMaPhieuXuat(GetNewSoPhieuXuatByNow(), DateTime.Now, "WO02");
        }

        public string GetNewMaPhieuXuatHuy()
        {
            return this.GenerateMaPhieuXuat(GetNewSoPhieuXuatByNow(), DateTime.Now, "PX02");
        }

        public string GetNewMaPhieuXuatChuyenKho()
        {
            return this.GenerateMaPhieuXuat(GetNewSoPhieuXuatByNow(), DateTime.Now, "WO02");
        }
    }
}

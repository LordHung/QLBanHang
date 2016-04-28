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
    public interface IPhieuNhapView
    {
        bool AddPhieuNhap();

        void ChonSanPhamPhieuNhap();

        void TangSoLuongMaVachPhieuNhap();

        void GiamSoLuongMaVachPhieuNhap();

        void ResetViewHoaDon();
    }


    class ctrlPhieuNhap
    {
        mdlPhieuNhap _mdlPhieuNhap = new mdlPhieuNhap();


        IPhieuNhapView _viewPhieuNhap;

        public void SetView(IPhieuNhapView view)
        {
            _viewPhieuNhap = view;
        }

        public decimal GenerateNewSoPhieuNhap(DateTime date)
        {
            return _mdlPhieuNhap.GenerateNewSoPhieuNhap(date.ToString("yyyy-MM-dd"));
        }

        public decimal GetNewSoPhieuNhapByNow()
        {
            return this.GenerateNewSoPhieuNhap(DateTime.Now);
        }

        public int GetIdPhieuNhap()
        {
            return _mdlPhieuNhap.GetIdPhieuNhap();
        }

        public bool AddData(clsPhieuNhap phieuNhap)
        {
            DialogResult result = MessageBox.Show("Xác nhận tạo phiếu nhập " + GetNewMaPhieuNhapByNow() + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuNhap.AddData(phieuNhap))
            {
                MessageBox.Show("Thêm thành công", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public string GenerateMaPhieuNhap(decimal soPhieuNhap, DateTime date)
        {
            string maPhieuNhap = soPhieuNhap.ToString();//String maHoaDon
            int maPhieuNhapLength = maPhieuNhap.Length;
            string result = "IV02";
            for (int i = 0; i < 5 - maPhieuNhapLength; i++)
            {
                result += "0";
            }
            result += maPhieuNhap + date.ToString("ddMMyyyy");
            return result;
        }

        public string GetNewMaPhieuNhapByNow()
        {
            return this.GenerateMaPhieuNhap(GetNewSoPhieuNhapByNow(), DateTime.Now);
        }
    }
}

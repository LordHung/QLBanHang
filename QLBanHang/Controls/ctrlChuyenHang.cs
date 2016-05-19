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

    public interface IChuyenHangView
    {
        bool AddPhieuPhuyenHang();

        void ChonSanPhamChuyenHang();

        void TangSoLuongSanPhamChuyenHang();

        void GiamSoLuongSanPhamChuyenHang();

        void ResetViewChuyenHang();
    }

    class ctrlChuyenHang
    {
        IChuyenHangView _view;

        mdlChuyenHang _mdlChuyenHang = new mdlChuyenHang();

        public void SetView(IChuyenHangView view)
        {
            _view = view;
        }
        /// <summary>
        /// Tạo số phiếu chuyên mới dựa trên ngày
        /// </summary>
        public int GernerateNew_SoPhieuChuyen(DateTime date)
        {
            return _mdlChuyenHang.GenerateNewSoChuyenHang(date.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// Tạo số phiếu chuyển tại thời điểm hiện tại
        /// </summary>
        /// <returns></returns>
        public int GetNew_SoPhieuChuyenByNow()
        {
            return GernerateNew_SoPhieuChuyen(DateTime.Now);
        }
        /// <summary>
        /// Tạo mã phiếu chuyển dựa trên số phiếu chuyển
        /// </summary>
        public string Generate_MaPhieuChuyen(int soPhieuChuyen, DateTime date)
        {
            string maPhieuChuyen = soPhieuChuyen.ToString();//String maHoaDon
            int maPhieuChuyenLength = maPhieuChuyen.Length;
            string result = "CH02/";
            for (int i = 0; i < 4 - maPhieuChuyenLength; i++)
            {
                result += "0";
            }
            result += maPhieuChuyen + "/" + date.ToString("ddMMyyyy");
            return result;
        }

        /// <summary>
        /// Tạo mã phiếu chuyển tại thời điểm hiện tại
        /// </summary>
        /// <returns></returns>
        public string GetNew_MaDatHangByNow()
        {
            return this.Generate_MaPhieuChuyen(GetNew_SoPhieuChuyenByNow(), DateTime.Now);
        }

        /// <summary>
        /// Trả về số phiếu chuyển vừa được add vào database hoặc phiếu chuyển có giá trị id cao nhất
        /// </summary>
        /// <returns></returns>
        public int GetIdPhieuChuyenMoiNhat()
        {
            return _mdlChuyenHang.GetIdChuyenKho();
        }

        /// <summary>
        /// Thêm dữ liệu vào databse 
        /// </summary>
        /// <param name="chuyenHang"></param>
        /// <returns></returns>
        public bool AddData(clsChuyenHang chuyenHang)
        {
            DialogResult result = MessageBox.Show("Xác nhận tạo phiếu chuyển " + GetNew_MaDatHangByNow() + " ?", "Xác nhận",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlChuyenHang.AddData(chuyenHang))
            {
                MessageBox.Show("Thêm thành công", "Thêm phiếu chuyển hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_viewDonDatHang.ResetViewDonDatHang();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu chuyển hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}

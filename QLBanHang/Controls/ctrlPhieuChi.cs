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

    public interface IPhieuChiView
    {
        void UpdateView();
    }


    public class ctrlPhieuChi
    {
        mdlPhieuChi _mdlPhieuChi = new mdlPhieuChi();

        IPhieuChiView _phieuChiView;

        public void SetView(IPhieuChiView view)
        {
            _phieuChiView = view;
        }
        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _mdlPhieuChi.GetData();
        }
        /// <summary>
        /// Tạo mã phiếu thi
        /// </summary>
        /// <param name="soPhieuThu"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public string GenerateMaPhieuChi(int soPhieuThu, DateTime date)
        {
            string maPhieuThu = soPhieuThu.ToString();//String maHoaDon
            int maPhieuThuLength = maPhieuThu.Length;
            string result = "PC02/";
            for (int i = 0; i < 5 - maPhieuThuLength; i++)
            {
                result += "0";
            }
            result += maPhieuThu + "/" + date.ToString("ddMMyyyy");
            return result;
        }
        /// <summary>
        ///Trả về mã phiếu thu tại thời điểm hiện tại
        /// </summary>
        /// <returns></returns>
        public string GetNewMaPhieuChi()
        {
            return this.GenerateMaPhieuChi(GetNewSoPhieuChi(), DateTime.Now);
        }
        /// <summary>
        /// Lây số phiếu thu
        /// </summary>
        /// <returns></returns>
        public int GetNewSoPhieuChi()
        {
            return GenerateNewSoPhieuChi(DateTime.Now);
        }
        /// <summary>
        /// Tạo số phiếu thu
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GenerateNewSoPhieuChi(DateTime date)
        {
            return _mdlPhieuChi.GenerateNewSoPhieuChi(date.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// Add phiếu thu vào database
        /// </summary>
        /// <param name="phieuChi"></param>
        /// <returns></returns>
        public bool AddData(clsPhieuChi phieuChi)
        {

            DialogResult result = MessageBox.Show("Xác nhận tạo phiếu chi " + GetNewMaPhieuChi() + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuChi.AddData(phieuChi))
            {
                MessageBox.Show("Thêm thành công", "Thêm phiếu chi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _phieuChiView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu chi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// Update phiếu thu
        /// </summary>
        /// <param name="phieuChi"></param>
        /// <returns></returns>
        public bool UpdateData(clsPhieuChi phieuChi)
        {

            DialogResult result = MessageBox.Show("Xác nhận sửa thông tin phiếu thu " + GenerateMaPhieuChi(phieuChi.SoPhieu, phieuChi.NgayLap)
                + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuChi.UpdateData(phieuChi))
            {
                MessageBox.Show("Sửa thành công", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _phieuChiView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public bool DeleteData(string maPhieu)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa phiếu chi " + maPhieu
             + " ?", "Xác nhận",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuChi.DeleteData(maPhieu))
            {
                _phieuChiView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa phiếu chi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Lấy id từ mã phiếu
        /// </summary>
        /// <param name="maPhieu"></param>
        /// <returns></returns>
        public int GetIdByMaPhieu(string maPhieu)
        {
            return _mdlPhieuChi.GetIdByMaPhieu(maPhieu);
        }
        /// <summary>
        /// Lấy dữ liệu mã phiếu từ id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetPhieuThuById(int id)
        {
            return _mdlPhieuChi.GetPhieuChiById(id);
        }
    }
}

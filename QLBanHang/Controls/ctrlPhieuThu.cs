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

    public interface IPhieuThuView
    {
        void UpdateView();
    }

    public delegate bool AddPhieuThuDelegate(clsPhieuThu phieuThu);

    public class ctrlPhieuThu
    {

        mdlPhieuThu _mdlPhieuThu = new mdlPhieuThu();

        IPhieuThuView _phieuThuView;

        public void SetView(IPhieuThuView view)
        {
            _phieuThuView = view;
        }
        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _mdlPhieuThu.GetData();
        }
        /// <summary>
        /// Tạo mã phiếu thi
        /// </summary>
        /// <param name="soPhieuThu"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public string GenerateMaPhieuThu(int soPhieuThu, DateTime date)
        {
            string maPhieuThu = soPhieuThu.ToString();//String maHoaDon
            int maPhieuThuLength = maPhieuThu.Length;
            string result = "PT02/";
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
        public string GetNewMaPhieuThu()
        {
            return this.GenerateMaPhieuThu(GetNewSoPhieuThu(), DateTime.Now);
        }
        /// <summary>
        /// Lây số phiếu thu
        /// </summary>
        /// <returns></returns>
        public int GetNewSoPhieuThu()
        {
            return GenerateNewSoPhieuThu(DateTime.Now);
        }
        /// <summary>
        /// Tạo số phiếu thu
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GenerateNewSoPhieuThu(DateTime date)
        {
            return _mdlPhieuThu.GenerateNewSoPhieuThu(date.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// Add phiếu thu vào database
        /// </summary>
        /// <param name="phieuThu"></param>
        /// <returns></returns>
        public bool AddData(clsPhieuThu phieuThu)
        {

            DialogResult result = MessageBox.Show("Xác nhận tạo phiếu thu " + GetNewMaPhieuThu() + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuThu.AddData(phieuThu))
            {
                MessageBox.Show("Thêm thành công", "Thêm phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _phieuThuView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// Update phiếu thu
        /// </summary>
        /// <param name="phieuThu"></param>
        /// <returns></returns>
        public bool UpdateData(clsPhieuThu phieuThu)
        {

            DialogResult result = MessageBox.Show("Xác nhận sửa thông tin phiếu thu " + GenerateMaPhieuThu(phieuThu.SoPhieu,phieuThu.NgayLap)
                + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuThu.UpdateData(phieuThu))
            {
                MessageBox.Show("Sửa thành công", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _phieuThuView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public bool DeleteData(string maPhieu)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa phiếu thu " + maPhieu
             + " ?", "Xác nhận",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlPhieuThu.DeleteData(maPhieu))
            {
                _phieuThuView.UpdateView();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        /// <summary>
        /// Lấy id từ mã phiếu
        /// </summary>
        /// <param name="maPhieu"></param>
        /// <returns></returns>
        public int GetIdByMaPhieu(string maPhieu)
        {
            return _mdlPhieuThu.GetIdByMaPhieu(maPhieu);
        }
        /// <summary>
        /// Lấy dữ liệu mã phiếu từ id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetPhieuThuById(int id)
        {
            return _mdlPhieuThu.GetPhieuThuById(id);
        }

       
    }
}

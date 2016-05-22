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

    public interface IPhieuQuaTangView
    {
        void UpdateViewPhieuQuaTang();
    }

    public class ctrlPhieuQuaTang
    {
        mdlPhieuQuaTang _mdlPhieuQuaTang = new mdlPhieuQuaTang();

        IPhieuQuaTangView _view;

        public void SetView(IPhieuQuaTangView view)
        {
            _view = view;
        }
        /// <summary>
        /// Lấy dữ liệu từ database và gán vào datatable ;
        /// </summary>
        /// <returns></returns>
        public DataTable GetData(int topRows = 0)
        {
            return _mdlPhieuQuaTang.GetData(topRows);
        }

        /// <summary>
        /// Tọa só phiếu cho phiếu quà tặng tại thời điểm date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GenerateNewSoPhieu(DateTime date)
        {
            return _mdlPhieuQuaTang.GenerateNewSoPhieu(date.ToString("yyyy - MM - dd"));
        }
        /// <summary>
        /// Thống kê dữ liệu
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="_theoNgayTao"></param>
        /// <param name="chuaSD"></param>
        /// <param name="daSD"></param>
        /// <param name="_theoPhieuQuaTang"></param>
        /// <param name="_theoPhieuDoiDiem"></param>
        /// <param name="_idKhachHang"></param>
        /// <returns></returns>
        public DataTable ThongKeDuLieu(DateTime fromDate, DateTime toDate//Từ ngày đến ngày
           , bool _theoNgayTao = false //Thoeo ngày tạo hoặc ngày hết hạn
           , bool chuaSD = false, bool daSD = false//đã sử dụng hay chưa
           , bool _theoPhieuQuaTang = false, bool _theoPhieuDoiDiem = false//Theo phiếu quà tặng hay đổi điểm
           , int _idKhachHang = 0 //idKhachHang
           )
        {
            return _mdlPhieuQuaTang.ThongKeDuLieu(fromDate,toDate,_theoNgayTao,chuaSD,daSD
                ,_theoPhieuQuaTang,_theoPhieuDoiDiem,_idKhachHang);
        }
        /// <summary>
        /// Tạo số phiếu tại thời điểm hiện tại
        /// </summary>
        /// <returns></returns>
        public int GetNewSoPhieu()
        {
            return this.GenerateNewSoPhieu(DateTime.Now);
        }
        /// <summary>
        /// Tạo mã phiếu quà tặng dựa trên số phiếu quà tặng 
        /// tại thời điểm date
        /// </summary>
        /// <param name="soPhieuQuaTang"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public string GenerateMaPhieuQuaTang(int soPhieuQuaTang, DateTime date)
        {
            string maPhieuQuaTang = soPhieuQuaTang.ToString();//String maHoaDon
            int maPhieuQuaTangLength = maPhieuQuaTang.Length;
            string result = "PT02/";
            for (int i = 0; i < 4 - maPhieuQuaTangLength; i++)
            {
                result += "0";
            }
            result += maPhieuQuaTang + date.ToString("MMyyyy");
            return result;
        }
        /// <summary>
        /// Tạo mã phiếu quà tặng mới tại thời điểm hiện tại
        /// </summary>
        /// <returns></returns>
        public string GetNewMaPhieuQuaTang()
        {
            return this.GenerateMaPhieuQuaTang(GetNewSoPhieu(), DateTime.Now);
        }
        /// <summary>
        /// Thêm dữ liệu vào databse 
        /// </summary>
        /// <param name="phieuQuaTang"></param>
        /// <returns></returns>
        public bool AddData(clsPhieuQuaTang phieuQuaTang,bool xacnhan = true)
        {
            if (xacnhan)
            {
                DialogResult result = MessageBox.Show("Xác nhận tạo phiếu quà tặng " + GetNewMaPhieuQuaTang() + " ?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return false;
            }
            ///them phieuquatang
            if (_mdlPhieuQuaTang.AddData(phieuQuaTang))
            {
                if (xacnhan)
                    MessageBox.Show("Thêm thành công", "Thêm phiếu quà tặng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _view.UpdateViewPhieuQuaTang();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm phiếu quà tặng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// Cập nhật dữ liệu cho phieuThu
        /// </summary>
        /// <param name="phieuQuaTang"></param>
        /// <returns></returns>
        public bool UpdateData(clsPhieuQuaTang phieuQuaTang,bool xacnhan = true)
        {
            if (xacnhan)
            {
                DialogResult result = MessageBox.Show("Xác nhận sửa thông tin phiếu quà tặng " + GenerateMaPhieuQuaTang(phieuQuaTang.MaVach, phieuQuaTang.NgayTao)
                    + " ?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return false;
            }
            ///them hoa don

            if (_mdlPhieuQuaTang.UpdateData(phieuQuaTang))
            {
                if (xacnhan)
                    MessageBox.Show("Sửa thành công", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                _view.UpdateViewPhieuQuaTang();
                return true;
            }
            else
                MessageBox.Show("Sửa thất bại", "Sửa phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        /// <summary>
        /// Xóa dữ liệu phiếu quà tặng
        /// </summary>
        /// <param name="idPhieuQuaTang"></param>
        /// <returns></returns>
        public bool DeleteData(int idPhieuQuaTang,bool xacnhan = true)
        {
            if (xacnhan)
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa phiếu quà tặng " + _mdlPhieuQuaTang.GetMaPhieuQuaTangById(idPhieuQuaTang)
                 + " ?", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return false;
            }
            ///xoa phieu qua tang

            if (_mdlPhieuQuaTang.DeleteData(idPhieuQuaTang))
            {
                _view.UpdateViewPhieuQuaTang();
                return true;
            }
            else
                MessageBox.Show("Xóa thất bại", "Xóa phiếu quà tặng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}

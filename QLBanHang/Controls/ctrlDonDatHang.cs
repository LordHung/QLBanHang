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
    public interface IDonDatHangView
    {
        bool AddDonDatHang();

        void ChonSanPhamDatHang();

        void TangSoLuongSanPhamDatHang();

        void GiamSoLuongSanPhamDatHang();

        void ResetViewDonDatHang();
    }

    public class ctrlDonDatHang
    {
        mdlDonDatHang _mdlDonDatHang = new mdlDonDatHang();

        int _idDonDatHang;

        public int IdDonDatHang
        {
            get { return _idDonDatHang; }
            set { _idDonDatHang = value; }
        }

        IDonDatHangView _viewDonDatHang;

        public void SetView(IDonDatHangView view)
        {
            _viewDonDatHang = view;
        }

        public int GenerateNewSoDonDatHang(DateTime date)
        {
            return _mdlDonDatHang.GenerateNewDonDatHang(date.ToString("yyyy-MM-dd"));
        }

        public int GetNewSoDonDatHangByNow()
        {
            return this.GenerateNewSoDonDatHang(DateTime.Now);
        }

        public int GetIdDonDatHang()
        {
            return _mdlDonDatHang.GetIdDonDatHang();
        }

        public bool AddData(clsDonDatHang donDatHang)
        {
            DialogResult result = MessageBox.Show("Xác nhận tạo đơn đặt hàng " + GetNewMaDatHangByNow() + " ?", "Xác nhận", 
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlDonDatHang.AddData(donDatHang))
            {
                MessageBox.Show("Thêm thành công", "Thêm đươn đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_viewDonDatHang.ResetViewDonDatHang();
                return true;
            }
            else
                MessageBox.Show("Thêm thất bại", "Thêm đơn đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public string GenerateMaDatHang(int soDonDatHang, DateTime date)
        {
            string maDonDatHang = soDonDatHang.ToString();//String maHoaDon
            int soDonDatHangLength = maDonDatHang.Length;
            string result = "DH02/";
            for (int i = 0; i < 4 - soDonDatHangLength; i++)
            {
                result += "0";
            }
            result += maDonDatHang +"/"+ date.ToString("ddMMyyyy");
            return result;
        }

        public string GetNewMaDatHangByNow()
        {
            return this.GenerateMaDatHang(GetNewSoDonDatHangByNow(), DateTime.Now);
        }


        public DataTable GetDonDatHang()
        {
            return _mdlDonDatHang.GetDonDatHang();
        }


        public int GetIdDonDatHangTheoSoDon(string maHoaDon)
        {
            return _mdlDonDatHang.GetIdDonDatHangTheoSoDon(maHoaDon);
        }

        public string GetMaDonDatHangById(int id)
        {
            return _mdlDonDatHang.GetMaDonDatHangById(id);
        }

    }
}

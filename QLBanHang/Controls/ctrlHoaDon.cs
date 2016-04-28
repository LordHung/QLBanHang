﻿using System;
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
    public interface IHoaDonView
    {
        bool AddHoaDon();

        void ChonSanPhamBanHang();

        void TangSoLuongMaVachBanHang();

        void GiamSoLuongMaVachBanHang();

        void ResetViewHoaDon();
    }

    public class ctrlHoaDon
    {
        mdlHoaDon _mdlHoaDon = new mdlHoaDon();


        IHoaDonView _viewHoaDon;

        public void SetView(IHoaDonView view)
        {
            _viewHoaDon = view;
        }

        public decimal GenerateNewSoHoaDon(DateTime date)
        {
            return _mdlHoaDon.GenerateNewSoHoaDon(date.ToString("yyyy-MM-dd"));
        }

        public decimal GetNewSoHoaDonByNow()
        {
            return this.GenerateNewSoHoaDon(DateTime.Now);
        }

        public decimal GetIdHoaDon()
        {
            return _mdlHoaDon.GetIdHoaDon();
        }

        public bool AddData(clsHoaDon hoaDon)
        {
            DialogResult result = MessageBox.Show("Xác nhận tạo hóa đơn " + GetNewMaHoaDonByNow() + " ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return false;
            ///them hoa don

            if (_mdlHoaDon.AddData(hoaDon))
            {
                MessageBox.Show( "Thêm thành công", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them chi tiet hoa don
                return true;
            }
            else
                MessageBox.Show( "Thêm thất bại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


        public string GenerateMaHoaDon(decimal soHoaDon, DateTime date)
        {
            string maHoaDon = soHoaDon.ToString();//String maHoaDon
            int maHoaDonLength = maHoaDon.Length;
            string result = "IV02";
            for (int i = 0; i < 5 - maHoaDonLength; i++)
            {
                result += "0";
            }
            result += maHoaDon + date.ToString("ddMMyyyy");
            return result;
        }

        public string GetNewMaHoaDonByNow()
        {
            return this.GenerateMaHoaDon(GetNewSoHoaDonByNow(), DateTime.Now);
        }

    }
}

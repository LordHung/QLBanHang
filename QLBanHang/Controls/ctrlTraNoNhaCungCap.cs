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
    class ctrlTraNoNhaCungCap
    {
        mdlTraNoNhaCungCap _mdlTraNhoNhaCungCap = new mdlTraNoNhaCungCap();

        public void AddData(clsTraNoNhaCungCap traNoNhaCunCap)
        {
            if (!_mdlTraNhoNhaCungCap.AddData(traNoNhaCunCap))
            {
                MessageBox.Show("Trả nợ nhà cung cấp lỗi", "Trả nợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GenerateNewSoPhieu(DateTime date)
        {
            return _mdlTraNhoNhaCungCap.GenerateNewSoPhieu(date.ToString("yyyy-MM-dd"));
        }

        public int GetNewSoPhieuByNow()
        {
            return this.GenerateNewSoPhieu(DateTime.Now);
        }

    }
}

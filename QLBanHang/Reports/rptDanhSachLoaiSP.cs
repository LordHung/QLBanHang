using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.Reports {
    public partial class rptDanhSachLoaiSP : Form {
        public rptDanhSachLoaiSP() {
            InitializeComponent();
        }

        private void rptDanhSachLoaiSP_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'qL.tbLoaiSanPham' table. You can move, or remove it, as needed.
            this.tbLoaiSanPhamTableAdapter.Fill(this.qL.tbLoaiSanPham);
            // TODO: This line of code loads data into the 'qL.tbNganhSanPham' table. You can move, or remove it, as needed.
            this.tbNganhSanPhamTableAdapter.Fill(this.qL.tbNganhSanPham);

            this.reportViewer1.RefreshReport();

            //gọi RefreshReport() để bắt đầu hiển thị
            reportViewer1.LocalReport.DisplayName = "DanhSachLoaiSP";
            //nếu bạn bỏ qua bước này, khi report hiện ra và bạn muốn export nó ra excel hoặc PDF thì VS sẽ lấy tên mặc định cho file export là rptCallLogs.
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            //bắt Reportviewer hiển thị ở chế độ PrintLayout (trông sẽ đẹp mắt hơn)
            reportViewer1.ZoomMode = ZoomMode.Percent;
            //đặt chế độ Zoom cho report là theo phần trăm
            reportViewer1.ZoomPercent = 100;
            //và zoom nó lên 100%
            this.reportViewer1.RefreshReport();
        }
    }
}

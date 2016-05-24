namespace QLBanHang.Reports {
    partial class rptDanhSachLoaiSP {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qL = new QLBanHang.QL();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbCuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCuaHangTableAdapter = new QLBanHang.QLTableAdapters.tbCuaHangTableAdapter();
            this.tbNganhSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNganhSanPhamTableAdapter = new QLBanHang.QLTableAdapters.tbNganhSanPhamTableAdapter();
            this.tbLoaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbLoaiSanPhamTableAdapter = new QLBanHang.QLTableAdapters.tbLoaiSanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNganhSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qL
            // 
            this.qL.DataSetName = "QL";
            this.qL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLoaiSanPham";
            reportDataSource1.Value = this.tbLoaiSanPhamBindingSource;
            reportDataSource2.Name = "dsNganhSanPham";
            reportDataSource2.Value = this.tbNganhSanPhamBindingSource;
            reportDataSource3.Name = "dsCuaHang";
            reportDataSource3.Value = this.tbCuaHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHang.Reports.rptDanhSachLoaiSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbCuaHangTableAdapter
            // 
            this.tbCuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // tbNganhSanPhamBindingSource
            // 
            this.tbNganhSanPhamBindingSource.DataMember = "tbNganhSanPham";
            this.tbNganhSanPhamBindingSource.DataSource = this.qL;
            // 
            // tbNganhSanPhamTableAdapter
            // 
            this.tbNganhSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tbLoaiSanPhamBindingSource
            // 
            this.tbLoaiSanPhamBindingSource.DataMember = "tbLoaiSanPham";
            this.tbLoaiSanPhamBindingSource.DataSource = this.qL;
            // 
            // tbLoaiSanPhamTableAdapter
            // 
            this.tbLoaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // rptDanhSachLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDanhSachLoaiSP";
            this.Text = "rptDanhSachLoaiSP";
            this.Load += new System.EventHandler(this.rptDanhSachLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNganhSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QL qL;
        private System.Windows.Forms.BindingSource tbCuaHangBindingSource;
        private QLTableAdapters.tbCuaHangTableAdapter tbCuaHangTableAdapter;
        private System.Windows.Forms.BindingSource tbNganhSanPhamBindingSource;
        private QLTableAdapters.tbNganhSanPhamTableAdapter tbNganhSanPhamTableAdapter;
        private System.Windows.Forms.BindingSource tbLoaiSanPhamBindingSource;
        private QLTableAdapters.tbLoaiSanPhamTableAdapter tbLoaiSanPhamTableAdapter;
    }
}
namespace QLBanHang.Reports {
    partial class rptDanhSachNSX {
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qL = new QLBanHang.QL();
            this.tbNhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNhaSanXuatTableAdapter = new QLBanHang.QLTableAdapters.tbNhaSanXuatTableAdapter();
            this.tbCuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCuaHangTableAdapter = new QLBanHang.QLTableAdapters.tbCuaHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhaSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsNhaSanXuat";
            reportDataSource1.Value = this.tbNhaSanXuatBindingSource;
            reportDataSource2.Name = "dsCuaHang";
            reportDataSource2.Value = this.tbCuaHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHang.Reports.rptDanhSachNhaSanXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // qL
            // 
            this.qL.DataSetName = "QL";
            this.qL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNhaSanXuatBindingSource
            // 
            this.tbNhaSanXuatBindingSource.DataMember = "tbNhaSanXuat";
            this.tbNhaSanXuatBindingSource.DataSource = this.qL;
            // 
            // tbNhaSanXuatTableAdapter
            // 
            this.tbNhaSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tbCuaHangBindingSource
            // 
            this.tbCuaHangBindingSource.DataMember = "tbCuaHang";
            this.tbCuaHangBindingSource.DataSource = this.qL;
            // 
            // tbCuaHangTableAdapter
            // 
            this.tbCuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // rptDanhSachNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDanhSachNSX";
            this.Text = "rptDanhSachNSX";
            this.Load += new System.EventHandler(this.rptDanhSachNSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhaSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QL qL;
        private System.Windows.Forms.BindingSource tbNhaSanXuatBindingSource;
        private QLTableAdapters.tbNhaSanXuatTableAdapter tbNhaSanXuatTableAdapter;
        private System.Windows.Forms.BindingSource tbCuaHangBindingSource;
        private QLTableAdapters.tbCuaHangTableAdapter tbCuaHangTableAdapter;
    }
}
namespace QLBanHang.Reports {
    partial class rptDanhSachNV {
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
            this.tbCuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL = new QLBanHang.QL();
            this.tbNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNhanVienTableAdapter = new QLBanHang.QLTableAdapters.tbNhanVienTableAdapter();
            this.tbCuaHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCuaHangTableAdapter = new QLBanHang.QLTableAdapters.tbCuaHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDanhSachNhanVien";
            reportDataSource1.Value = this.tbNhanVienBindingSource;
            reportDataSource2.Name = "dsCuaHang";
            reportDataSource2.Value = this.tbCuaHangBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHang.Reports.rptDanhSachNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbCuaHangBindingSource
            // 
            this.tbCuaHangBindingSource.DataMember = "tbCuaHang";
            // 
            // qL
            // 
            this.qL.DataSetName = "QL";
            this.qL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNhanVienBindingSource
            // 
            this.tbNhanVienBindingSource.DataMember = "tbNhanVien";
            this.tbNhanVienBindingSource.DataSource = this.qL;
            // 
            // tbNhanVienTableAdapter
            // 
            this.tbNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tbCuaHangBindingSource1
            // 
            this.tbCuaHangBindingSource1.DataMember = "tbCuaHang";
            this.tbCuaHangBindingSource1.DataSource = this.qL;
            // 
            // tbCuaHangTableAdapter
            // 
            this.tbCuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // rptDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptDanhSachNV";
            this.Text = "rptDanhSachNV";
            this.Load += new System.EventHandler(this.rptDanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuaHangBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbCuaHangBindingSource;
        private QL qL;
        private System.Windows.Forms.BindingSource tbNhanVienBindingSource;
        private QLTableAdapters.tbNhanVienTableAdapter tbNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tbCuaHangBindingSource1;
        private QLTableAdapters.tbCuaHangTableAdapter tbCuaHangTableAdapter;
    }
}
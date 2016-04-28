namespace QLBanHang.Views
{
    partial class FrmDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsHoaDon = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSCmbCuaHang = new System.Windows.Forms.ToolStripComboBox();
            this.tSbBtnDongYDatHang = new System.Windows.Forms.ToolStripButton();
            this.tSBtnXemTruoc = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNhaCungCapDatHang = new System.Windows.Forms.ComboBox();
            this.txtGhiChuDonDatHang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNgayNhapDonDatHang = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNhanVienLapDonDatHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaDonDatHang = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgViewMaVach = new System.Windows.Forms.DataGridView();
            this.tSMaVach = new System.Windows.Forms.ToolStrip();
            this.tSBtnChonMaVach = new System.Windows.Forms.ToolStripButton();
            this.dgViewMaVachDaChon = new System.Windows.Forms.DataGridView();
            this.tSMaVachDaChon = new System.Windows.Forms.ToolStrip();
            this.tSBtnPlusMaVach = new System.Windows.Forms.ToolStripButton();
            this.tSbtnMinusMaVach = new System.Windows.Forms.ToolStripButton();
            this.tsHoaDon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVach)).BeginInit();
            this.tSMaVach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachDaChon)).BeginInit();
            this.tSMaVachDaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHoaDon
            // 
            this.tsHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tSCmbCuaHang,
            this.tSbBtnDongYDatHang,
            this.tSBtnXemTruoc});
            this.tsHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tsHoaDon.Name = "tsHoaDon";
            this.tsHoaDon.Size = new System.Drawing.Size(1235, 25);
            this.tsHoaDon.TabIndex = 24;
            this.tsHoaDon.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Hóa đơn";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Cửa hàng : ";
            // 
            // tSCmbCuaHang
            // 
            this.tSCmbCuaHang.Name = "tSCmbCuaHang";
            this.tSCmbCuaHang.Size = new System.Drawing.Size(121, 25);
            this.tSCmbCuaHang.SelectedIndexChanged += new System.EventHandler(this.tSCmbCuaHang_SelectedIndexChanged);
            // 
            // tSbBtnDongYDatHang
            // 
            this.tSbBtnDongYDatHang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSbBtnDongYDatHang.Image = global::QLBanHang.Properties.Resources.dautich;
            this.tSbBtnDongYDatHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbBtnDongYDatHang.Name = "tSbBtnDongYDatHang";
            this.tSbBtnDongYDatHang.Size = new System.Drawing.Size(65, 22);
            this.tSbBtnDongYDatHang.Text = "Đồng ý";
            this.tSbBtnDongYDatHang.Click += new System.EventHandler(this.tSbBtnDongYDatHang_Click);
            // 
            // tSBtnXemTruoc
            // 
            this.tSBtnXemTruoc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnXemTruoc.Image = global::QLBanHang.Properties.Resources.kinh_lup;
            this.tSBtnXemTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnXemTruoc.Name = "tSBtnXemTruoc";
            this.tSBtnXemTruoc.Size = new System.Drawing.Size(82, 22);
            this.tSBtnXemTruoc.Text = "Xem trước";
            this.tSBtnXemTruoc.Click += new System.EventHandler(this.tSBtnXemTruoc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNhaCungCapDatHang);
            this.panel1.Controls.Add(this.txtGhiChuDonDatHang);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.dtpNgayNhapDonDatHang);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtNhanVienLapDonDatHang);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMaDonDatHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 134);
            this.panel1.TabIndex = 25;
            // 
            // cmbNhaCungCapDatHang
            // 
            this.cmbNhaCungCapDatHang.FormattingEnabled = true;
            this.cmbNhaCungCapDatHang.Location = new System.Drawing.Point(466, 52);
            this.cmbNhaCungCapDatHang.Name = "cmbNhaCungCapDatHang";
            this.cmbNhaCungCapDatHang.Size = new System.Drawing.Size(196, 21);
            this.cmbNhaCungCapDatHang.TabIndex = 35;
            this.cmbNhaCungCapDatHang.SelectedIndexChanged += new System.EventHandler(this.cmbNhaCungCapDatHang_SelectedIndexChanged);
            // 
            // txtGhiChuDonDatHang
            // 
            this.txtGhiChuDonDatHang.Location = new System.Drawing.Point(125, 79);
            this.txtGhiChuDonDatHang.Multiline = true;
            this.txtGhiChuDonDatHang.Name = "txtGhiChuDonDatHang";
            this.txtGhiChuDonDatHang.Size = new System.Drawing.Size(542, 52);
            this.txtGhiChuDonDatHang.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Nhà cung cấp :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Mã đơn :";
            // 
            // dtpNgayNhapDonDatHang
            // 
            this.dtpNgayNhapDonDatHang.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpNgayNhapDonDatHang.Location = new System.Drawing.Point(125, 46);
            this.dtpNgayNhapDonDatHang.Name = "dtpNgayNhapDonDatHang";
            this.dtpNgayNhapDonDatHang.Size = new System.Drawing.Size(196, 20);
            this.dtpNgayNhapDonDatHang.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Nhân viên :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ngày lập :";
            // 
            // txtNhanVienLapDonDatHang
            // 
            this.txtNhanVienLapDonDatHang.Location = new System.Drawing.Point(466, 17);
            this.txtNhanVienLapDonDatHang.Name = "txtNhanVienLapDonDatHang";
            this.txtNhanVienLapDonDatHang.ReadOnly = true;
            this.txtNhanVienLapDonDatHang.Size = new System.Drawing.Size(196, 20);
            this.txtNhanVienLapDonDatHang.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ghi chú :";
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.Location = new System.Drawing.Point(125, 20);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(196, 20);
            this.txtMaDonDatHang.TabIndex = 30;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 159);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgViewMaVach);
            this.splitContainer1.Panel1.Controls.Add(this.tSMaVach);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgViewMaVachDaChon);
            this.splitContainer1.Panel2.Controls.Add(this.tSMaVachDaChon);
            this.splitContainer1.Size = new System.Drawing.Size(1235, 606);
            this.splitContainer1.SplitterDistance = 747;
            this.splitContainer1.TabIndex = 26;
            // 
            // dgViewMaVach
            // 
            this.dgViewMaVach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewMaVach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgViewMaVach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVach.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVach.MultiSelect = false;
            this.dgViewMaVach.Name = "dgViewMaVach";
            this.dgViewMaVach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewMaVach.Size = new System.Drawing.Size(747, 581);
            this.dgViewMaVach.TabIndex = 3;
            // 
            // tSMaVach
            // 
            this.tSMaVach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnChonMaVach});
            this.tSMaVach.Location = new System.Drawing.Point(0, 0);
            this.tSMaVach.Name = "tSMaVach";
            this.tSMaVach.Size = new System.Drawing.Size(747, 25);
            this.tSMaVach.TabIndex = 0;
            this.tSMaVach.Text = "toolStrip1";
            // 
            // tSBtnChonMaVach
            // 
            this.tSBtnChonMaVach.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnChonMaVach.Image = global::QLBanHang.Properties.Resources.dautich;
            this.tSBtnChonMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnChonMaVach.Name = "tSBtnChonMaVach";
            this.tSBtnChonMaVach.Size = new System.Drawing.Size(56, 22);
            this.tSBtnChonMaVach.Text = "Chọn";
            this.tSBtnChonMaVach.Click += new System.EventHandler(this.tSBtnChonMaVach_Click);
            // 
            // dgViewMaVachDaChon
            // 
            this.dgViewMaVachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVachDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVachDaChon.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVachDaChon.Name = "dgViewMaVachDaChon";
            this.dgViewMaVachDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewMaVachDaChon.Size = new System.Drawing.Size(484, 581);
            this.dgViewMaVachDaChon.TabIndex = 1;
            // 
            // tSMaVachDaChon
            // 
            this.tSMaVachDaChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnPlusMaVach,
            this.tSbtnMinusMaVach});
            this.tSMaVachDaChon.Location = new System.Drawing.Point(0, 0);
            this.tSMaVachDaChon.Name = "tSMaVachDaChon";
            this.tSMaVachDaChon.Size = new System.Drawing.Size(484, 25);
            this.tSMaVachDaChon.TabIndex = 0;
            this.tSMaVachDaChon.Text = "toolStrip2";
            // 
            // tSBtnPlusMaVach
            // 
            this.tSBtnPlusMaVach.Image = global::QLBanHang.Properties.Resources.dauCong;
            this.tSBtnPlusMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPlusMaVach.Name = "tSBtnPlusMaVach";
            this.tSBtnPlusMaVach.Size = new System.Drawing.Size(41, 22);
            this.tSBtnPlusMaVach.Text = "+1";
            this.tSBtnPlusMaVach.Click += new System.EventHandler(this.tSBtnPlusMaVach_Click);
            // 
            // tSbtnMinusMaVach
            // 
            this.tSbtnMinusMaVach.Image = global::QLBanHang.Properties.Resources.dautru;
            this.tSbtnMinusMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnMinusMaVach.Name = "tSbtnMinusMaVach";
            this.tSbtnMinusMaVach.Size = new System.Drawing.Size(38, 22);
            this.tSbtnMinusMaVach.Text = "-1";
            this.tSbtnMinusMaVach.Click += new System.EventHandler(this.tSbtnMinusMaVach_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 765);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsHoaDon);
            this.Name = "FrmDatHang";
            this.Text = "FromDatHang";
            this.Load += new System.EventHandler(this.FromDatHang_Load);
            this.tsHoaDon.ResumeLayout(false);
            this.tsHoaDon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVach)).EndInit();
            this.tSMaVach.ResumeLayout(false);
            this.tSMaVach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachDaChon)).EndInit();
            this.tSMaVachDaChon.ResumeLayout(false);
            this.tSMaVachDaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsHoaDon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tSCmbCuaHang;
        private System.Windows.Forms.ToolStripButton tSbBtnDongYDatHang;
        private System.Windows.Forms.ToolStripButton tSBtnXemTruoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNhaCungCapDatHang;
        private System.Windows.Forms.TextBox txtGhiChuDonDatHang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapDonDatHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNhanVienLapDonDatHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaDonDatHang;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgViewMaVach;
        private System.Windows.Forms.ToolStrip tSMaVach;
        private System.Windows.Forms.ToolStripButton tSBtnChonMaVach;
        private System.Windows.Forms.DataGridView dgViewMaVachDaChon;
        private System.Windows.Forms.ToolStrip tSMaVachDaChon;
        private System.Windows.Forms.ToolStripButton tSBtnPlusMaVach;
        private System.Windows.Forms.ToolStripButton tSbtnMinusMaVach;
    }
}
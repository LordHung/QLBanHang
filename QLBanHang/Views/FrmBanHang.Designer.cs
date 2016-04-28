namespace QLBanHang.Views
{
    partial class FrmBanHang
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tSBtnXemTruoc = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.numCK = new System.Windows.Forms.NumericUpDown();
            this.numNo = new System.Windows.Forms.NumericUpDown();
            this.numThoiLai = new System.Windows.Forms.NumericUpDown();
            this.numSoTienKhachDua = new System.Windows.Forms.NumericUpDown();
            this.numPQT = new System.Windows.Forms.NumericUpDown();
            this.numTongTien = new System.Windows.Forms.NumericUpDown();
            this.numCongTien = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.cmbKhachHangMuaHoaDon = new System.Windows.Forms.ComboBox();
            this.txtGhiChuHoaDon = new System.Windows.Forms.TextBox();
            this.txtNhanVienLapHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienKhachDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCongTien)).BeginInit();
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
            this.toolStripButton1,
            this.tSBtnXemTruoc});
            this.tsHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tsHoaDon.Name = "tsHoaDon";
            this.tsHoaDon.Size = new System.Drawing.Size(1196, 25);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::QLBanHang.Properties.Resources.dautich;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Đồng ý";
            this.toolStripButton1.Click += new System.EventHandler(this.tSBtnDongYBanHang);
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
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numCK);
            this.panel1.Controls.Add(this.numNo);
            this.panel1.Controls.Add(this.numThoiLai);
            this.panel1.Controls.Add(this.numSoTienKhachDua);
            this.panel1.Controls.Add(this.numPQT);
            this.panel1.Controls.Add(this.numTongTien);
            this.panel1.Controls.Add(this.numCongTien);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpNgayLapHoaDon);
            this.panel1.Controls.Add(this.cmbKhachHangMuaHoaDon);
            this.panel1.Controls.Add(this.txtGhiChuHoaDon);
            this.panel1.Controls.Add(this.txtNhanVienLapHoaDon);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 197);
            this.panel1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(713, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "CK(%)";
            // 
            // numCK
            // 
            this.numCK.Location = new System.Drawing.Point(642, 10);
            this.numCK.Name = "numCK";
            this.numCK.Size = new System.Drawing.Size(56, 20);
            this.numCK.TabIndex = 47;
            this.numCK.ValueChanged += new System.EventHandler(this.numCK_ValueChanged);
            // 
            // numNo
            // 
            this.numNo.ForeColor = System.Drawing.Color.DarkRed;
            this.numNo.Location = new System.Drawing.Point(499, 140);
            this.numNo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(120, 20);
            this.numNo.TabIndex = 46;
            this.numNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNo.ThousandsSeparator = true;
            // 
            // numThoiLai
            // 
            this.numThoiLai.ForeColor = System.Drawing.Color.DarkRed;
            this.numThoiLai.Location = new System.Drawing.Point(499, 113);
            this.numThoiLai.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numThoiLai.Name = "numThoiLai";
            this.numThoiLai.Size = new System.Drawing.Size(120, 20);
            this.numThoiLai.TabIndex = 45;
            this.numThoiLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numThoiLai.ThousandsSeparator = true;
            // 
            // numSoTienKhachDua
            // 
            this.numSoTienKhachDua.ForeColor = System.Drawing.Color.DarkRed;
            this.numSoTienKhachDua.Location = new System.Drawing.Point(499, 87);
            this.numSoTienKhachDua.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoTienKhachDua.Name = "numSoTienKhachDua";
            this.numSoTienKhachDua.Size = new System.Drawing.Size(120, 20);
            this.numSoTienKhachDua.TabIndex = 44;
            this.numSoTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoTienKhachDua.ThousandsSeparator = true;
            // 
            // numPQT
            // 
            this.numPQT.ForeColor = System.Drawing.Color.DarkRed;
            this.numPQT.Location = new System.Drawing.Point(499, 60);
            this.numPQT.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPQT.Name = "numPQT";
            this.numPQT.Size = new System.Drawing.Size(120, 20);
            this.numPQT.TabIndex = 43;
            this.numPQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPQT.ThousandsSeparator = true;
            // 
            // numTongTien
            // 
            this.numTongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.numTongTien.Location = new System.Drawing.Point(499, 34);
            this.numTongTien.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTongTien.Name = "numTongTien";
            this.numTongTien.Size = new System.Drawing.Size(120, 20);
            this.numTongTien.TabIndex = 42;
            this.numTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTongTien.ThousandsSeparator = true;
            // 
            // numCongTien
            // 
            this.numCongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.numCongTien.Location = new System.Drawing.Point(499, 8);
            this.numCongTien.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCongTien.Name = "numCongTien";
            this.numCongTien.Size = new System.Drawing.Size(120, 20);
            this.numCongTien.TabIndex = 41;
            this.numCongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCongTien.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Nợ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tổng tiền :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "PQT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Đưa :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Thối lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cộng tiền :";
            // 
            // dtpNgayLapHoaDon
            // 
            this.dtpNgayLapHoaDon.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpNgayLapHoaDon.Location = new System.Drawing.Point(127, 41);
            this.dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            this.dtpNgayLapHoaDon.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLapHoaDon.TabIndex = 34;
            // 
            // cmbKhachHangMuaHoaDon
            // 
            this.cmbKhachHangMuaHoaDon.FormattingEnabled = true;
            this.cmbKhachHangMuaHoaDon.Location = new System.Drawing.Point(127, 94);
            this.cmbKhachHangMuaHoaDon.Name = "cmbKhachHangMuaHoaDon";
            this.cmbKhachHangMuaHoaDon.Size = new System.Drawing.Size(178, 21);
            this.cmbKhachHangMuaHoaDon.TabIndex = 33;
            this.cmbKhachHangMuaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // txtGhiChuHoaDon
            // 
            this.txtGhiChuHoaDon.Location = new System.Drawing.Point(127, 121);
            this.txtGhiChuHoaDon.Multiline = true;
            this.txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            this.txtGhiChuHoaDon.Size = new System.Drawing.Size(196, 65);
            this.txtGhiChuHoaDon.TabIndex = 32;
            // 
            // txtNhanVienLapHoaDon
            // 
            this.txtNhanVienLapHoaDon.Location = new System.Drawing.Point(127, 68);
            this.txtNhanVienLapHoaDon.Name = "txtNhanVienLapHoaDon";
            this.txtNhanVienLapHoaDon.ReadOnly = true;
            this.txtNhanVienLapHoaDon.Size = new System.Drawing.Size(196, 20);
            this.txtNhanVienLapHoaDon.TabIndex = 31;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(127, 9);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(196, 20);
            this.txtMaHoaDon.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày lập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 222);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgViewMaVach);
            this.splitContainer1.Panel1.Controls.Add(this.tSMaVach);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgViewMaVachDaChon);
            this.splitContainer1.Panel2.Controls.Add(this.tSMaVachDaChon);
            this.splitContainer1.Size = new System.Drawing.Size(1196, 490);
            this.splitContainer1.SplitterDistance = 633;
            this.splitContainer1.TabIndex = 26;
            // 
            // dgViewMaVach
            // 
            this.dgViewMaVach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVach.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVach.Name = "dgViewMaVach";
            this.dgViewMaVach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewMaVach.Size = new System.Drawing.Size(633, 465);
            this.dgViewMaVach.TabIndex = 3;
            // 
            // tSMaVach
            // 
            this.tSMaVach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnChonMaVach});
            this.tSMaVach.Location = new System.Drawing.Point(0, 0);
            this.tSMaVach.Name = "tSMaVach";
            this.tSMaVach.Size = new System.Drawing.Size(633, 25);
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
            this.dgViewMaVachDaChon.Size = new System.Drawing.Size(559, 465);
            this.dgViewMaVachDaChon.TabIndex = 1;
            // 
            // tSMaVachDaChon
            // 
            this.tSMaVachDaChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnPlusMaVach,
            this.tSbtnMinusMaVach});
            this.tSMaVachDaChon.Location = new System.Drawing.Point(0, 0);
            this.tSMaVachDaChon.Name = "tSMaVachDaChon";
            this.tSMaVachDaChon.Size = new System.Drawing.Size(559, 25);
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
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 707);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsHoaDon);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.tsHoaDon.ResumeLayout(false);
            this.tsHoaDon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienKhachDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCongTien)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tSBtnXemTruoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numCK;
        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.NumericUpDown numThoiLai;
        private System.Windows.Forms.NumericUpDown numSoTienKhachDua;
        private System.Windows.Forms.NumericUpDown numPQT;
        private System.Windows.Forms.NumericUpDown numTongTien;
        private System.Windows.Forms.NumericUpDown numCongTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDon;
        private System.Windows.Forms.ComboBox cmbKhachHangMuaHoaDon;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.TextBox txtNhanVienLapHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
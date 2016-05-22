namespace QLBanHang.Views
{
    partial class FrmThongKePhieuQuaTang
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
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckChuaSD = new System.Windows.Forms.CheckBox();
            this.ckTaoPhieu = new System.Windows.Forms.RadioButton();
            this.ckNgayHetHan = new System.Windows.Forms.RadioButton();
            this.ckDaSD = new System.Windows.Forms.RadioButton();
            this.btnPhieuQuaTang = new System.Windows.Forms.Button();
            this.btnPhieuDoiDiem = new System.Windows.Forms.Button();
            this.ckBoxTheoKhachHang = new System.Windows.Forms.CheckBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.cmbKhachHang);
            this.panel1.Controls.Add(this.ckBoxTheoKhachHang);
            this.panel1.Controls.Add(this.btnPhieuDoiDiem);
            this.panel1.Controls.Add(this.btnPhieuQuaTang);
            this.panel1.Controls.Add(this.ckDaSD);
            this.panel1.Controls.Add(this.ckNgayHetHan);
            this.panel1.Controls.Add(this.ckTaoPhieu);
            this.panel1.Controls.Add(this.ckChuaSD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Size = new System.Drawing.Size(325, 832);
            this.panel1.Controls.SetChildIndex(this.dtpTuNgay, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDenNgay, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.ckChuaSD, 0);
            this.panel1.Controls.SetChildIndex(this.ckTaoPhieu, 0);
            this.panel1.Controls.SetChildIndex(this.ckNgayHetHan, 0);
            this.panel1.Controls.SetChildIndex(this.ckDaSD, 0);
            this.panel1.Controls.SetChildIndex(this.btnPhieuQuaTang, 0);
            this.panel1.Controls.SetChildIndex(this.btnPhieuDoiDiem, 0);
            this.panel1.Controls.SetChildIndex(this.ckBoxTheoKhachHang, 0);
            this.panel1.Controls.SetChildIndex(this.cmbKhachHang, 0);
            this.panel1.Controls.SetChildIndex(this.btnTim, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(22, 28);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(22, 85);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // ckChuaSD
            // 
            this.ckChuaSD.AutoSize = true;
            this.ckChuaSD.Location = new System.Drawing.Point(80, 219);
            this.ckChuaSD.Name = "ckChuaSD";
            this.ckChuaSD.Size = new System.Drawing.Size(108, 20);
            this.ckChuaSD.TabIndex = 7;
            this.ckChuaSD.Text = "Chưa sử dụng";
            this.ckChuaSD.UseVisualStyleBackColor = true;
            this.ckChuaSD.CheckedChanged += new System.EventHandler(this.ckChuaSD_CheckedChanged);
            // 
            // ckTaoPhieu
            // 
            this.ckTaoPhieu.AutoSize = true;
            this.ckTaoPhieu.Location = new System.Drawing.Point(52, 138);
            this.ckTaoPhieu.Name = "ckTaoPhieu";
            this.ckTaoPhieu.Size = new System.Drawing.Size(87, 20);
            this.ckTaoPhieu.TabIndex = 9;
            this.ckTaoPhieu.TabStop = true;
            this.ckTaoPhieu.Text = "Tạo phiếu";
            this.ckTaoPhieu.UseVisualStyleBackColor = true;
            this.ckTaoPhieu.CheckedChanged += new System.EventHandler(this.ckTaoPhieu_CheckedChanged);
            // 
            // ckNgayHetHan
            // 
            this.ckNgayHetHan.AutoSize = true;
            this.ckNgayHetHan.Location = new System.Drawing.Point(52, 181);
            this.ckNgayHetHan.Name = "ckNgayHetHan";
            this.ckNgayHetHan.Size = new System.Drawing.Size(105, 20);
            this.ckNgayHetHan.TabIndex = 10;
            this.ckNgayHetHan.TabStop = true;
            this.ckNgayHetHan.Text = "Ngày hết hạn";
            this.ckNgayHetHan.UseVisualStyleBackColor = true;
            this.ckNgayHetHan.CheckedChanged += new System.EventHandler(this.ckNgayHetHan_CheckedChanged);
            // 
            // ckDaSD
            // 
            this.ckDaSD.AutoSize = true;
            this.ckDaSD.Location = new System.Drawing.Point(52, 263);
            this.ckDaSD.Name = "ckDaSD";
            this.ckDaSD.Size = new System.Drawing.Size(93, 20);
            this.ckDaSD.TabIndex = 11;
            this.ckDaSD.TabStop = true;
            this.ckDaSD.Text = "Đã sử dụng";
            this.ckDaSD.UseVisualStyleBackColor = true;
            this.ckDaSD.CheckedChanged += new System.EventHandler(this.ckDaSD_CheckedChanged);
            // 
            // btnPhieuQuaTang
            // 
            this.btnPhieuQuaTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuQuaTang.Location = new System.Drawing.Point(22, 290);
            this.btnPhieuQuaTang.Name = "btnPhieuQuaTang";
            this.btnPhieuQuaTang.Size = new System.Drawing.Size(248, 32);
            this.btnPhieuQuaTang.TabIndex = 12;
            this.btnPhieuQuaTang.Text = "Phiếu quà tặng";
            this.btnPhieuQuaTang.UseVisualStyleBackColor = true;
            this.btnPhieuQuaTang.Click += new System.EventHandler(this.btnPhieuQuaTang_Click);
            // 
            // btnPhieuDoiDiem
            // 
            this.btnPhieuDoiDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuDoiDiem.Location = new System.Drawing.Point(22, 342);
            this.btnPhieuDoiDiem.Name = "btnPhieuDoiDiem";
            this.btnPhieuDoiDiem.Size = new System.Drawing.Size(248, 32);
            this.btnPhieuDoiDiem.TabIndex = 13;
            this.btnPhieuDoiDiem.Text = "Phiếu đổi điểm";
            this.btnPhieuDoiDiem.UseVisualStyleBackColor = true;
            this.btnPhieuDoiDiem.Click += new System.EventHandler(this.btnPhieuDoiDiem_Click);
            // 
            // ckBoxTheoKhachHang
            // 
            this.ckBoxTheoKhachHang.AutoSize = true;
            this.ckBoxTheoKhachHang.Location = new System.Drawing.Point(22, 396);
            this.ckBoxTheoKhachHang.Name = "ckBoxTheoKhachHang";
            this.ckBoxTheoKhachHang.Size = new System.Drawing.Size(213, 20);
            this.ckBoxTheoKhachHang.TabIndex = 14;
            this.ckBoxTheoKhachHang.Text = "Phiếu đổi điểm của khách hàng";
            this.ckBoxTheoKhachHang.UseVisualStyleBackColor = true;
            this.ckBoxTheoKhachHang.CheckedChanged += new System.EventHandler(this.ckBoxTheoKhachHang_CheckedChanged);
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(22, 423);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(248, 24);
            this.cmbKhachHang.TabIndex = 15;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(22, 470);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(248, 45);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // FrmThongKePhieuQuaTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 857);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmThongKePhieuQuaTang";
            this.Text = "FrmThongKePhieuQuaTang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.RadioButton ckDaSD;
        private System.Windows.Forms.RadioButton ckNgayHetHan;
        private System.Windows.Forms.RadioButton ckTaoPhieu;
        private System.Windows.Forms.CheckBox ckChuaSD;
        private System.Windows.Forms.Button btnPhieuDoiDiem;
        private System.Windows.Forms.Button btnPhieuQuaTang;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.CheckBox ckBoxTheoKhachHang;
        private System.Windows.Forms.Button btnTim;
    }
}
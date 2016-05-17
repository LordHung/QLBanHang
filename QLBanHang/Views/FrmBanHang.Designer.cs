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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienKhachDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 274);
            this.splitContainer1.Size = new System.Drawing.Size(1196, 433);
            this.splitContainer1.SplitterDistance = 656;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.numCK);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.numNo);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.numThoiLai);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.numSoTienKhachDua);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.numPQT);
            this.panelMain.Controls.Add(this.txtMaHoaDon);
            this.panelMain.Controls.Add(this.numTongTien);
            this.panelMain.Controls.Add(this.txtNhanVienLapHoaDon);
            this.panelMain.Controls.Add(this.numCongTien);
            this.panelMain.Controls.Add(this.txtGhiChuHoaDon);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.cmbKhachHangMuaHoaDon);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.dtpNgayLapHoaDon);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Size = new System.Drawing.Size(1196, 249);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(745, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "CK(%)";
            // 
            // numCK
            // 
            this.numCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numCK.Location = new System.Drawing.Point(674, 20);
            this.numCK.Name = "numCK";
            this.numCK.Size = new System.Drawing.Size(56, 26);
            this.numCK.TabIndex = 71;
            this.numCK.ValueChanged += new System.EventHandler(this.numCK_ValueChanged);
            // 
            // numNo
            // 
            this.numNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numNo.ForeColor = System.Drawing.Color.DarkRed;
            this.numNo.Location = new System.Drawing.Point(531, 179);
            this.numNo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(120, 26);
            this.numNo.TabIndex = 70;
            this.numNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNo.ThousandsSeparator = true;
            // 
            // numThoiLai
            // 
            this.numThoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numThoiLai.ForeColor = System.Drawing.Color.DarkRed;
            this.numThoiLai.Location = new System.Drawing.Point(531, 147);
            this.numThoiLai.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numThoiLai.Name = "numThoiLai";
            this.numThoiLai.Size = new System.Drawing.Size(120, 26);
            this.numThoiLai.TabIndex = 69;
            this.numThoiLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numThoiLai.ThousandsSeparator = true;
            // 
            // numSoTienKhachDua
            // 
            this.numSoTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSoTienKhachDua.ForeColor = System.Drawing.Color.DarkRed;
            this.numSoTienKhachDua.Location = new System.Drawing.Point(531, 115);
            this.numSoTienKhachDua.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoTienKhachDua.Name = "numSoTienKhachDua";
            this.numSoTienKhachDua.Size = new System.Drawing.Size(120, 26);
            this.numSoTienKhachDua.TabIndex = 68;
            this.numSoTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoTienKhachDua.ThousandsSeparator = true;
            // 
            // numPQT
            // 
            this.numPQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numPQT.ForeColor = System.Drawing.Color.DarkRed;
            this.numPQT.Location = new System.Drawing.Point(531, 83);
            this.numPQT.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPQT.Name = "numPQT";
            this.numPQT.Size = new System.Drawing.Size(120, 26);
            this.numPQT.TabIndex = 67;
            this.numPQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPQT.ThousandsSeparator = true;
            // 
            // numTongTien
            // 
            this.numTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numTongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.numTongTien.Location = new System.Drawing.Point(531, 51);
            this.numTongTien.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTongTien.Name = "numTongTien";
            this.numTongTien.Size = new System.Drawing.Size(120, 26);
            this.numTongTien.TabIndex = 66;
            this.numTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTongTien.ThousandsSeparator = true;
            // 
            // numCongTien
            // 
            this.numCongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numCongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.numCongTien.Location = new System.Drawing.Point(531, 18);
            this.numCongTien.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCongTien.Name = "numCongTien";
            this.numCongTien.Size = new System.Drawing.Size(120, 26);
            this.numCongTien.TabIndex = 65;
            this.numCongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCongTien.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(488, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "Nợ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(444, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tổng tiền :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(477, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "PQT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(478, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Đưa :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(459, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Thối lại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(442, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cộng tiền :";
            // 
            // dtpNgayLapHoaDon
            // 
            this.dtpNgayLapHoaDon.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLapHoaDon.Location = new System.Drawing.Point(159, 57);
            this.dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            this.dtpNgayLapHoaDon.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayLapHoaDon.TabIndex = 58;
            // 
            // cmbKhachHangMuaHoaDon
            // 
            this.cmbKhachHangMuaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhachHangMuaHoaDon.FormattingEnabled = true;
            this.cmbKhachHangMuaHoaDon.Location = new System.Drawing.Point(159, 130);
            this.cmbKhachHangMuaHoaDon.Name = "cmbKhachHangMuaHoaDon";
            this.cmbKhachHangMuaHoaDon.Size = new System.Drawing.Size(178, 28);
            this.cmbKhachHangMuaHoaDon.TabIndex = 57;
            this.cmbKhachHangMuaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // txtGhiChuHoaDon
            // 
            this.txtGhiChuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChuHoaDon.Location = new System.Drawing.Point(159, 164);
            this.txtGhiChuHoaDon.Multiline = true;
            this.txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            this.txtGhiChuHoaDon.Size = new System.Drawing.Size(196, 65);
            this.txtGhiChuHoaDon.TabIndex = 56;
            // 
            // txtNhanVienLapHoaDon
            // 
            this.txtNhanVienLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVienLapHoaDon.Location = new System.Drawing.Point(159, 97);
            this.txtNhanVienLapHoaDon.Name = "txtNhanVienLapHoaDon";
            this.txtNhanVienLapHoaDon.ReadOnly = true;
            this.txtNhanVienLapHoaDon.Size = new System.Drawing.Size(196, 26);
            this.txtNhanVienLapHoaDon.TabIndex = 55;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(159, 19);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(196, 26);
            this.txtMaHoaDon.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(65, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(59, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày lập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 707);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienKhachDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numThoiLai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoTienKhachDua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPQT;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.NumericUpDown numTongTien;
        private System.Windows.Forms.TextBox txtNhanVienLapHoaDon;
        private System.Windows.Forms.NumericUpDown numCongTien;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbKhachHangMuaHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;


    }
}
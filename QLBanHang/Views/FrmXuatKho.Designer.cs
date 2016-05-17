namespace QLBanHang.Views
{
    partial class FrmXuatKho
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tSPhieuChuyen = new System.Windows.Forms.ToolStrip();
            this.tsTxtMaPhieuChuyen = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnHuyPhieuChuyen = new System.Windows.Forms.ToolStripButton();
            this.tsBtnXemPhieuChuyen = new System.Windows.Forms.ToolStripButton();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.numTongTien = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tSPhieuChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 274);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 412);
            this.splitContainer1.SplitterDistance = 632;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtGhiChu);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.tSPhieuChuyen);
            this.panelMain.Controls.Add(this.cmbNhaCungCap);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.txtNhanVienLap);
            this.panelMain.Controls.Add(this.numTongTien);
            this.panelMain.Controls.Add(this.dtpNgayLap);
            this.panelMain.Controls.Add(this.txtMaPhieu);
            this.panelMain.Controls.Add(this.cmbLoaiPhieu);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelMain.Size = new System.Drawing.Size(1153, 249);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Ghi chú :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(137, 127);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(652, 86);
            this.txtGhiChu.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Phiếu chuyển";
            // 
            // tSPhieuChuyen
            // 
            this.tSPhieuChuyen.AutoSize = false;
            this.tSPhieuChuyen.Dock = System.Windows.Forms.DockStyle.None;
            this.tSPhieuChuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tSPhieuChuyen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSPhieuChuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtMaPhieuChuyen,
            this.tsBtnHuyPhieuChuyen,
            this.tsBtnXemPhieuChuyen});
            this.tSPhieuChuyen.Location = new System.Drawing.Point(552, 51);
            this.tSPhieuChuyen.Name = "tSPhieuChuyen";
            this.tSPhieuChuyen.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tSPhieuChuyen.Size = new System.Drawing.Size(258, 30);
            this.tSPhieuChuyen.TabIndex = 52;
            this.tSPhieuChuyen.Text = "6";
            // 
            // tsTxtMaPhieuChuyen
            // 
            this.tsTxtMaPhieuChuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsTxtMaPhieuChuyen.Name = "tsTxtMaPhieuChuyen";
            this.tsTxtMaPhieuChuyen.Size = new System.Drawing.Size(200, 30);
            // 
            // tsBtnHuyPhieuChuyen
            // 
            this.tsBtnHuyPhieuChuyen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHuyPhieuChuyen.Image = global::QLBanHang.Properties.Resources.DauX;
            this.tsBtnHuyPhieuChuyen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHuyPhieuChuyen.Name = "tsBtnHuyPhieuChuyen";
            this.tsBtnHuyPhieuChuyen.Size = new System.Drawing.Size(23, 27);
            this.tsBtnHuyPhieuChuyen.Text = "toolStripButton1";
            this.tsBtnHuyPhieuChuyen.Click += new System.EventHandler(this.tsBtnHuyPhieuChuyen_Click);
            // 
            // tsBtnXemPhieuChuyen
            // 
            this.tsBtnXemPhieuChuyen.AutoSize = false;
            this.tsBtnXemPhieuChuyen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnXemPhieuChuyen.Image = global::QLBanHang.Properties.Resources.lookup;
            this.tsBtnXemPhieuChuyen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnXemPhieuChuyen.Name = "tsBtnXemPhieuChuyen";
            this.tsBtnXemPhieuChuyen.Size = new System.Drawing.Size(25, 25);
            this.tsBtnXemPhieuChuyen.Text = "toolStripButton1";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(137, 48);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(263, 26);
            this.cmbNhaCungCap.TabIndex = 51;
            this.cmbNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.tSCmbNhaCungCap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Nhà cung cấp ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Ngày lập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nhân viên lập";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Location = new System.Drawing.Point(557, 95);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(220, 24);
            this.txtNhanVienLap.TabIndex = 47;
            // 
            // numTongTien
            // 
            this.numTongTien.Location = new System.Drawing.Point(935, 85);
            this.numTongTien.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numTongTien.Name = "numTongTien";
            this.numTongTien.ReadOnly = true;
            this.numTongTien.Size = new System.Drawing.Size(109, 24);
            this.numTongTien.TabIndex = 46;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(137, 93);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(263, 24);
            this.dtpNgayLap.TabIndex = 45;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(552, 10);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(224, 24);
            this.txtMaPhieu.TabIndex = 44;
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(137, 8);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(263, 26);
            this.cmbLoaiPhieu.TabIndex = 43;
            this.cmbLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhieu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(813, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Loại phiếu";
            // 
            // FrmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 686);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXuatKho";
            this.Text = "FrmXuatKho";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tSPhieuChuyen.ResumeLayout(false);
            this.tSPhieuChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tSPhieuChuyen;
        private System.Windows.Forms.ToolStripTextBox tsTxtMaPhieuChuyen;
        private System.Windows.Forms.ToolStripButton tsBtnHuyPhieuChuyen;
        private System.Windows.Forms.ToolStripButton tsBtnXemPhieuChuyen;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private System.Windows.Forms.NumericUpDown numTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;

    }
}
namespace QLBanHang.Views
{
    partial class FrmChuyenKho
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaDonChuyenKho = new System.Windows.Forms.TextBox();
            this.cmbCuaHangDen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._maVachDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1144, 456);
            this.splitContainer1.SplitterDistance = 467;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.cmbCuaHangDen);
            this.panelMain.Controls.Add(this.txtGhiChu);
            this.panelMain.Controls.Add(this.label17);
            this.panelMain.Controls.Add(this.dtpNgayNhap);
            this.panelMain.Controls.Add(this.label15);
            this.panelMain.Controls.Add(this.label14);
            this.panelMain.Controls.Add(this.txtNhanVien);
            this.panelMain.Controls.Add(this.label13);
            this.panelMain.Controls.Add(this.txtMaDonChuyenKho);
            this.panelMain.Size = new System.Drawing.Size(1144, 213);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(129, 94);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(542, 68);
            this.txtGhiChu.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(23, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Mã đơn :";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Location = new System.Drawing.Point(129, 56);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(196, 26);
            this.dtpNgayNhap.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(366, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Nhân viên :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(23, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Ngày lập :";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVien.Location = new System.Drawing.Point(499, 22);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(196, 26);
            this.txtNhanVien.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(23, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Ghi chú :";
            // 
            // txtMaDonChuyenKho
            // 
            this.txtMaDonChuyenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDonChuyenKho.Location = new System.Drawing.Point(129, 22);
            this.txtMaDonChuyenKho.Name = "txtMaDonChuyenKho";
            this.txtMaDonChuyenKho.Size = new System.Drawing.Size(196, 26);
            this.txtMaDonChuyenKho.TabIndex = 50;
            // 
            // cmbCuaHangDen
            // 
            this.cmbCuaHangDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHangDen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuaHangDen.FormattingEnabled = true;
            this.cmbCuaHangDen.Location = new System.Drawing.Point(499, 57);
            this.cmbCuaHangDen.Name = "cmbCuaHangDen";
            this.cmbCuaHangDen.Size = new System.Drawing.Size(196, 24);
            this.cmbCuaHangDen.TabIndex = 54;
            this.cmbCuaHangDen.SelectedIndexChanged += new System.EventHandler(this.cmbCuaHangDen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(366, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Cửa hàng nhận:";
            // 
            // FrmChuyenKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 694);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChuyenKho";
            this.Text = "FrmChuyenKho";
            ((System.ComponentModel.ISupportInitialize)(this._maVachDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaDonChuyenKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCuaHangDen;

    }
}
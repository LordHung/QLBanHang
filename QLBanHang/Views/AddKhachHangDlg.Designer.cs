namespace QLBanHang.Views
{
    partial class AddKhachHangDlg
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
            this.cmbLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.numTongDiemTL = new System.Windows.Forms.NumericUpDown();
            this.numDTLHienTai = new System.Windows.Forms.NumericUpDown();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtCongNoDauKy = new System.Windows.Forms.TextBox();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.cBNam = new System.Windows.Forms.CheckBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.cmbCuaHang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTongDiemTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDTLHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLoaiKhachHang
            // 
            this.cmbLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLoaiKhachHang.FormattingEnabled = true;
            this.cmbLoaiKhachHang.Location = new System.Drawing.Point(176, 242);
            this.cmbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
            this.cmbLoaiKhachHang.Size = new System.Drawing.Size(273, 24);
            this.cmbLoaiKhachHang.TabIndex = 13;
            this.cmbLoaiKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiKhachHang_SelectedIndexChanged);
            // 
            // numTongDiemTL
            // 
            this.numTongDiemTL.Location = new System.Drawing.Point(178, 326);
            this.numTongDiemTL.Margin = new System.Windows.Forms.Padding(4);
            this.numTongDiemTL.Name = "numTongDiemTL";
            this.numTongDiemTL.ReadOnly = true;
            this.numTongDiemTL.Size = new System.Drawing.Size(186, 22);
            this.numTongDiemTL.TabIndex = 17;
            this.numTongDiemTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDTLHienTai
            // 
            this.numDTLHienTai.Location = new System.Drawing.Point(176, 285);
            this.numDTLHienTai.Margin = new System.Windows.Forms.Padding(4);
            this.numDTLHienTai.Name = "numDTLHienTai";
            this.numDTLHienTai.ReadOnly = true;
            this.numDTLHienTai.Size = new System.Drawing.Size(186, 22);
            this.numDTLHienTai.TabIndex = 15;
            this.numDTLHienTai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(176, 490);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(273, 22);
            this.txtNgayLap.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 407);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(176, 448);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(273, 40);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(176, 367);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(273, 22);
            this.txtDienThoai.TabIndex = 19;
            // 
            // txtCongNoDauKy
            // 
            this.txtCongNoDauKy.ForeColor = System.Drawing.Color.Red;
            this.txtCongNoDauKy.Location = new System.Drawing.Point(176, 203);
            this.txtCongNoDauKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongNoDauKy.Name = "txtCongNoDauKy";
            this.txtCongNoDauKy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCongNoDauKy.Size = new System.Drawing.Size(273, 22);
            this.txtCongNoDauKy.TabIndex = 11;
            this.txtCongNoDauKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNoDauKy.Validated += new System.EventHandler(this.txtCongNoDauKy_Validated);
            // 
            // txtCongNo
            // 
            this.txtCongNo.ForeColor = System.Drawing.Color.Red;
            this.txtCongNo.Location = new System.Drawing.Point(176, 160);
            this.txtCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCongNo.Size = new System.Drawing.Size(273, 22);
            this.txtCongNo.TabIndex = 9;
            this.txtCongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCongNo_KeyPress);
            this.txtCongNo.Validated += new System.EventHandler(this.txtCongNo_Validated);
            // 
            // cBNam
            // 
            this.cBNam.AutoSize = true;
            this.cBNam.Location = new System.Drawing.Point(180, 127);
            this.cBNam.Margin = new System.Windows.Forms.Padding(4);
            this.cBNam.Name = "cBNam";
            this.cBNam.Size = new System.Drawing.Size(56, 20);
            this.cBNam.TabIndex = 7;
            this.cBNam.Text = "Nam";
            this.cBNam.UseVisualStyleBackColor = true;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(180, 87);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(273, 22);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // cmbCuaHang
            // 
            this.cmbCuaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCuaHang.FormattingEnabled = true;
            this.cmbCuaHang.Location = new System.Drawing.Point(180, 11);
            this.cmbCuaHang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCuaHang.Name = "cmbCuaHang";
            this.cmbCuaHang.Size = new System.Drawing.Size(273, 24);
            this.cmbCuaHang.TabIndex = 1;
            this.cmbCuaHang.SelectedIndexChanged += new System.EventHandler(this.cmbCuaHang_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 493);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ngày Lập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 452);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Địa Chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 411);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Điện Thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng ĐTL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ĐTL Hiện Tại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Loại Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cộng Nợ Đầu Kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Công Nợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa Hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(180, 48);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(273, 22);
            this.txtMaKhachHang.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(154, 536);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 49);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AddKhachHangDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 594);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbLoaiKhachHang);
            this.Controls.Add(this.numTongDiemTL);
            this.Controls.Add(this.numDTLHienTai);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtCongNoDauKy);
            this.Controls.Add(this.txtCongNo);
            this.Controls.Add(this.cBNam);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.cmbCuaHang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddKhachHangDlg";
            this.Text = "AddKhachHangDlg";
            this.Load += new System.EventHandler(this.AddKhachHangDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTongDiemTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDTLHienTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLoaiKhachHang;
        private System.Windows.Forms.NumericUpDown numTongDiemTL;
        private System.Windows.Forms.NumericUpDown numDTLHienTai;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtCongNoDauKy;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.CheckBox cBNam;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ComboBox cmbCuaHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Button btnThem;

    }
}
namespace QLBanHang.Views
{
    partial class AddNhanVienDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCuaHang = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.ckToanQuyen = new System.Windows.Forms.CheckBox();
            this.ckValid = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa hàng*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toàn quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hợp lệ";
            // 
            // cmbCuaHang
            // 
            this.cmbCuaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuaHang.FormattingEnabled = true;
            this.cmbCuaHang.Location = new System.Drawing.Point(141, 40);
            this.cmbCuaHang.Name = "cmbCuaHang";
            this.cmbCuaHang.Size = new System.Drawing.Size(269, 26);
            this.cmbCuaHang.TabIndex = 7;
            this.cmbCuaHang.SelectedIndexChanged += new System.EventHandler(this.cmbCuaHang_SelectedIndexChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(141, 93);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(269, 24);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(141, 136);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(269, 24);
            this.txtMatKhau.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(141, 181);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(269, 24);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(141, 234);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(269, 24);
            this.txtChucVu.TabIndex = 11;
            // 
            // ckToanQuyen
            // 
            this.ckToanQuyen.AutoSize = true;
            this.ckToanQuyen.Location = new System.Drawing.Point(141, 290);
            this.ckToanQuyen.Name = "ckToanQuyen";
            this.ckToanQuyen.Size = new System.Drawing.Size(177, 22);
            this.ckToanQuyen.TabIndex = 12;
            this.ckToanQuyen.Text = "Checked là toàn quyền";
            this.ckToanQuyen.UseVisualStyleBackColor = true;
            // 
            // ckValid
            // 
            this.ckValid.AutoSize = true;
            this.ckValid.Location = new System.Drawing.Point(141, 334);
            this.ckValid.Name = "ckValid";
            this.ckValid.Size = new System.Drawing.Size(58, 22);
            this.ckValid.TabIndex = 13;
            this.ckValid.Text = "Valid";
            this.ckValid.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(141, 381);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 22);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(154, 436);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 56);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AddNhanVienDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 504);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.ckValid);
            this.Controls.Add(this.ckToanQuyen);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cmbCuaHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNhanVienDlg";
            this.Text = "AddNhanVienDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCuaHang;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.CheckBox ckToanQuyen;
        private System.Windows.Forms.CheckBox ckValid;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnThem;
    }
}
namespace QLBanHang.Views
{
    partial class FrmThongKeHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbCuaHang = new System.Windows.Forms.ComboBox();
            this.ckBoxTheoKhachHang = new System.Windows.Forms.CheckBox();
            this.ckBoxTheoNhanVien = new System.Windows.Forms.CheckBox();
            this.ckBoxTheoCuaHang = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgViewThongKe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cmbLoaiHoaDon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbKhachHang);
            this.panel1.Controls.Add(this.cmbNhanVien);
            this.panel1.Controls.Add(this.cmbCuaHang);
            this.panel1.Controls.Add(this.ckBoxTheoKhachHang);
            this.panel1.Controls.Add(this.ckBoxTheoNhanVien);
            this.panel1.Controls.Add(this.ckBoxTheoCuaHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 759);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(44, 614);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(247, 75);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbLoaiHoaDon
            // 
            this.cmbLoaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiHoaDon.FormattingEnabled = true;
            this.cmbLoaiHoaDon.Location = new System.Drawing.Point(32, 560);
            this.cmbLoaiHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLoaiHoaDon.Name = "cmbLoaiHoaDon";
            this.cmbLoaiHoaDon.Size = new System.Drawing.Size(176, 26);
            this.cmbLoaiHoaDon.TabIndex = 23;
            this.cmbLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHoaDon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại hóa đơn :";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.Enabled = false;
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(32, 459);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(176, 26);
            this.cmbKhachHang.TabIndex = 21;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(32, 345);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(176, 26);
            this.cmbNhanVien.TabIndex = 20;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // cmbCuaHang
            // 
            this.cmbCuaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHang.Enabled = false;
            this.cmbCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuaHang.FormattingEnabled = true;
            this.cmbCuaHang.Location = new System.Drawing.Point(32, 240);
            this.cmbCuaHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCuaHang.Name = "cmbCuaHang";
            this.cmbCuaHang.Size = new System.Drawing.Size(176, 26);
            this.cmbCuaHang.TabIndex = 19;
            this.cmbCuaHang.SelectedIndexChanged += new System.EventHandler(this.cmbCuaHang_SelectedIndexChanged);
            // 
            // ckBoxTheoKhachHang
            // 
            this.ckBoxTheoKhachHang.AutoSize = true;
            this.ckBoxTheoKhachHang.Location = new System.Drawing.Point(32, 402);
            this.ckBoxTheoKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBoxTheoKhachHang.Name = "ckBoxTheoKhachHang";
            this.ckBoxTheoKhachHang.Size = new System.Drawing.Size(141, 22);
            this.ckBoxTheoKhachHang.TabIndex = 18;
            this.ckBoxTheoKhachHang.Text = "Theo khách hàng";
            this.ckBoxTheoKhachHang.UseVisualStyleBackColor = true;
            this.ckBoxTheoKhachHang.CheckedChanged += new System.EventHandler(this.ckBoxTheoKhachHang_CheckedChanged);
            // 
            // ckBoxTheoNhanVien
            // 
            this.ckBoxTheoNhanVien.AutoSize = true;
            this.ckBoxTheoNhanVien.Location = new System.Drawing.Point(32, 299);
            this.ckBoxTheoNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBoxTheoNhanVien.Name = "ckBoxTheoNhanVien";
            this.ckBoxTheoNhanVien.Size = new System.Drawing.Size(127, 22);
            this.ckBoxTheoNhanVien.TabIndex = 17;
            this.ckBoxTheoNhanVien.Text = "Theo nhân viên";
            this.ckBoxTheoNhanVien.UseVisualStyleBackColor = true;
            this.ckBoxTheoNhanVien.CheckedChanged += new System.EventHandler(this.ckBoxTheoNhanVien_CheckedChanged);
            // 
            // ckBoxTheoCuaHang
            // 
            this.ckBoxTheoCuaHang.AutoSize = true;
            this.ckBoxTheoCuaHang.Location = new System.Drawing.Point(32, 199);
            this.ckBoxTheoCuaHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBoxTheoCuaHang.Name = "ckBoxTheoCuaHang";
            this.ckBoxTheoCuaHang.Size = new System.Drawing.Size(125, 22);
            this.ckBoxTheoCuaHang.TabIndex = 16;
            this.ckBoxTheoCuaHang.Text = "Theo cửa hàng";
            this.ckBoxTheoCuaHang.UseVisualStyleBackColor = true;
            this.ckBoxTheoCuaHang.CheckedChanged += new System.EventHandler(this.ckBoxTheoCuaHang_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Từ ngày :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(104, 111);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(201, 24);
            this.dtpToDate.TabIndex = 12;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(104, 46);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(201, 24);
            this.dtpFromDate.TabIndex = 13;
            // 
            // dgViewThongKe
            // 
            this.dgViewThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewThongKe.Location = new System.Drawing.Point(332, 0);
            this.dgViewThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgViewThongKe.MultiSelect = false;
            this.dgViewThongKe.Name = "dgViewThongKe";
            this.dgViewThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewThongKe.Size = new System.Drawing.Size(902, 759);
            this.dgViewThongKe.TabIndex = 2;
            // 
            // FrmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 759);
            this.Controls.Add(this.dgViewThongKe);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmThongKeHoaDon";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKeHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbLoaiHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbCuaHang;
        private System.Windows.Forms.CheckBox ckBoxTheoKhachHang;
        private System.Windows.Forms.CheckBox ckBoxTheoNhanVien;
        private System.Windows.Forms.CheckBox ckBoxTheoCuaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView dgViewThongKe;


    }
}
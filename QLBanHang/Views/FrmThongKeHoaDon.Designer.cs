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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ckBoxTheoCuaHang = new System.Windows.Forms.CheckBox();
            this.ckBoxTheoNhanVien = new System.Windows.Forms.CheckBox();
            this.ckBoxTheoKhachHang = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBoxLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.dgViewThongTinHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThongTinHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmBoxLoaiHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ckBoxTheoKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.ckBoxTheoNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.ckBoxTheoCuaHang);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgViewThongTinHoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 684);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(86, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ckBoxTheoCuaHang
            // 
            this.ckBoxTheoCuaHang.AutoSize = true;
            this.ckBoxTheoCuaHang.Location = new System.Drawing.Point(16, 181);
            this.ckBoxTheoCuaHang.Name = "ckBoxTheoCuaHang";
            this.ckBoxTheoCuaHang.Size = new System.Drawing.Size(99, 17);
            this.ckBoxTheoCuaHang.TabIndex = 3;
            this.ckBoxTheoCuaHang.Text = "Theo cửa hàng";
            this.ckBoxTheoCuaHang.UseVisualStyleBackColor = true;
            // 
            // ckBoxTheoNhanVien
            // 
            this.ckBoxTheoNhanVien.AutoSize = true;
            this.ckBoxTheoNhanVien.Location = new System.Drawing.Point(16, 262);
            this.ckBoxTheoNhanVien.Name = "ckBoxTheoNhanVien";
            this.ckBoxTheoNhanVien.Size = new System.Drawing.Size(101, 17);
            this.ckBoxTheoNhanVien.TabIndex = 4;
            this.ckBoxTheoNhanVien.Text = "Theo nhân viên";
            this.ckBoxTheoNhanVien.UseVisualStyleBackColor = true;
            // 
            // ckBoxTheoKhachHang
            // 
            this.ckBoxTheoKhachHang.AutoSize = true;
            this.ckBoxTheoKhachHang.Location = new System.Drawing.Point(16, 346);
            this.ckBoxTheoKhachHang.Name = "ckBoxTheoKhachHang";
            this.ckBoxTheoKhachHang.Size = new System.Drawing.Size(111, 17);
            this.ckBoxTheoKhachHang.TabIndex = 5;
            this.ckBoxTheoKhachHang.Text = "Theo khách hàng";
            this.ckBoxTheoKhachHang.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 392);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(181, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại hóa đơn :";
            // 
            // cmBoxLoaiHoaDon
            // 
            this.cmBoxLoaiHoaDon.FormattingEnabled = true;
            this.cmBoxLoaiHoaDon.Location = new System.Drawing.Point(16, 474);
            this.cmBoxLoaiHoaDon.Name = "cmBoxLoaiHoaDon";
            this.cmBoxLoaiHoaDon.Size = new System.Drawing.Size(181, 21);
            this.cmBoxLoaiHoaDon.TabIndex = 10;
            // 
            // dgViewThongTinHoaDon
            // 
            this.dgViewThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewThongTinHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgViewThongTinHoaDon.Name = "dgViewThongTinHoaDon";
            this.dgViewThongTinHoaDon.Size = new System.Drawing.Size(829, 684);
            this.dgViewThongTinHoaDon.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 684);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewThongTinHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox ckBoxTheoKhachHang;
        private System.Windows.Forms.CheckBox ckBoxTheoNhanVien;
        private System.Windows.Forms.CheckBox ckBoxTheoCuaHang;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBoxLoaiHoaDon;
        private System.Windows.Forms.DataGridView dgViewThongTinHoaDon;

    }
}
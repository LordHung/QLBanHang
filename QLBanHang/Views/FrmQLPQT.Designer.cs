namespace QLBanHang.Views
{
    partial class FrmQLPQT
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
            this.txtMaVach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.numTriGia = new System.Windows.Forms.NumericUpDown();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.ckPhieuDoiDiem = new System.Windows.Forms.CheckBox();
            this.ckPhieuQuaTang = new System.Windows.Forms.CheckBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySD = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTriGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgaySD);
            this.panel1.Controls.Add(this.dtpNgayTao);
            this.panel1.Controls.Add(this.ckPhieuQuaTang);
            this.panel1.Controls.Add(this.ckPhieuDoiDiem);
            this.panel1.Controls.Add(this.cmbKhachHang);
            this.panel1.Controls.Add(this.numTriGia);
            this.panel1.Controls.Add(this.dtpHSD);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaVach);
            // 
            // txtMaVach
            // 
            this.txtMaVach.Location = new System.Drawing.Point(118, 104);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.ReadOnly = true;
            this.txtMaVach.Size = new System.Drawing.Size(187, 22);
            this.txtMaVach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Vạch*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trị Giá*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Tạo*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày SD*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "HSD*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(118, 398);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(187, 88);
            this.txtMoTa.TabIndex = 8;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Location = new System.Drawing.Point(118, 339);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(187, 22);
            this.dtpHSD.TabIndex = 11;
            // 
            // numTriGia
            // 
            this.numTriGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTriGia.Location = new System.Drawing.Point(118, 167);
            this.numTriGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTriGia.Name = "numTriGia";
            this.numTriGia.Size = new System.Drawing.Size(187, 22);
            this.numTriGia.TabIndex = 12;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(118, 53);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(187, 24);
            this.cmbKhachHang.TabIndex = 13;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // ckPhieuDoiDiem
            // 
            this.ckPhieuDoiDiem.AutoSize = true;
            this.ckPhieuDoiDiem.Location = new System.Drawing.Point(26, 16);
            this.ckPhieuDoiDiem.Name = "ckPhieuDoiDiem";
            this.ckPhieuDoiDiem.Size = new System.Drawing.Size(116, 20);
            this.ckPhieuDoiDiem.TabIndex = 14;
            this.ckPhieuDoiDiem.Text = "Phiếu đổi điểm";
            this.ckPhieuDoiDiem.UseVisualStyleBackColor = true;
            this.ckPhieuDoiDiem.CheckedChanged += new System.EventHandler(this.ckPhieuDoiDiem_CheckedChanged);
            // 
            // ckPhieuQuaTang
            // 
            this.ckPhieuQuaTang.AutoSize = true;
            this.ckPhieuQuaTang.Location = new System.Drawing.Point(148, 16);
            this.ckPhieuQuaTang.Name = "ckPhieuQuaTang";
            this.ckPhieuQuaTang.Size = new System.Drawing.Size(116, 20);
            this.ckPhieuQuaTang.TabIndex = 15;
            this.ckPhieuQuaTang.Text = "Phiếu quà tặng";
            this.ckPhieuQuaTang.UseVisualStyleBackColor = true;
            this.ckPhieuQuaTang.CheckedChanged += new System.EventHandler(this.ckPhieuQuaTang_CheckedChanged);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Location = new System.Drawing.Point(118, 226);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(187, 22);
            this.dtpNgayTao.TabIndex = 16;
            // 
            // dtpNgaySD
            // 
            this.dtpNgaySD.Location = new System.Drawing.Point(118, 281);
            this.dtpNgaySD.Name = "dtpNgaySD";
            this.dtpNgaySD.ShowCheckBox = true;
            this.dtpNgaySD.Size = new System.Drawing.Size(187, 22);
            this.dtpNgaySD.TabIndex = 17;
            // 
            // FrmQLPQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 817);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FrmQLPQT";
            this.Text = "FormQLPQT";
            this.Load += new System.EventHandler(this.FrmQLPQT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTriGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaVach;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.NumericUpDown numTriGia;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.CheckBox ckPhieuQuaTang;
        private System.Windows.Forms.CheckBox ckPhieuDoiDiem;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgaySD;

    }
}
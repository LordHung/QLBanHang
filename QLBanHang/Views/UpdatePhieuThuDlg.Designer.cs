namespace QLBanHang.Views
{
    partial class UpdatePhieuThuDlg
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtChungTuKem = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtTenNguoiNop = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.numSoTien = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 61);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Thêm";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtChungTuKem
            // 
            this.txtChungTuKem.Location = new System.Drawing.Point(191, 345);
            this.txtChungTuKem.Name = "txtChungTuKem";
            this.txtChungTuKem.Size = new System.Drawing.Size(356, 29);
            this.txtChungTuKem.TabIndex = 45;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(191, 273);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(356, 65);
            this.txtLyDo.TabIndex = 44;
            // 
            // txtTenNguoiNop
            // 
            this.txtTenNguoiNop.Location = new System.Drawing.Point(191, 109);
            this.txtTenNguoiNop.Name = "txtTenNguoiNop";
            this.txtTenNguoiNop.Size = new System.Drawing.Size(356, 29);
            this.txtTenNguoiNop.TabIndex = 43;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(191, 148);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(356, 84);
            this.txtDiaChi.TabIndex = 42;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(191, 22);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(356, 29);
            this.txtMaPhieu.TabIndex = 41;
            // 
            // numSoTien
            // 
            this.numSoTien.ForeColor = System.Drawing.Color.Red;
            this.numSoTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoTien.Location = new System.Drawing.Point(191, 238);
            this.numSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numSoTien.Name = "numSoTien";
            this.numSoTien.Size = new System.Drawing.Size(356, 29);
            this.numSoTien.TabIndex = 40;
            this.numSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Location = new System.Drawing.Point(191, 71);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(356, 29);
            this.dtpNgayThu.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Chứng Từ Kèm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lý Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Người Nộp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày Thu";
            // 
            // UpdatePhieuThuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 465);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtChungTuKem);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtTenNguoiNop);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.numSoTien);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdatePhieuThuDlg";
            this.Text = "UpdatePhieuThuDlg";
            this.Load += new System.EventHandler(this.UpdatePhieuThuDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtChungTuKem;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtTenNguoiNop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.NumericUpDown numSoTien;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

    }
}
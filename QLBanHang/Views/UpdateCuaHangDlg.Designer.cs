namespace QLBanHang.Views
{
    partial class UpdateCuaHangDlg
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtQuanLy = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtTenCuaHangTrenBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThongTinTrenBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(309, 20);
            this.txtTen.TabIndex = 23;
            // 
            // txtQuanLy
            // 
            this.txtQuanLy.Location = new System.Drawing.Point(121, 106);
            this.txtQuanLy.Name = "txtQuanLy";
            this.txtQuanLy.Size = new System.Drawing.Size(309, 20);
            this.txtQuanLy.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(121, 140);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(309, 20);
            this.txtSDT.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(121, 180);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(309, 92);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(121, 40);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(309, 20);
            this.txtMa.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(165, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(129, 135);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(199, 159);
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // txtTenCuaHangTrenBill
            // 
            this.txtTenCuaHangTrenBill.Location = new System.Drawing.Point(129, 32);
            this.txtTenCuaHangTrenBill.Name = "txtTenCuaHangTrenBill";
            this.txtTenCuaHangTrenBill.Size = new System.Drawing.Size(309, 20);
            this.txtTenCuaHangTrenBill.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Logo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thông tin liên hệ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên cửa hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.txtTenCuaHangTrenBill);
            this.groupBox1.Controls.Add(this.txtThongTinTrenBill);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(-8, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 311);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trên hóa đơn";
            // 
            // txtThongTinTrenBill
            // 
            this.txtThongTinTrenBill.Location = new System.Drawing.Point(129, 58);
            this.txtThongTinTrenBill.Multiline = true;
            this.txtThongTinTrenBill.Name = "txtThongTinTrenBill";
            this.txtThongTinTrenBill.Size = new System.Drawing.Size(309, 71);
            this.txtThongTinTrenBill.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Người quản lý :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên cửa hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã cửa hàng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UpdateCuaHangDlg
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 641);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtQuanLy);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCuaHangDlg";
            this.Text = "UpdateCuaHangDlg";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtQuanLy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtTenCuaHangTrenBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThongTinTrenBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
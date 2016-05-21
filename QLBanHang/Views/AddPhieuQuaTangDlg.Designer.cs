namespace QLBanHang.Views
{
    partial class AddPhieuQuaTangDlg
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
            this.dtpNgaySD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.ckPhieuQuaTang = new System.Windows.Forms.CheckBox();
            this.ckPhieuDoiDiem = new System.Windows.Forms.CheckBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.numTriGia = new System.Windows.Forms.NumericUpDown();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaVach = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTriGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySD
            // 
            this.dtpNgaySD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySD.Location = new System.Drawing.Point(131, 185);
            this.dtpNgaySD.Name = "dtpNgaySD";
            this.dtpNgaySD.ShowCheckBox = true;
            this.dtpNgaySD.Size = new System.Drawing.Size(238, 22);
            this.dtpNgaySD.TabIndex = 33;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayTao.Location = new System.Drawing.Point(131, 153);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(238, 22);
            this.dtpNgayTao.TabIndex = 32;
            // 
            // ckPhieuQuaTang
            // 
            this.ckPhieuQuaTang.AutoSize = true;
            this.ckPhieuQuaTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckPhieuQuaTang.Location = new System.Drawing.Point(187, 12);
            this.ckPhieuQuaTang.Name = "ckPhieuQuaTang";
            this.ckPhieuQuaTang.Size = new System.Drawing.Size(116, 20);
            this.ckPhieuQuaTang.TabIndex = 31;
            this.ckPhieuQuaTang.Text = "Phiếu quà tặng";
            this.ckPhieuQuaTang.UseVisualStyleBackColor = true;
            this.ckPhieuQuaTang.CheckedChanged += new System.EventHandler(this.ckPhieuQuaTang_CheckedChanged);
            // 
            // ckPhieuDoiDiem
            // 
            this.ckPhieuDoiDiem.AutoSize = true;
            this.ckPhieuDoiDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckPhieuDoiDiem.Location = new System.Drawing.Point(38, 12);
            this.ckPhieuDoiDiem.Name = "ckPhieuDoiDiem";
            this.ckPhieuDoiDiem.Size = new System.Drawing.Size(116, 20);
            this.ckPhieuDoiDiem.TabIndex = 30;
            this.ckPhieuDoiDiem.Text = "Phiếu đổi điểm";
            this.ckPhieuDoiDiem.UseVisualStyleBackColor = true;
            this.ckPhieuDoiDiem.CheckedChanged += new System.EventHandler(this.ckPhieuDoiDiem_CheckedChanged);
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(130, 49);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(238, 24);
            this.cmbKhachHang.TabIndex = 29;
            // 
            // numTriGia
            // 
            this.numTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numTriGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTriGia.Location = new System.Drawing.Point(131, 118);
            this.numTriGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTriGia.Name = "numTriGia";
            this.numTriGia.Size = new System.Drawing.Size(238, 22);
            this.numTriGia.TabIndex = 28;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpHSD.Location = new System.Drawing.Point(131, 221);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(238, 22);
            this.dtpHSD.TabIndex = 27;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.Location = new System.Drawing.Point(131, 258);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(238, 88);
            this.txtMoTa.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(25, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(25, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "HSD*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày SD*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày Tạo*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Trị Giá*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Vạch*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Khách Hàng*";
            // 
            // txtMaVach
            // 
            this.txtMaVach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaVach.Location = new System.Drawing.Point(131, 82);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.ReadOnly = true;
            this.txtMaVach.Size = new System.Drawing.Size(238, 22);
            this.txtMaVach.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 51);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddPhieuQuaTangDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 442);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpNgaySD);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.ckPhieuQuaTang);
            this.Controls.Add(this.ckPhieuDoiDiem);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.numTriGia);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaVach);
            this.Name = "AddPhieuQuaTangDlg";
            this.Text = "AddPhieuQuaTangDlg";
            ((System.ComponentModel.ISupportInitialize)(this.numTriGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySD;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.CheckBox ckPhieuQuaTang;
        private System.Windows.Forms.CheckBox ckPhieuDoiDiem;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.NumericUpDown numTriGia;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaVach;
        private System.Windows.Forms.Button btnAdd;

    }
}
namespace QLBanHang.Views
{
    partial class FrmSanPham
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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.cmbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.cmbNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.cmbNhaSanXuat);
            this.panel1.Controls.Add(this.txtDonVi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaSanPham);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbLoaiSanPham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Size = new System.Drawing.Size(300, 700);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(104, 211);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(192, 109);
            this.txtMoTa.TabIndex = 25;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(105, 170);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(192, 22);
            this.txtDonVi.TabIndex = 24;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(104, 137);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(192, 22);
            this.txtTenSanPham.TabIndex = 23;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(104, 96);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(192, 22);
            this.txtMaSanPham.TabIndex = 22;
            // 
            // cmbLoaiSanPham
            // 
            this.cmbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiSanPham.FormattingEnabled = true;
            this.cmbLoaiSanPham.Location = new System.Drawing.Point(104, 52);
            this.cmbLoaiSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiSanPham.Name = "cmbLoaiSanPham";
            this.cmbLoaiSanPham.Size = new System.Drawing.Size(192, 24);
            this.cmbLoaiSanPham.TabIndex = 21;
            this.cmbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSanPham_SelectedIndexChanged);
            // 
            // cmbNhaSanXuat
            // 
            this.cmbNhaSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaSanXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNhaSanXuat.FormattingEnabled = true;
            this.cmbNhaSanXuat.Location = new System.Drawing.Point(104, 16);
            this.cmbNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNhaSanXuat.Name = "cmbNhaSanXuat";
            this.cmbNhaSanXuat.Size = new System.Drawing.Size(192, 24);
            this.cmbNhaSanXuat.TabIndex = 20;
            this.cmbNhaSanXuat.SelectedIndexChanged += new System.EventHandler(this.cmbNhaSanXuat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mô Tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Đơn Vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhà Sản Xuất";
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 725);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cmbNhaSanXuat;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
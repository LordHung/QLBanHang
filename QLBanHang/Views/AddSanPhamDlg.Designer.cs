namespace QLBanHang.Views
{
    partial class AddSanPhamDlg
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.cmbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà Sản Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn Vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mô Tả";
            // 
            // cmbNhaSanXuat
            // 
            this.cmbNhaSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaSanXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNhaSanXuat.FormattingEnabled = true;
            this.cmbNhaSanXuat.Location = new System.Drawing.Point(144, 36);
            this.cmbNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNhaSanXuat.Name = "cmbNhaSanXuat";
            this.cmbNhaSanXuat.Size = new System.Drawing.Size(307, 24);
            this.cmbNhaSanXuat.TabIndex = 8;
            this.cmbNhaSanXuat.SelectedIndexChanged += new System.EventHandler(this.cmbNhaSanXuat_SelectedIndexChanged);
            // 
            // cmbLoaiSanPham
            // 
            this.cmbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiSanPham.FormattingEnabled = true;
            this.cmbLoaiSanPham.Location = new System.Drawing.Point(144, 72);
            this.cmbLoaiSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiSanPham.Name = "cmbLoaiSanPham";
            this.cmbLoaiSanPham.Size = new System.Drawing.Size(307, 24);
            this.cmbLoaiSanPham.TabIndex = 9;
            this.cmbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSanPham_SelectedIndexChanged);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(144, 116);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(307, 22);
            this.txtMaSanPham.TabIndex = 10;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(144, 157);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(307, 22);
            this.txtTenSanPham.TabIndex = 11;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(145, 190);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(307, 22);
            this.txtDonVi.TabIndex = 12;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(144, 231);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(307, 109);
            this.txtMoTa.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(144, 353);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 54);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSanPhamDlg
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 427);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.cmbLoaiSanPham);
            this.Controls.Add(this.cmbNhaSanXuat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSanPhamDlg";
            this.Text = "AddSanPhamDlg";
            this.Load += new System.EventHandler(this.AddSanPhamDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNhaSanXuat;
        private System.Windows.Forms.ComboBox cmbLoaiSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnAdd;
    }
}
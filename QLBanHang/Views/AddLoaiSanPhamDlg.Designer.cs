namespace QLBanHang.Views
{
    partial class AddLoaiSanPhamDlg
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
            this.cmbNganh = new System.Windows.Forms.ComboBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngành * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô Tả";
            // 
            // cmbNganh
            // 
            this.cmbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNganh.FormattingEnabled = true;
            this.cmbNganh.Location = new System.Drawing.Point(116, 48);
            this.cmbNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNganh.Name = "cmbNganh";
            this.cmbNganh.Size = new System.Drawing.Size(333, 28);
            this.cmbNganh.TabIndex = 1;
            this.cmbNganh.SelectedIndexChanged += new System.EventHandler(this.cmbNganh_SelectedIndexChanged);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(116, 93);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(333, 26);
            this.txtMaLoai.TabIndex = 3;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(116, 140);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(333, 26);
            this.txtTenLoai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(116, 195);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(333, 127);
            this.txtMoTa.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(166, 332);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 75);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddLoaiSanPhamDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 424);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.cmbNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddLoaiSanPhamDlg";
            this.Text = "AddNhomHangDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNganh;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnAdd;
    }
}
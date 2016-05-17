namespace QLBanHang.Views
{
    partial class AddNhaCungCapDlg
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodeNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCongNoDauKi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Công nợ đầu kì";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên nhà cung cấp";
            // 
            // txtCodeNhaCungCap
            // 
            this.txtCodeNhaCungCap.Location = new System.Drawing.Point(163, 20);
            this.txtCodeNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeNhaCungCap.Name = "txtCodeNhaCungCap";
            this.txtCodeNhaCungCap.Size = new System.Drawing.Size(350, 24);
            this.txtCodeNhaCungCap.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(163, 342);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(350, 88);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtCongNoDauKi
            // 
            this.txtCongNoDauKi.Location = new System.Drawing.Point(163, 207);
            this.txtCongNoDauKi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongNoDauKi.Name = "txtCongNoDauKi";
            this.txtCongNoDauKi.Size = new System.Drawing.Size(350, 24);
            this.txtCongNoDauKi.TabIndex = 7;
            this.txtCongNoDauKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNoDauKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCongNoDauKi_KeyPress);
            this.txtCongNoDauKi.Validated += new System.EventHandler(this.txtCongNoDauKi_Validated);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(163, 271);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(350, 24);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(163, 82);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(350, 24);
            this.txtTenNhaCungCap.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(182, 438);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 63);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCongNo
            // 
            this.txtCongNo.Location = new System.Drawing.Point(163, 140);
            this.txtCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.Size = new System.Drawing.Size(350, 24);
            this.txtCongNo.TabIndex = 5;
            this.txtCongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCongNo_KeyPress);
            this.txtCongNo.Validated += new System.EventHandler(this.txtCongNo_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Công nợ";
            // 
            // AddNhaCungCapDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 533);
            this.Controls.Add(this.txtCongNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCongNoDauKi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCodeNhaCungCap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNhaCungCapDlg";
            this.Text = "AddNhaCungCapDlg";
            this.Load += new System.EventHandler(this.AddNhaCungCapDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodeNhaCungCap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCongNoDauKi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.Label label3;
    }
}
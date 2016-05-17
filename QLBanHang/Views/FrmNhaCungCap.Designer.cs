namespace QLBanHang.Views
{
    partial class FrmNhaCungCap
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
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCongNoDauKi = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCodeNhaCungCap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCongNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNhaCungCap);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtCongNoDauKi);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtCodeNhaCungCap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(382, 792);
            this.panel1.TabIndex = 1;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(123, 82);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(244, 22);
            this.txtTenNhaCungCap.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(122, 276);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(244, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // txtCongNoDauKi
            // 
            this.txtCongNoDauKi.Location = new System.Drawing.Point(122, 207);
            this.txtCongNoDauKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCongNoDauKi.Name = "txtCongNoDauKi";
            this.txtCongNoDauKi.Size = new System.Drawing.Size(244, 22);
            this.txtCongNoDauKi.TabIndex = 7;
            this.txtCongNoDauKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNoDauKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCongNoDauKi_KeyPress);
            this.txtCongNoDauKi.Validated += new System.EventHandler(this.txtCongNoDauKi_Validated);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(122, 338);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 112);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtCodeNhaCungCap
            // 
            this.txtCodeNhaCungCap.Location = new System.Drawing.Point(123, 26);
            this.txtCodeNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodeNhaCungCap.Name = "txtCodeNhaCungCap";
            this.txtCodeNhaCungCap.Size = new System.Drawing.Size(244, 22);
            this.txtCodeNhaCungCap.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Công nợ đầu kì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // txtCongNo
            // 
            this.txtCongNo.Location = new System.Drawing.Point(123, 148);
            this.txtCongNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.Size = new System.Drawing.Size(244, 22);
            this.txtCongNo.TabIndex = 5;
            this.txtCongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCongNo_KeyPress);
            this.txtCongNo.Validated += new System.EventHandler(this.txtCongNo_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Công nợ";
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 817);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmNhaCungCap";
            this.Text = "FrmNhaCungCap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCongNoDauKi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCodeNhaCungCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.Label label3;

    }
}
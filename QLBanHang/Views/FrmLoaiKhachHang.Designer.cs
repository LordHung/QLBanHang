namespace QLBanHang.Views
{
    partial class FrmLoaiKhachHang
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
            this.txtLoaiThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.numTiLeQuyDoi = new System.Windows.Forms.NumericUpDown();
            this.numNguong = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiLeQuyDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNguong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numNguong);
            this.panel1.Controls.Add(this.numTiLeQuyDoi);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLoaiThe);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(423, 651);
            this.panel1.TabIndex = 2;
            // 
            // txtLoaiThe
            // 
            this.txtLoaiThe.Location = new System.Drawing.Point(141, 31);
            this.txtLoaiThe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoaiThe.Name = "txtLoaiThe";
            this.txtLoaiThe.Size = new System.Drawing.Size(233, 22);
            this.txtLoaiThe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quy Đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngưỡng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô Tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(141, 203);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(233, 93);
            this.txtMoTa.TabIndex = 7;
            // 
            // numTiLeQuyDoi
            // 
            this.numTiLeQuyDoi.Location = new System.Drawing.Point(141, 86);
            this.numTiLeQuyDoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTiLeQuyDoi.Name = "numTiLeQuyDoi";
            this.numTiLeQuyDoi.Size = new System.Drawing.Size(160, 22);
            this.numTiLeQuyDoi.TabIndex = 3;
            // 
            // numNguong
            // 
            this.numNguong.Location = new System.Drawing.Point(141, 143);
            this.numNguong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNguong.Name = "numNguong";
            this.numNguong.Size = new System.Drawing.Size(160, 22);
            this.numNguong.TabIndex = 5;
            // 
            // FrmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 676);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmLoaiKhachHang";
            this.Text = "FrmLoaiKhachHang";
            this.Load += new System.EventHandler(this.FrmLoaiKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiLeQuyDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiThe;
        private System.Windows.Forms.NumericUpDown numNguong;
        private System.Windows.Forms.NumericUpDown numTiLeQuyDoi;
    }
}
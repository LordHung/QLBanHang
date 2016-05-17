namespace QLBanHang.Views
{
    partial class AddLoaiKhachHangDlg
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.numNguong = new System.Windows.Forms.NumericUpDown();
            this.numTiLeQuyDoi = new System.Windows.Forms.NumericUpDown();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiThe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNguong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiLeQuyDoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numNguong
            // 
            this.numNguong.Location = new System.Drawing.Point(123, 133);
            this.numNguong.Name = "numNguong";
            this.numNguong.Size = new System.Drawing.Size(207, 29);
            this.numNguong.TabIndex = 5;
            // 
            // numTiLeQuyDoi
            // 
            this.numTiLeQuyDoi.Location = new System.Drawing.Point(123, 87);
            this.numTiLeQuyDoi.Name = "numTiLeQuyDoi";
            this.numTiLeQuyDoi.Size = new System.Drawing.Size(207, 29);
            this.numTiLeQuyDoi.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(123, 182);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(263, 76);
            this.txtMoTa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô Tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngưỡng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quy Đổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọai";
            // 
            // txtLoaiThe
            // 
            this.txtLoaiThe.Location = new System.Drawing.Point(123, 42);
            this.txtLoaiThe.Name = "txtLoaiThe";
            this.txtLoaiThe.Size = new System.Drawing.Size(263, 29);
            this.txtLoaiThe.TabIndex = 1;
            // 
            // AddLoaiKhachHangDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 366);
            this.Controls.Add(this.numNguong);
            this.Controls.Add(this.numTiLeQuyDoi);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiThe);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddLoaiKhachHangDlg";
            this.Text = "AddLoaiKhachHangDlg";
            ((System.ComponentModel.ISupportInitialize)(this.numNguong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiLeQuyDoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numNguong;
        private System.Windows.Forms.NumericUpDown numTiLeQuyDoi;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiThe;
    }
}
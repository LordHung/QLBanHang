namespace QLBanHang.Views
{
    partial class UpdatePhieuChiDlg
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
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 61);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdatePhieuChiDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 469);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdatePhieuChiDlg";
            this.Text = "UpdatePhieuChiDlg";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpNgayChi, 0);
            this.Controls.SetChildIndex(this.numSoTien, 0);
            this.Controls.SetChildIndex(this.txtMaPhieu, 0);
            this.Controls.SetChildIndex(this.txtDiaChi, 0);
            this.Controls.SetChildIndex(this.txtTenNguoiNhan, 0);
            this.Controls.SetChildIndex(this.txtLyDo, 0);
            this.Controls.SetChildIndex(this.txtChungTuKem, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
    }
}
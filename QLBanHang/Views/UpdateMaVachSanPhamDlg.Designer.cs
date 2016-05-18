namespace QLBanHang.Views
{
    partial class UpdateMaVachSanPhamDlg
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBQGQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaLe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            // 
            // label4
            // 
            this.label4.Enabled = false;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            // 
            // label1
            // 
            this.label1.Enabled = false;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Enabled = false;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Enabled = false;
            // 
            // txtCuaHang
            // 
            this.txtCuaHang.Enabled = false;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cmbNhaCungCap_SelectedIndexChanged);
            // 
            // numTonKho
            // 
            this.numTonKho.Enabled = false;
            // 
            // numGiaBQGQ
            // 
            this.numGiaBQGQ.Enabled = false;
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.Enabled = false;
            // 
            // numGiaSi
            // 
            this.numGiaSi.Enabled = false;
            // 
            // numGiaLe
            // 
            this.numGiaLe.Enabled = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(437, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateMaVachSanPhamDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 469);
            this.Name = "UpdateMaVachSanPhamDlg";
            this.Text = "UpdateMaVachSanPhamDlg";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBQGQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaLe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
    }
}
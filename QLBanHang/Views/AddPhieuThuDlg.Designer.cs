namespace QLBanHang.Views
{
    partial class AddPhieuThuDlg
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
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 61);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddPhieuThuDlg
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 436);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPhieuThuDlg";
            this.Text = "AddPhieuThuDlg";
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpNgayThu, 0);
            this.Controls.SetChildIndex(this.numSoTien, 0);
            this.Controls.SetChildIndex(this.txtMaPhieu, 0);
            this.Controls.SetChildIndex(this.txtDiaChi, 0);
            this.Controls.SetChildIndex(this.txtTenNguoiNop, 0);
            this.Controls.SetChildIndex(this.txtLyDo, 0);
            this.Controls.SetChildIndex(this.txtChungTuKem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
    }
}
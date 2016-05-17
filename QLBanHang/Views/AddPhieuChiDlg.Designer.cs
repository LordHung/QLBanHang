namespace QLBanHang.Views
{
    partial class AddPhieuChiDlg
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
            // txtChungTuKem
            // 
            this.txtChungTuKem.Location = new System.Drawing.Point(180, 345);
            this.txtChungTuKem.Size = new System.Drawing.Size(389, 29);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(180, 273);
            this.txtLyDo.Size = new System.Drawing.Size(389, 48);
            // 
            // txtTenNguoiNhan
            // 
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(180, 109);
            this.txtTenNguoiNhan.Size = new System.Drawing.Size(389, 29);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(180, 148);
            this.txtDiaChi.Size = new System.Drawing.Size(389, 67);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(180, 22);
            this.txtMaPhieu.Size = new System.Drawing.Size(389, 29);
            // 
            // numSoTien
            // 
            this.numSoTien.Location = new System.Drawing.Point(180, 238);
            this.numSoTien.Size = new System.Drawing.Size(389, 29);
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.Location = new System.Drawing.Point(180, 71);
            this.dtpNgayChi.Size = new System.Drawing.Size(389, 29);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 348);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 276);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 243);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 151);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 112);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 68);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 68);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddPhieuChiDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 475);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddPhieuChiDlg";
            this.Text = "AddPhieuChiDlg";
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
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
    }
}
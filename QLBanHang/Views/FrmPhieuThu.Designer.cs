namespace QLBanHang.Views
{
    partial class FrmPhieuThu
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
            this.tSBtnThem = new System.Windows.Forms.ToolStripButton();
            this.tsBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSua = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // tSBtnThem
            // 
            this.tSBtnThem.Image = global::QLBanHang.Properties.Resources.dauCong;
            this.tSBtnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnThem.Name = "tSBtnThem";
            this.tSBtnThem.Size = new System.Drawing.Size(58, 22);
            this.tSBtnThem.Text = "Thêm";
            this.tSBtnThem.Click += new System.EventHandler(this.tSBtnThem_Click);
            // 
            // tsBtnXoa
            // 
            this.tsBtnXoa.Image = global::QLBanHang.Properties.Resources.DauX;
            this.tsBtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnXoa.Name = "tsBtnXoa";
            this.tsBtnXoa.Size = new System.Drawing.Size(47, 22);
            this.tsBtnXoa.Text = "Xóa";
            this.tsBtnXoa.Click += new System.EventHandler(this.tsBtnXoa_Click);
            // 
            // tsBtnSua
            // 
            this.tsBtnSua.Image = global::QLBanHang.Properties.Resources.sua1;
            this.tsBtnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSua.Name = "tsBtnSua";
            this.tsBtnSua.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSua.Text = "Sửa";
            this.tsBtnSua.Click += new System.EventHandler(this.tsBtnSua_Click);
            // 
            // FrmQuanLyPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 645);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyPhieuThu";
            this.Text = "FrmQuanLyPhieuThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tSBtnThem;
        private System.Windows.Forms.ToolStripButton tsBtnXoa;
        private System.Windows.Forms.ToolStripButton tsBtnSua;
    }
}
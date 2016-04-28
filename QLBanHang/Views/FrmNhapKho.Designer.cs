namespace QLBanHang.Views
{
    partial class FrmNhapKho
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
            this.tsHoaDon = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSCmbCuaHang = new System.Windows.Forms.ToolStripComboBox();
            this.tSbBtnDongYDatHang = new System.Windows.Forms.ToolStripButton();
            this.tSBtnXemTruoc = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHoaDon
            // 
            this.tsHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tSCmbCuaHang,
            this.tSbBtnDongYDatHang,
            this.tSBtnXemTruoc});
            this.tsHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tsHoaDon.Name = "tsHoaDon";
            this.tsHoaDon.Size = new System.Drawing.Size(1194, 25);
            this.tsHoaDon.TabIndex = 25;
            this.tsHoaDon.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Hóa đơn";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Cửa hàng : ";
            // 
            // tSCmbCuaHang
            // 
            this.tSCmbCuaHang.Name = "tSCmbCuaHang";
            this.tSCmbCuaHang.Size = new System.Drawing.Size(121, 25);
            // 
            // tSbBtnDongYDatHang
            // 
            this.tSbBtnDongYDatHang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSbBtnDongYDatHang.Image = global::QLBanHang.Properties.Resources.dautich;
            this.tSbBtnDongYDatHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbBtnDongYDatHang.Name = "tSbBtnDongYDatHang";
            this.tSbBtnDongYDatHang.Size = new System.Drawing.Size(65, 22);
            this.tSbBtnDongYDatHang.Text = "Đồng ý";
            // 
            // tSBtnXemTruoc
            // 
            this.tSBtnXemTruoc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnXemTruoc.Image = global::QLBanHang.Properties.Resources.kinh_lup;
            this.tSBtnXemTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnXemTruoc.Name = "tSBtnXemTruoc";
            this.tSBtnXemTruoc.Size = new System.Drawing.Size(82, 22);
            this.tSBtnXemTruoc.Text = "Xem trước";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 196);
            this.panel1.TabIndex = 26;
            // 
            // FrmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsHoaDon);
            this.DoubleBuffered = true;
            this.Name = "FrmNhapKho";
            this.Text = "FrmNhapKho";
            this.tsHoaDon.ResumeLayout(false);
            this.tsHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsHoaDon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tSCmbCuaHang;
        private System.Windows.Forms.ToolStripButton tSbBtnDongYDatHang;
        private System.Windows.Forms.ToolStripButton tSBtnXemTruoc;
        private System.Windows.Forms.Panel panel1;
    }
}
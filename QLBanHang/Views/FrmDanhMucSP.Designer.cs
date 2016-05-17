namespace QLBanHang.Views
{
    partial class FrmDanhMucSP
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgViewSanPham = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgViewSanPhamCuaHang = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.dgViewMaVachSanPham = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPhamCuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1127, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Sản phẩm";
            // 
            // dgViewSanPham
            // 
            this.dgViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgViewSanPham.Location = new System.Drawing.Point(0, 25);
            this.dgViewSanPham.Name = "dgViewSanPham";
            this.dgViewSanPham.Size = new System.Drawing.Size(1127, 294);
            this.dgViewSanPham.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 319);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1127, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 344);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgViewSanPhamCuaHang);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgViewMaVachSanPham);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer1.Size = new System.Drawing.Size(1127, 334);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgViewSanPhamCuaHang
            // 
            this.dgViewSanPhamCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSanPhamCuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewSanPhamCuaHang.Location = new System.Drawing.Point(0, 25);
            this.dgViewSanPhamCuaHang.Name = "dgViewSanPhamCuaHang";
            this.dgViewSanPhamCuaHang.Size = new System.Drawing.Size(466, 309);
            this.dgViewSanPhamCuaHang.TabIndex = 4;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(466, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // dgViewMaVachSanPham
            // 
            this.dgViewMaVachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVachSanPham.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVachSanPham.Name = "dgViewMaVachSanPham";
            this.dgViewMaVachSanPham.Size = new System.Drawing.Size(657, 309);
            this.dgViewMaVachSanPham.TabIndex = 5;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(657, 25);
            this.toolStrip4.TabIndex = 3;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // FrmDanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 678);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgViewSanPham);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDanhMucSP";
            this.Text = "DanhMucSp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPham)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSanPhamCuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgViewSanPham;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgViewSanPhamCuaHang;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.DataGridView dgViewMaVachSanPham;
        private System.Windows.Forms.ToolStrip toolStrip4;
    }
}
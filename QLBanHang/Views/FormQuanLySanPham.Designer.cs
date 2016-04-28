namespace QLBanHang
{
    partial class FormQuanLyBanHang
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
            this.components = new System.ComponentModel.Container();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhaSanXuat = new System.Windows.Forms.Button();
            this.btnInMaVach = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNhomHang = new System.Windows.Forms.Button();
            this.btnNganhHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(263, 34);
            this.dgView.Name = "dgView";
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(856, 606);
            this.dgView.TabIndex = 0;
            this.dgView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgView_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Thêm";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.updateToolStripMenuItem.Text = "Sửa";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnNhaSanXuat
            // 
            this.btnNhaSanXuat.Location = new System.Drawing.Point(-1, 34);
            this.btnNhaSanXuat.Name = "btnNhaSanXuat";
            this.btnNhaSanXuat.Size = new System.Drawing.Size(161, 48);
            this.btnNhaSanXuat.TabIndex = 1;
            this.btnNhaSanXuat.Text = "NHÀ SẢN XUẤT";
            this.btnNhaSanXuat.UseVisualStyleBackColor = true;
            this.btnNhaSanXuat.Click += new System.EventHandler(this.btnNhaSanXuat_Click);
            // 
            // btnInMaVach
            // 
            this.btnInMaVach.Location = new System.Drawing.Point(-1, 257);
            this.btnInMaVach.Name = "btnInMaVach";
            this.btnInMaVach.Size = new System.Drawing.Size(161, 48);
            this.btnInMaVach.TabIndex = 2;
            this.btnInMaVach.Text = "IM MÃ VẠCH";
            this.btnInMaVach.UseVisualStyleBackColor = true;
            this.btnInMaVach.Click += new System.EventHandler(this.btnInMaVach_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(-1, 212);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(161, 48);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = "DANH MỤC SP";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(-1, 167);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(161, 48);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "SẢN PHẨM";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhomHang
            // 
            this.btnNhomHang.Location = new System.Drawing.Point(-1, 123);
            this.btnNhomHang.Name = "btnNhomHang";
            this.btnNhomHang.Size = new System.Drawing.Size(161, 48);
            this.btnNhomHang.TabIndex = 5;
            this.btnNhomHang.Text = "NHÓM HÀNG";
            this.btnNhomHang.UseVisualStyleBackColor = true;
            this.btnNhomHang.Click += new System.EventHandler(this.btnNhomHang_Click);
            // 
            // btnNganhHang
            // 
            this.btnNganhHang.Location = new System.Drawing.Point(-1, 78);
            this.btnNganhHang.Name = "btnNganhHang";
            this.btnNganhHang.Size = new System.Drawing.Size(161, 48);
            this.btnNganhHang.TabIndex = 6;
            this.btnNganhHang.Text = "NGÀNH HÀNG";
            this.btnNganhHang.UseVisualStyleBackColor = true;
            this.btnNganhHang.Click += new System.EventHandler(this.btnNganhHang_Click);
            // 
            // FormQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 635);
            this.Controls.Add(this.btnNganhHang);
            this.Controls.Add(this.btnNhomHang);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnInMaVach);
            this.Controls.Add(this.btnNhaSanXuat);
            this.Controls.Add(this.dgView);
            this.Name = "FormQuanLyBanHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmQuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button btnNhaSanXuat;
        private System.Windows.Forms.Button btnInMaVach;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhomHang;
        private System.Windows.Forms.Button btnNganhHang;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}


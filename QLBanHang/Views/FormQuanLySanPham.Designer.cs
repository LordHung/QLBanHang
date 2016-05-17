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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnThem = new System.Windows.Forms.ToolStripButton();
            this.tsBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSua = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnNhaSanXuat.BackColor = System.Drawing.Color.LightCyan;
            this.btnNhaSanXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaSanXuat.Location = new System.Drawing.Point(0, 3);
            this.btnNhaSanXuat.Name = "btnNhaSanXuat";
            this.btnNhaSanXuat.Size = new System.Drawing.Size(161, 48);
            this.btnNhaSanXuat.TabIndex = 1;
            this.btnNhaSanXuat.Text = "NHÀ SẢN XUẤT";
            this.btnNhaSanXuat.UseVisualStyleBackColor = false;
            this.btnNhaSanXuat.Click += new System.EventHandler(this.btnNhaSanXuat_Click);
            // 
            // btnInMaVach
            // 
            this.btnInMaVach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInMaVach.Location = new System.Drawing.Point(0, 226);
            this.btnInMaVach.Name = "btnInMaVach";
            this.btnInMaVach.Size = new System.Drawing.Size(161, 48);
            this.btnInMaVach.TabIndex = 2;
            this.btnInMaVach.Text = "IM MÃ VẠCH";
            this.btnInMaVach.UseVisualStyleBackColor = true;
            this.btnInMaVach.Click += new System.EventHandler(this.btnInMaVach_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 181);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(161, 48);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = "DANH MỤC SP";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Location = new System.Drawing.Point(0, 136);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(161, 48);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "SẢN PHẨM";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhomHang
            // 
            this.btnNhomHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhomHang.Location = new System.Drawing.Point(0, 92);
            this.btnNhomHang.Name = "btnNhomHang";
            this.btnNhomHang.Size = new System.Drawing.Size(161, 48);
            this.btnNhomHang.TabIndex = 5;
            this.btnNhomHang.Text = "NHÓM HÀNG";
            this.btnNhomHang.UseVisualStyleBackColor = true;
            this.btnNhomHang.Click += new System.EventHandler(this.btnNhomHang_Click);
            // 
            // btnNganhHang
            // 
            this.btnNganhHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnNganhHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNganhHang.Location = new System.Drawing.Point(0, 47);
            this.btnNganhHang.Name = "btnNganhHang";
            this.btnNganhHang.Size = new System.Drawing.Size(161, 48);
            this.btnNganhHang.TabIndex = 6;
            this.btnNganhHang.Text = "NGÀNH HÀNG";
            this.btnNganhHang.UseVisualStyleBackColor = false;
            this.btnNganhHang.Click += new System.EventHandler(this.btnNganhHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNhaSanXuat);
            this.panel1.Controls.Add(this.btnInMaVach);
            this.panel1.Controls.Add(this.btnDanhMuc);
            this.panel1.Controls.Add(this.btnNganhHang);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnNhomHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 635);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgView);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 635);
            this.panel2.TabIndex = 9;
            // 
            // dgView
            // 
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 25);
            this.dgView.Name = "dgView";
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(953, 610);
            this.dgView.TabIndex = 2;
            this.dgView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgView_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnThem,
            this.tsBtnXoa,
            this.tsBtnSua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // FormQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyBanHang";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FrmQuanLySanPham_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnThem;
        private System.Windows.Forms.ToolStripButton tsBtnXoa;
        private System.Windows.Forms.ToolStripButton tsBtnSua;
        private System.Windows.Forms.DataGridView dgView;
    }
}


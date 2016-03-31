namespace QLBanHang.Views
{
    partial class FormQLKH_NCC
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
            this.btnPhieuQuaTang = new System.Windows.Forms.Button();
            this.btnLoaiKhacHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnTangHangThe = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhieuQuaTang
            // 
            this.btnPhieuQuaTang.Location = new System.Drawing.Point(12, 156);
            this.btnPhieuQuaTang.Name = "btnPhieuQuaTang";
            this.btnPhieuQuaTang.Size = new System.Drawing.Size(161, 48);
            this.btnPhieuQuaTang.TabIndex = 2;
            this.btnPhieuQuaTang.Text = "PHIẾU QUÀ TẶNG";
            this.btnPhieuQuaTang.UseVisualStyleBackColor = true;
            this.btnPhieuQuaTang.Click += new System.EventHandler(this.btnPhieuQuaTang_Click);
            // 
            // btnLoaiKhacHang
            // 
            this.btnLoaiKhacHang.Location = new System.Drawing.Point(12, 111);
            this.btnLoaiKhacHang.Name = "btnLoaiKhacHang";
            this.btnLoaiKhacHang.Size = new System.Drawing.Size(161, 48);
            this.btnLoaiKhacHang.TabIndex = 3;
            this.btnLoaiKhacHang.Text = "LOẠI KHÁCH HÀNG";
            this.btnLoaiKhacHang.UseVisualStyleBackColor = true;
            this.btnLoaiKhacHang.Click += new System.EventHandler(this.btnLoaiKhacHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(12, 66);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(161, 48);
            this.btnNhaCungCap.TabIndex = 4;
            this.btnNhaCungCap.Text = "NHÀ CUNG CẤP";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(12, 21);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(161, 48);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnTangHangThe
            // 
            this.btnTangHangThe.Location = new System.Drawing.Point(12, 200);
            this.btnTangHangThe.Name = "btnTangHangThe";
            this.btnTangHangThe.Size = new System.Drawing.Size(161, 48);
            this.btnTangHangThe.TabIndex = 6;
            this.btnTangHangThe.Text = "TĂNG HẠNG THẺ";
            this.btnTangHangThe.UseVisualStyleBackColor = true;
            this.btnTangHangThe.Click += new System.EventHandler(this.btnTangHangThe_Click);
            // 
            // dgView
            // 
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(299, 66);
            this.dgView.Name = "dgView";
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(862, 689);
            this.dgView.TabIndex = 7;
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
            // FormQLKH_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 752);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btnTangHangThe);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.btnLoaiKhacHang);
            this.Controls.Add(this.btnPhieuQuaTang);
            this.Name = "FormQLKH_NCC";
            this.Text = "viwQLKH_NCC";
            this.Load += new System.EventHandler(this.FormQLKH_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhieuQuaTang;
        private System.Windows.Forms.Button btnLoaiKhacHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnTangHangThe;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
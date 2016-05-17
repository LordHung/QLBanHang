namespace QLBanHang.Views
{
    partial class FrmPhieuThuChiBase
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
            this.tSBtnThem = new System.Windows.Forms.ToolStripButton();
            this.tsBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSua = new System.Windows.Forms.ToolStripButton();
            this.dgViewPhieu = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnThem,
            this.tsBtnXoa,
            this.tsBtnSua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1448, 25);
            this.toolStrip1.TabIndex = 4;
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
            // dgViewPhieu
            // 
            this.dgViewPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgViewPhieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgViewPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewPhieu.Location = new System.Drawing.Point(0, 25);
            this.dgViewPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgViewPhieu.Name = "dgViewPhieu";
            this.dgViewPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewPhieu.Size = new System.Drawing.Size(1448, 779);
            this.dgViewPhieu.TabIndex = 6;
            this.dgViewPhieu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgViewPhieu_RowPostPaint);
            // 
            // FrmPhieuThuChiBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 804);
            this.Controls.Add(this.dgViewPhieu);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhieuThuChiBase";
            this.Text = "FrmQuanLyPhieuThuChiBase";
            this.Load += new System.EventHandler(this.FrmQuanLyPhieuThuChiBase_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton tSBtnThem;
        protected System.Windows.Forms.ToolStripButton tsBtnXoa;
        protected System.Windows.Forms.ToolStripButton tsBtnSua;
        protected System.Windows.Forms.DataGridView dgViewPhieu;
    }
}
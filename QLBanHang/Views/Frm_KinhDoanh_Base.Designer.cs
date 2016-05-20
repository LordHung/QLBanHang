namespace QLBanHang.Views
{
    partial class Frm_KinhDoanh_Base
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
            this.tSbtnMinusMaVach = new System.Windows.Forms.ToolStripButton();
            this.tSMaVachDaChon = new System.Windows.Forms.ToolStrip();
            this.tSBtnPlusMaVach = new System.Windows.Forms.ToolStripButton();
            this.tSBtnChonMaVach = new System.Windows.Forms.ToolStripButton();
            this.tSMaVach = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgViewMaVach = new System.Windows.Forms.DataGridView();
            this.tsSoLuongMaVachSanPham = new System.Windows.Forms.ToolStrip();
            this.lblSoLuongMaVach = new System.Windows.Forms.ToolStripLabel();
            this.dgViewMaVachDaChon = new System.Windows.Forms.DataGridView();
            this.tsSoLuongSanPhamDuocChon = new System.Windows.Forms.ToolStrip();
            this.lblSoLuongMaVachDuocChon = new System.Windows.Forms.ToolStripLabel();
            this.tSBtnXemTruoc = new System.Windows.Forms.ToolStripButton();
            this.tSbBtnDongY = new System.Windows.Forms.ToolStripButton();
            this.tSCmbCuaHang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSTxtMain = new System.Windows.Forms.ToolStripLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tSMain = new System.Windows.Forms.ToolStrip();
            this.tSMaVachDaChon.SuspendLayout();
            this.tSMaVach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVach)).BeginInit();
            this.tsSoLuongMaVachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachDaChon)).BeginInit();
            this.tsSoLuongSanPhamDuocChon.SuspendLayout();
            this.tSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSbtnMinusMaVach
            // 
            this.tSbtnMinusMaVach.Image = global::QLBanHang.Properties.Resources.dautru;
            this.tSbtnMinusMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnMinusMaVach.Name = "tSbtnMinusMaVach";
            this.tSbtnMinusMaVach.Size = new System.Drawing.Size(38, 22);
            this.tSbtnMinusMaVach.Text = "-1";
            this.tSbtnMinusMaVach.Click += new System.EventHandler(this.tSbtnMinusMaVach_Click);
            // 
            // tSMaVachDaChon
            // 
            this.tSMaVachDaChon.BackColor = System.Drawing.Color.Azure;
            this.tSMaVachDaChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnPlusMaVach,
            this.tSbtnMinusMaVach});
            this.tSMaVachDaChon.Location = new System.Drawing.Point(0, 0);
            this.tSMaVachDaChon.Name = "tSMaVachDaChon";
            this.tSMaVachDaChon.Size = new System.Drawing.Size(712, 25);
            this.tSMaVachDaChon.TabIndex = 0;
            this.tSMaVachDaChon.Text = "toolStrip2";
            // 
            // tSBtnPlusMaVach
            // 
            this.tSBtnPlusMaVach.Image = global::QLBanHang.Properties.Resources.dauCong;
            this.tSBtnPlusMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPlusMaVach.Name = "tSBtnPlusMaVach";
            this.tSBtnPlusMaVach.Size = new System.Drawing.Size(41, 22);
            this.tSBtnPlusMaVach.Text = "+1";
            this.tSBtnPlusMaVach.Click += new System.EventHandler(this.tSBtnPlusMaVach_Click);
            // 
            // tSBtnChonMaVach
            // 
            this.tSBtnChonMaVach.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnChonMaVach.Image = global::QLBanHang.Properties.Resources.dautich;
            this.tSBtnChonMaVach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnChonMaVach.Name = "tSBtnChonMaVach";
            this.tSBtnChonMaVach.Size = new System.Drawing.Size(56, 22);
            this.tSBtnChonMaVach.Text = "Chọn";
            this.tSBtnChonMaVach.Click += new System.EventHandler(this.tSBtnChonMaVach_Click);
            // 
            // tSMaVach
            // 
            this.tSMaVach.BackColor = System.Drawing.Color.Azure;
            this.tSMaVach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnChonMaVach});
            this.tSMaVach.Location = new System.Drawing.Point(0, 0);
            this.tSMaVach.Name = "tSMaVach";
            this.tSMaVach.Size = new System.Drawing.Size(499, 25);
            this.tSMaVach.TabIndex = 0;
            this.tSMaVach.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 238);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgViewMaVach);
            this.splitContainer1.Panel1.Controls.Add(this.tsSoLuongMaVachSanPham);
            this.splitContainer1.Panel1.Controls.Add(this.tSMaVach);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgViewMaVachDaChon);
            this.splitContainer1.Panel2.Controls.Add(this.tsSoLuongSanPhamDuocChon);
            this.splitContainer1.Panel2.Controls.Add(this.tSMaVachDaChon);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.splitContainer1.Size = new System.Drawing.Size(1215, 399);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 29;
            // 
            // dgViewMaVach
            // 
            this.dgViewMaVach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgViewMaVach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVach.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVach.MultiSelect = false;
            this.dgViewMaVach.Name = "dgViewMaVach";
            this.dgViewMaVach.ReadOnly = true;
            this.dgViewMaVach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewMaVach.Size = new System.Drawing.Size(499, 349);
            this.dgViewMaVach.TabIndex = 5;
            this.dgViewMaVach.VirtualMode = true;
            this.dgViewMaVach.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgViewMaVach_CellValueNeeded);
            this.dgViewMaVach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgViewMaVach_DataBindingComplete);
            this.dgViewMaVach.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgViewMaVach_RowPostPaint);
            // 
            // tsSoLuongMaVachSanPham
            // 
            this.tsSoLuongMaVachSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSoLuongMaVachSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSoLuongMaVach});
            this.tsSoLuongMaVachSanPham.Location = new System.Drawing.Point(0, 374);
            this.tsSoLuongMaVachSanPham.Name = "tsSoLuongMaVachSanPham";
            this.tsSoLuongMaVachSanPham.Size = new System.Drawing.Size(499, 25);
            this.tsSoLuongMaVachSanPham.TabIndex = 4;
            this.tsSoLuongMaVachSanPham.Text = "toolStrip1";
            // 
            // lblSoLuongMaVach
            // 
            this.lblSoLuongMaVach.Name = "lblSoLuongMaVach";
            this.lblSoLuongMaVach.Size = new System.Drawing.Size(86, 22);
            this.lblSoLuongMaVach.Text = "toolStripLabel1";
            // 
            // dgViewMaVachDaChon
            // 
            this.dgViewMaVachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaVachDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewMaVachDaChon.Location = new System.Drawing.Point(0, 25);
            this.dgViewMaVachDaChon.MultiSelect = false;
            this.dgViewMaVachDaChon.Name = "dgViewMaVachDaChon";
            this.dgViewMaVachDaChon.ReadOnly = true;
            this.dgViewMaVachDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewMaVachDaChon.Size = new System.Drawing.Size(712, 349);
            this.dgViewMaVachDaChon.TabIndex = 6;
            this.dgViewMaVachDaChon.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgViewMaVachDaChon_CellValueNeeded);
            this.dgViewMaVachDaChon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgViewMaVachDaChon_DataBindingComplete);
            this.dgViewMaVachDaChon.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgViewMaVach_RowPostPaint);
            this.dgViewMaVachDaChon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgViewMaVachDaChon_RowsAdded);
            this.dgViewMaVachDaChon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgViewMaVachDaChon_RowsRemoved);
            // 
            // tsSoLuongSanPhamDuocChon
            // 
            this.tsSoLuongSanPhamDuocChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSoLuongSanPhamDuocChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSoLuongMaVachDuocChon});
            this.tsSoLuongSanPhamDuocChon.Location = new System.Drawing.Point(0, 374);
            this.tsSoLuongSanPhamDuocChon.Name = "tsSoLuongSanPhamDuocChon";
            this.tsSoLuongSanPhamDuocChon.Size = new System.Drawing.Size(712, 25);
            this.tsSoLuongSanPhamDuocChon.TabIndex = 5;
            this.tsSoLuongSanPhamDuocChon.Text = "toolStrip1";
            // 
            // lblSoLuongMaVachDuocChon
            // 
            this.lblSoLuongMaVachDuocChon.Name = "lblSoLuongMaVachDuocChon";
            this.lblSoLuongMaVachDuocChon.Size = new System.Drawing.Size(86, 22);
            this.lblSoLuongMaVachDuocChon.Text = "toolStripLabel1";
            // 
            // tSBtnXemTruoc
            // 
            this.tSBtnXemTruoc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnXemTruoc.Image = global::QLBanHang.Properties.Resources.kinh_lup;
            this.tSBtnXemTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnXemTruoc.Name = "tSBtnXemTruoc";
            this.tSBtnXemTruoc.Size = new System.Drawing.Size(82, 22);
            this.tSBtnXemTruoc.Text = "Xem trước";
            this.tSBtnXemTruoc.Click += new System.EventHandler(this.tSBtnXemTruoc_Click);
            // 
            // tSbBtnDongY
            // 
            this.tSbBtnDongY.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSbBtnDongY.Image = global::QLBanHang.Properties.Resources.dautich;
            this.tSbBtnDongY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbBtnDongY.Name = "tSbBtnDongY";
            this.tSbBtnDongY.Size = new System.Drawing.Size(65, 22);
            this.tSbBtnDongY.Text = "Đồng ý";
            this.tSbBtnDongY.Click += new System.EventHandler(this.tSbBtnDongY_Click);
            // 
            // tSCmbCuaHang
            // 
            this.tSCmbCuaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tSCmbCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tSCmbCuaHang.Name = "tSCmbCuaHang";
            this.tSCmbCuaHang.Size = new System.Drawing.Size(150, 25);
            this.tSCmbCuaHang.SelectedIndexChanged += new System.EventHandler(this.tSCmbCuaHang_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Cửa hàng : ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSTxtMain
            // 
            this.tSTxtMain.Name = "tSTxtMain";
            this.tSTxtMain.Size = new System.Drawing.Size(53, 22);
            this.tSTxtMain.Text = "Hóa đơn";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Azure;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1215, 213);
            this.panelMain.TabIndex = 28;
            // 
            // tSMain
            // 
            this.tSMain.BackColor = System.Drawing.Color.Azure;
            this.tSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSTxtMain,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tSCmbCuaHang,
            this.tSbBtnDongY,
            this.tSBtnXemTruoc});
            this.tSMain.Location = new System.Drawing.Point(0, 0);
            this.tSMain.Name = "tSMain";
            this.tSMain.Size = new System.Drawing.Size(1215, 25);
            this.tSMain.TabIndex = 27;
            this.tSMain.Text = "toolStrip1";
            // 
            // Frm_KinhDoanh_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 637);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tSMain);
            this.Name = "Frm_KinhDoanh_Base";
            this.Text = "Frm_KinhDoanh_Base";
            this.Shown += new System.EventHandler(this.Frm_KinhDoanh_Base_Shown);
            this.tSMaVachDaChon.ResumeLayout(false);
            this.tSMaVachDaChon.PerformLayout();
            this.tSMaVach.ResumeLayout(false);
            this.tSMaVach.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVach)).EndInit();
            this.tsSoLuongMaVachSanPham.ResumeLayout(false);
            this.tsSoLuongMaVachSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaVachDaChon)).EndInit();
            this.tsSoLuongSanPhamDuocChon.ResumeLayout(false);
            this.tsSoLuongSanPhamDuocChon.PerformLayout();
            this.tSMain.ResumeLayout(false);
            this.tSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripButton tSbtnMinusMaVach;
        protected System.Windows.Forms.ToolStrip tSMaVachDaChon;
        protected System.Windows.Forms.ToolStripButton tSBtnPlusMaVach;
        protected System.Windows.Forms.ToolStripButton tSBtnChonMaVach;
        protected System.Windows.Forms.ToolStrip tSMaVach;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.ToolStripButton tSBtnXemTruoc;
        protected System.Windows.Forms.ToolStripButton tSbBtnDongY;
        protected System.Windows.Forms.ToolStripComboBox tSCmbCuaHang;
        protected System.Windows.Forms.ToolStripLabel toolStripLabel2;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripLabel tSTxtMain;
        protected System.Windows.Forms.Panel panelMain;
        protected System.Windows.Forms.ToolStrip tSMain;
        private System.Windows.Forms.ToolStrip tsSoLuongMaVachSanPham;
        private System.Windows.Forms.ToolStripLabel lblSoLuongMaVach;
        private System.Windows.Forms.ToolStrip tsSoLuongSanPhamDuocChon;
        private System.Windows.Forms.ToolStripLabel lblSoLuongMaVachDuocChon;
        protected System.Windows.Forms.DataGridView dgViewMaVach;
        protected System.Windows.Forms.DataGridView dgViewMaVachDaChon;

    }
}
namespace QLBanHang.Views
{
    partial class Frm_Them_Xoa_Sua_Base
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
            this.tsBtnLuu = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblSoLuong = new System.Windows.Forms.ToolStripLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnThem,
            this.tsBtnXoa,
            this.tsBtnSua,
            this.tsBtnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1106, 25);
            this.toolStrip1.TabIndex = 0;
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
            // tsBtnLuu
            // 
            this.tsBtnLuu.Image = global::QLBanHang.Properties.Resources.save;
            this.tsBtnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLuu.Name = "tsBtnLuu";
            this.tsBtnLuu.Size = new System.Drawing.Size(47, 22);
            this.tsBtnLuu.Text = "Lưu";
            this.tsBtnLuu.Click += new System.EventHandler(this.tsBtnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 650);
            this.panel1.TabIndex = 1;
            // 
            // dgView
            // 
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(325, 25);
            this.dgView.Margin = new System.Windows.Forms.Padding(4);
            this.dgView.MultiSelect = false;
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(781, 625);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgView_CellValueNeeded);
            this.dgView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgView_DataBindingComplete);
            this.dgView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgView_RowPostPaint);
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSoLuong});
            this.toolStrip2.Location = new System.Drawing.Point(325, 650);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(781, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(86, 22);
            this.lblSoLuong.Text = "toolStripLabel1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 650);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Frm_Them_Xoa_Sua_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 675);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Them_Xoa_Sua_Base";
            this.Text = "FrmKH_NCC_Base";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton tSBtnThem;
        protected System.Windows.Forms.ToolStripButton tsBtnXoa;
        protected System.Windows.Forms.ToolStripButton tsBtnSua;
        protected System.Windows.Forms.DataGridView dgView;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.ToolStripButton tsBtnLuu;
        protected System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripLabel lblSoLuong;
        private System.Windows.Forms.Splitter splitter1;
    }
}
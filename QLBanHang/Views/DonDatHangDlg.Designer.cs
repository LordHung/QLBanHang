namespace QLBanHang.Views
{
    partial class DonDatHangDlg
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
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnChon = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dgViewDonDatHang = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.btnChon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // btnChon
            // 
            this.btnChon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnChon.Image = global::QLBanHang.Properties.Resources.dautich;
            this.btnChon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(56, 22);
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Location = new System.Drawing.Point(0, 393);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(828, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dgViewDonDatHang
            // 
            this.dgViewDonDatHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgViewDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewDonDatHang.Location = new System.Drawing.Point(0, 25);
            this.dgViewDonDatHang.MultiSelect = false;
            this.dgViewDonDatHang.Name = "dgViewDonDatHang";
            this.dgViewDonDatHang.ReadOnly = true;
            this.dgViewDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewDonDatHang.Size = new System.Drawing.Size(828, 368);
            this.dgViewDonDatHang.TabIndex = 3;
            this.dgViewDonDatHang.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgViewDonDatHang_CellValueNeeded);
            this.dgViewDonDatHang.DoubleClick += new System.EventHandler(this.dgViewDonDatHang_DoubleClick);
            // 
            // DonDatHangDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 418);
            this.Controls.Add(this.dgViewDonDatHang);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DonDatHangDlg";
            this.Text = "Tìm kiếm đơn đặt hàng";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDonDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dgViewDonDatHang;
        private System.Windows.Forms.ToolStripButton btnChon;
    }
}
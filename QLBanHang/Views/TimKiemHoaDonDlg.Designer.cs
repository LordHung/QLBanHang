namespace QLBanHang.Views
{
    partial class TimKiemHoaDonDlg
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
            this.dgViewHoaDon = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.btnChon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 2;
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
            // dgViewHoaDon
            // 
            this.dgViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewHoaDon.Location = new System.Drawing.Point(0, 25);
            this.dgViewHoaDon.Name = "dgViewHoaDon";
            this.dgViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewHoaDon.Size = new System.Drawing.Size(989, 488);
            this.dgViewHoaDon.TabIndex = 3;
            this.dgViewHoaDon.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgViewHoaDon_CellValueNeeded);
            // 
            // TimKiemHoaDonDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 513);
            this.Controls.Add(this.dgViewHoaDon);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimKiemHoaDonDlg";
            this.Text = "TimKiemHoaDOn";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnChon;
        private System.Windows.Forms.DataGridView dgViewHoaDon;

    }
}
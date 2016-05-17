namespace QLBanHang.Views
{
    partial class FrmPhanQuyen
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
            this.tsCmbNhanVien = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.treeViewQuyen = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCmbNhanVien,
            this.tsBtnUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsCmbNhanVien
            // 
            this.tsCmbNhanVien.Name = "tsCmbNhanVien";
            this.tsCmbNhanVien.Size = new System.Drawing.Size(121, 25);
            this.tsCmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.tsCmbNhanVien_SelectedIndexChanged);
            // 
            // tsBtnUpdate
            // 
            this.tsBtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUpdate.Image = global::QLBanHang.Properties.Resources.refresh1;
            this.tsBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUpdate.Name = "tsBtnUpdate";
            this.tsBtnUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsBtnUpdate.Text = "Cập nhật lại nhân viên";
            this.tsBtnUpdate.Click += new System.EventHandler(this.tsBtnUpdate_Click);
            // 
            // treeViewQuyen
            // 
            this.treeViewQuyen.CheckBoxes = true;
            this.treeViewQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewQuyen.Location = new System.Drawing.Point(0, 25);
            this.treeViewQuyen.Name = "treeViewQuyen";
            this.treeViewQuyen.Size = new System.Drawing.Size(977, 592);
            this.treeViewQuyen.TabIndex = 2;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 617);
            this.Controls.Add(this.treeViewQuyen);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhanQuyen";
            this.Text = "FrmPhanQuyen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnUpdate;
        private System.Windows.Forms.TreeView treeViewQuyen;
        private System.Windows.Forms.ToolStripComboBox tsCmbNhanVien;

    }
}
namespace QLBanHang.Views
{
    partial class FormQLNV_PQ
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhanQuyen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(221, 80);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnPhanQuyen);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 600);
            this.panel1.TabIndex = 1;
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanQuyen.Location = new System.Drawing.Point(0, 80);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(221, 80);
            this.btnPhanQuyen.TabIndex = 1;
            this.btnPhanQuyen.Text = "PHÂN QUYỀN";
            this.btnPhanQuyen.UseVisualStyleBackColor = false;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // FormQLNV_PQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 600);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormQLNV_PQ";
            this.Text = "FrmQLNV_PQ";
            this.Load += new System.EventHandler(this.FormQLNV_PQ_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPhanQuyen;
    }
}
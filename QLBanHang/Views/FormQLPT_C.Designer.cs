namespace QLBanHang.Views
{
    partial class FormQLPT_C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhieuChi = new System.Windows.Forms.Button();
            this.btnPhieuThu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPhieuChi);
            this.panel1.Controls.Add(this.btnPhieuThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 656);
            this.panel1.TabIndex = 0;
            // 
            // btnPhieuChi
            // 
            this.btnPhieuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuChi.Location = new System.Drawing.Point(0, 75);
            this.btnPhieuChi.Name = "btnPhieuChi";
            this.btnPhieuChi.Size = new System.Drawing.Size(200, 75);
            this.btnPhieuChi.TabIndex = 2;
            this.btnPhieuChi.Text = "PHIẾU CHI";
            this.btnPhieuChi.UseVisualStyleBackColor = true;
            this.btnPhieuChi.Click += new System.EventHandler(this.btnPhieuChi_Click);
            // 
            // btnPhieuThu
            // 
            this.btnPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.btnPhieuThu.Name = "btnPhieuThu";
            this.btnPhieuThu.Size = new System.Drawing.Size(200, 75);
            this.btnPhieuThu.TabIndex = 0;
            this.btnPhieuThu.Text = "PHIẾU THU";
            this.btnPhieuThu.UseVisualStyleBackColor = true;
            this.btnPhieuThu.Click += new System.EventHandler(this.btnPhieuThu_Click);
            // 
            // FormQLPT_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 656);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormQLPT_C";
            this.Text = "FrmQuanLyPhieuThuChi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyPhieuThuChi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPhieuChi;
        private System.Windows.Forms.Button btnPhieuThu;
    }
}
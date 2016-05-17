namespace QLBanHang.Views
{
    partial class FrmNganhHang
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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenNganh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNganh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Size = new System.Drawing.Size(300, 639);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(102, 95);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(177, 79);
            this.txtMoTa.TabIndex = 16;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(102, 65);
            this.txtTenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(177, 22);
            this.txtTenNganh.TabIndex = 14;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(102, 33);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(177, 22);
            this.txtMaNganh.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mô Tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Ngành";
            // 
            // FrmNganhHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 664);
            this.Name = "FrmNganhHang";
            this.Text = "FrmNganhHang";
            this.Load += new System.EventHandler(this.FrmNganhHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
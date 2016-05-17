namespace QLBanHang.Views
{
    partial class FrmNhomHang
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
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.cmbNganh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.txtMaLoai);
            this.panel1.Controls.Add(this.cmbNganh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Size = new System.Drawing.Size(300, 639);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(100, 168);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(184, 92);
            this.txtMoTa.TabIndex = 7;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(100, 113);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(184, 22);
            this.txtTenLoai.TabIndex = 13;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(100, 66);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(184, 22);
            this.txtMaLoai.TabIndex = 11;
            // 
            // cmbNganh
            // 
            this.cmbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNganh.FormattingEnabled = true;
            this.cmbNganh.Location = new System.Drawing.Point(100, 21);
            this.cmbNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNganh.Name = "cmbNganh";
            this.cmbNganh.Size = new System.Drawing.Size(184, 24);
            this.cmbNganh.TabIndex = 9;
            this.cmbNganh.SelectedIndexChanged += new System.EventHandler(this.cmbNganh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mô Tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngành * :";
            // 
            // FrmNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 664);
            this.Name = "FrmNhomHang";
            this.Text = "FrmNhomHang";
            this.Load += new System.EventHandler(this.FrmNhomHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.ComboBox cmbNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
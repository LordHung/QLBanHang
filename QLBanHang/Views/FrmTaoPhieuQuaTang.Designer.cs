namespace QLBanHang.Views
{
    partial class FrmTaoPhieuQuaTang
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.numTriGiaPhieu = new System.Windows.Forms.NumericUpDown();
            this.numSoPhieu = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTriGiaPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.dtpHSD);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgayLap);
            this.splitContainer1.Panel1.Controls.Add(this.numTriGiaPhieu);
            this.splitContainer1.Panel1.Controls.Add(this.numSoPhieu);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 654);
            this.splitContainer1.SplitterDistance = 272;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 68);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(27, 347);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 103);
            this.txtGhiChu.TabIndex = 42;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Location = new System.Drawing.Point(27, 276);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(200, 22);
            this.dtpHSD.TabIndex = 41;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(27, 205);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLap.TabIndex = 40;
            // 
            // numTriGiaPhieu
            // 
            this.numTriGiaPhieu.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTriGiaPhieu.Location = new System.Drawing.Point(27, 130);
            this.numTriGiaPhieu.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numTriGiaPhieu.Name = "numTriGiaPhieu";
            this.numTriGiaPhieu.Size = new System.Drawing.Size(156, 22);
            this.numTriGiaPhieu.TabIndex = 39;
            // 
            // numSoPhieu
            // 
            this.numSoPhieu.Location = new System.Drawing.Point(27, 66);
            this.numSoPhieu.Name = "numSoPhieu";
            this.numSoPhieu.Size = new System.Drawing.Size(156, 22);
            this.numSoPhieu.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Trị giá phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số phiếu quà tặng";
            // 
            // FrmTaoPhieuQuaTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 654);
            this.Name = "FrmTaoPhieuQuaTang";
            this.Text = "FrmTaoPhieuQuaTang";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTriGiaPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.NumericUpDown numTriGiaPhieu;
        private System.Windows.Forms.NumericUpDown numSoPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
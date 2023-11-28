namespace WindowsFormsApp1
{
    partial class NguyenKhacPhuocbai3
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
            this.nhapa = new System.Windows.Forms.TextBox();
            this.nhapb = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yeucau = new System.Windows.Forms.Label();
            this.hienthi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nhapa
            // 
            this.nhapa.Location = new System.Drawing.Point(319, 120);
            this.nhapa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nhapa.Multiline = true;
            this.nhapa.Name = "nhapa";
            this.nhapa.Size = new System.Drawing.Size(169, 38);
            this.nhapa.TabIndex = 0;
            // 
            // nhapb
            // 
            this.nhapb.Location = new System.Drawing.Point(319, 179);
            this.nhapb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nhapb.Multiline = true;
            this.nhapb.Name = "nhapb";
            this.nhapb.Size = new System.Drawing.Size(169, 38);
            this.nhapb.TabIndex = 1;
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(319, 304);
            this.ketqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(169, 101);
            this.ketqua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "kết quả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // yeucau
            // 
            this.yeucau.AutoSize = true;
            this.yeucau.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeucau.Location = new System.Drawing.Point(151, 37);
            this.yeucau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yeucau.Name = "yeucau";
            this.yeucau.Size = new System.Drawing.Size(480, 39);
            this.yeucau.TabIndex = 6;
            this.yeucau.Text = "giải phương trình bậc nhất ax+b=0";
            // 
            // hienthi
            // 
            this.hienthi.Location = new System.Drawing.Point(394, 245);
            this.hienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(94, 29);
            this.hienthi.TabIndex = 7;
            this.hienthi.Text = "hiển thị";
            this.hienthi.UseVisualStyleBackColor = true;
            this.hienthi.Click += new System.EventHandler(this.button1_Click);
            // 
            // NguyenKhacPhuocbai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 438);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.yeucau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.nhapb);
            this.Controls.Add(this.nhapa);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NguyenKhacPhuocbai3";
            this.Text = "NguyenKhacPhuocbai3";
            this.Load += new System.EventHandler(this.NguyenKhacPhuocbai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nhapa;
        private System.Windows.Forms.TextBox nhapb;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yeucau;
        private System.Windows.Forms.Button hienthi;
    }
}
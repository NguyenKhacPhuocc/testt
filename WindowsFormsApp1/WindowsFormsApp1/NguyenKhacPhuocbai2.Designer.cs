namespace WindowsFormsApp1
{
    partial class NguyenKhacPhuocbai2
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
            this.thang = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.TextBox();
            this.ádasd = new System.Windows.Forms.Label();
            this.tháng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thang
            // 
            this.thang.Location = new System.Drawing.Point(323, 116);
            this.thang.Multiline = true;
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(231, 31);
            this.thang.TabIndex = 0;
            this.thang.TextChanged += new System.EventHandler(this.thang_TextChanged);
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(323, 179);
            this.nam.Multiline = true;
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(231, 31);
            this.nam.TabIndex = 1;
            this.nam.TextChanged += new System.EventHandler(this.nam_TextChanged);
            // 
            // ádasd
            // 
            this.ádasd.AutoSize = true;
            this.ádasd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ádasd.Location = new System.Drawing.Point(227, 121);
            this.ádasd.Name = "ádasd";
            this.ádasd.Size = new System.Drawing.Size(69, 26);
            this.ádasd.TabIndex = 2;
            this.ádasd.Text = "tháng:";
            this.ádasd.Click += new System.EventHandler(this.label1_Click);
            // 
            // tháng
            // 
            this.tháng.AutoSize = true;
            this.tháng.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tháng.Location = new System.Drawing.Point(227, 184);
            this.tháng.Name = "tháng";
            this.tháng.Size = new System.Drawing.Size(58, 26);
            this.tháng.TabIndex = 3;
            this.tháng.Text = "năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "nhập vào ngày tháng năm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(479, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "hiển thị ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(323, 286);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(231, 31);
            this.ketqua.TabIndex = 6;
            this.ketqua.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "kết quả";
            // 
            // NguyenKhacPhuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tháng);
            this.Controls.Add(this.ádasd);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Name = "NguyenKhacPhuoc";
            this.Text = "Formtinhsongay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox thang;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.Label ádasd;
        private System.Windows.Forms.Label tháng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label2;
    }
}
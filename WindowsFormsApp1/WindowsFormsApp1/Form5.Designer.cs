namespace WindowsFormsApp1
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thoat = new System.Windows.Forms.Button();
            this.xoaitem = new System.Windows.Forms.Button();
            this.capnhatitem = new System.Windows.Forms.Button();
            this.themmoi = new System.Windows.Forms.Button();
            this.cbolop = new System.Windows.Forms.ComboBox();
            this.lop1 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.ngaysinh1 = new System.Windows.Forms.Label();
            this.diachi1 = new System.Windows.Forms.Label();
            this.hoten1 = new System.Windows.Forms.Label();
            this.masinhvien1 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.masinhvien = new System.Windows.Forms.TextBox();
            this.bangtt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangtt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.xoaitem);
            this.groupBox1.Controls.Add(this.capnhatitem);
            this.groupBox1.Controls.Add(this.themmoi);
            this.groupBox1.Controls.Add(this.cbolop);
            this.groupBox1.Controls.Add(this.lop1);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.ngaysinh1);
            this.groupBox1.Controls.Add(this.diachi1);
            this.groupBox1.Controls.Add(this.hoten1);
            this.groupBox1.Controls.Add(this.masinhvien1);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.masinhvien);
            this.groupBox1.Location = new System.Drawing.Point(101, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin sinh viên";
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(532, 10);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(179, 232);
            this.thoat.TabIndex = 18;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoaitem
            // 
            this.xoaitem.Location = new System.Drawing.Point(377, 161);
            this.xoaitem.Name = "xoaitem";
            this.xoaitem.Size = new System.Drawing.Size(128, 62);
            this.xoaitem.TabIndex = 17;
            this.xoaitem.Text = "Xoá Item";
            this.xoaitem.UseVisualStyleBackColor = true;
            this.xoaitem.Click += new System.EventHandler(this.xoaitem_Click);
            // 
            // capnhatitem
            // 
            this.capnhatitem.Location = new System.Drawing.Point(377, 100);
            this.capnhatitem.Name = "capnhatitem";
            this.capnhatitem.Size = new System.Drawing.Size(128, 62);
            this.capnhatitem.TabIndex = 16;
            this.capnhatitem.Text = "Cập nhật Item";
            this.capnhatitem.UseVisualStyleBackColor = true;
            this.capnhatitem.Click += new System.EventHandler(this.capnhatitem_Click);
            // 
            // themmoi
            // 
            this.themmoi.Location = new System.Drawing.Point(377, 39);
            this.themmoi.Name = "themmoi";
            this.themmoi.Size = new System.Drawing.Size(128, 62);
            this.themmoi.TabIndex = 15;
            this.themmoi.Text = "Thêm mới";
            this.themmoi.UseVisualStyleBackColor = true;
            this.themmoi.Click += new System.EventHandler(this.themmoi_Click);
            // 
            // cbolop
            // 
            this.cbolop.FormattingEnabled = true;
            this.cbolop.Items.AddRange(new object[] {
            "73DCTT25",
            "73DCTT24"});
            this.cbolop.Location = new System.Drawing.Point(102, 199);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(244, 24);
            this.cbolop.TabIndex = 14;
            // 
            // lop1
            // 
            this.lop1.AutoSize = true;
            this.lop1.Location = new System.Drawing.Point(20, 202);
            this.lop1.Name = "lop1";
            this.lop1.Size = new System.Drawing.Size(30, 16);
            this.lop1.TabIndex = 13;
            this.lop1.Text = "Lớp";
            // 
            // ngaysinh
            // 
            this.ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinh.Location = new System.Drawing.Point(102, 160);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(244, 22);
            this.ngaysinh.TabIndex = 12;
            // 
            // ngaysinh1
            // 
            this.ngaysinh1.AutoSize = true;
            this.ngaysinh1.Location = new System.Drawing.Point(20, 166);
            this.ngaysinh1.Name = "ngaysinh1";
            this.ngaysinh1.Size = new System.Drawing.Size(67, 16);
            this.ngaysinh1.TabIndex = 11;
            this.ngaysinh1.Text = "Ngày sinh";
            // 
            // diachi1
            // 
            this.diachi1.AutoSize = true;
            this.diachi1.Location = new System.Drawing.Point(20, 123);
            this.diachi1.Name = "diachi1";
            this.diachi1.Size = new System.Drawing.Size(47, 16);
            this.diachi1.TabIndex = 5;
            this.diachi1.Text = "Địa chỉ";
            // 
            // hoten1
            // 
            this.hoten1.AutoSize = true;
            this.hoten1.Location = new System.Drawing.Point(20, 83);
            this.hoten1.Name = "hoten1";
            this.hoten1.Size = new System.Drawing.Size(46, 16);
            this.hoten1.TabIndex = 4;
            this.hoten1.Text = "Họ tên";
            // 
            // masinhvien1
            // 
            this.masinhvien1.AutoSize = true;
            this.masinhvien1.Location = new System.Drawing.Point(20, 46);
            this.masinhvien1.Name = "masinhvien1";
            this.masinhvien1.Size = new System.Drawing.Size(47, 16);
            this.masinhvien1.TabIndex = 3;
            this.masinhvien1.Text = "Mã SV";
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(102, 120);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(244, 22);
            this.diachi.TabIndex = 2;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(102, 80);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(244, 22);
            this.hoten.TabIndex = 1;
            // 
            // masinhvien
            // 
            this.masinhvien.Location = new System.Drawing.Point(102, 43);
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.Size = new System.Drawing.Size(244, 22);
            this.masinhvien.TabIndex = 0;
            this.masinhvien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bangtt
            // 
            this.bangtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangtt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bangtt.Location = new System.Drawing.Point(101, 314);
            this.bangtt.Name = "bangtt";
            this.bangtt.RowHeadersWidth = 51;
            this.bangtt.RowTemplate.Height = 24;
            this.bangtt.Size = new System.Drawing.Size(922, 150);
            this.bangtt.TabIndex = 1;
            this.bangtt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangtt_CellClick);
            this.bangtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangtt_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lớp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 561);
            this.Controls.Add(this.bangtt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "NguyenKhacPhuoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lop1;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Label ngaysinh1;
        private System.Windows.Forms.Label diachi1;
        private System.Windows.Forms.Label hoten1;
        private System.Windows.Forms.Label masinhvien1;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox masinhvien;
        private System.Windows.Forms.ComboBox cbolop;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoaitem;
        private System.Windows.Forms.Button capnhatitem;
        private System.Windows.Forms.Button themmoi;
        private System.Windows.Forms.DataGridView bangtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.capnhat = new System.Windows.Forms.Button();
            this.nhapso = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxdanhsach = new System.Windows.Forms.ListBox();
            this.tongcacuoc = new System.Windows.Forms.Button();
            this.uocsochan = new System.Windows.Forms.Button();
            this.songuyento = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.capnhat);
            this.groupBox1.Controls.Add(this.nhapso);
            this.groupBox1.Location = new System.Drawing.Point(105, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(135, 38);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(100, 31);
            this.capnhat.TabIndex = 1;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // nhapso
            // 
            this.nhapso.Location = new System.Drawing.Point(7, 42);
            this.nhapso.Name = "nhapso";
            this.nhapso.Size = new System.Drawing.Size(109, 22);
            this.nhapso.TabIndex = 0;
            this.nhapso.TextChanged += new System.EventHandler(this.nhapso_TextChanged);
            this.nhapso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhapso_KeyDown);
            this.nhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxdanhsach);
            this.groupBox2.Location = new System.Drawing.Point(369, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // listBoxdanhsach
            // 
            this.listBoxdanhsach.FormattingEnabled = true;
            this.listBoxdanhsach.ItemHeight = 16;
            this.listBoxdanhsach.Location = new System.Drawing.Point(6, 21);
            this.listBoxdanhsach.Name = "listBoxdanhsach";
            this.listBoxdanhsach.Size = new System.Drawing.Size(229, 116);
            this.listBoxdanhsach.TabIndex = 0;
            // 
            // tongcacuoc
            // 
            this.tongcacuoc.Location = new System.Drawing.Point(368, 257);
            this.tongcacuoc.Name = "tongcacuoc";
            this.tongcacuoc.Size = new System.Drawing.Size(242, 23);
            this.tongcacuoc.TabIndex = 2;
            this.tongcacuoc.Text = "Tổng các ước số";
            this.tongcacuoc.UseVisualStyleBackColor = true;
            this.tongcacuoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // uocsochan
            // 
            this.uocsochan.Location = new System.Drawing.Point(368, 286);
            this.uocsochan.Name = "uocsochan";
            this.uocsochan.Size = new System.Drawing.Size(242, 23);
            this.uocsochan.TabIndex = 3;
            this.uocsochan.Text = "Số lượng các ước số chẵn";
            this.uocsochan.UseVisualStyleBackColor = true;
            this.uocsochan.Click += new System.EventHandler(this.button3_Click);
            // 
            // songuyento
            // 
            this.songuyento.Location = new System.Drawing.Point(368, 315);
            this.songuyento.Name = "songuyento";
            this.songuyento.Size = new System.Drawing.Size(242, 23);
            this.songuyento.TabIndex = 4;
            this.songuyento.Text = "Số lượng các ước số nguyên tố";
            this.songuyento.UseVisualStyleBackColor = true;
            this.songuyento.Click += new System.EventHandler(this.button4_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(271, 341);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.songuyento);
            this.Controls.Add(this.uocsochan);
            this.Controls.Add(this.tongcacuoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "NguyenPhuHai";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.TextBox nhapso;
        private System.Windows.Forms.ListBox listBoxdanhsach;
        private System.Windows.Forms.Button tongcacuoc;
        private System.Windows.Forms.Button uocsochan;
        private System.Windows.Forms.Button songuyento;
        private System.Windows.Forms.Button thoat;
    }
}
namespace WindowsFormsApp1
{
    partial class comboboxlistbox
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
            this.cbomonhoc = new System.Windows.Forms.ComboBox();
            this.monhoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbomonhoc
            // 
            this.cbomonhoc.FormattingEnabled = true;
            this.cbomonhoc.Items.AddRange(new object[] {
            "lập trình trực quan C#",
            "cấu trúc dữ liệu và giải thuật ",
            "phân tích và thiết kế hệ thống thông tin ",
            "hệ quản trị cơ sở dữ liệu spl server"});
            this.cbomonhoc.Location = new System.Drawing.Point(279, 212);
            this.cbomonhoc.Name = "cbomonhoc";
            this.cbomonhoc.Size = new System.Drawing.Size(346, 24);
            this.cbomonhoc.TabIndex = 0;
            this.cbomonhoc.SelectedIndexChanged += new System.EventHandler(this.cbomonhoc_SelectedIndexChanged);
            // 
            // monhoc
            // 
            this.monhoc.Location = new System.Drawing.Point(280, 136);
            this.monhoc.Name = "monhoc";
            this.monhoc.Size = new System.Drawing.Size(345, 22);
            this.monhoc.TabIndex = 1;
            this.monhoc.TextChanged += new System.EventHandler(this.monhoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Môn học";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(550, 174);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 3;
            this.them.Text = "thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(280, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 148);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboboxlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monhoc);
            this.Controls.Add(this.cbomonhoc);
            this.Name = "comboboxlistbox";
            this.Text = "comboboxlistbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbomonhoc;
        private System.Windows.Forms.TextBox monhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.ListBox listBox1;
    }
}
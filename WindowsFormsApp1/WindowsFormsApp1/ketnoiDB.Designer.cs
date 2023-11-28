namespace WindowsFormsApp1
{
    partial class ketnoiDB
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
            this.dgvloaisach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvloaisach
            // 
            this.dgvloaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaisach.Location = new System.Drawing.Point(278, 123);
            this.dgvloaisach.Name = "dgvloaisach";
            this.dgvloaisach.RowHeadersWidth = 51;
            this.dgvloaisach.RowTemplate.Height = 24;
            this.dgvloaisach.Size = new System.Drawing.Size(384, 251);
            this.dgvloaisach.TabIndex = 0;
            this.dgvloaisach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaisach_CellContentClick);
            // 
            // ketnoiDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvloaisach);
            this.Name = "ketnoiDB";
            this.Text = "ketnoiDB";
            this.Load += new System.EventHandler(this.ketnoiDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloaisach;
    }
}
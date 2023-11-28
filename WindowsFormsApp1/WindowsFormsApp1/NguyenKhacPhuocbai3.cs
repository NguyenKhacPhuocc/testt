using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NguyenKhacPhuocbai3 : Form
    {
        public NguyenKhacPhuocbai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NguyenKhacPhuocbai3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nhapa.Text);
            int b = int.Parse(nhapb.Text);
            if (a == 0 && b!=0)
            {
                ketqua.Text = "phương trình vô nghiệm ";
            }
            else if (a == 0 && b == 0)
            {
                ketqua.Text = "phương trình có vô số nghiệm ";
            }
            else ketqua.Text = string.Format(" phương trình có nghiệm x = {0} ", (float)-b/a );
        }
    }
}

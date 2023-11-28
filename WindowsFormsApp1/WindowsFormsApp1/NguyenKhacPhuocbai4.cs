using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NguyenKhacPhuocbai4 : Form
    {
        public NguyenKhacPhuocbai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nhapn.Text);
            int sum = 0;
            string a = "các số thoả mãn là: ";
            for(int i = 0; i < n; i++)
            {
                if(i%3==0 && i%2==1)
                {
                    sum = sum + i;
                    a = a + " " + i;
                }
            }
            string b = "tổng các số thoả mãn là: " + sum;
            ketqua.Text = a + "\r\n" + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class NguyenKhacPhuocbai1 : Form
    {
        public NguyenKhacPhuocbai1()
        {
            InitializeComponent();
        }

        
         private void txtA_TextChanged(object sender, EventArgs e)
                {
                    txtB.Text = txtA.Text; 
                }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            if (a == 0)
            {
                MessageBox.Show("nhap lai");
                return;
            }
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                txtketqua.Text = "phuong trinh vo nghiem";

            }else if (delta == 0) 
            {
                double x = -b / (2 * a);
                txtketqua.Text = "phuong trinh co nghiem kep x= "+ x;
            }
            else
            {
                double x1= (-b - Math.Sqrt(delta)) / (2 * a);
                double x2= (-b + Math.Sqrt(delta)) / (2 * a);
                txtketqua.Text = "phuong trinh co 2 nghiem kep x1 = " + x1 + "\n x2 = " + x2 + "";
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar>='0' && e.KeyChar <= '9' || e.KeyChar==(char)8))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}

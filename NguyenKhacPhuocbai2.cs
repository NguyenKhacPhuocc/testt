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
    public partial class NguyenKhacPhuocbai2 : Form
    {
        public NguyenKhacPhuocbai2()
        {
            InitializeComponent();
        }
        private void thang_TextChanged(object sender, EventArgs e)
        {

        }
        private void ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void nam_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new NguyenKhacPhuocbai3();
            f.Show();
            int a = int.Parse(thang.Text);
            int b = int.Parse(nam.Text);
            switch(a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ketqua.Text = string.Format("thang {0} nam {1} co 31 ngay", a, b);
                    break;
                case 4:
                case 6:
                case 9:
                case 11: 
                    ketqua.Text = string.Format("thang {0} nam {1} co 30 ngay", a, b);
                    break;
                case 2:
                    if (b%100==0)
                    {
                        if (b%400==0)
                        {
                            ketqua.Text = string.Format("thang {0} nam {1} co 29 ngay", a, b);
                        }
                        else ketqua.Text = string.Format("thang {0} nam {1} co 28 ngay", a, b);
                    }
                    else if (b%4==0)
                    {
                        ketqua.Text = string.Format("thang {0} nam {1} co 29 ngay", a, b);
                    }
                    else ketqua.Text = string.Format("thang {0} nam {1} co 28 ngay", a, b);
                    break;
            }
        }
    }
}

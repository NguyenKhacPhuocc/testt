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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ và tên: " + hoten.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn mở chương trình người dùng", "người dùng", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) 
                == DialogResult.Cancel)
                Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                hoten.Text = " Trường ĐH công nghệ GTVT";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                MessageBox.Show("bạn vừa nhấn chuột trái");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("bạn vừa nhấn chuột phải");
            }
            if(e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("bạn vừa nhấn chuột giữa");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl= MessageBox.Show("bạn có chắc chắn thoát không?","Quit",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if(dl== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

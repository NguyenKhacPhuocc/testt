using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void capnhat_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nhapso.Text);
            if (!comboBox1.Items.Contains(nhapso.Text))
            {
                comboBox1.Items.Add(nhapso.Text);
                nhapso.Clear();
                nhapso.Focus();
            }
            if (comboBox1.Items.Contains(nhapso.Text))
            {
                nhapso.Clear();
                nhapso.Focus();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxdanhsach.Items.Clear();
            int a = int.Parse(comboBox1.SelectedItem.ToString());
            for(int i = 1; i<= a; i++)
            {
                if (a % i == 0)
                {
                    listBoxdanhsach.Items.Add(i.ToString());
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int a = int.Parse(comboBox1.SelectedItem.ToString());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    sum = sum + i;
                }
            }
            MessageBox.Show("Tổng các ước số: " + sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int a = int.Parse(comboBox1.SelectedItem.ToString());
            for(int i = 1; i<=a; i++)
            {
                if(a % i == 0 && i % 2 == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show("Số lượng các ước là số chẵn: " + dem);
        }
        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox1.SelectedItem.ToString());
            int dem = 0;
            for(int i = 2; i < a; i++)
            {
                if(a % i == 0 && IsPrime(i))
                {
                    dem++;
                }
            }
            MessageBox.Show("Số lượng các ước số nguyên tố: " + dem);
        }

        private void nhapso_TextChanged(object sender, EventArgs e)
        {
            nhapso.Focus();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn có chắc chắn thoát không?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            
        }

        private void nhapso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(nhapso.Text);
                nhapso.Clear();
            }
        }
    }
}


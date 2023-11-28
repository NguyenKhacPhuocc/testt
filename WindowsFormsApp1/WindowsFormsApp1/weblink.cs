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
    public partial class weblink : Form
    {
        public weblink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!listBoxhien.Items.Contains(listBoxthem.Text))
            {
                listBoxhien.Items.Add(listBoxthem.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxhien.Items.Clear();
        }

        private void listBoxthem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!listBoxhien.Items.Contains(listBoxthem.Text))
            {
                listBoxhien.Items.Add(listBoxthem.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void weblink_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listBoxhien;
        }
    }
}

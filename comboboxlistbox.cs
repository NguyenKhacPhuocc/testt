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
    public partial class comboboxlistbox : Form
    {
        public comboboxlistbox()
        {
            InitializeComponent();
        }

        private void cbomonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(cbomonhoc.SelectedItem.ToString());
        }

        private void monhoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            if(!cbomonhoc.Items.Contains(monhoc.Text))
            {
                cbomonhoc.Items.Add(monhoc.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

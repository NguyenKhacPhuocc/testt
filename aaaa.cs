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
    public partial class aaaa : Form
    {
        public aaaa()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aaaa_Load(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            bangtt.Rows.Add(hovaten.Text,cbogioitinh.SelectedItem.ToString(),date.Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bangtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            hovaten.Text = bangtt.Rows[i].Cells[0].Value.ToString();
            cbogioitinh.SelectedItem = bangtt.Rows[i].Cells[1].Value.ToString();
            date.Value =DateTime.Parse(bangtt.Rows[i].Cells[2].Value.ToString());
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            bangtt.Rows.RemoveAt(bangtt.CurrentRow.Index);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            bangtt.CurrentRow.Cells[0].Value = hovaten.Text;
            bangtt.CurrentRow.Cells[1].Value = cbogioitinh.Text;
            bangtt.CurrentRow.Cells[2].Value = date.Value;
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void themmoi_Click(object sender, EventArgs e)
        {
            bangtt.Rows.Add(masinhvien.Text, hoten.Text, diachi.Text, ngaysinh.Value.ToString(),cbolop.SelectedItem.ToString());
        }

        private void capnhatitem_Click(object sender, EventArgs e)
        {
            bangtt.CurrentRow.Cells[0].Value = masinhvien.Text;
            bangtt.CurrentRow.Cells[1].Value = hoten.Text;
            bangtt.CurrentRow.Cells[2].Value = diachi.Text;
            bangtt.CurrentRow.Cells[3].Value = ngaysinh.Value;
            bangtt.CurrentRow.Cells[4].Value = cbolop.Text;
        }

        private void bangtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void xoaitem_Click(object sender, EventArgs e)
        {
            bangtt.Rows.RemoveAt(bangtt.CurrentRow.Index);
        }

        private void bangtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            masinhvien.Text = bangtt.Rows[i].Cells[0].Value.ToString();
            hoten.Text = bangtt.Rows[i].Cells[1].Value.ToString();
            diachi.Text = bangtt.Rows[i].Cells[2].Value.ToString();
            ngaysinh.Value = DateTime.Parse(bangtt.Rows[i].Cells[3].Value.ToString());
            cbolop.SelectedItem = bangtt.Rows[i].Cells[4].Value.ToString();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn có chắc chắn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

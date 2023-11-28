using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class ketnoiDB : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public ketnoiDB()
        {
            InitializeComponent();
        }

        private void dgvloaisach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load_dvgloaisach()
        {
            //buoc1 ket noi den DB
            //SqlConnection con = new SqlConnection("Data Source=NGUYENKHACPHUOC;Initial Catalog=73DCTT25_QLKTX;User ID=sa;Password = 0812");
            //con.ConnectionString = "Data Source=NGUYENKHACPHUOC;Initial Catalog=73DCTT25_quanlycuahang2;Persist Security Info=True;User ID=sa";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //buoc2 tao doi tuong command de thuc hien truy van 
            string sql = "Select *From loaisach";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Connection = con;
            //cmd.CommandText = "Select *From loaisach";
            //bước 3 tạo đối tượng đataadapter để lấy dl từ cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //bước 3 đổ dữ liệu từ da vào datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose(); // giải phóng bộ nhớ
            con.Close(); // ngắt kết nối
            //bước 5 hiển thị tb lên datagridview
            dgvloaisach.DataSource = tb;
            dgvloaisach.Refresh();
        }
        private void ketnoiDB_Load(object sender, EventArgs e)
        {
            load_dvgloaisach();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void aToolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void thuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb_thunhap.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gb_thunhap.Hide();

        }

        private void gb_thunhap_Enter(object sender, EventArgs e)
        {

        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllThuNhap().Tables[0];
            //dataGridView1.DataMember = "ThuNhap";
        }
        //Connection String
        DataSet GetAllThuNhap()
        {
            DataSet data = new DataSet();
            //SqlConnection, sau khi sai xong la bo, giai phong bo nho
            string query = "select * from ThuNhap";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
                //SqlCommand
                //SqlAdapter
                return data;
        }
    }
}

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
            tb_tk.Text = "ahihi";
            tb_mk.Text = "ahihi";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_tk.Text.Length == 0)
            {
                lbloi.Text = "Vui Lòng Nhập Tài Khoản";
                lbloi.Visible = true;
            }

            else if (this.tb_mk.Text.Length == 0)
            {
                lbloi.Visible = true;
                lbloi.Text = "Vui lòng Nhập Mật Khẩu";

            }
            else
            {
                lbloi.Visible = false;
            }
            if (this.tb_tk.Text.CompareTo("ahihi") == 0 && tb_mk.Text.CompareTo("ahihi") == 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                lbloi.Visible = false;

                Visible = false;
                ShowInTaskbar = false;

                FormMenu formMenu = new FormMenu();
                formMenu.Activate();
                formMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                lbloi.Visible = false;
            }
        }

        private void tb_tk_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

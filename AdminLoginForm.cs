using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServerHacking
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login Successful");
                Get_IPAdress_and_other_websites_by_webserver_hacking getipaddress = new Get_IPAdress_and_other_websites_by_webserver_hacking();
                getipaddress.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful.Please check the login credentials.");
            }
        }
    }
}

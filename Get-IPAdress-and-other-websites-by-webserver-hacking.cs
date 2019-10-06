using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebServerHacking
{
    public partial class Get_IPAdress_and_other_websites_by_webserver_hacking : Form
    {
        public Get_IPAdress_and_other_websites_by_webserver_hacking()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        Hacking_Library.hacking hackingLibrary = new Hacking_Library.hacking();
        private void button1_Click(object sender, EventArgs e)
        {
            var address = Dns.GetHostAddresses(textBox1.Text)[hackingLibrary.HostArguments()];
            textBox2.Text = address.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAdd = textBox2.Text;
                textBox3.Text = hackingLibrary.GetIPAddress(ipAdd);
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Find_Protocol_in_the_server findprotocol = new Find_Protocol_in_the_server();
            findprotocol.Show();
            this.Hide();
        }
    }
}

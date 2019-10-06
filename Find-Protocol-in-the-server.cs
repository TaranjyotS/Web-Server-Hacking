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
    public partial class Find_Protocol_in_the_server : Form
    {
        public Find_Protocol_in_the_server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri("Enter Website Name");
            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(myUri);

            myrequest.ProtocolVersion = HttpVersion.Version10;
            HttpWebResponse myresponse = (HttpWebResponse)myrequest.GetResponse();

            if (myresponse.ProtocolVersion != HttpVersion.Version10)
            {
                textBox1.Text = myresponse.ProtocolVersion.Minor.ToString();
                textBox2.Text = myresponse.ProtocolVersion.Major.ToString();
                textBox3.Text = "http" + myresponse.ProtocolVersion.ToString();
            }
            if (myresponse.StatusCode == HttpStatusCode.OK)
            {
                textBox4.Text = "Response Sent using Version" + textBox3.Text + "Successfully received response with the version of" + textBox3.Text;
            }
            myresponse.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebsiteSniffing websiteSniffing = new WebsiteSniffing();
            websiteSniffing.Show();
            this.Hide();
        }
    }
}

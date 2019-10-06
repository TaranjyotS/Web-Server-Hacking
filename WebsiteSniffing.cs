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
    public partial class WebsiteSniffing : Form
    {
        public WebsiteSniffing()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        Hacking_Library.hacking hackingLibrary = new Hacking_Library.hacking();

        private void button1_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri("Enter Website Name");
            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(myUri);

            myrequest.ProtocolVersion = HttpVersion.Version10;
            HttpWebResponse myresponse = (HttpWebResponse)myrequest.GetResponse();

            richTextBox1.Text = myresponse.Headers.ToString();

            textBox1.Text = "The destination Remote Server is:" + myresponse.Server;
            textBox2.Text = "The destination Remote Server Character Set is:" + myresponse.CharacterSet;

            string contentType = myresponse.ContentType;
            string MainPageType = contentType.Substring(hackingLibrary.bytes(), contentType.IndexOf(hackingLibrary.HttpResponse()));
            //text and its a html page

            if (String.Compare(MainPageType, hackingLibrary.HttpResponseText()) == 0)
            {
                textBox3.Text = "Content Type is a text format.";
            }
            else
            {
                textBox3.Text = "Content Type is not a text format and it can be any other formats like image.";
            }
            if (myresponse.StatusCode.ToString() == "OK")
            {
                int val = 200;
                textBox4.Text = "The Status Code of the Web Response is " + val.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_for_Vulnerability_Open_Ports_in_the_WebServer portScanner = new Check_for_Vulnerability_Open_Ports_in_the_WebServer();
            portScanner.Show();
            this.Hide();
        }
    }
}

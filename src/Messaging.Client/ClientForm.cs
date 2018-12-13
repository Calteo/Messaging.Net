using Messaging.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging.Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = $"tcp://{Dns.GetHostName()}:55833/server";
        }

        public Sender Sender { get; set; }

        private void ButtonSendHelloClick(object sender, EventArgs e)
        {
            try
            {
                Sender.Post("hello", textBoxHello.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void ButtonConnectClick(object sender, EventArgs e)
        {
            Sender = Sender.Create(textBoxServer.Text);
        }
    }
}

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

            Receiver = new ClientReceiver(this);
            Receiver.AddListener($"tcp://{Dns.GetHostName()}:55933/client");
            Receiver.Start();
        }

        public Sender Sender { get; set; }
        public ReceiverBase Receiver { get; set; }

        private void ButtonSendHelloClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Sender.Post("hello", textBoxHello.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ButtonConnectClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Sender = Sender.Create(textBoxServer.Text);
            Cursor = Cursors.Default;
        }

        public void GotAnswer(string text)
        {
            MessageBox.Show(this, text, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSayHelloClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Sender.Post("sayhello", textBoxSayHello.Text, Receiver);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}

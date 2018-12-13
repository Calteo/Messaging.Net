using Messaging.Core;
using System;
using System.Net;
using System.Windows.Forms;

namespace Messaging.Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();        
        }

        public ReceiverBase Receiver { get; set; }

        private void ServerFormLoad(object sender, System.EventArgs e)
        {
            Receiver = new ServerReceiver(this);
            var listener = Receiver.AddListener($"tcp://{Dns.GetHostName()}:55833/server");
            textBoxServer.Text = listener.Uri.ToString();

            Receiver.Start();
        }

        public void AddHello(string text)
        {
            textBoxMessages.Text += $"{DateTime.Now:HH:mm:ss}: Hello '{text}'" + Environment.NewLine;
        }

        public void SayHello(string text)
        {
            textBoxMessages.Text += $"{DateTime.Now:HH:mm:ss}: SayHello '{text}'" + Environment.NewLine;
            MessageBox.Show(this, $"Say hello to {text}.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

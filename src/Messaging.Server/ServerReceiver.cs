using Messaging.Core;
using Messaging.Forms;
using System;

namespace Messaging.Server
{
    class ServerReceiver : ControlReceiver
    {
        public ServerReceiver(ServerForm form) : base(form)
        {
            Form = form;
        }

        public ServerForm Form { get; private set; }

        [MessageHandler("hello")]
        private void Hello(string name)
        {
            Form.AddHello(name);
        }

        [MessageHandler("sayhello")]
        private void SayHello(string name, Sender replyTo)
        {
            Form.SayHello(name);
            replyTo.Post("answer", $"Hello {name}.");
        }
    }
}
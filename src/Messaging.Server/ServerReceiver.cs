using Messaging.Core;
using System;

namespace Messaging.Server
{
    class ServerReceiver : Receiver
    {
        public ServerReceiver(ServerForm form)
        {
            Form = form;
            HelloAction = new Action<string>(Form.AddHello);
            SayHelloAction = new Action<string>(Form.SayHello);
        }

        public ServerForm Form { get; private set; }
        public Action<string> HelloAction { get; private set; }
        public Action<string> SayHelloAction { get; private set; }

        [MessageHandler("hello")]
        private void Hello(string name)
        {
            Form.BeginInvoke(HelloAction, new object[] { name });
        }

        [MessageHandler("sayhello")]
        private void SayHello(string name, Sender replyTo)
        {
            Form.Invoke(SayHelloAction, new object[] { name });
            replyTo.Post("answer", $"Hello {name}.");
        }
    }
}
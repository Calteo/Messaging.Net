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
        }

        public ServerForm Form { get; private set; }
        public Action<string> HelloAction { get; private set; }

        [MessageHandler("hello")]
        private void Hello(string name)
        {
            Form.BeginInvoke(HelloAction, new object[] { name });
        }
    }
}
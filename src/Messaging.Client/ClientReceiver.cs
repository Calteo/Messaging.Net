using Messaging.Core;
using System;

namespace Messaging.Client
{
    class ClientReceiver : Receiver
    {
        public ClientReceiver(ClientForm form)
        {
            Form = form;
            AnswerAction = new Action<string>(Form.GotAnswer);
        }

        public ClientForm Form { get; private set; }
        public Action<string> AnswerAction { get; private set; }

        [MessageHandler("answer")]
        private void Answer(string name)
        {
            Form.BeginInvoke(AnswerAction, new object[] { name });
        }
    }
}

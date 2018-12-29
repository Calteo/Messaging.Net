using Messaging.Core;
using Messaging.Forms;

namespace Messaging.Client
{
    class ClientReceiver : ControlReceiver
    {
        public ClientReceiver(ClientForm form) : base(form)
        {
            Form = form;
        }

        public ClientForm Form { get; private set; }

        [MessageHandler("answer")]
        private void Answer(string name)
        {
            Form.GotAnswer(name);
        }
    }
}

using Messaging.Core;
using System;
using System.Windows.Forms;

namespace Messaging.Forms
{
    /// <summary>
    /// A <see cref="Reciever"/> for <see cref="Control"/>s.
    /// </summary>
    /// <remarks>
    /// All messages are automatically processed on the UI thread.
    /// </remarks>
    public class ControlReceiver : Receiver
    {
        public ControlReceiver(Control control)
        {
            Control = control;
            _handler = new Action<Core.Message>(OnReceived);
        }

        public Control Control { get; set; }
        private Action<Core.Message> _handler;
        
        protected override void OnReceived(Core.Message message)
        {
            if (Control.InvokeRequired)
                Control.BeginInvoke(_handler, message);
            else
                base.OnReceived(message);
        }
    }
}

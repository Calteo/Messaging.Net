using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Core
{
    /// <summary>
    /// A <see cref="Receiver"/> for <see cref="Controls"/>.   
    /// </summary>
    /// <remarks>
    /// All message calls are automatically transfered to the UI Thread, so manipulating the UI is possible 
    /// in the message processing.
    /// </remarks>
    public class ControlReceiver : Receiver
    {
        public ControlReceiver(Control control)
        {

        }
    }
}

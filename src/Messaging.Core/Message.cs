using System;

namespace Messaging.Core
{
    [Serializable]
    internal class Message
    {
        public Message(string name, params object[] args)
        {
            Name = name;
            Arguments = args;
        }

        public string Name { get; }
        public object[] Arguments { get; private set; }
    }
}

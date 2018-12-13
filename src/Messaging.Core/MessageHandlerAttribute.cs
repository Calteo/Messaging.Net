using System;

namespace Messaging.Core
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public sealed class MessageHandlerAttribute : Attribute
    {
        public MessageHandlerAttribute(string name)
        {
            if (name != name.ToLower())
                throw new ArgumentException($"Name of message handler ({name}) is not lowercase.", nameof(name));
            Name = name;
        }

        public string Name { get; }
    }
}

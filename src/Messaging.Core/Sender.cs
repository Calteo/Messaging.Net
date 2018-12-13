using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Messaging.Core
{
    public abstract class Sender
    {
        static Sender()
        {
            _senderTypes = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => typeof(Sender).IsAssignableFrom(t) && t.GetCustomAttribute<SchemeAttribute>() != null)
                            .ToDictionary(t => t.GetCustomAttribute<SchemeAttribute>().Name);
        }

        private static Dictionary<string, Type> _senderTypes;

        public static Sender Create(string connection)
        {
            var uri = new Uri(connection);

            if (!_senderTypes.TryGetValue(uri.Scheme, out Type senderType))
                throw new ArgumentException($"Invalid scheme on connection ({connection}).", nameof(connection));

            var sender = (Sender)Activator.CreateInstance(senderType, new object[] { uri });

            return sender;
        }

        internal Sender(Uri uri)
        {
            Uri = uri;
        }

        public Uri Uri { get; }

        public void Post(string name, params object[] args)
        {
            var message = new Message(name, args);
            var stream = new MemoryStream();

            OnBeforeEncode(message, stream);

            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, message);

            OnAfterEncode(message, stream);
            Post(stream);
        }

        internal virtual void OnBeforeEncode(Message message, MemoryStream stream)
        {
        }

        internal virtual void OnAfterEncode(Message message, MemoryStream stream)
        {
        }

        internal abstract void Post(MemoryStream stream);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Messaging.Core
{
    public abstract class Listener
    {
        static Listener()
        {
            _listenerTypes = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => typeof(Listener).IsAssignableFrom(t) && t.GetCustomAttribute<SchemeAttribute>() != null)
                            .ToDictionary(t => t.GetCustomAttribute<SchemeAttribute>().Name);
        }

        private static Dictionary<string, Type> _listenerTypes;

        internal static Listener Create(string connection)
        {
            var uri = new Uri(connection);

            if (!_listenerTypes.TryGetValue(uri.Scheme, out Type listenerType))
                throw new ArgumentException($"Invalid scheme on connection ({connection}).", nameof(connection));

            var listener = (Listener)Activator.CreateInstance(listenerType, new object[] { uri });

            return listener;
        }

        protected Listener(Uri uri)
        {
            Uri = uri;
        }

        public Uri Uri { get; protected set; }
        public ReceiverBase Receiver { get; internal set; }

        internal abstract void Start();
        internal abstract void Stop();
    }
}

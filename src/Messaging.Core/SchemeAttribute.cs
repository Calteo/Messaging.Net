using System;

namespace Messaging.Core
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal class SchemeAttribute : Attribute
    {
        public SchemeAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}

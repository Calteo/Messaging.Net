using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Core
{
    [Serializable]
    class EndPoint
    {
        public Uri Uri { get; set; }
    }
}

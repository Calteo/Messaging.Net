using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Messaging.Core
{
    [Scheme("udp")]
    public class SenderUdp : SenderSocket
    {
        public SenderUdp(Uri uri) : base(uri)
        {
            _udpClient = new UdpClient();
        }

        private UdpClient _udpClient;

        internal override void Post(MemoryStream stream)
        {
            Trace.WriteLine($"{Uri} - post - {stream.Length} bytes");

            var buffer = stream.ToArray();
            var send = _udpClient.Send(buffer, buffer.Length, EndPoint);

            Trace.WriteLine($"{Uri} - posted - {send} bytes");
        }
    }
}

using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Messaging.Core
{
    [Scheme("tcp")]
    public class SenderTcp : SenderSocket
    {
        public SenderTcp(Uri uri) : base(uri)
        {
            _tcpClient = new TcpClient(uri.Host, uri.Port);
        }

        private TcpClient _tcpClient;

        internal override void Post(MemoryStream stream)
        {
            Trace.WriteLine($"{Uri} - post - {stream.Length} bytes");

            if (!_tcpClient.Connected)
                throw new Exception("not connected");

            var length = stream.Length;
            stream.Position = 0;

            var lengthBuffer = BitConverter.GetBytes(stream.Length);

            var tcpStream = _tcpClient.GetStream();
            tcpStream.Write(lengthBuffer, 0, lengthBuffer.Length);
            stream.WriteTo(tcpStream);
            tcpStream.Flush();

            Trace.WriteLine($"{Uri} - posted - {stream.Length} bytes");
        }
    }
}

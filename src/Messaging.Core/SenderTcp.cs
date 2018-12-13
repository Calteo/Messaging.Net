using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Core
{
    [Scheme("tcp")]
    public class SenderTcp : Sender
    {
        public SenderTcp(Uri uri) : base(uri)
        {
            if (uri.Host == "")
                throw new ArgumentException($"No host given on connection ({uri.OriginalString}).", nameof(uri));

            if (uri.IsDefaultPort)
                throw new ArgumentException($"No port given on connection ({uri.OriginalString}).", nameof(uri));

            _tcpClient = new TcpClient(uri.Host, uri.Port);
        }

        private TcpClient _tcpClient;

        internal override void Post(MemoryStream stream)
        {
            if (!_tcpClient.Connected)
                throw new Exception("not connected");

            var length = stream.Length;
            stream.Position = 0;

            var lengthBuffer = BitConverter.GetBytes(stream.Length);

            var tcpStream = _tcpClient.GetStream();
            tcpStream.Write(lengthBuffer, 0, lengthBuffer.Length);
            stream.WriteTo(tcpStream);
            tcpStream.Flush();            
        }
    }
}

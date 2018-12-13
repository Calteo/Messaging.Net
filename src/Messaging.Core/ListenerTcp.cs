using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Messaging.Core
{
    [Scheme("tcp")]
    class ListenerTcp : Listener
    {
        private static readonly IPEndPoint DefaultLoopbackEndpoint = new IPEndPoint(IPAddress.Loopback, 0);

        public ListenerTcp(Uri uri) : base(uri)
        {
            if (IPAddress.TryParse(uri.Host, out IPAddress address))
                throw new ArgumentException($"Invalid address on connection ({uri.OriginalString}).", nameof(uri));
                            
            if (address == null)
            {
                address = Dns.GetHostAddresses(uri.Host).FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            }

            if (address == null)
                throw new ArgumentException($"Can not resolve address on connection ({uri.OriginalString}).", nameof(uri));

            if (uri.IsDefaultPort)
            {
                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.Bind(DefaultLoopbackEndpoint);
                    var port = ((IPEndPoint)socket.LocalEndPoint).Port;

                    _tcpListener = new TcpListener(address, port);

                    var builder = new UriBuilder(uri);
                    builder.Port = port;
                    Uri = builder.Uri;
                }
            }
            else
            {
                _tcpListener = new TcpListener(address, uri.Port);
            }                   
        }

        private TcpListener _tcpListener;

        internal override async void Start()
        {
            _tcpListener.Start();
            while (true)
            {
                try
                {
                    Trace.WriteLine("awaiting connection", "ListenerTcp.Start");
                    TcpClient tcpClient = await _tcpListener.AcceptTcpClientAsync();
                    Trace.WriteLine($"got connection - {tcpClient.Client.RemoteEndPoint}", "ListenerTcp.Start");
                    var task = StartHandleConnectionAsync(tcpClient);
                    // if already faulted, re-throw any error on the calling context
                    if (task.IsFaulted)
                        task.Wait();                                      
                }
                catch (Exception exception)
                {
                    Trace.WriteLine(exception.Message, "ListenerTcp.Start");
                }
            }
        }

        private async Task StartHandleConnectionAsync(TcpClient tcpClient)
        {
            // start the new connection task
            var connectionTask = HandleConnectionAsync(tcpClient);

            // catch all errors of HandleConnectionAsync
            try
            {
                // we may be on another thread after "await"
                await connectionTask;                
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.Message, "ListenerTcp.StartHandleConnectionAsync");
            }
        }

        private async Task HandleConnectionAsync(TcpClient tcpClient)
        {
            await Task.Yield();
            // continue asynchronously on another threads

            var clientEndPoint = tcpClient.Client.RemoteEndPoint;
            try
            {
                var networkStream = tcpClient.GetStream();
                var lengthBuffer = new byte[sizeof(long)];
                while (true)
                {
                    Trace.WriteLine($"{clientEndPoint} - awaiting request", "ListenerTcp.HandleConnectionAsync");

                    var length = await networkStream.ReadAsync(lengthBuffer, 0, lengthBuffer.Length);
                    if (length == lengthBuffer.Length)
                    {
                        var messageLength = BitConverter.ToInt64(lengthBuffer, 0);
                        var messageBuffer = new byte[messageLength];
                        var gotLength = await networkStream.ReadAsync(messageBuffer, 0, messageBuffer.Length);

                        Trace.WriteLine($"{clientEndPoint} - message read - {gotLength} bytes", "ListenerTcp.HandleConnectionAsync");

                        if (gotLength == messageLength)
                        {
                            var stream = new MemoryStream(messageBuffer);
                            var formatter = new BinaryFormatter();
                            var message = (Message)formatter.Deserialize(stream);

                            Trace.WriteLine($"{clientEndPoint} - message '{message.Name}' received", "ListenerTcp.HandleConnectionAsync");

                            Receiver.OnReceived(message);
                        }
                    }
                    else
                    {
                        Trace.WriteLine($"{clientEndPoint} - bad length input (length={length})", "ListenerTcp.HandleConnectionAsync");
                        break; // Client closed connection
                    }
                }
                Trace.WriteLine($"{clientEndPoint} - close", "ListenerTcp.HandleConnectionAsync");
                tcpClient.Close();
            }
            catch (Exception exception)
            {
                Trace.WriteLine($"{clientEndPoint} - " + exception.Message, "ListenerTcp.Process");

                if (tcpClient.Connected)
                {
                    Trace.WriteLine($"{clientEndPoint} - close@catch", "ListenerTcp.Process");
                    tcpClient.Close();
                }
            }
        }

        internal override void Stop()
        {
            _tcpListener.Stop();
        }
    }
}

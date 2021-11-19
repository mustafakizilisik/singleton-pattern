using System.Net;
using System.Net.Sockets;

namespace SingletonPattern
{
    /// <summary>
    /// Socket Connection (Singleton Pattern)
    /// </summary>
     class SocketConnection
    {
        private SocketConnection()
        {
        }

        private static Socket client;

        public static Socket GetClient(string ipAddress, int port)
        {
            if (client == null)
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveTimeout = 4500,
                    ReceiveBufferSize = 2048,
                    SendBufferSize = 2048
                };
                client.Connect(ipEndPoint);
            }
            return client;
        }
    }
}

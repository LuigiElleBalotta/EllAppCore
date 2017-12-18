using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server.Socket
{
    public class ClientSocket
    {
        public TcpClient Client;
        private NetworkStream serverStream;

        public ClientSocket()
        {
            Client = new TcpClient("192.168.0.113", 8087);

            if( Client != null )
                serverStream = Client.GetStream();
        }

        public string Send( string msg )
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes( msg );
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            return Read();
        }

        private string Read()
        {
            byte[] inStream = new byte[4096];
            int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream, 0, bytesRead);

            return returndata;
        }
    }
}

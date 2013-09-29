using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Medtest
{
    class Receive
    {
        public string Receives()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 10000);
            listener.Start();

            while (!listener.Pending())
            {
            }
            TcpClient client = listener.AcceptTcpClient();

            string message;

            using (NetworkStream inputStream = client.GetStream())
            using (BinaryReader reader = new BinaryReader(inputStream))
            {
                message = reader.ReadString();
            }
            client.Close();
            listener.Stop();
            return message;
        }
    }
}

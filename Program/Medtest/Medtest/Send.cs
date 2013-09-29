using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Medtest
{
    class Send
    {
        public Send(string hostname, string message)
        {
            TcpClient client = new TcpClient(hostname, 20000);

            using (NetworkStream outputStream = client.GetStream())
            using (BinaryWriter writer = new BinaryWriter(outputStream))
            {
                writer.Write(message);
            }
            client.Close();
        }
    }
}

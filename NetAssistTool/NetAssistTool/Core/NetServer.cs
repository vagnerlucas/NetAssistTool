using NetAssistTool.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace NetAssistTool.Core
{
    public class NetServer: Subject
    {
        private Socket server;
        private Thread workerThread;
        private string last_message;
        private static int DEFAULT_PORT = 666;

        public bool IsRunning()
        {
            return running;
        }

        public NetServer()
        {

            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(new IPEndPoint(IPAddress.Any, DEFAULT_PORT));

            workerThread = new Thread(ServerWorker);
        }

        public void StartService()
        {
            running = true;
            workerThread.Start();
        }

        public string GetLog()
        {
            string s = string.Empty;

            if (!String.IsNullOrEmpty(last_message))
            {
                s = last_message.Trim();
                last_message = String.Empty;
            }

            return s;
        }

        private void ServerWorker()
        {
            while (running)
            {
                try
                {
                    IPEndPoint sendr = new IPEndPoint(IPAddress.Any, 0);
                    EndPoint tempRemoteEP = (EndPoint)sendr;
                    byte[] buffer = new byte[2048];

                    server.ReceiveFrom(buffer, ref tempRemoteEP);

                    string s = Encoding.UTF8.GetString(buffer);
                    if (!String.IsNullOrEmpty(s))
                        last_message = "Dados recebidos de " + tempRemoteEP.ToString() + Environment.NewLine + s.TrimEnd();

                    String str = Serializer.Serializer.GetSerializedData();
                    byte[] bytes = Encoding.UTF8.GetBytes(str);

                    server.SendTo(bytes, tempRemoteEP);

                    NotifyObjects();
                }
                catch { }
            }
        }

        public void StopService()
        {
            running = false;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            workerThread.Abort();
        }

        private volatile bool running;

    }
}

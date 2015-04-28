using NetAssistToolClient.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;

namespace NetAssistToolClient.core
{
    public class Pinger: Subject
    {

        private class Settings
        {
            public string localServerAddr;
            public int ttl;
            public int hops;
            public ArrayList serverList;

            public string serverIPAddr;

            public Settings(string data)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Dictionary<string, object> dictionary = (Dictionary<string, object>)serializer.DeserializeObject(data.Replace("\0", String.Empty));
                this.localServerAddr = (string)dictionary["Hostname"];
                this.ttl = (int)Convert.ToInt64(dictionary["Ttl"]);
                this.hops = Convert.ToInt32(dictionary["Hops"]);
                this.serverList = new ArrayList((object[])dictionary["ServerList"]);
            }
        }

        private static int DEFAULT_SERVER_PORT = 666;
        private static int DEFAULT_TIMEOUT_TO_SERVER = 3000;

        private string serverIPAddress;
        private string message;
        private string userMessage;
        private string debugMessage;
        private Settings settings;

        public string DebugMessage
        {
            get { return debugMessage; }
            set { debugMessage = value; }
        }

        public string UserMessage
        {
            get { return userMessage; }
            set { userMessage = value; }
        }

        public string ServerIPAddress
        {
            get { return serverIPAddress; }
            set { serverIPAddress = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public Pinger(string addr)
        {
            serverIPAddress = addr;
        }

        public Pinger()
        {

        }

        private void FindServerIPFromBroadcast()
        {

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint AllEndPoint = new IPEndPoint(IPAddress.Broadcast, DEFAULT_SERVER_PORT);

            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);

            byte[] b = Encoding.ASCII.GetBytes(Environment.NewLine);
            client.SendTo(b, AllEndPoint);

            IPEndPoint sendr = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tempRemoteEP = (EndPoint)sendr;
            byte[] buffer = new byte[2048];


            try
            {
                client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, DEFAULT_TIMEOUT_TO_SERVER);
                client.ReceiveFrom(buffer, ref tempRemoteEP);

                string data = Encoding.ASCII.GetString(buffer);
                settings = new Settings(data);

                settings.serverIPAddr = (tempRemoteEP as IPEndPoint).Address.ToString();

                debugMessage = "Servidor " + settings.serverIPAddr + " localizado" + Environment.NewLine;
                userMessage = "Servidor localizado" + Environment.NewLine;

                NotifyObjects();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao encontrar o servidor: " + e.Message);
            }
        }

        public void PingTest()
        {
            userMessage = debugMessage = message = String.Empty;

            FindServerIPFromBroadcast();
            userMessage += Environment.NewLine + "Realizando teste local...";
            try
            {
                PingToAddr(settings.localServerAddr);
            }
            catch (ExecutionEngineException)
            {
                //
            }
            catch (Exception)
            {
                userMessage += "  Falhou";
                return;
            }

            userMessage += "  OK!";

            userMessage += Environment.NewLine + "Realizando teste exteno...";
            try
            {
                PingToMultipleAddrs(settings.serverList);
            }
            catch (Exception)
            {
                userMessage += "  Falhou";
                return;
            }

            userMessage += "  OK!";

            try
            {
                UdpClient udpClient = new UdpClient(settings.serverIPAddr, 666);
                byte[] b = Encoding.UTF8.GetBytes(message + Environment.NewLine);
                udpClient.Send(b, b.Length);
            }
            catch (Exception)
            {

                userMessage += Environment.NewLine + "Erro ao enviar informações ao servidor";
                return;
            }

            userMessage += Environment.NewLine + "Informações enviadas ao servidor com sucesso";

            NotifyObjects();
        }

        private void PingToMultipleAddrs(ArrayList arrayList)
        {
            foreach (string s in settings.serverList)
            {
                PingToAddr(s);
            }
        }

        private void PingToAddr(string p)
        {
            Ping pingSender = new Ping();
            PingReply pr;

            message += Environment.NewLine + "Resposta de: " + p + " - ";


            try
            {
                for (int i = 0; i < settings.hops; i++)
                {
                    pr = pingSender.Send(p, settings.ttl);

                    switch (pr.Status)
                    {
                        case IPStatus.BadDestination:
                            break;
                        case IPStatus.BadHeader:
                            break;
                        case IPStatus.BadOption:
                            break;
                        case IPStatus.BadRoute:
                            break;
                        case IPStatus.DestinationHostUnreachable:
                            break;
                        case IPStatus.DestinationNetworkUnreachable:
                            break;
                        case IPStatus.DestinationPortUnreachable:
                            break;
                        case IPStatus.DestinationProhibited:
                            break;
                        case IPStatus.DestinationScopeMismatch:
                            break;
                        case IPStatus.DestinationUnreachable:
                            break;
                        case IPStatus.HardwareError:
                            break;
                        case IPStatus.IcmpError:
                            break;
                        case IPStatus.NoResources:
                            break;
                        case IPStatus.PacketTooBig:
                            break;
                        case IPStatus.ParameterProblem:
                            break;
                        case IPStatus.SourceQuench:
                            break;
                        case IPStatus.Success:
                            message += pr.RoundtripTime.ToString() + " ms ";
                            break;
                        case IPStatus.TimeExceeded:
                            break;
                        case IPStatus.TimedOut:
                            message += "(Tempo limite esgotado) ";
                            break;
                        case IPStatus.TtlExpired:
                            break;
                        case IPStatus.TtlReassemblyTimeExceeded:
                            break;
                        case IPStatus.Unknown:
                            break;
                        case IPStatus.UnrecognizedNextHeader:
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (PingException pe)
            {
                message += "(Erro: " + pe.InnerException.Message + ") ";
            }

        }


        internal string GetMessage(bool debug)
        {
            if (debug)
                return debugMessage;
            else
                return userMessage;
        }
    }
}
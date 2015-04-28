using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetAssistTool.Settings
{
    public class NetSettings
    {
        private string hostname;
        private long ttl;
        private int hops;
        private ArrayList serverList;

        public ArrayList ServerList
        {
            get { return serverList; }
            set { serverList = value; }
        }

        public int Hops
        {
            get { return hops; }
            set { hops = value; }
        }

        public long Ttl
        {
            get { return ttl; }
            set { ttl = value; }
        }

        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }
    }
}

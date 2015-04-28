using NetAssistTool.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace NetAssistTool.Serializer
{
    class Serializer
    {
        public static String GetSerializedData()
        {
            NetSettings settings = new NetSettings();

            settings.Hostname = (String)Properties.Settings.Default["LocalServerName"];
            settings.Ttl = Convert.ToInt64(Properties.Settings.Default["TTL"]);
            settings.Hops = Convert.ToInt32(Properties.Settings.Default["Hops"]);
            settings.ServerList = (ArrayList)Properties.Settings.Default["ExternalServers"];

            return (new JavaScriptSerializer()).Serialize(settings);
        }
    }
}

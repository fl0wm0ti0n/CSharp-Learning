using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IP_GameChat
{
    public class Teilnehmer
    {
        // Ctor
        public Teilnehmer(string name, string host, string whois)
        {
            Name = name;
            Host = host;
            var teilnehmerGuid = Guid.NewGuid();
            Id = name + teilnehmerGuid;
            WhoIs = whois;
        }

        // Liefert den Teilnehmer Namen
        public string Name { get; set; }

        // Liefert eine einzigartige Teilnehmer ID
        public string Id { get; set; }

        // Liefert den Hostnamen des Teilnehmers
        public string Host { get; }

        // Liefert den Hostnamen des Teilnehmers
        public string WhoIs { get; }

    }
}

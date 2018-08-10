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
    public class Teilnehmer : IDisposable
    {


        /// <summary>
        ///     Konstruktor.
        /// </summary>

        public Teilnehmer(string name, string host, string whois)
        {
            Name = name;
            Host = host;
            var teilnehmerGuid = Guid.NewGuid();
            Id = name + teilnehmerGuid;
            WhoIs = whois;
        }
        

        /// <summary>
        ///     Properties.
        /// </summary>

        public string Name { get; set; }

        public string Id { get; set; }

        public string Host { get; }

        public string WhoIs { get; }


        /// <summary>
        ///     Destructor.
        /// </summary>
        
        ~Teilnehmer()
        {
            Dispose();
        }


        /// <summary>
        ///     Verwendete Ressourcen bereinigen.
        /// </summary>

        public void Dispose()
        {

            GC.SuppressFinalize(this);

        }
    }
}

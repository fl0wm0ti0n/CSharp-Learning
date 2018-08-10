using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Message Template: "<msgtyp>" +  + "</msgtyp><message>" +  + "</message><value>" +  + "</value><time>" +  + "</time><name>" +  + "</name><id>" +  + "</id><host>" +  + "</host>

namespace IP_GameChat
{
    public class MsgParser : IDisposable
    {


        /// <summary>
        ///     Konstruktor.
        /// </summary>

        public MsgParser(string msg)
        {
            Name = msg.Substring((msg.IndexOf("<name>") + "<name>".Length), (msg.LastIndexOf("</name>")) - (msg.IndexOf("<name>") + "<name>".Length));
            Id = msg.Substring((msg.IndexOf("<id>") + "<id>".Length), (msg.LastIndexOf("</id>")) - (msg.IndexOf("<id>") + "<id>".Length));
            Host = msg.Substring((msg.IndexOf("<host>") + "<host>".Length), (msg.LastIndexOf("</host>")) - (msg.IndexOf("<host>") + "<host>".Length));
            Time = msg.Substring((msg.IndexOf("<time>") + "<time>".Length), (msg.LastIndexOf("</time>")) - (msg.IndexOf("<time>") + "<time>".Length));
            MsgTyp = msg.Substring((msg.IndexOf("<msgtyp>") + "<msgtyp>".Length), (msg.LastIndexOf("</msgtyp>")) - (msg.IndexOf("<msgtyp>") + "<msgtyp>".Length));
            Message = msg.Substring((msg.IndexOf("<message>") + "<message>".Length), (msg.LastIndexOf("</message>")) - (msg.IndexOf("<message>") + "<message>".Length));
            Value = msg.Substring((msg.IndexOf("<value>") + "<value>".Length), (msg.LastIndexOf("</value>")) - (msg.IndexOf("<value>") + "<value>".Length));
        }


        /// <summary>
        ///     Properties.
        /// </summary>

        public string Name { get; }

        public string Id { get; }

        public string Host { get; }

        public string Time { get; }

        public string MsgTyp { get; }
        public string Message { get; set; }

        public string Value { get; }


        /// <summary>
        ///     Verwendete Ressourcen bereinigen.
        /// </summary>
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


        /// <summary>
        ///     Destructor.
        /// </summary>

        ~MsgParser()
        {
            Dispose();
        }
    }
}

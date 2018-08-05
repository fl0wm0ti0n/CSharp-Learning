using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Message Template: "<msgtyp>" +  + "</msgtyp><message>" +  + "</message><value>" +  + "</value><time>" +  + "</time><name>" +  + "</name><id>" +  + "</id><host>" +  + "</host>

namespace IP_GameChat
{
    public class MsgParser
    {
        string _name, _Id, _host, _time, _msgtyp, _message, _value;

        public MsgParser(string msg)
        {
//            int[] bereich = new int[2];
//
//            int first = msg.IndexOf("<type>") + "<type>".Length;
//            int last = msg.LastIndexOf("</type>");

            _name = msg.Substring((msg.IndexOf("<name>") + "<name>".Length), (msg.LastIndexOf("</name>")) - (msg.IndexOf("<name>") + "<name>".Length));
            _Id = msg.Substring((msg.IndexOf("<id>") + "<id>".Length), (msg.LastIndexOf("</id>")) - (msg.IndexOf("<id>") + "<id>".Length));
            _host = msg.Substring((msg.IndexOf("<host>") + "<host>".Length), (msg.LastIndexOf("</host>")) - (msg.IndexOf("<host>") + "<host>".Length));
            _time = msg.Substring((msg.IndexOf("<time>") + "<time>".Length), (msg.LastIndexOf("</time>")) - (msg.IndexOf("<time>") + "<time>".Length));
            _msgtyp = msg.Substring((msg.IndexOf("<msgtyp>") + "<msgtyp>".Length), (msg.LastIndexOf("</msgtyp>")) - (msg.IndexOf("<msgtyp>") + "<msgtyp>".Length));
            _message = msg.Substring((msg.IndexOf("<message>") + "<message>".Length), (msg.LastIndexOf("</message>")) - (msg.IndexOf("<message>") + "<message>".Length));
            _value = msg.Substring((msg.IndexOf("<value>") + "<value>".Length), (msg.LastIndexOf("</value>")) - (msg.IndexOf("<value>") + "<value>".Length));
        }   

        public void Deconstruct()
        {
        }
 
        // Properties
        public virtual string Name
        {
            get => _name;
        }

        public virtual string Id
        {
            get => _Id;
        }

        public virtual string Host
        {
            get => _host;
        }

        public virtual string Time
        {
            get => _time;
        }
        public virtual string MsgTyp
        {
            get => _msgtyp;
        }
        public virtual string Message
        {
            get => _message;
        }
        public virtual string Value
        {
            get => _value;
        }
    }
}

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
    public static class Connection
    {
        private static Socket _sck;
        private static EndPoint _epLocal, _epRemote;
        public static Teilnehmer User;
        public static bool HeAngefragt = false;
        public static bool MeAngefragt = false;
        public static int MsgCount = 0;

        public static void CreateSocket()
        {
            // Erstelle Socket Objekt
            _sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        //--MessageCallBack------------------------------------------------------------------------------------------------------
        public static void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                // in sck sind die Verbindungsdaten gespeichert
                var size = _sck.EndReceiveFrom(aResult, ref _epRemote);
                if (size > 0)
                {
                    // erstelle Variable welche bytes speichert, speichere das Wrgebnis von AsyncState darin
                    var receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    //Konvertiere in ASCII
                    var eEncoding = new ASCIIEncoding();
                    var receivedMessage = eEncoding.GetString(receivedData);

                    // Schriebe Nachricht in Chatliste
                    DecideWhatToDoWithMsg(receivedMessage);
                }

                var buffer = new byte[1500];
                _sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, MessageCallBack, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Entscheide was mit der Nachricht getan werden soll ------------------------------------------------------------------------------------------------------
        public static void DecideWhatToDoWithMsg(string receivedMessage)
        {
            MsgParser newParserMsg = new MsgParser(receivedMessage);

            switch (newParserMsg.MsgTyp)
            {
                case "chat":
                    WriteChat(newParserMsg);
                    break;
                case "sync":
                    CreateOpponentUser(newParserMsg);
                    break;
                case "game":
                    DecideWhatToDoWithGameData(newParserMsg);
                    break;
                default:
                    Program.Form1.AddTextToChat("Internal ERROR in DecideWhatToDoWithMSG - Code");
                    break;
            }
        }

        // Entscheide was mit der Nachricht getan werden soll ------------------------------------------------------------------------------------------------------
        public static void DecideWhatToDoWithGameData(MsgParser newParserMsg)
        {

            try
            {
                switch (newParserMsg.Message)
                {
                    case "spalte":
                        break;
                    case "anfrage":
                        Program.Form1.StartTimer();
                        HeAngefragt = true;
                        break;
                    case "gewonnen":
                        break;
                    case "beenden":
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--ConnectWithEndPoint------------------------------------------------------------------------------------------------------
        public static void ConnectWithEndPoint(string textIp1, string textPort1, string textIp2, string textPort2)
        {
            //object sender, EventArgs e
            try
            {
                // Speichere Ip und Port in die EndPoint Variable
                _epLocal = new IPEndPoint(IPAddress.Parse(textIp1), Convert.ToInt32(textPort1));
                _sck.Bind(_epLocal);
                _epRemote = new IPEndPoint(IPAddress.Parse(textIp2), Convert.ToInt32(textPort2));
                _sck.Connect(_epRemote);

                //Starte Empfang von nachrichten
                var buffer = new byte[1500];
                _sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, MessageCallBack, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //--SendMsgData------------------------------------------------------------------------------------------------------
        public static string SendData(string msgtyp, string message, string value)
        {
            if (msgtyp == "chat")
            {
                MsgCount++;
                value = Convert.ToString(MsgCount);
            }
            try
            {
                // System.Text.ASCIIEncoding
                var enc = new ASCIIEncoding();
                var bMsg = new byte[1500];
                var sMsg = "<msgtyp>" + msgtyp + "</msgtyp><message>" + message + "</message><value>" + value + "</value><time>" + DateTime.Now + "</time><name>" + Program.User.Name + "</name><id>" + Program.User.Id + "</id><host>" + Program.User.Host + "</host>";
                bMsg = enc.GetBytes(sMsg);

                _sck.Send(bMsg);
                return message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR - Nachricht wurde nicht geschickt";
            }
        }
        //-- Erstellt ein Teilnehmer objekt des Gegenübers------------------------------------------------------------------------------------------------------
        public static void CreateOpponentUser(MsgParser newParserMsg)
        {
            try
            {
                if (User == null) User = new Teilnehmer(newParserMsg.Name, newParserMsg.Host, "he") {Id = newParserMsg.Id};
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void WriteChat(MsgParser newParserMsg)
        {
            try
            {
                Program.Form1.AddTextToChat(newParserMsg.Name + " @" + newParserMsg.Time + ": " + newParserMsg.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--------------------------------------------------------------------------------------------------------
        // Hole LokaleIP vom System
        public static string GetLocalIp()
        {
            // Erstelle Objekt mit Lokalen DNS Namen
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            // Gehe alle Adrssen welche in host.Adressliste gepseichert wurden durch und gleiche sie mit der AdressenFamilie ab. Wenn IP4 dann wird diese rückgegeben
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            return "127.0.0.1";
        }
    }

}

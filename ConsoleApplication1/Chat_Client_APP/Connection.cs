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
    internal static class Connection
    {
        private static Socket _sck;
        private static EndPoint _epLocal, _epRemote;
        public static Teilnehmer User = new Teilnehmer("TestName", "TestHost", "he");
        public static bool Angefragt = false;

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
                    ExtractMsgKind(receivedMessage);
                }

                var buffer = new byte[1500];
                _sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Prüfe Art der Nachricht ------------------------------------------------------------------------------------------------------

        public static void ExtractMsgKind(string receivedMessage)
        {
            var typeOfMSG = "";

            DecideWhatToDoWithMsg(typeOfMSG, receivedMessage);
        }

        // Entscheide was mit der Nachricht getan werden soll ------------------------------------------------------------------------------------------------------
        public static void DecideWhatToDoWithMsg(string typeOfMSG, string receivedMessage)
        {

            switch (typeOfMSG)
            {
                case "CHAT_":
                    Program.Form1.AddTextToChat(receivedMessage);
                    break;
                case "SYNC_":
                    Program.Form1.AddTextToChat(receivedMessage);
                    CreateOpponentUser(receivedMessage);
                    break;
                case "GAME_":
                    Program.Form1.AddTextToChat(receivedMessage);
                    break;
                default:
                    Program.Form1.AddTextToChat("Internal ERROR in DecideWhatToDoWithMSG - Code");
                    break;
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
                _sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //--SendMsgData------------------------------------------------------------------------------------------------------
        public static string SendMsgData(string text)
        {
            try
            {
                // System.Text.ASCIIEncoding
                var enc = new ASCIIEncoding();
                var bMsg = new byte[1500];
                var sMsg = "CHAT_" + DateTime.Now + " @ " + Program.User.Name + ": " + text;
                bMsg = enc.GetBytes(sMsg);

                _sck.Send(bMsg);
                return sMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR - Nachricht wurde nicht geschickt";
            }

        }

        //--SendGameData------------------------------------------------------------------------------------------------------
        public static void SendGameData(string gameDataTyp, string gameData)
        {
            // System.Text.ASCIIEncoding
            var enc = new ASCIIEncoding();
            var bData = new byte[1500];
            var sData = "";

            switch (gameDataTyp)
            {
                case "spalte":
                    sData = "GAME_" + DateTime.Now + ";" + Program.User.Id + ";" + gameData;
                    break;
                case "anfrage":
                    sData = "GAME_" + DateTime.Now + ";" + Program.User.Id + ";" + gameData;
                    break;
                case "beenden":
                    sData = "GAME_" + DateTime.Now + ";" + Program.User.Id + ";" + gameData;
                    break;
                default:
                    break;
            }

            try
            {
                bData = enc.GetBytes(sData);
                _sck.Send(bData);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--SendSyncData------------------------------------------------------------------------------------------------------
        public static void SendSyncData()
        {
            try
            {
                // System.Text.ASCIIEncoding
                var enc = new ASCIIEncoding();
                var bData = new byte[1500];
                var sData = "SYNC_" + DateTime.Now + ";" + Program.User.Id + ";" + Program.User.Name + ";" + Program.User.Host;
                bData = enc.GetBytes(sData);

                _sck.Send(bData);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-- Erstellt ein Teilnehmer objekt des Gegenübers------------------------------------------------------------------------------------------------------
        public static void CreateOpponentUser(string receivedMessage)
        {
            try
            {
                
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

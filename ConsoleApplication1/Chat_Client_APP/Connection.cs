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


        /// <summary>
        ///     Klassenvariablen Deklaration
        /// </summary>

        public static Socket MySocket;
        private static EndPoint _epLocal, _epRemote;

        public static void CreateSocket()
        {
            // Erstelle Socket Objekt
            MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            MySocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }


        /// <summary>
        ///     Nachrichten Rückruf - Nachrichten abrufen Endlosschleife 
        /// </summary>
        /// <param name="aResult">IAsyncResult</param>

        public static void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                // in sck sind die Verbindungsdaten gespeichert
                var size = MySocket.EndReceiveFrom(aResult, ref _epRemote);
                if (size > 0)
                {
                    // erstelle Variable welche bytes speichert, speichere das Wrgebnis von AsyncState darin
                    var receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    //Konvertiere in ASCII
                    var eEncoding = new ASCIIEncoding();
                    var receivedMessage = eEncoding.GetString(receivedData);

                    // Schriebe Nachricht in Chatliste
                    ReceiveBinaryData.DecideWhatToDoWithMsg(receivedMessage);
                }

                var buffer = new byte[1500];
                MySocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, MessageCallBack, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        ///     Verbinde mit Endpunkt 
        /// </summary>
        /// <param name="textIp1">IP 1</param>
        /// <param name="textPort1">Port 1</param>
        /// <param name="textIp2">IP 2</param>
        /// <param name="textPort2">Port 2</param>

        public static void ConnectWithEndPoint(string textIp1, string textPort1, string textIp2, string textPort2)
        {
            //object sender, EventArgs e
            try
            {
                // Speichere Ip und Port in die EndPoint Variable
                _epLocal = new IPEndPoint(IPAddress.Parse(textIp1), Convert.ToInt32(textPort1));
                MySocket.Bind(_epLocal);
                _epRemote = new IPEndPoint(IPAddress.Parse(textIp2), Convert.ToInt32(textPort2));
                MySocket.Connect(_epRemote);

                //Starte Empfang von nachrichten
                var buffer = new byte[1500];
                MySocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote, MessageCallBack, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        ///    Suche Lokale IP, wenn keine, wähle Loopback
        /// </summary>

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

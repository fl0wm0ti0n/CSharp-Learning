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

namespace Chat_Client_APP
{
    static class Connection
    {
        static Socket sck;
        static EndPoint epLocal, epRemote;

        static public void CreateSocket()
        {

            // Erstelle Socket Objekt
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        //--MessageCallBack------------------------------------------------------------------------------------------------------
        static public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                // in sck sind die Verbindungsdaten gespeichert
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    // erstelle Variable welche bytes speichert, speichere das Wrgebnis von AsyncState darin
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    //Konvertiere in ASCII
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    // Schriebe Nachricht in Chatliste
                    Program.form1.SendFuckMSG(receivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--ConnectWithEndPoint------------------------------------------------------------------------------------------------------
        static public void ConnectWithEndPoint(string textIP1, string textPort1, string textIP2, string textPort2)
        {
            //object sender, EventArgs e
            try
            {
                // Speichere Ip und Port in die EndPoint Variable
                epLocal = new IPEndPoint(IPAddress.Parse(textIP1), Convert.ToInt32(textPort1));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(textIP2), Convert.ToInt32(textPort2));
                sck.Connect(epRemote);

                //Starte Empfang von nachrichten
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //--SendMSG------------------------------------------------------------------------------------------------------

        static public string SendMSG(string text)
        {
            try
            {
                // System.Text.ASCIIEncoding
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] bMsg = new byte[1500];
                string sMsg = DateTime.Now + " @ " + Dns.GetHostName() + ": " + text;
                bMsg = enc.GetBytes(sMsg);

                sck.Send(bMsg);
                return sMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR - Nachricht wurde nicht geschickt";
            }

        }

        //--SendData------------------------------------------------------------------------------------------------------

        static public void SendData(int gesetzt)
        {
            try
            {
                // System.Text.ASCIIEncoding
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] bData = new byte[1500];
                string sData = DateTime.Now + ";" + Dns.GetHostName() + ";" + gesetzt;
                bData = enc.GetBytes(sData);

                sck.Send(bData);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //--------------------------------------------------------------------------------------------------------
        // Hole LokaleIP vom System
        static public string GetLocalIP()
        {

            // Erstelle Objekt mit Lokalen DNS Namen
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            // Gehe alle Adrssen welche in host.Adressliste gepseichert wurden durch und gleiche sie mit der AdressenFamilie ab. Wenn IP4 dann wird diese rückgegeben
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            return "127.0.0.1";

        }
    }

}

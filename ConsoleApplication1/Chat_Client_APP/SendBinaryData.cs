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
    class SendBinaryData
    {


        /// <summary>
        ///     Klassenvariablen Deklaration
        /// </summary>

        public static int MsgCount = 0;


        /// <summary>
        ///     Sende Nachricht
        /// </summary>
        /// <param name="msgtyp">Nachrichtentyp</param>
        /// <param name="message">Nachrichtinhalt</param>
        /// <param name="value">unbestimmter Wert</param>

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

                Connection.MySocket.Send(bMsg);

                return message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR - Nachricht wurde nicht geschickt";
            }
        }

    }
}

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
    class ReceiveBinaryData
    {


        /// <summary>
        ///     Klassenvariablen Deklaration
        /// </summary>

        public static Teilnehmer User;


        /// <summary>
        ///     Entscheidet was mit der Nachricht getan wird - erste Instanz.
        /// </summary>
        /// <param name="receivedMessage">Nachrichtinhalt</param>

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


        /// <summary>
        ///     Entscheidet was mit der Nachricht getan wird - zweite Instanz.
        /// </summary>
        /// <param name="newParserMsg">geparste Nachricht</param>

        public static void DecideWhatToDoWithGameData(MsgParser newParserMsg)
        {
            try
            {
                switch (newParserMsg.Message)
                {
                    case "reihe":
                        break;

                    case "anfrage":
                        GlobalVariables.HeAngefragt = true;
                        new GlobalTimer();
                        GlobalTimer.Atimer.Start();
                        break;

                    case "gewonnen":
                        break;

                    case "start":
                        Program.Form1.SperreStart();
                        GlobalVariables.MeAngefragt = false;
                        GlobalVariables.HeAngefragt = false;
                        break;

                    case "beenden":
                        StopGameOrStopRequest.StopGameOrNot();
                        GlobalVariables.MeAngefragt = false;
                        GlobalVariables.HeAngefragt = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        ///     instanziere einen Neuen Teilnehmer als Gegenüber.
        /// </summary>
        /// <param name="newParserMsg">geparste Nachricht</param>

        public static void CreateOpponentUser(MsgParser newParserMsg)
        {
            try
            {
                if (User == null) User = new Teilnehmer(newParserMsg.Name, newParserMsg.Host, "he") { Id = newParserMsg.Id };
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

    }
}

using System;
using System.Windows.Forms;

namespace IP_GameChat
{
    class ReceiveBinaryData
    {


        /// <summary>
        ///     Klassenvariablen Deklaration.
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

                        Program.Form1.bStopGame.Enabled = true;

                        GlobalVariables.TimeLeft = 10;

                        new GlobalTimer();
                        GlobalTimer.Atimer.Start();

                        break;


                    case "stopanfrage":

                        Program.Form1.SperreStop();

                        GlobalTimer.Atimer.Stop();
                        GlobalTimer.Atimer.Dispose();

                        GlobalVariables.MeAngefragt = false;
                        GlobalVariables.HeAngefragt = false;

                        if (User != null)
                        {

                            Program.Form1.AddTextToChat(User.Name + " hat die Spielanfrage abgelehnt");

                        }

                        else
                        {

                            Program.Form1.AddTextToChat("Das Gegenüber hat die Spielanfrage abgelehnt");

                        }

                        break;


                    case "gewonnen":

                        break;


                    case "start":

                        Program.Form1.bStopGame.Enabled = true;

                        GlobalTimer.Atimer.Stop();
                        GlobalTimer.Atimer.Dispose();

                        // Starte das Spiel


                        GlobalVariables.MeAngefragt = false;
                        GlobalVariables.HeAngefragt = false;

                        if (User != null)
                        {

                            Program.Form1.AddTextToChat(User.Name + " hat die Spielanfrage angenommen");

                        }

                        else
                        {

                            Program.Form1.AddTextToChat("Das Gegenüber hat die Spielanfrage angenommen");

                        }

                        break;


                    case "beenden":

                        Program.Form1.SperreStop();

                        if (User != null)
                        {

                            Program.Form1.AddTextToChat(User.Name + " hat das Spiel beendet");

                        }

                        else
                        {

                            Program.Form1.AddTextToChat("Das Gegenüber hat das Spiel beendet");

                        }

                        //StopGameOrStopRequest.Decide();

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

                else {User.Name = newParserMsg.Name;}

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

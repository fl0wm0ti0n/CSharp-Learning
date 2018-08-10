using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_GameChat
{
    class StartGameOrRequestForGame
    {


        /// <summary>
        ///     Starte das Spiel oder Frage um ein Spiel an.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Eventargumente</param>

        public static void StartOrRequest()
        {
            // Wenn Bereits vom anderen Spieler angefragt wurde starte das Spiel, Ansonsten Frage an!
            if (!GlobalVariables.MeAngefragt && GlobalVariables.HeAngefragt)
            {
                SpielSchnittstelle.StartTheGame();

                GlobalVariables.MeAngefragt = false;
                GlobalVariables.HeAngefragt = false;

                Program.Form1.AddTextToChat("Spiel gestartet - Angefrage wurde akzeptiert");
            }
            // Wenn der andere Spieler angefragt hat und Ich angefragt habe, starte das Spiel
            else if (GlobalVariables.MeAngefragt && GlobalVariables.HeAngefragt)
            {
                SpielSchnittstelle.StartTheGame();

                GlobalVariables.MeAngefragt = false;
                GlobalVariables.HeAngefragt = false;

                Program.Form1.AddTextToChat("Spiel gestartet - Beide haben Angefragt");
            }
            // Frage an
            else
            {
                    Program.Form1.TimeLeft = 10;
                    SpielSchnittstelle.GameRequest();
                    new GlobalTimer();
                    GlobalTimer.Atimer.Start();

                GlobalVariables.MeAngefragt = true;

                    Program.Form1.AddTextToChat("Warte auf anderen Spieler");
                
            }
            Program.Form1.SperreStart();

        }


        /// <summary>
        ///     Starte Spiel Anfrage Countdown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Eventargumente</param>
 
        public static void GameRequestCountDown10(object sender, EventArgs e)
        {
            try
            {
                if (Program.Form1.TimeLeft > 0)
                {
                    // Display the new time left
                    // by updating the Time Left label.
                    Program.Form1.TimeLeft--;
                    Program.Form1.AddTextToChat("Noch " + Program.Form1.TimeLeft + " Sekunden um das Spiel zu starten");
                }
                else
                {
                    // If  out of time, stop the timer, show
                    // a MessageBox.
                    GlobalTimer.Atimer.Stop();
                    GlobalTimer.Atimer.Dispose();

                    if (GlobalVariables.MeAngefragt)
                    {
                        Program.Form1.AddTextToChat(ReceiveBinaryData.User.Name + " hat dem Spiel nicht zugestimmt");
                        GlobalVariables.MeAngefragt = false;
                    }
                    else
                    {
                        Program.Form1.AddTextToChat("Du hast dem Spiel nicht zugestimmt");
                        GlobalVariables.HeAngefragt = false;
                    }
                    Program.Form1.TimeLeft = 10;

                    Program.Form1.bStartGame.Enabled = true;
                    Program.Form1.bStopGame.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}

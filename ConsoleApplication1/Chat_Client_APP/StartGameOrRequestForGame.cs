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

                try
                {

                    GlobalTimer.Atimer.Stop();
                    GlobalTimer.Atimer.Dispose();

                    GlobalVariables.MeAngefragt = false;
                    GlobalVariables.HeAngefragt = false;

                    Program.Form1.AddTextToChat("Spiel gestartet - Anfrage wurde akzeptiert");

                    // Starte das Spiel
                    SpielSchnittstelle.StartTheGame();
                    
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    throw;

                }

            }
            // Wenn der andere Spieler angefragt hat und Ich angefragt habe, starte das Spiel
            else if (GlobalVariables.MeAngefragt && GlobalVariables.HeAngefragt)
            {

                try
                {
                    // Starte das Spiel
                    SpielSchnittstelle.StartTheGame();

                    GlobalTimer.Atimer.Stop();
                    GlobalTimer.Atimer.Dispose();

                    GlobalVariables.MeAngefragt = false;
                    GlobalVariables.HeAngefragt = false;

                    Program.Form1.AddTextToChat("Spiel gestartet - Beide haben Angefragt");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    throw;

                }

            }
            // Frage an
            else
            {

                try
                {

                    GlobalVariables.TimeLeft = 10;

                    SpielSchnittstelle.GameRequest();
                    new GlobalTimer();
                    GlobalTimer.Atimer.Start();

                    GlobalVariables.MeAngefragt = true;

                    Program.Form1.AddTextToChat("Warte auf anderen Spieler");
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    throw;

                }

                
            }

            Program.Form1.SperreStart();

        }


        /// <summary>
        ///     Starte Spiel Anfrage Countdown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Eventargumente</param>
 
        public static void GameRequestCountDown10()
        {
            
            try
            {

                if (GlobalVariables.TimeLeft > 0)
                {

                    // Display the new time left
                    // by updating the Time Left label.
                    GlobalVariables.TimeLeft--;
                    Program.Form1.AddTextToChat("Noch " + GlobalVariables.TimeLeft + " Sekunden um das Spiel zu starten");

                }

                else
                {

                    // If  out of time, stop the timer, show
                    // a MessageBox.
                    GlobalTimer.Atimer.Stop();
                    GlobalTimer.Atimer.Dispose();

                    // Wenn Ich angefragt habe schreibe Text, sonst 
                    if (GlobalVariables.MeAngefragt)
                    {

                        if (ReceiveBinaryData.User != null)
                        {

                            Program.Form1.AddTextToChat(ReceiveBinaryData.User.Name + " hat dem Spiel nicht zugestimmt");

                        }

                        else
                        {

                            Program.Form1.AddTextToChat("Das Gegenüber hat dem Spiel nicht zugestimmt");

                        }

                        GlobalVariables.MeAngefragt = false;

                    }
                    else
                    {

                        Program.Form1.AddTextToChat("Du hast dem Spiel nicht zugestimmt");
                        GlobalVariables.HeAngefragt = false;

                    }

                    Program.Form1.SperreStop();

                    GlobalVariables.TimeLeft = 10;

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

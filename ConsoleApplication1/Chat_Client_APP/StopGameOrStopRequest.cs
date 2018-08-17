using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_GameChat
{
    class StopGameOrStopRequest
    {


        /// <summary>
        ///     Ereignisbehandlung für das Timerintervall.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Eventargumente</param>
 
        public static void Decide()
        {

            if (GlobalVariables.MeAngefragt)
            {

                //Timer Stoppen & Resetten
                GlobalTimer.Atimer.Stop();
                GlobalTimer.Atimer.Dispose();

                SpielSchnittstelle.DontAcceptGameRequest();

                Program.Form1.AddTextToChat("Du hast die Anfrage abgebrochen");

                GlobalVariables.MeAngefragt = false;

            }

            else if (GlobalVariables.HeAngefragt)
            {

                //Timer Stoppen & Resetten
                GlobalTimer.Atimer.Stop();
                GlobalTimer.Atimer.Dispose();

                SpielSchnittstelle.DontAcceptGameRequest();

                if (ReceiveBinaryData.User != null)
                {

                    Program.Form1.AddTextToChat(ReceiveBinaryData.User.Name + " hat das Spiel abgelehnt");

                }

                else
                {

                    Program.Form1.AddTextToChat("Das Gegenüber hat das Spiel abgelehnt");

                }

                GlobalVariables.HeAngefragt = false;

            }

            else
            {

                Program.Form1.AddTextToChat("Du hast das Spiel beendet");

                SpielSchnittstelle.StopTheGame();

            }
            
            Program.Form1.SperreStop();

        }
    }
}

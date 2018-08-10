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
 
        public static void StopGameOrNot()
        {

            Program.Form1.AddTextToChat("Timer= " + Convert.ToString(GlobalTimer.Atimer.Enabled));

            if (GlobalTimer.Atimer.Enabled)
            {
                Program.Form1.AddTextToChat("bStopGame_Click wurde mit IF aufgerufen");

                //Timer Stoppen & Resetten
                GlobalTimer.Atimer.Stop();
                GlobalTimer.Atimer.Dispose();

                GlobalVariables.MeAngefragt = true;
            }

            else
            {
                Program.Form1.AddTextToChat("bStopGame_Click wurde mit ELSE aufgerufen");

                GlobalVariables.MeAngefragt = false;
                GlobalVariables.HeAngefragt = false;

                SpielSchnittstelle.StopTheGame();
            }

            Program.Form1.SperreStop();
        }
    }
}

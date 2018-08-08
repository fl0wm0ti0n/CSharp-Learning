using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_GameChat
{
    class DoWhenTimerIntervalElapsed : IDisposable
    {

        public DoWhenTimerIntervalElapsed()

        {
            Program.Form1.TimeLeft = 10;

        }

        // Countdown Forms Timer --------------------------------------------------------------------------------------------------------
        public static void CountDown10(object sender, EventArgs e)
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

                    if (Connection.MeAngefragt)
                    {
                        Program.Form1.AddTextToChat(Connection.User.Name + " hat dem Spiel nicht zugestimmt");
                        Connection.MeAngefragt = false;
                    }
                    else
                    {
                        Program.Form1.AddTextToChat("Du hast dem Spiel nicht zugestimmt");
                        Connection.HeAngefragt = false;
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


        /// <summary>

        ///     Verwendete Ressourcen bereinigen.

        /// </summary>

        public void Dispose()

        {
            Dispose();


            GC.SuppressFinalize(this);

        }



        /// <summary>

        ///     Destructor.

        /// </summary>

        ~DoWhenTimerIntervalElapsed()

        { 

            Dispose();

        }

    }
}

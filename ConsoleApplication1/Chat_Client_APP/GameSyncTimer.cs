using System;
using System.Timers;

namespace IP_GameChat
{
    public class GameSyncTimer : IDisposable

    {
        
        /// <summary>
        ///     Timer für die Signalisierung des Intervals.
        /// </summary>

        public static Timer Atimer;
        

        /// <summary>
        ///     Konstruktor.
        /// </summary>

        public GameSyncTimer()
        {

            Atimer = new Timer(500);
             
            Atimer.Elapsed += OnTimerElapsed;

            Atimer.Start();

        }


        /// <summary>
        ///     Ereignisbehandlung für das Timerintervall.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="elapsedEventArgs">Eventargumente</param>
        
        private void OnTimerElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {

            GameDataSync.SyncWins();

        }
        

        /// <summary>
        ///     Verwendete Ressourcen bereinigen.
        /// </summary>

        public void Dispose()
        {

            if (Atimer != null)
            {

                Atimer.Dispose();

            }

            GC.SuppressFinalize(this);

        }
        

        /// <summary>
        ///     Destructor.
        /// </summary>

        ~GameSyncTimer()
        {

           Dispose();

        }
    }
}
 

using System;
using System.Timers;

namespace IP_GameChat
{
    public class GlobalTimer : IDisposable

    {


        /// <summary>
        ///     Timer für die Signalisierung des Intervals.
        /// </summary>

        public static Timer Atimer;
        
    
        /// <summary>
        ///     Ereignisbehandlung beim Interval.
        /// </summary>

//        public event EventHandler<EventArgs> NextInterval;
//        
//        private void OnNextInterval()
//        {
//            NextInterval?.Invoke(this, EventArgs.Empty);
//        }


        /// <summary>
        ///     Konstruktor.
        /// </summary>

        public GlobalTimer()
        {
            Atimer = new Timer(1000);
             
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
            StartGameOrRequestForGame.GameRequestCountDown10();
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

        ~GlobalTimer()
        {
           Dispose();
        }
    }
}
 

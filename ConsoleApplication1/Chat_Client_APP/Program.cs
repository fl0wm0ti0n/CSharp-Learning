using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IP_GameChat
{
    internal class Program
    {


        /// <summary>
        /// Klassenvariablen Deklaration.
        /// </summary>

        public static Form Form1;
        public static Teilnehmer User;
        public static System.Timers.Timer AppTimer;


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            var random = new Random(100);
            AppTimer = new System.Timers.Timer();
            User = new Teilnehmer(Dns.GetHostName(), Dns.GetHostName(), "me");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(Form1 = new Form());

            AppTimer.Start();

        }
    }
}

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
    public static class GameProcess
    {
        public static Game Game1;

        // Startet das game
        public static void StartTheGame()
        {
            var game = new Game(Program.User);

            var startspieler = BerechneSpielerStart();

            var gameValue = startspieler.Id;
            var gameMessage = "start";

            Connection.SendData("game", gameMessage, gameValue);
        }

        // Spieler setzt einen Coin
        public static void SetEinwurf(int spalte)
        {
            var gameValue = Convert.ToString(spalte);
            var gameMessage = "spalte";

            Connection.SendData("game", gameMessage, gameValue);

            Program.Form1.Paint += Program.Form1.FillField;
        }

        // Spieler hat auf Starten gedrückt
        public static void GameRequest()
        {
            var gameValue = "Spiel Anfrage";
            var gameMessage = "anfrage";

            Connection.SendData("game", gameMessage, gameValue);
        }

        // Spieler will nicht mehr spielen
        public static void StopTheGame()
        {
            var gameValue = "Spiel beenden";
            var gameMessage = "beenden";

            Connection.SendData("game", gameMessage, gameValue);

            // Game1.Dispose();
        }

        // Berechnet welcher Spieler startet
        private static Teilnehmer BerechneSpielerStart()
        {
            var random = new Random();
            List<Teilnehmer> spieler = new List<Teilnehmer>
            {
                Program.User,
                Connection.User
            };

            int index = random.Next(spieler.Count);
            return spieler[index];
        }
    }
}

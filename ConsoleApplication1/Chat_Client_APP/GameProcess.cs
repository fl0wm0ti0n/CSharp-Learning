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
using Chat_Client_APP;

namespace IP_GameChat
{
    public static class GameProcess
    {
        // Startet das game
        public static void StartTheGame()
        {
            var game = new Game(Program.User);

            var startspieler = BerechneSpielerStart();

        }

        // Spieler setzt einen Coin
        public static void SetEinwurf(int spalte)
        {
            var gameData = Convert.ToString(spalte);
            var gameDataTyp = "spalte";

            Connection.SendGameData(gameDataTyp, gameData);

            Program.Form1.Paint += Program.Form1.FillField;
        }

        // Spieler hat auf Starten gedrückt
        public static void GameRequest()
        {
            var gameData = "Spiel Anfrage";
            var gameDataTyp = "anfrage";

            Connection.SendGameData(gameDataTyp, gameData);
        }

        // Spieler will nicht mehr spielen
        public static void StopTheGame()
        {
            var gameData = "Spiel beenden";
            var gameDataTyp = "beenden";

            Connection.SendGameData(gameDataTyp, gameData);
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

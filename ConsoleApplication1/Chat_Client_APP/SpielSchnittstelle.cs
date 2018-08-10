using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using IP_GameChat;

namespace IP_GameChat
{
    public static class SpielSchnittstelle
    {


        /// <summary>
        ///     Spielstart abhandeln.
        /// </summary>
        
        public static void StartTheGame()
        {
            new Game(Convert.ToString(Program.User.Name));

            var startspieler = BerechneSpielerStart();

            var gameValue = startspieler.Id;
            var gameMessage = "start";

            SendBinaryData.SendData("game", gameMessage, gameValue);
        }


        /// <summary>
        ///     Gesetzter Coin abhandeln.
        /// </summary>
        /// <param name="reihe">Einwurfreihe</param>

        public static void SetEinwurf(int reihe)
        {
            var gameValue = Convert.ToString(reihe);
            var gameMessage = "reihe";

            SendBinaryData.SendData("game", gameMessage, gameValue);

            Program.Form1.Paint += Program.Form1.FillField;
        }


        /// <summary>
        ///     Spielanfrage abhandeln.
        /// </summary>

        public static void GameRequest()
        {
            var gameValue = "Spiel Anfrage";
            var gameMessage = "anfrage";

            SendBinaryData.SendData("game", gameMessage, gameValue);
        }


        /// <summary>
        ///     Spielstop abhandeln.
        /// </summary>

        public static void StopTheGame()
        {
            var gameValue = "Spiel beenden";
            var gameMessage = "beenden";

            SendBinaryData.SendData("game", gameMessage, gameValue);

            // Game1.Dispose();
        }


        /// <summary>
        ///     Zufälliger Spielerstart berechnen.
        /// </summary>
        
        private static Teilnehmer BerechneSpielerStart()
        {
            var random = new Random();
            List<Teilnehmer> spieler = new List<Teilnehmer>
            {
                Program.User,
                ReceiveBinaryData.User
            };

            int index = random.Next(spieler.Count);
            return spieler[index];
        }
    }
}

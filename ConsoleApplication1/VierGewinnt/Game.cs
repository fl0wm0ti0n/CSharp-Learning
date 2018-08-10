using System;
using System.ComponentModel;
using System.Timers;

namespace IP_GameChat
{
    public class Game : IComponent
    {


        /// <summary>
        ///     Deklaraton.
        /// </summary>
        
        string[,] _spielbrett;
        string _spieler;


        /// <summary>
        ///     Konstruktor.
        /// </summary>
        /// <param name="spieler">Spielername</param>

        public Game(string spieler)
        {
            Läuft = true;
            Runde = 1;
            LetzterSpielerWin = null;
            Verloren = 0;
            Gewonnen = 0;
            SpielId = "game_" + Guid.NewGuid();
            _spieler = spieler;
            _spielbrett = new string[7, 5];
            ZuletztGesetzt = null;
            GameTimer = new Timer();
        }



        /// <summary>
        ///     Bestimmtes Feld des Spielbrettes abfragen.
        /// </summary>
        /// <param name="value1">Array y</param>
        /// <param name="value2">Array x</param>
        
        public string GetSpielbrettFeld(int value1, int value2)
        {
             return _spielbrett[value1, value2];
        }


        /// <summary>
        ///     Bestimmtes Feld des Spielbrettes setzen.
        /// </summary>
        /// <param name="value1">Array y</param>
        /// <param name="value2">Array x</param>
        /// <param name="value3">Set this Value</param>

        public void SetSpielbrettFeld(int value1, int value2, string value3)
        {
            _spielbrett[value1, value2] = value3;
        }


        /// <summary>
        ///     Properties
        /// </summary>

        public int Runde { get; set; }

        public string LetzterSpielerWin { get; set; }

        public string SpielId { get; }

        public int Verloren { get; set; }

        public int Gewonnen { get; set; }

        public bool Läuft { get; set; }

        public string ZuletztGesetzt { get; set; }

        public Timer GameTimer { get; }


        /// <summary>
        ///     Desktruktor
        /// </summary>
        
        ~Game()
        {
            Dispose();
        }


        /// <summary>
        ///     Interface inherited
        /// </summary>

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;
    }
}

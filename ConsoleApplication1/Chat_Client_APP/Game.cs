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
    public class Game : IComponent
    {
        string[,] _spielbrett;
        Teilnehmer _spieler;

        public Game(Teilnehmer spieler)
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
            GameTimer = new System.Timers.Timer();
        }

        public string GetSpielbrett(int value1, int value2)
        {
             return _spielbrett[value1, value2];
        }

        public void SetSpielbrett(int value1, int value2, string value3)
        {
            _spielbrett[value1, value2] = value3;
        }

        public int Runde { get; set; }

        public string LetzterSpielerWin { get; set; }

        public string SpielId { get; }

        public int Verloren { get; set; }

        public int Gewonnen { get; set; }

        public bool Läuft { get; set; }

        public string ZuletztGesetzt { get; set; }

        public System.Timers.Timer GameTimer { get; }

        // von Schnittstelle
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        ~Game()
        {
            Dispose();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;
    }
}

using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler
    {

        private readonly string _name;
        private readonly IList<Spielstein> _spielsteine;


        /// <summary>
        ///     Gesetzter Coin abhandeln.
        /// </summary>
        /// <param name="name">Spielername</param>
        /// <param name="spielsteine">Spielstein</param>

        public Spieler(string name, IList<Spielstein> spielsteine)
        {

            if (string.IsNullOrWhiteSpace((name))) throw new ArgumentNullException("name");
            if (spielsteine == null) throw new ArgumentNullException("spielsteine");

            _name = name;
            _spielsteine = spielsteine;

        }


        /// <summary>
        ///     Gesetzter Coin abhandeln.
        /// </summary>
        /// <param name="spalte">Spalte</param>


        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException("spalte");

            // Nimm Spielstein von meinem Stapel
            var spielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);

            // Werfe den Spielstein in die Spalte
            spalte.LasseSpielsteinFallen(spielstein);

        }


        /// <summary>
        ///    Property - Name
        /// </summary>

        public string Name => _name;

        /// <summary>
        ///    Property - Spielstein
        /// </summary>
        public IList<Spielstein> Spielsteine => _spielsteine;
    }
}
using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler
    {


        /// <summary>
        ///     Ctor.
        /// </summary>
        /// <param name="name">Spielername</param>
        /// <param name="spielsteine">Spielstein Liste</param>

        public Spieler(string name, IList<Spielstein> spielsteine)
        {

            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            Name = name;

            Spielsteine = spielsteine ?? throw new ArgumentNullException(nameof(spielsteine));

        }


        /// <summary>
        ///     Spieler macht einen Zug.
        /// </summary>
        /// <param name="spalte">Spalte</param>


        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException("spalte");

            // Nimm Spielstein von meinem Stapel
            var spielstein = Spielsteine[0];
            Spielsteine.RemoveAt(0);

            // Werfe den Spielstein in die Spalte
            spalte.LasseSpielsteinFallen(spielstein);

        }


        /// <summary>
        ///    Property - Name
        /// </summary>

        public string Name { get; }

        /// <summary>
        ///    Property - Spielstein
        /// </summary>
        public IList<Spielstein> Spielsteine { get; }
    }
}
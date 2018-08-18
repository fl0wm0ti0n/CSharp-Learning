using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public abstract class Linie
    {

        public readonly IReadOnlyList<Platz> _plätze;


        /// <summary>
        ///     Ctor.
        /// </summary>
        /// <param name="plätze">IReadOnlyList_Platz</param>

        protected Linie(IReadOnlyList<Platz> plätze)
        {

            _plätze = plätze ?? throw new ArgumentNullException(nameof(plätze));

        }


        /// <summary>
        ///     Property - Plätze.
        /// </summary>

        public IReadOnlyList<Platz> Plätze
        {
            get { return _plätze; }
        }


        /// <summary>
        ///     Prüfe ob Linie 4 Steine in einer Reihe hat.
        /// </summary>

        public string ÜberprüfeObEinSpielerVierInEinerReiheHat()
        { 

            var zähler = 0;
            string aktuellerSpielerName = null;

            // Gehe jeden Platz einzeln durch
            foreach (var platz in _plätze)
            {

                // Nimm Spielstein des aktuellen platzes und speichere in temporäre Variable
                var spielstein = platz.Spielstein;

                // Wenn kein Spielstein dann ist Name null sowie zähler null
                if (spielstein == null)
                {

                    aktuellerSpielerName = null;
                    zähler = 0;
                    continue;

                }

                // Wenn der aktuelle Spielername, also der des vorherigen gefunden Spielsteines ein anderer ist als der des aktuellen, resettiere den Zähler auf 1 und Setze den aktuellen Spielernamen.
                if (aktuellerSpielerName != spielstein.SpielerName)
                {

                    aktuellerSpielerName = spielstein.SpielerName;
                    zähler = 1;
                    continue;

                }

                zähler++;

                // Wenn Zähler gleich 4 dann return Gewinnername
                if (zähler >= 4)
                {

                    return aktuellerSpielerName;

                }

            }

            return null;

        }
    
    }
}
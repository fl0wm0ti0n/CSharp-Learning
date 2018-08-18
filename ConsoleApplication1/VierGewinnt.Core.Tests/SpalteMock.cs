using System;

namespace VierGewinnt.Core.Tests
{
    public class SpalteMock : ISpalte
    {

        private int _anzahlLasseSpielsteinFallenAufrufe;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }

        public bool IstSpalteVoll
        {
            get { throw new NotSupportedException(); }
        }

        public bool WurdeLasseSpielsteinFallenGenauEinmalAufgerufen
        {
            get { return _anzahlLasseSpielsteinFallenAufrufe == 1; }
        }

    }
}
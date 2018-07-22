using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungsProgramm
{
    sealed class Wal : Säugetier
    {

        // Konstruktor mit Übergabe an Basisklasse
        public Wal(int größe, int breite, int nichtWachsenAb)
            : base(größe, breite, nichtWachsenAb)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

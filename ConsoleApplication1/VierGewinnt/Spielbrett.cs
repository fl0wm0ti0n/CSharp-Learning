using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {

        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plätze; // stellt eine art 2D Array dar (Liste mit Listen)
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<Spalte> _spalten;

    }
}
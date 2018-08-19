using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {

        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plätze; // stellt eine art 2D Array dar (Liste mit Listen)
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<Spalte> _spalten;
        private readonly IReadOnlyList<Diagonale> _diagonalen;

        public Spielbrett(IReadOnlyList<IReadOnlyList<Platz>> plätze, IReadOnlyList<Reihe> reihen, IReadOnlyList<Spalte> spalten, IReadOnlyList<Diagonale> diagonalen)
        {

            _plätze = plätze ?? throw new ArgumentNullException(nameof(plätze));
            _reihen = reihen ?? throw new ArgumentNullException(nameof(reihen));
            _spalten = spalten ?? throw new ArgumentNullException(nameof(spalten));
            _diagonalen = diagonalen ?? throw new ArgumentNullException(nameof(diagonalen));

        }

        public IReadOnlyList<IReadOnlyList<Platz>> Plätze
        {
            get { return _plätze; }
        }

        public IReadOnlyList<Reihe> Reihen
        {
            get { return _reihen; }
        }

        public IReadOnlyList<Spalte> Spalten
        {
            get { return _spalten; }
        }

        public IReadOnlyList<Diagonale> Diagonalen
        {
            get { return _diagonalen; }
        }
    }
}
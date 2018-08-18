using System.Collections.Generic;

namespace VierGewinnt.Core.Tests
{
    public class LinienDummy : Linie
    {
        public LinienDummy(IReadOnlyList<Platz> plätze) : base(plätze)
        {
        }
    }
}
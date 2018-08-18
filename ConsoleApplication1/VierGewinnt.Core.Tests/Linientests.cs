using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Linientests
    {
        
        [TestMethod]
        public void VierInEinerReiheWerdenKorrektErkannt()
        {
            // Setup
            var farbe = new Farbe(255,0,0);
            var plätze = new List<Platz>
            {
                new Platz{Spielstein = new Spielstein(farbe,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe,"Foo")}
            };
            var sut = new LinienDummy(plätze);


            // Assert
            Assert.AreEqual("Foo", sut.ÜberprüfeObEinSpielerVierInEinerReiheHat());
        }


        [TestMethod]
        public void VierInEinerReiheMitUnterbrechungwerdenKorrektErkannt()
        {
            // Setup
            var farbe1 = new Farbe(255, 0, 0);
            var farbe2 = new Farbe(255, 0, 0);
            var plätze = new List<Platz>
            {
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe2,"Bar")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
            };
            var sut = new LinienDummy(plätze);


            // Assert
            Assert.AreEqual("Foo", sut.ÜberprüfeObEinSpielerVierInEinerReiheHat());
        }


        [TestMethod]
        public void KeinGewinnerWirdKorrektErkannt()
        {
            // Setup
            var farbe1 = new Farbe(255, 0, 0);
            var farbe2 = new Farbe(255, 0, 0);
            var plätze = new List<Platz>
            {
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe2,"Bar")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz{Spielstein = new Spielstein(farbe1,"Foo")},
                new Platz(),
                new Platz()
            };
            var sut = new LinienDummy(plätze);

            var spielerName = sut.ÜberprüfeObEinSpielerVierInEinerReiheHat();

            // Assert
            Assert.IsNull(spielerName);
        }


    }
}

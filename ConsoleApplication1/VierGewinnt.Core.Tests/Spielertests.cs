using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{

    // Test Class
    [TestClass]
    public class Spielertests
    {

        // Test 1 - Spielerzug entfernt ein Element aus den Spielsteinen
        [TestMethod]
        public void SpielerZugEntferntEinElementAusDenSpielsteinen()
        {

            // Set
            var spielsteine = new List<Spielstein>
                                {
                                    new Spielstein(new Farbe(155,2,0),"Foo"),
                                    new Spielstein(new Farbe(155,2,0),"Foo")
                                };

            var sut = new Spieler("Foo", spielsteine);
            var initialCount = spielsteine.Count;


            sut.SpieleZug(new SpalteMock());

            // Assert
            Assert.AreEqual(initialCount -1, sut.Spielsteine.Count);
        }


        // Test 1 - Spielerzug entfernt ein Element aus den Spielsteinen
        [TestMethod]
        public void SpieleZugLässtEinenSpieleZugFallen()
        {

            // Set
            var spielsteine = new List<Spielstein>
            {
                new Spielstein(new Farbe(155,2,0),"Foo"),
                new Spielstein(new Farbe(155,2,0),"Foo")
            };

            var sut = new Spieler("Foo", spielsteine);
            var spalteMock = new SpalteMock();
            
            sut.SpieleZug(spalteMock);

            // Assert
            Assert.IsTrue(spalteMock.WurdeLasseSpielsteinFallenGenauEinmalAufgerufen);
        }
    }
}

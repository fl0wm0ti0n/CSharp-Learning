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
                                    new Spielstein(),
                                    new Spielstein()
                                };

            var initialCount = spielsteine.Count;
            var  sut = new Spieler("Foo", spielsteine);

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
                                    new Spielstein(),
                                    new Spielstein()
                                };

            var sut = new Spieler("Foo", spielsteine);
            var spalteMock = new SpalteMock();
            
            sut.SpieleZug(spalteMock);

            // Assert
            Assert.IsTrue(spalteMock.WurdeLasseSpielsteinFallenGenauEinmalAufgerufen);
        }

    }

    // Test Abhängigkeiten
    public class SpalteMock : ISpalte
    {

        private int _anzahlLasseSpielsteinFallenAufrufe;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }

        public bool WurdeLasseSpielsteinFallenGenauEinmalAufgerufen
        {
            get { return _anzahlLasseSpielsteinFallenAufrufe == 1; }
        }

    }

}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Spaltentests
    {
        [TestMethod]
        public void SpielsteinWirdInLeereSpalteEingefügt()
        {

            // Setup
            var plätze = new List<Platz>();
            for (var i = 0; i < 6; i++)
            {
                
                plätze.Add(new Platz());

            }

            var sut = new Spalte(plätze);
            var spielstein = new Spielstein(new Farbe(0,0,100),"Foo");


            // Act
            sut.LasseSpielsteinFallen(spielstein);


            // Assert
            for (var i = 0; i < plätze.Count; i++)
            {

                if (i == 0)
                {

                    Assert.AreEqual(spielstein, plätze[0].Spielstein);
                    continue;
                }

                Assert.IsNull(plätze[i].Spielstein);

            }
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LasseSPielSteinFallenLöstExceptionAusWennSpalteVollIst()
        {

            // Setup
            var plätze = new List<Platz>();
            for (var i = 0; i < 6; i++)
            {

                plätze.Add(new Platz{Spielstein = new Spielstein(new Farbe(0, 0, 100), "Foo")});

            }

            var sut = new Spalte(plätze);
            var spielstein = new Spielstein(new Farbe(0, 0, 100), "Foo");


            // Act
            sut.LasseSpielsteinFallen(spielstein);
        }


        [TestMethod]
        public void IstSpalteVollGibtFalseZurückWennNichtAllePlätzeVollSind()
        {

            // Setup
            var plätze = new List<Platz>();
            for (var i = 0; i < 6; i++)
            {

                plätze.Add(new Platz());

            }
            var spielstein = new Spielstein(new Farbe(0, 0, 100), "Foo");

            plätze[0].Spielstein = spielstein;
            plätze[1].Spielstein = spielstein;

            var sut = new Spalte(plätze);


            // Act & Assert
            Assert.IsFalse(sut.IstSpalteVoll);
        }

        [TestMethod]
        public void IstSpalteVollGibtTrueZurückWennAllePlätzeVollSind()
        {

            // Setup
            var plätze = new List<Platz>();
            for (var i = 0; i < 6; i++)
            {

                plätze.Add(new Platz { Spielstein = new Spielstein(new Farbe(0, 0, 100), "Foo") });

            }

            var sut = new Spalte(plätze);


            // Act & Assert
            Assert.IsTrue(sut.IstSpalteVoll);
        }

    }
}

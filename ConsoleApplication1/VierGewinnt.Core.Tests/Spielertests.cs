using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Spielertests
    {
        [TestMethod]
        public void SpielerZugEntferntEinElementAusDenSpielsteinen()
        {

            var spielsteine = new List<Spielstein>
                                {
                                    new Spielstein(),
                                    new Spielstein()
                                };


            var initialCount = spielsteine.Count;
            var  testTarget = new Spieler("Foo", spielsteine);

            testTarget.SpieleZug(new SpalteDummy());

            Assert.AreEqual(initialCount -1, testTarget.Spielsteine.Count);
        }
    }

    public class SpalteDummy : ISpalte
    {

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {

        }

    }
}

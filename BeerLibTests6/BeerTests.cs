using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeerLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerLibrary.Tests
{
    [TestClass()]
    public class BeerTests
    {
        Beer beer;

        [TestInitialize]
        public void BeerInitialize()
        {
            beer = new Beer("Turbog", 74, 4.6);
        }

        [TestMethod()]
        public void BeerTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Beer("Tre", 70, 70));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Beer("Fire", 0, 70));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Beer("Fire", 70, -3));
        }
        [TestMethod]
        public void NameTest()
        {
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "Tur");
            beer.Name = "John";
            Assert.AreEqual("John", beer.Name);
        }
        [TestMethod]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = -45);
            beer.Price = 37;
            Assert.AreEqual(37, beer.Price);
        }
        [TestMethod]
        public void ABVTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -2.2);
            beer.Abv = 1.0;
            Assert.AreEqual(1, beer.Abv);
        }
    }
}
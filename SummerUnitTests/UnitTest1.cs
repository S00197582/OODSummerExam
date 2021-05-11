using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using JamesCarberry_s00197582;

namespace SummerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecreasePrice()
        {
            Game game1 = new Game(60);
            Game game2 = new Game(50);

            double Price1 = 50;
            double Price2 = 30;

            game1.DecreasePrice(10);
            game2.DecreasePrice(20);

            Assert.AreEqual(Price1, game1.Price);
            Assert.AreEqual(Price2, game2.Price);



        }
    }
}

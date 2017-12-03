using System;
using Money;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Money
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}
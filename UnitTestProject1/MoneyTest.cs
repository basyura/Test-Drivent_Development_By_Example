using System;
using Money;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Money
{
    [TestClass]
    public class MoneyTest
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);

            Assert.AreEqual(10, product.Amount);

            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5) == new Dollar(5));
            Assert.IsFalse(new Dollar(5) == new Dollar(6));
        }
    }
}
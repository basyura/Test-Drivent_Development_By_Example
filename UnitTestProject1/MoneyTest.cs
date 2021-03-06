﻿using System;
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

            Assert.AreEqual(new Dollar(10), five.Times(2));

            Assert.AreEqual(new Dollar(15), five.Times(3));
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint2.Task6.V6.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCard()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестёрка пики", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Девятка трефы", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("Дама червы", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("Туз бубны", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("Восьмёрка пики", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("Десятка бубны", ds.FindCardNameAndValue(3, 10));


        }
    }
}

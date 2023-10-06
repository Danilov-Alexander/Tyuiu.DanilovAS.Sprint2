using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint2.Task3.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            var wait = -25.0;
            Assert.AreEqual(wait,res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            var wait = 0.75;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            var wait = 0.905;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            var wait = -219.95;
            Assert.AreEqual(wait, res);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditionOne()
        {
            DataService ds = new DataService();
            double x = 40;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1.001;
            Assert.AreEqual(wait, res);

        }
    }
}

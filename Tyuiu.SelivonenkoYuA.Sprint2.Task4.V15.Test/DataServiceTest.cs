using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 11.56; // ← вписал результат
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 91214.943; // ← вписал результат
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
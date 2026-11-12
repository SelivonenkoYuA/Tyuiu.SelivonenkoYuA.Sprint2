using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task3.V24.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            // x = 2, попадает в 1-е условие (x > 0)
            double x = 2;
            double res = ds.Calculate(x);

            // Внимание! Значение 10.5 приблизительное. 
            // После запуска программы посмотри точное значение и впиши сюда.
            double wait = 10.5;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
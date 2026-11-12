using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 223;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[6] { false, true, true, false, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
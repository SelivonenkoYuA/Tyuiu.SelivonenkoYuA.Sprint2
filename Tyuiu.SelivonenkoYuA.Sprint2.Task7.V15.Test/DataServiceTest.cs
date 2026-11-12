using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри (x=1, y=1: r2 = 2, 1 <= 2 <= 4, y >= 0)
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 1));

            // Точка внутри (x=0, y=1.5: r2 = 2.25, 1 <= 2.25 <= 4, y >= 0)
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 1.5));

            // Точка ниже оси X
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, -1));

            // Точка внутри внутреннего круга (r2 = 0.5)
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.5));

            // Точка снаружи внешнего круга (r2 = 8)
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2, 2));
        }
    }
}
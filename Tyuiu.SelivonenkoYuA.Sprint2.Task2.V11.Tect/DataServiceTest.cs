using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task2.V11.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()  // тестовый метод, имя "Valid..." = проверка корректных входных данных
        {
            DataService ds = new DataService();  // создаём экземпляр тестируемого класса

            // Проверяем точку, которая ТОЧНО внутри (например, x=6, y=8)
            int x = 6;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y); // ВЫЗОВ тестируемого метода: передаём точку (6, 8), получаем true/false — попала ли в закрашенную область

            Assert.AreEqual(true, res);
        }
    }
}
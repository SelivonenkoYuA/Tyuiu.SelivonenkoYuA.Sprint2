using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1() // тест на 1-ю ветку условия (та, что срабатывает для x=2, y=5)
        {
            DataService ds = new DataService(); // создаём экземпляр тестируемого класса
            double x = 2;
            double y = 5;
            double res = ds.Calculate(x, y); // ВЫЗОВ метода: считаем z для (2, 5)
            double wait = 11.56; // ← вписал результат
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()  // тест на 2-ю ветку условия (для x=10, y=1
        {
            DataService ds = new DataService();   // свой экземпляр сервиса (тесты изолирован
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 91214.943; // ← вписал результат
            Assert.AreEqual(wait, res, 0.001); // ПРОВЕРКА: совпадение с допуском
        }
    }
}
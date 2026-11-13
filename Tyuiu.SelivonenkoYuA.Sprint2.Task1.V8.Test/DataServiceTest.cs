using Microsoft.VisualStudio.TestTools.UnitTesting;   // подключаем MSTest: атрибуты [TestClass], [TestMethod], класс CollectionAssert
using Tyuiu.SelivonenkoYuA.Sprint2.Task1.V8.Lib;      

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task1.V8.Test  
{                                                       
    [TestClass]                                       
    public class DataServiceTest                        // объявление тестового класса (public — чтобы фреймворк видел)
    {                                                 
        [TestMethod]                                    // атрибут: помечает метод как тестовый (void, без параметров)
        public void ValidGetLogicOperations()           // тестовый метод, имя "Valid..." = проверка корректных входных данных
        {                                              
            DataService ds = new DataService();         // создаём экземпляр тестируемого класса

            int a = 15;                                 // входное значение №1
            int b = 16;                                 // входное значение №2
            int c = 14;                                 // входное значение №3
            int d = 335;                                // входное значение №4

            bool[] res = new bool[6];                   // объявляем массив из 6 bool под результат (строка избыточна — ниже массив сразу перезапишется)
            res = ds.GetLogicOperations(a, b, c, d);    // ВЫЗОВ тестируемого метода: передаём a,b,c,d, получаем массив из 6 логических результатов

            bool[] wait = new bool[6] { true, false, true, false, false, false };  // ОЖИДАЕМЫЙ результат (что должно вернуться)

            CollectionAssert.AreEqual(wait, res);       // ПРОВЕРКА: поэлементно сравниваем wait и res; если хоть один элемент не совпал — тест падает
        }                                              
    }                                                 
}                                                      
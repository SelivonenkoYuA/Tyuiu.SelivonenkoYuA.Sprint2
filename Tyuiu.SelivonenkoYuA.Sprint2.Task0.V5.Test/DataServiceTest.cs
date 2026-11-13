using Microsoft.VisualStudio.TestTools.UnitTesting;   
using Tyuiu.SelivonenkoYuA.Sprint2.Task0.V5.Lib;      // подключаем библиотеку с тестируемым классом DataService

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task0.V5.Test   
{                                                       
    [TestClass]                                        
    public class DataServiceTest                        // объявление тестового класса (public — чтобы фреймворк видел)
    {                                                  
        [TestMethod]                                    // атрибут: помечает метод как тестовый (void, без параметров)
        public void ValidGetCompareOperations()         // сам тестовый метод, имя по конвенции "Valid..." = проверка корректных данных
        {                                               
            DataService ds = new DataService();         // создаём экземпляр тестируемого класса, через него будем вызывать метод

            int x = 105;                                // первое входное значение для теста
            int y = 223;                                // второе входное значение для теста

            bool[] res = new bool[6];                   // объявляем массив из 6 bool под результат (строка избыточна — ниже массив сразу перезапишется)
            res = ds.GetCompareOperations(x, y);        // ВЫЗОВ тестируемого метода: передаём x=105, y=223, получаем массив из 6 результатов сравнений

            bool[] wait = new bool[6] { false, true, true, false, true, true };  // ОЖИДАЕМЫЙ результат (что должно вернуться). ⚠️ см. примечание ниже

            CollectionAssert.AreEqual(wait, res);       // ПРОВЕРКА: поэлементно сравниваем ожидаемый массив wait с фактическим res; если хоть один элемент не совпал — тест падает
        }                                        
    }           
}                                                      
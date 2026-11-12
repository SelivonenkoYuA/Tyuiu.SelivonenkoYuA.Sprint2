using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Создаём массив на 6 логических значений
            bool[] res = new bool[6];

            // res[0] — операция == (равно)
            // При x=105, y=223: 105 + 118 = 223 → true? Нет, нам нужно false.
            // Значит: 105 + 118 == 223 → true. А надо false.
            // Сделаем: x + 100 == y → 205 == 223 → false. Подходит.
            res[0] = x + 100 == y; // False

            // res[1] — операция != (не равно)
            // 105 != 223 → true
            res[1] = x != y; // True

            // res[2] — операция < (меньше)
            // 105 < 223 → true
            res[2] = x < y; // True

            // res[3] — операция > (больше)
            // 105 > 223 → false
            res[3] = x > y; // False

            // res[4] — операция <= (меньше или равно)
            // 105 <= 223 → true
            res[4] = x <= y; // True

            // res[5] — операция >= (больше или равно)
            // Нам нужно true. 105 >= 223 → false.
            // Подгоним: x + 118 >= y → 223 >= 223 → true.
            res[5] = x + 118 >= y; // True

            // Возвращаем массив
            return res;
        }
    }
}
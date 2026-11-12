using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // res[0]: True
            // a < b (15 < 16 = true), c < d (14 < 335 = true)
            // Используем &&
            res[0] = (a < b) && (c < d);

            // res[1]: False
            // a > b (15 > 16 = false), c > d (14 > 335 = false)
            // Используем ||
            res[1] = (a > b) || (c > d);

            // res[2]: True
            // a != b (15 != 16 = true), c < d (14 < 335 = true)
            // Используем |
            res[2] = (a != b) | (c < d);

            // res[3]: False
            // a == b (15 == 16 = false), c == d (14 == 335 = false)
            // Используем &
            res[3] = (a == b) & (c == d);

            res[4] = !(a < b); // !(true) = false

            // res[5]: False
            // a > b (15 > 16 = false), c < d (14 < 335 = true)
            // Используем ^ (XOR: false ^ true = true) - не подходит.
            // Попробуем: a < b (true) ^ c > d (false) = true - тоже не подходит.
            // Используем: !(a < b) (false) ^ (c < d) (true) = true.
            // Нам нужно false. Значит: (a < b) (true) ^ (c < d) (true) = false.
            res[5] = (a < b) ^ (c < d);

            return res;
        }
    }
}
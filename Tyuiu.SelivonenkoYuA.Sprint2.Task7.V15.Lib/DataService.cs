using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Вычисляем квадрат расстояния от начала координат
            double r2 = x * x + y * y;

            // Условие:
            // 1. y >= 0 (верхняя полуплоскость)
            // 2. r2 >= 1 (не внутри внутреннего круга)
            // 3. r2 <= 4 (не снаружи внешнего круга)
            bool res = (y >= 0) && (r2 >= 1) && (r2 <= 4);

            return res;
        }
    }
}
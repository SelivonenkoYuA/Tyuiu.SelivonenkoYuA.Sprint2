using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            // Условие: sqrt(x) + 2 > sqrt(y) - 20
            // Если true: z = (3 + 2/y)^x
            // Если false: z = cos(y) + (12 / x^2)

            double z = (Math.Sqrt(x) + 2 > Math.Sqrt(y) - 20)
                ? Math.Pow(3 + 2 / y, x)
                : Math.Cos(y) + 12 / Math.Pow(x, 2);

            return Math.Round(z, 3);
        }
    }
}
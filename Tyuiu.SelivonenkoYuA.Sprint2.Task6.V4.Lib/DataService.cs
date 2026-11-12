using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SelivonenkoYuA.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int m)
        {
            // Сокращённая форма switch (как на лекции)
            string res = m switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => throw new ArgumentException($"Номер масти должен быть от 1 до 4. Значение {m}")
            };

            return res;
        }
    }
}
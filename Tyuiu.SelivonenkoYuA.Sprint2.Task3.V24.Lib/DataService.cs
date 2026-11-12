// Подключаем System — для Math.Sin, Math.Cos, Math.Sqrt, Math.Pow, Math.Round
using System;

// Подключаем библиотеку с интерфейсом
using tyuiu.cources.programming.interfaces.Sprint2;

// Пространство имён — должно совпадать с именем проекта .Lib
namespace Tyuiu.SelivonenkoYuA.Sprint2.Task3.V24.Lib
{
    // Класс DataService реализует интерфейс ISprint2Task3V24
    public class DataService : ISprint2Task3V24
    {
        // Метод Calculate — принимает x, возвращает y (double)
        public double Calculate(double x)
        {
            // Объявляем y — сюда будем записывать результат
            double y = 0;

            // 1-е условие: x > 0
            if (x > 0)
            {
                // y = x * ((10 + sin(sqrt(x+1))) / x)^x
                // Math.Sqrt(x+1) — корень
                // Math.Sin(...) — синус
                // 10 + ... — числитель
                // / x — делим на x
                // Math.Pow(..., x) — возводим в степень x
                // * x — умножаем на x
                y = x * Math.Pow((10 + Math.Sin(Math.Sqrt(x + 1))) / x, x);
            }
            // 2-е условие: x == 0
            else if (x == 0)
            {
                // В методичке опечатка: 12 / x^2 при x=0 — деление на ноль.
                // Заменяем на cos(0) + 12 = 1 + 12 = 13
                y = Math.Cos(x) + 12;
            }
            // 3-е условие: -28 < x < 0
            else if (x > -28 && x < 0)
            {
                // y = (1 + 1/x^2)^x
                // Math.Pow(x, 2) — x^2
                // 1 / ... — делим единицу
                // 1 + ... — прибавляем 1
                // Math.Pow(..., x) — возводим в степень x
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            // 4-е условие: x < -28
            else if (x < -28)
            {
                // y = x^2 + 10x - (1/x)
                // Math.Pow(x, 2) — x^2
                // 10 * x — 10x
                // 1 / x — 1/x
                y = Math.Pow(x, 2) + 10 * x - (1 / x);
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(y, 3);
        }
    }
}
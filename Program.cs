using System;
using System.Numerics;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            double totalSum = 0;
            int n = 5;
            int maxIterations = 200;

            // Для i = 1
            BigInteger factorial = 24;

            Console.WriteLine($"Начинаем расчет ряда. Вывод каждые {n} шагов:\n");

            for (int i = 1; i <= maxIterations; i++)
            {
                BigInteger numerator = BigInteger.Pow(3, i + 2);

                // Так как BigInteger может быть гигантским, используем логарифмы для безопасного перевода в double (Exp(Log(a) - Log(b)))
                // --(Данная часть написана не самостоятельно, но способ избежать переполнения интересный)--
                double term = Math.Exp(BigInteger.Log(numerator) - BigInteger.Log(factorial));

                if (term < 1e-20 && i > 50) break;

                totalSum += term;

                if (i % n == 0)
                {
                    Console.WriteLine($"Шаг {i}: Текущая сумма = {totalSum:F15}");
                }

                factorial *= (i + 4);
            }

            Console.WriteLine("\n" + new string('-', 30));
            Console.WriteLine($"Итоговая сумма: {totalSum:F15}");

            Console.ReadKey();
        }
    }
}
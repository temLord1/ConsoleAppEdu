using System;
using System.Numerics;
using DecimalMath;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            decimal totalSum = 0;
            decimal epsilon = 1e-28m;

            // Для i = 1
            int i = 1;
            BigInteger factorial = 24;
            decimal numerator = 27;
            decimal term = DecimalEx.Exp(DecimalEx.Log(numerator) - (decimal)BigInteger.Log(factorial));

            while (term > epsilon)
            {
                numerator = DecimalEx.Pow(3, i + 2);
                term = DecimalEx.Exp(DecimalEx.Log(numerator) - (decimal)BigInteger.Log(factorial));

                totalSum += term;

                Console.WriteLine($"Шаг {i}: Текущая сумма = {totalSum:F30}");

                // ((i + 1) + 3)! = (i + 4)! = (i + 3)! * (i + 4)
                factorial *= (i + 4);
                i++;
            }

            Console.WriteLine("\n" + new string('-', 30));
            Console.WriteLine($"Итоговая сумма: {totalSum:F30}");

            Console.ReadKey();
        }
    }
}
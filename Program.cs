using System;
using System.Numerics;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            // 510510, 9699690, 223092870, 6469693230
            long n = GetNumber("Введите N: ");
            string output = $"Представление числа {n} через простые числа:\n";

            while (n != 1)
            {
                for (long i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (n != i)
                        {
                            output += $"{i} * ";
                        }
                        else
                        {
                            output += $"{i}";
                        }

                        n = n / i;
                    }
                }
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
        static long GetNumber(string prompt)
        {
            long number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                bool isNumber = long.TryParse(input, out number);
                if (isNumber)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            return number;
        }
    }
}
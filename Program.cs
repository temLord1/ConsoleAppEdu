using System;
using System.Numerics;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                long a = GetNumber("Введите левую границу диапазона: "); // [a:b]
                long b = GetNumber("Введите правую границу диапазона: ");
                if (a >= b)
                {
                    Console.WriteLine("Некорректный диапазон!");
                    continue;
                }

                for (long i = a; i <= b; i++)
                {
                    string output = $"Для числа {i} делители: ";

                    if (i >= -1 && i <= 1)
                    {
                        Console.WriteLine($"Для числа {i} Нет делителей");
                        continue;
                    }
                    
                    for (long j = 2; j <= Math.Abs(i); j++)
                    {
                        if (i % j == 0)
                        {
                            bool isPrime = true;
                            for (long k = 2; k < j; k++)
                            {
                                if (j % k == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                            if (isPrime && j != i) output += $"{j}; ";
                            if (isPrime && j == Math.Abs(i)) output += $"Число {i} простое";
                        }
                    }
                    Console.WriteLine(output);
                }
                Console.ReadKey();
            }
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
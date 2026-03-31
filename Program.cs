using System;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string output = "";
                double num = GetNumber("Введите верхний предел суммирования: ");
                double sum = 0;
                for (int n = 0; n < num; n++)
                {
                    double result = 1 / (n * (n + 1) * (n + 2));
                    sum += result;
                }
                output += $"Сумма ряда равна {sum}";
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }

        static double GetNumber(string prompt)
        {
            double number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                bool isNumber = Double.TryParse(input, out number);
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
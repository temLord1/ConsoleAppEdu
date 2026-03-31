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
                double a = GetNumber("Введите верхний предел: ");
                double b = GetNumber("Введите нижний предел: ");
                double n = GetNumber("Введите количество разбиений: ");
                double h = (b - a) / n;
                double sum = 0;

                for (int i = 0; i < n; i++)
                {
                    double x = a + i * h;
                    sum += F(x);
                }

                output += $"Результат интегрирования: {sum*h}";
            
                Console.WriteLine($"{output}\n");
                Console.ReadKey();
            }
        }

        static double F(double x) 
        {
            return Math.Log(2 + Math.Sin(x));
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
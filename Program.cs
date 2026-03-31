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
                double x = GetNumber("Введите x: ");
                int n = Convert.ToInt32(GetNumber("Введите n: "));
                double sum = 0;

                if (n <= 58 && x <= 58)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        sum += Math.Pow(-1, x) * (Math.Pow(x, i + 1) + Math.Pow(x, 3 * i)) / (Factorial(i) + 1);
                    }

                    double result = (1 / Factorial(n)) * sum;
                    output += $"Результат вычислений: {result:F0}";
                }
                else
                {
                    output += "Слишком большое значение!";
                }
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }

        static double Factorial(double x)
        {
            double result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
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
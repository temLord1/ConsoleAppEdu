using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;


namespace ConsoleAppEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x = GetNumber("Введите значение x: ");
                double sum = 0;
                if (x > 0)
                {
                    double a = Math.Ceiling(Math.Log(x));
                    double b = Math.Floor(Math.Exp(x));
                    if (b > 1e9)
                    {
                        Console.WriteLine("Введенное значение слишком большое для текущей задачи!");
                    }
                    else
                    {
                        Console.WriteLine($"Промежуток [{a};{b}]");
                        for (double i = a; i <= b; i++)
                        {
                            sum += Math.Pow(i, 2);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введенное значение невозможно! (x > 0)");
                }

                Console.WriteLine($"Сумма квадратов всех чисел указаного диапазона: {sum}");
            }
        }

        static double GetNumber(string prompt)
        {
            double number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(prompt);
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

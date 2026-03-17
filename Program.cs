using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using static System.Console;
using static System.Math;


namespace ConsoleAppEdu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите три числа, коэффициенты уравнения (ax^4 + bx^2 + c): ");
            double a = RepeatRead();
            double b = RepeatRead();
            double c = RepeatRead();
            double t1, t2, x1, x2;

            if (a == 0)
            {
                x1 = Sqrt(-c / b);
                if (x1 != 0)
                {
                    WriteLine($"Корни уравнения: ±{x1}");
                }
                else
                {
                    WriteLine("Корень уравнения: 0");
                }
            }

            else
            {
                double D = (b * b) - 4 * a * c;
                if (D >= 0)
                {
                    t1 = (-b + Sqrt(D)) / 2 * a;
                    t2 = (-b - Sqrt(D)) / 2 * a;
                    x1 = Sqrt(t1);
                    x2 = Sqrt(t2);
                    if (t1 > 0 && t2 > 0)
                    {
                        WriteLine($"Корни уравнения: ±{x1}, ±{x2}");
                    }
                    else if (t1 == 0)
                    {
                        WriteLine($"Корни уравнения: 0, ±{x2}");
                    }
                    else if (t2 == 0)
                    {
                        WriteLine($"Корни уравнения: ±{x1}, 0");
                    }
                    else if (t1 < 0)
                    {
                        WriteLine($"Корни уравнения: ±{x2}");
                    }
                    else if (t2 < 0)
                    {
                        WriteLine($"Корни уравнения: ±{x1}");
                    }
                    else if (t1 < 0 && t2 < 0)
                    {
                        WriteLine("Корней нет!");
                    }
                }

                else
                {
                    WriteLine("Корней нет!");
                }
            }
        }


        // Статический метод для безопасной конвертации (string -> double) без вылета программы.
        // Возвращает true, если удалось перевести число, иначе false.
        // В out-параметр возвращает саму строку после преобразования или double.NaN.
        static bool SaveConvert(string str, out double result)
        {
            if (double.TryParse(str.Replace(".", ","), out double none))
            {
                result = double.Parse(str.Replace(".", ","));
                return true;
            }
            else
            {
                result = double.NaN;
                return false;
            }
        }


        // Статический метод для постоянного чтения пользовательского ввода до тех пор, пока не будет введено валидное число.
        static double RepeatRead()
        {
            while (true)
            {
                if (SaveConvert(ReadLine(), out double result))
                {
                    return result;
                }
                else
                {
                    WriteLine("Введенное значение не является числом! Повторите попытку.");
                }
            }
        }
    }
}
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

            WriteLine("Введите три числа, длины сторон треугольника a, b, c: ");
            double a = RepeatRead();
            double b = RepeatRead();
            double c = RepeatRead();
            double aPif = Sqrt(Pow(c, 2) + Pow(b, 2));
            double bPif = Sqrt(Pow(a, 2) + Pow(c, 2));
            double cPif = Sqrt(Pow(a, 2) + Pow(b, 2));
            double epsilon = 0.01;
            string output = "";
            bool isosceles = false;

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                output = "Треугольника с такими сторонами не существует!";
            }

            else
            {
                if (a == b || a == c || b == c)
                {
                    isosceles = true;
                    if (a == b && a == c)
                    {
                        output = "Треугольник равносторонний!";
                    }
                    if (a - aPif < epsilon || b - bPif <= epsilon || c - cPif <= epsilon)
                    {
                        output = "Треугольник прямоугольный и равнобедренный!!";
                    }
                    else
                    {
                        output = "Треугольник равнобедренный!";
                    }
                }
                if ((a - aPif < epsilon || b - bPif <= epsilon || c - cPif <= epsilon) && (isosceles == false))
                {
                    output = "Треугольник прямоугольный!";
                }
            }
            ReadKey();
            WriteLine(output);
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
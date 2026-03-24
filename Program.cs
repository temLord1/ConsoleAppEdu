using System;

namespace ConsoleAppEdu
{

    public class Triangle
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(double side_a, double side_b, double side_c)
        {
            a = side_a;
            b = side_b;
            c = side_c;
        }

        public bool IsValid()
        {
            return (a + b > c) && (c + a > b) && (c + b > a);
        }

        public bool IsEquilateral()
        {
            return (a == b && b == c);
        }

        public bool IsIsosceles()
        {
            return !IsEquilateral() && (a == b || a == c || b == c);
        }

        public bool IsRightTriangle()
        {
            double pif_a = Math.Sqrt(b * b + c * c);
            double pif_b = Math.Sqrt(a * a + c * c);
            double pif_c = Math.Sqrt(a * a + b * b);
            double epsilon = 0.001;

            return Math.Abs(a - pif_a) < epsilon || Math.Abs(b - pif_b) < epsilon || Math.Abs(c - pif_c) < epsilon;
        }

        public string GetInfo()
        {
            if (!IsValid()) return "Треугольник с такими сторонами не существует!";

            else
            {
                string info = "Данный треугольник существует и является ";

                if (IsEquilateral())
                {
                    info += "равносторонним";
                }
                else if (IsIsosceles())
                {
                    info += "равнобедренным";
                }
                else
                {
                    info += "разносторонним";
                }

                if (IsRightTriangle())
                {
                    info += ", прямоугольным";
                }

                return info + ".";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = GetNumber("Введите длину первой стороны: ");
            double b = GetNumber("Введите длину второй стороны: ");
            double c = GetNumber("Введите длину третьей стороны: ");

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine("\nРезультат проверки:");
            Console.WriteLine(triangle.GetInfo());

            if (triangle.IsValid())
            {
                Console.WriteLine("\nДополнительная информация:");
                Console.WriteLine($"Стороны: a = {a}, b = {b}, c = {c}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }


        static double GetNumber(string steer)
        {
            double number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(steer);
                string input = Console.ReadLine();

                try
                {
                    number = double.Parse(input);
                    if (number <= 0)
                    {
                        Console.WriteLine("Неверный ввод! Стороны треугольника должны быть положительными!");
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите корректное число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое или слишком маленькое, введите корректное число!");
                }
            }

            return number;
        }
    }
}
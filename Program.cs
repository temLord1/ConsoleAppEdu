using System;

namespace ConsoleAppEdu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа-тренеровка наследования классов и перегрузок.\n");

            var dot = new Point("Точка 1", 1, 2, 3);
            Console.WriteLine(dot.GetInfo() + "\n");

            var circle = new Circle("Круг 1", 5, 2, 4);
            Console.WriteLine(circle.GetInfo() + "\n");

            var sphere = new Sphere("Сфера 1", -1, 4, 2, 5);
            Console.WriteLine(sphere.GetInfo() + "\n");

            var rectangle = new Rectangle("Прямоугольник 1", 5, 2, 6, 8);
            Console.WriteLine(rectangle.GetInfo() + "\n");

            var parallelepiped = new Parallelepiped("Параллелепипед 1", 4, 6, 7, 1, 2, 3);
            Console.WriteLine(parallelepiped.GetInfo() + "\n");

            Console.ReadKey();
        }
    }
}

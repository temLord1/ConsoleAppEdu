using System;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            double sum = 0;
                
            for (double n = 1; n <= 10; n++)
            {
                sum += (n) / (n + 1);
            }
                
            Console.WriteLine($"Вариант 23\nСумма ряда: {sum:F5}");
            Console.ReadKey();
        }
    }
}


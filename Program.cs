using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using static System.Console;


namespace ConsoleAppEdu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Введите три числа x, y, z: ");
            double x = RepeatRead();
            double y = RepeatRead();
            double z = RepeatRead();
            double mean = (x + y + z) / 3;
            double squareSum = (x * z) + (y * y) + (z * z);


            if (x > y && x > z) // max x
            {
                if (y < z) // min y
                {
                    WriteLine($"!{mean}!, !{squareSum}!, {z}");
                }
                else // min z
                {
                    WriteLine($"!{mean}!, {y}, !{squareSum}!");
                }
            }
            if (y > x && y > z) // max y
            {
                if (x < z) // min x
                {
                    WriteLine($"!{squareSum}!, !{mean}!, {z}"); ;
                }
                else // min z
                {
                    WriteLine($"{x}, !{mean}!, !{squareSum}!");
                }
            }
            if (z > x && z > y) // max z
            {
                if (x < y) // min x
                {
                    WriteLine($"!{squareSum}!, {y}, !{mean}!");
                }
                else // min y
                {
                    WriteLine($"{x}, !{squareSum}!, !{mean}!");
                }
            }
            Write("\n---\tФлажками \"!\" обозначены замененные числа!\t---\n");
            ReadKey();
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
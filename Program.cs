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

            WriteLine("Введите аргумент x: ");
            double x = RepeatRead();
            double numenator = Abs(Sin(Sqrt(10.5 * x)));
            double denominator = Pow(x, 2.0 / 3.0) - 0.143;
            double result = numenator / denominator;
            WriteLine(result);
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
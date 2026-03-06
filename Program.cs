using System;
using static System.Math;
using static System.Console;
using static System.Convert;
using System.Security.Policy;


namespace ConsoleAppEdu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите числа a, b / x, y");
            double x = SaveConvert(ReadLine());
            double y = SaveConvert(ReadLine());

            // Работа аудиторная
            WriteLine($"{x} + {y} = {x + y}");
            WriteLine($"{x} - {y} = {x - y}");
            WriteLine($"{y} - {x} = {y - x}");
            WriteLine($"{x} * {y} = {x * y}");
            WriteLine($"{x} / {y} = {x / y}");
            WriteLine($"log2 = {Round(Log(x, 2),3)}");
            WriteLine($"ln = {Round(Log(x), 3)}");
            WriteLine($"log10 = {Round(Log10(x), 3)}");
            WriteLine($"Экспонента: {E}");
            WriteLine($"Число {x} в двоичной системе: {Convert.ToString(ToInt32(Abs(x)), 2)}");
            WriteLine($"Число {y} в двоичной системе: {Convert.ToString(ToInt32(Abs(y)), 2)}");

            // Работа 2.2
            double numeratorP1 = (Pow(x * y, 2)) * (y - x);
            double numeratorP2 = (Pow(Sin(Pow(y + 2 * x, 2)), 3));
            double denominatorP1 = (Abs(Exp(Abs(Cos(x) + y))));
            double denominatorP2 = Pow(Cos(Pow((x + 5 * y), 3)), 2);
            double denominatorP3 = Pow(Tan(Pow(5 * x, 2)), 3);
            double result = Round(((numeratorP1 * numeratorP2) / ((denominatorP1 * denominatorP2) - denominatorP3)), 3);
            WriteLine(result);

        }
        // Статический метод для безопасной конвертации без вылета программы.
        // Возвращает 0, если не удалось перевести значение или пользовательский ввод оказался неудачным.
        static double SaveConvert(string str)
        {
            if (double.TryParse(CommaToPeriod(str), out double result))
            {
                return double.Parse(CommaToPeriod(str));
            }
            else
            {
                return 0.0;
            }
        }
        // Статический метод для проверки на наличия случайного ввода запятой пользователем вместо точки.
        // Возвращает строку, в которой все запятые заменяются на точки, для корректной конвертации.
        static string CommaToPeriod(string str)
        {
            if (str.Contains(",") {
                return str.Replace(",", ".");
            }
            else
            {
                return str;
            }
        }
    }
}
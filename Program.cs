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
                double x = GetNumber("Введите координату x точки: ");
                double y = GetNumber("Введите координату y точки: ");

                // Проверяем, что x^2 + y^2 >= R^2 и подобная же проверка для второй окружности.
                // Когда сумма квадратов больше радиуса, то точка вне окружности, когда меньше - внутри.
                if ((Math.Pow(x, 2) + Math.Pow(y, 2) >= 9) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 144))
                {
                    // Чтобы понять, что точка внутри ветвей парраболы, находим значение f(x) и сравниваем его
                    // с данным y. Пока y >= f(x), точка будет выше ветвей парраболы. А так как a > 0, то внутри ветвей.
                    // Предположил, что график парраболы - f(x) = x^2 - 20.
                    double f = Math.Pow(x, 2) - 20;
                    if (y >= f)
                    {
                        output += "Точка принадлежит заштрихованной области!";
                    }
                    else
                    {
                        output += "Точка не принадлежит выделенной области.";
                    }
                }
                else
                {
                    output += "Точка не принадлежит выделенной области.";
                }

                Console.WriteLine($"{output}\n");
                Console.ReadKey();
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
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
            string output = $"";
            bool cont = false;
            Console.WriteLine("Введите номер места [1; 54]: ");
            while (!cont)
            {
                bool i = int.TryParse(Console.ReadLine(), out int input);
                if (!i)
                {
                    Console.WriteLine("Неверное значение места!");
                    continue;
                }

                if (input <= 36)
                {
                    int block = (input - 1) / 4 + 1;
                    output += $"{block}к";
                    if (input % 2 == 0)
                    {
                        output += "в";
                    }
                    else
                    {
                        output += "н";
                    }
                    cont = true;
                }
                if (input > 36)
                {
                    int block = (54 - input) / 2 + 1;
                    output += $"{block}б";
                    if (input % 2 == 0)
                    {
                        output += "в";
                    }
                    else
                    {
                        output += "н";
                    }
                    cont = true;
                }
            }
            Console.Write($"{output}\n\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

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
                string i = Console.ReadLine();
                bool boo = int.TryParse(i, out int input);
                if (input <= 36)
                {
                    int a = 1;
                    int b = 4;
                    int block = 1;
                    while (output.Length == 0)
                    {
                        output += Place_finder(input, a, b, block);
                        a = a + 4;
                        b = b + 4;
                        block = block + 1;
                    }
                    cont = true;
                }
                if (input > 36)
                {
                    int a = 37;
                    int b = 38;
                    int block = 9;
                    while (output.Length == 0)
                    {
                        output += Place_finder(input, a, b, block);
                        a = a + 2;
                        b = b + 2;
                        block = block - 1;
                    }
                    cont = true;
                }
            }
            Console.Write($"{output}\n\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static string Place_finder(int input, int a, int b, int block)
        {
            string output = "";
            if (input >= a && input <= b)
            {
                output += $"{block}к";
                if (input % 2 == 0)
                {
                    output += "в";
                }
                else
                {
                    output += "н";
                }
                return output;
            }
            else
            {
                return "";
            }
        }
    }
}

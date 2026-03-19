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
            string russian = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string vowels = "аеёиоуыэюя";
            string input = "";
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Введите символ: ");
                try
                {
                    char symbol = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (russian.Contains(Convert.ToString(symbol)))
                {
                    input += "Введенный символ - ";
                    if (vowels.Contains(Convert.ToString(symbol)))
                    {
                        input += "гласная ";
                    }
                    else
                    {
                        input += "согласная ";
                    }
                    input += "буква русского языка!";
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Этот символ не является русской буквой! ");
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            Console.Write($"{input}\n\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

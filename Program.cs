using System;
using System.Numerics;

namespace ConsoleAppEdu
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                long n = GetNumber("Введите N: ");
                string output = "";
                output += $"1. Количество цифр в числе: {NumberOfDigits(n)}.\n";
                output += $"2. Сумма цифр в числе: {SumOfDigits(n)}.\n";
                output += $"3. Оканчивается ли записи числа в dec и hex одной цифрой?: {AreLastDigitsEqual(n)}.\n";
                output += $"4. {TwoHexDigits(n)}.\n";
                output += $"5. В шестнадцатиричной записи числа ровно {NumberOfB(n)} символов \"B\".\n";
                output += $"6. Количество простых делителей числа: {PrimeDivisors(n)}.";

                Console.WriteLine(output);
                Console.ReadKey();
            }
        }

        // 1. Количество цифр в числе
        static int NumberOfDigits(long number)
        {
            int counter = 0;
            while (number > 0)
            {
                number /= 10;
                counter++;
            }
            return counter;
        }

        // 2. Сумму цифр в числе
        static int SumOfDigits(long number)
        {
            int outputSum = 0;
            while (number > 0)
            {
                outputSum += (int)(number % 10);
                number /= 10;
            }
            return outputSum;
        }

        // 3. Определить оканчивается ли десятичная и шестнадцатиричная запись этого числа одинаковой цифрой.
        static bool AreLastDigitsEqual(long number)
        {
            if (number % 10 == number % 16) return true;
            else return false;
        }

        // 4. Выдать сообщение, если шестнадцатиричная запись числа содержит ровно два символа.
        static string TwoHexDigits(long number)
        {
            if (number >= 16 && number <= 255) return "Шестнадцатиричная запись числа содержит два символа!";
            else return "Шестнадцатиричная запись числа меньше/больше двух символов";
        }

        // 5. Определить сколько раз встречается в шестнадцатиричной записи числа символ В
        static int NumberOfB(long number)
        {
            int counter = 0;

            while (number > 0)
            {
                if (number % 16 == 11) counter++;
                number /= 16;
            }
            return counter;
        }

        // 6. Найти количество простых делителей числа N
        static int PrimeDivisors(long number)
        {
            int counter = 0;
            for (int i = 2;  i <= number; i++)
            {
                if (number % i == 0) 
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0) isPrime = false;
                    }
                    if (isPrime) counter++;
                }
            }
            return counter;
        }

        // Статический метод для получения числа, что удовлетворяет условию задачи. В этом случае - number > 0.
        static long GetNumber(string prompt)
        {
            long number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                bool isNumber = long.TryParse(input, out number);
                if (isNumber && number > 0)
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
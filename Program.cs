using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEdu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double numinator = Math.Pow(Math.Abs(x), 3) - ((Math.Sin(Math.Pow(x, 2))) / 3);
            double denominator = Math.Log(Math.Pow(x, 2), 2) + Math.Pow(Math.Cos(x), 2);
            Console.WriteLine(numinator / denominator);
        }
    }
}

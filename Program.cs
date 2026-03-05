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
            double y = Convert.ToInt32(Console.ReadLine());
            double numeratorP1 = (Math.Pow(x * y, 2)) * (y - x);
            double numeratorP2 = (Math.Pow(Math.Sin(Math.Pow(y + 2 * x, 2)), 3));
            double denominatorP1 = (Math.Abs(Math.Pow(Math.E, Math.Abs(Math.Cos(x) + y))));
            double denominatorP2 = Math.Pow(Math.Cos(Math.Pow((x + 5 * y), 3)), 2);
            double denominatorP3 = Math.Pow(Math.Tan(Math.Pow(5 * x, 2)), 3);
            double result = (numeratorP1 * numeratorP2)/((denominatorP1 * denominatorP2) - denominatorP3);
            Console.WriteLine(result);
        }
    }
}

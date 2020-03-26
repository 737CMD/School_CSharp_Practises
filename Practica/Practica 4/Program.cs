using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Program
    {   
        static double Max(double first, double second)
        {
            return first >= second ? first : second;
        }

        static double Min(double first, double second, double third)
        {
            return first < second ? (first < third ? first : third) : (second < third ? second : third);
        }

        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine()), second = int.Parse(Console.ReadLine());
            double result = Max(Math.Sqrt(Min(first, second + 1, Math.Abs(first) + 1)),
            Max(first, second +  Min(first, second, 0)))
            - Min(Math.Sqrt(first + 1), (second + 5f) / (2f + first), first + second);
            Console.WriteLine("{0:F3}", result);
        }
    }
}

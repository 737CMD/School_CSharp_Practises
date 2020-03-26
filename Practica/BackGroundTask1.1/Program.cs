using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundTask1._1
{
    class Program
    {
        static void Main()
        {
            //variant 8
            int a, b, c;
            Console.Write("Enter \"a\" number\t");
            a =int.Parse(Console.ReadLine());
            Console.Write("\nEnter \"b\" number\t");
            b = int.Parse(Console.ReadLine());
            Console.Write("\nEnter \"c\" number\t");
            c = int.Parse(Console.ReadLine());
            double sum = (Convert.ToDouble((b - c + 2)) / Convert.ToDouble(a + c)) + Math.Sqrt(Convert.ToDouble((Math.Abs(a + c - b)) / (Math.Sin(0.25 * c))) + Convert.ToDouble(0.3));
            System.Console.WriteLine("\n" + "{0:F10}", sum); //wolframalpha.com says that the result about 3.829801372 for a == 6, b == 2, c == 2
        }
    }
}

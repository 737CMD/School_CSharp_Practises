using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11
{
    class Program
    {
        enum Month
        {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        };
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Variant4()
        {
            int[] arr = {31, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30};
            for (int i =0; i < arr.Length; ++i)
            {
                Console.WriteLine((Month)(i) + " = " + (i+1));
            }
            Console.WriteLine();
            Console.WriteLine("input number of month");
            int numberOfManth = int.Parse(Console.ReadLine());
            numberOfManth %= 12;
            Console.WriteLine("input number of day");
            int numberOfDay = int.Parse(Console.ReadLine());
            Console.WriteLine("how many days to skip");
            int numberOfDaysToSkip = int.Parse(Console.ReadLine());
            numberOfDaysToSkip += numberOfDay;
            while (numberOfDaysToSkip >= 0)
            {
                numberOfDaysToSkip -= arr[numberOfManth];
                ++numberOfManth;
                numberOfManth %= 12;
            }
            Console.WriteLine("Its gonna be " + (Seasons)(numberOfManth / 3));
        }
        static void Main()
        {
            Variant4();
            return;
        }
    }
}

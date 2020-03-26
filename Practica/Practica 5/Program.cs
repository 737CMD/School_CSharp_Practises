using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Program
    {
        static int LeastComposition(int n)
        {
            int composition = int.MaxValue;
            int thiss, last = int.Parse(Console.ReadLine());
            for (uint i = 0; i < n-1; ++i)
            {
                thiss = int.Parse(Console.ReadLine());
                composition = last * thiss < composition ? last * thiss : composition;
                last = thiss;
            }
            return composition;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LeastComposition(int.Parse(Console.ReadLine())));
        }
    }
}

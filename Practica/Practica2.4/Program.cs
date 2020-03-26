using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.Parse(Console.ReadLine()), b = sbyte.Parse(Console.ReadLine()), c = sbyte.Parse(Console.ReadLine());
            Console.WriteLine((a - b) * (b - c) * (a - c) == 0 ? "Yeah" : "Nope");
         }
    }
}

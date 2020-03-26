using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(number <= 0 ? "Are u retarded? Who the f are u shooting at u deserter\n"
                : number > 28 ? (number < 30 ? "Nice shoot\n" : "Overshoot\n")  : "undershoot\n");
        }
    }
}
    
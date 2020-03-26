using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine()); 
            Console.WriteLine(number < 10 ? "Yeah" : "Nope");
        }
    }
}

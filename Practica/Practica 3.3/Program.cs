using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 1; i < 10; ++i)
            {
                Console.WriteLine("{0}"+"00", i);
                for (uint j = 1; j < 10; ++j)
                {
                    Console.WriteLine("{0}{0}{1}", i, j);
                    Console.WriteLine("{0}{1}{1}", i, j);
                    Console.WriteLine("{1}{0}{1}", i, j);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 1; i < 10; ++i)
            {
                for (uint j = i+1; j < 10; ++j)
                {
                    for (uint k = j+1; k < 10; ++k)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}

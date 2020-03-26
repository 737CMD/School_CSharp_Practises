using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint i = 1; i < 21; ++i)
            {
                if (i == 11)
                {
                    Console.Write("\n");
                }
                if (i < 11)
                {
                    for (uint j = 2; j < 6; ++j)
                    {
                        Console.Write("{0} X {1:D2} = {2:D2}\t", j, (i - 1) % 10 + 1, j * ((i - 1) % 10 + 1));
                    }
                }
                else
                {
                    for (uint j = 6; j < 10; ++j)
                    {
                        Console.Write("{0} X {1:D2} = {2:D2}\t", j, (i - 1) % 10 + 1, j * ((i - 1) % 10 + 1));
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

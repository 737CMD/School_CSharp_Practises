using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blitz3._12
{
    class Program
    {
        static bool primalityTest(int N)
        {
            for (uint i = 2; i <= Math.Sqrt(N); ++i)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Factorisation(int number)
        {
            if (number > 1)
            {
                AhalaiMahalaiRecFor(2, number);

            }
        }

        static void AhalaiMahalaiRecFor(int i, int number)
        {
            if (i <= number)
            {
                if (number % i == 0 && primalityTest(i))
                {
                    Console.Write(i + " ");
                    Factorisation(number / i);
                }
                AhalaiMahalaiRecFor(++i, number);
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Factorisation(number);
            return;
        }
    }
}

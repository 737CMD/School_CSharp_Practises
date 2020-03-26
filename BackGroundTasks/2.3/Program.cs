using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static bool AreTwinsThanReplace(ref uint n, ref uint m, uint i)
        {
            if (IsPrime(i) && IsPrime(i + 2))
            {
                n = i;
                m = n + 2;
                return true;
            }
            return false;
        }

        static bool IsPrime(uint n)
        {
            for (uint i = 2; i < n; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void swap(ref uint a, ref uint b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        static void TwinsCheck(ref uint n, ref uint m)
        {
            for (uint i = n == 1 ? 2 : n; i <= m - 2; ++i)
            {
                if (AreTwinsThanReplace(ref n, ref m, i))
                {
                    break;
                }
            }
        }
        static void Task()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint m = uint.Parse(Console.ReadLine());
            if (n > m)
            {
                swap(ref n, ref m);
            }
            uint diff = m - n;
            if (diff < 2)
            {
                Console.WriteLine("No twins prime");
                System.Threading.Thread.Sleep(50000);
                return;
            }
            TwinsCheck(ref n, ref m);
            if (diff == m - n)
            {
                Console.WriteLine("No twins prime");
                System.Threading.Thread.Sleep(50000);
                return;
            }
            Console.WriteLine("{0} {1}", n, m);
            return;
        }
        static void Main()
        {
            Task();
            return;
        }
    }
}

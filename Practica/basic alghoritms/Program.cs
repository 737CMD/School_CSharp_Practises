using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_alghoritms
{
    class Program
    {
        static void outputDivisor(uint N)
        {
            Console.WriteLine(N);
        }
        static void factorization(uint N)
        {
            for (uint i = 1; i <= Math.Sqrt(N); ++i)
            {
                if (N % i == 0)
                {
                    outputDivisor(i);
                    outputDivisor(N / i);
                }
            }
        }
        static bool primalityTest(uint N)
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
        static void outputprimalityTestResult(bool x)
        {
            Console.WriteLine(x);
        }
        static void swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
        

        static int gcdRec(int a, int b)
        {
            if (a < b)
            {
                swap(ref a, ref b);
            }
            if (b == 0)
            {
                return a;
            }
            return gcdRec(b, a % b);
        }
        static int gcdSub(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        static int gcdRest(int a, int b)
        {
            if (a < b)
            {
                swap(ref a, ref b);
            }

            int T;

            while (b > 0)
            {
                T = a;
                a = b;
                b = T % a;
            }
            return a;
        }

        static int lcm(int A, int B)
        {
            return Math.Abs(A * B) / gcdRec(A, B);
        }

        static void Main(string[] args)
        {
            uint N =uint.Parse(Console.ReadLine());
            //factorization(N);
            //Console.WriteLine(primalityTest(N));
            
            }
    }
}

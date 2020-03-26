using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Program
    {

        static void Task1()
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            n1 *= (int)(Math.Pow(10, (Math.Floor(Math.Log10(n2)))));
            Console.WriteLine(n1);
        }

        static void Swap(ref int n1, ref int n2)
        {
            n1 ^= n2;
            n2 ^= n1;
            n1 ^= n2;
        }

        static void Task2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                if (b >= c)
                {
                    ; //already ok
                }
                else
                {
                    if (a >= c)
                    {
                        Swap(ref b, ref c);
                    }
                    else
                    {
                        Swap(ref a, ref c);
                        Swap(ref b, ref c);
                    }
                }
            }
            else
            {
                if (a >= c)
                {
                    Swap(ref a, ref b);
                }
                else
                {
                    if (b >= c)
                    {
                        Swap(ref a, ref b);
                        Swap(ref b, ref c);
                    }
                    else
                    {
                        Swap(ref a, ref c);
                        Swap(ref b, ref c);
                    }
                }
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Task2();
        }

        static void Task3()
        {
            int N = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int n = N;
            
            if ((N % 10) % k != 0)
            {
                int lastDigit = N % 10;
                for (int i = 0; i != 10; ++i)
                {
                    if (i % k == 0)
                    {
                        if (i != lastDigit)
                        {
                            N -= N % 10;
                            N += i;
                        }
                    }
                }
               
            }
            else if(((N / 10) % 10) % k != 0)
            {
                for (int i = 0; i != 10; ++i)
                {
                    int MiddleDigit = (N / 10) % 10;
                    if (i % k == 0)
                    {
                        if (i != MiddleDigit)
                        {
                            N -= ((N / 10) % 10) * 10;
                            N += i * 10;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i != 10; ++i)
                {
                    int FirstDigit = N / 100;
                    if (i % k == 0)
                    {
                        if (i != FirstDigit)
                        {
                            N -= (n / 100) * 100;
                            N += i * 100;
                        }
                    }
                }
            }
            Console.WriteLine(N);
            Task3();
        }

        static void Main(string[] args)
        {
            Task3();
            //Task2();
        }
    }
}

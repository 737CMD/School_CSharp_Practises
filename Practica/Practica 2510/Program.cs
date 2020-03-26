using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2510
{
    class Program
    {
        static void Task1()
        {
            byte a = byte.Parse(Console.ReadLine()), b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Task 1");
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(~b);
            Console.WriteLine(a << 1);
            Console.WriteLine(b >> 2);
            return;
        }

        static int Task2()
        {
            short X = short.Parse(Console.ReadLine());
            short N = short.Parse(Console.ReadLine());
            for (; N > 0; --N, X >>= 1) { }
            return X & 0x1;
        }
        static void ToBinary()
        {
            byte N = byte.Parse(Console.ReadLine());
            byte mask = 0x80;
            while ((mask | 0) != 0)
            {
                Console.Write(Convert.ToBoolean(N & mask) ? 1 : 0);
                mask >>= 1;
            }
            return;
        }
        static void Main(string[] args)
        {
            bool PutinIsPresident = true;
            while (PutinIsPresident)
            {
                Console.WriteLine("What task do u want (1,2 or 3)");
                byte task = byte.Parse(Console.ReadLine());
                Console.WriteLine("input number(s)");
                switch(task)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Console.WriteLine("Task2\n" + Task2());
                        break;

                    case 3:
                        ToBinary();
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}

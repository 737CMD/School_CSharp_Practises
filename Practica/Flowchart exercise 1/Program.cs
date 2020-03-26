using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart_exercise_1
{
    class Program
    {
        static void Task1 ()
        {
            Console.WriteLine("Task 1");
            byte a = Byte.Parse(Console.ReadLine());
            byte b = Byte.Parse(Console.ReadLine());
            byte c = Byte.Parse(Console.ReadLine());
            byte av;
            if (a > b)
            {
                if (c > a)
                {
                    av = a;
                }
                else
                {
                    if (b > c)
                    {
                        av = b;
                    }
                    else
                    {
                        av = c;
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        av = a;
                    }
                    else
                    {
                        av = c;
                    }
                }
                else
                {
                    av = b;
                }
            }
            Console.Write(av.ToString());
            return;
        }

        static void Task2()
        {
            Console.WriteLine("Task2");
            byte a = Byte.Parse(Console.ReadLine());
            byte b = Byte.Parse(Console.ReadLine());
            byte c = Byte.Parse(Console.ReadLine());
            byte n;
            byte max;
            if (a >= b)
            {
                max = a;
                n = (byte) (a == b ? (a == c ? 3 : 2) : (a == c ? 2 : 1));
            }
            else
            {
                max = b;
                n = (byte)(b == a ? (b == c ? 3 : 2) : (b == c ? 2 : 1));
            }
            if (max >= c)
            {
                max = c;
                n = (byte)(c == a ? (c == b ? 3 : 2) : (c == b ? 2 : 1));
            }
            Console.WriteLine(n.ToString());
        }

        static void Main(string[] args)
        {
            Task1();
            //Task2();
        }
    }
}

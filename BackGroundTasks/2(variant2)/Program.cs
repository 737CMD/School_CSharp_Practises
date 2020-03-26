using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_variant2_
{
    class Program
    {
        static byte nullBitsInFirst(ushort x1)
        {
            ushort mask = 1;
            byte counter = 0;
            while (mask != 0)
            {
                mask <<= 1;
                if ((x1 & mask) == 0)
                {
                    ++counter;
                }
            }
            return counter;
        }
        static void Task2(short number)
        {
            for (short mask = 0x1800; Convert.ToBoolean(mask); mask >>= 1)
            {
                if (Convert.ToBoolean(number & mask))
                {
                    break;
                }
            }
            for (; Convert.ToBoolean(mask); mask >>= 1)
            {
                Console.Write(number & mask);
            }
            return;
        }
        static void Main(string[] args)
        {
            ushort x1 = ushort.Parse(Console.ReadLine()); 
            ushort n = ushort.Parse(Console.ReadLine());
            short x2 = short.Parse(Console.ReadLine());
            Task2(x2);
            return;
        }
    }
}

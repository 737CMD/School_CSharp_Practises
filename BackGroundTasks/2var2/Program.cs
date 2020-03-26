
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_variant2_
{
    class Program
    {
        static void inrcement(ref uint number)
        {
            uint mask = 1;
            while (Convert.ToBoolean(number & mask))
            {
                number &= ~mask;
                mask <<= 1;
            }
            number |= mask;
            
        }
        static uint nullBitsInFirst(ushort x1)
        {
            ushort mask = 0x8000;
            uint counter = 0;
            while (Convert.ToBoolean(mask))
            {
                if ((x1 & mask) == 0)
                {
                    inrcement(ref counter);
                }
                mask >>= 1;
            }
            return counter;
        }
        static void Task2(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }
            long mask = 0x80000000;
            for (; !(Convert.ToBoolean(number & mask)); mask >>= 1)
            {   }
            for (; Convert.ToBoolean(mask); mask >>= 1)
            {
                Console.Write(Convert.ToBoolean(number & mask) ? "1" : "0");
            }
            Console.Write("\n");
            return;
        }
        static void CircularShiftRight(int number, ushort shifts)
        {
            int lastbit;
            for (uint i = 0; i < shifts; inrcement(ref i))
            {
                lastbit = (Convert.ToBoolean(number & 1) ? 0x8000 : 0x0);
                number >>= 1;
                number |= lastbit;
            }
            ToBinary(number);
        }
        static void ToBinary(int N)
        {
            int mask = 0x8000;
            while (Convert.ToBoolean(mask))
            {
                Console.Write(Convert.ToBoolean(N & mask) ? 1 : 0);
                mask >>= 1;
            }
            return;
        }

        static void Main(string[] args)
        {
            ushort x1 = ushort.Parse(Console.ReadLine());
            ushort n = ushort.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Task1");
            Console.WriteLine(nullBitsInFirst(x1));
            Console.WriteLine("Task2");
            Task2(x2);
            Console.WriteLine("Task3");
            CircularShiftRight(x1, n);
        }
    }
}

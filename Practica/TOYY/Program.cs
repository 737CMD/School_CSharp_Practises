using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOYY
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -125;
            ushort b = (ushort)a;
            Console.WriteLine(b);
            ushort c = 167;
            byte d = (byte)c;
            Console.WriteLine(d);
            Console.WriteLine((256 - 0xA9));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variant 9
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()), u;
            if (Math.Abs(x) <= 1)
            {
                if (y >= -2)
                {
                    if (y <= 0)
                    {
                        u = x + Math.Sqrt(Math.Sqrt(x * y));
                    }
                    else
                    {
                        if (y <= 1)
                        {
                            if (y < Math.Abs(x))
                            {
                                u = x + Math.Sqrt(Math.Pow(x * y, 4));
                            }
                            else
                            {
                                u = Math.Abs((x * x) - (y * y * y));
                            }
                        }
                        else
                        {
                            u = Math.Abs((x * x) - (y * y * y));
                        }
                    }
                }
                else
                {
                    u = Math.Abs((x * x) - (y * y * y));
                }
            }
            else
            {
                u = Math.Abs((x * x) - (y * y * y));
            }
            Console.WriteLine("{0:F2}", u);
        }
    }
}

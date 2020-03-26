using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#warning 
namespace Practica2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            switch (s[0])
            {
                case 'a':
                    Console.WriteLine("a is vowel \n");
                    break;
                case 'e':
                    Console.WriteLine("e is vowel \n");
                    break;
                case 'o':
                    Console.WriteLine("o is vowel \n");
                    break;
                case 'i':
                    Console.WriteLine("i is vowel \n");
                    break;
                case 'u':
                    Console.WriteLine("u is vowel \n");
                    break;
                default:
                    Console.WriteLine((s[0] >= 'a' && s[0] <= 'z' && s.Length == 1) ? s[0] 
                        + " is consonant\n" : ("Whats wrong with u? Is " + s +" a letter? " +
                        "Do u think its funny?\n"));
                    break;
            }
           }
    }
}

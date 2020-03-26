using System;

namespace Practica_10
{
    class Program
    {
        static void ThouthandsPointer()
        {
            string s = Console.ReadLine();
            for (int i = s.Length - 3; i > 0; i -= 3)
            {
                s = s.Insert(i, ".");
            }
            Console.WriteLine(s);
            return;
        }
        static void RemoveSubString()
        {
            string s = Console.ReadLine();
            string subs = Console.ReadLine();
            while (s.Contains(subs))
            {
                s = s.Remove(s.IndexOf(subs), subs.Length);
            }
            Console.WriteLine(s);
            return;
        }

        static void RemoveMidNumbers()
        {
            string s = Console.ReadLine();
            if (!(Convert.ToBoolean(s.Length & 1))) 
            {
                s = s.Remove(s.Length / 2 - 1, 2);
            }
            else
            {
                s = s.Remove(s.Length / 2, 1);
            }
            Console.WriteLine(s);
            s.Remove((s.Length - 1) / 2, 2 - (s.Length % 2));
        }


        static void Main()
        {
            ThouthandsPointer();
            RemoveSubString();
            RemoveMidNumbers();
            Main();
            return;
        }
    }
}

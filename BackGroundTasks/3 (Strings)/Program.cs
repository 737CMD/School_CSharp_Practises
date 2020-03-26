using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Strings_
{
    class Program
    {
        
        static void StringsWith7NumbersConverToNormal(ref string s)
        {
            if (s.Length == 7)
            {
                s = "8495" + s;
            }
            return;
        }
        static void Conver7To8(ref string s)
        {
            if (s[0] == '+')
            {
                s = s.Remove(0, 2);
                s = "8" + s;
            }
            return;
        }
        static void OutPutResult(string s1, string s2, string s3, string s4)
        {
            Console.WriteLine(s2 == s1 ? "Yes" : "NotYes");
            Console.WriteLine(s3 == s1 ? "Yes" : "NotYes");
            Console.WriteLine(s4 == s1 ? "Yes" : "NotYes");
            return;
        }
        static void Task1()
        {
            Console.WriteLine("Input the string you want to insert to dictionary");
            string s1 = Console.ReadLine().Replace("-", "").Replace("(", "").Replace(")", "");
            Console.WriteLine("Input strings that are in dictionary");
            string s2 = Console.ReadLine().Replace("-", "").Replace("(", "").Replace(")", "");
            string s3 = Console.ReadLine().Replace("-", "").Replace("(", "").Replace(")", "");
            string s4 = Console.ReadLine().Replace("-", "").Replace("(", "").Replace(")", "");
            Conver7To8(ref s1);
            Conver7To8(ref s2);
            Conver7To8(ref s3);
            Conver7To8(ref s4);
            StringsWith7NumbersConverToNormal(ref s1);
            StringsWith7NumbersConverToNormal(ref s2);
            StringsWith7NumbersConverToNormal(ref s3);
            StringsWith7NumbersConverToNormal(ref s4);
            OutPutResult(s1, s2, s3, s4);
            return;
        }

        static bool CmpWithMaskCheck(in string r, in string mask)
        {
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] != mask[i] && mask[i] != '?')
                {
                    if (mask[i] == '*')
                    {
                        string MaskLeftPart = mask.Substring(i + 1, mask.Length - i - 1);
                        for (int j = MaskLeftPart.Length - 1; j > -1; j--)
                        {
                            int k = r.Length - (MaskLeftPart.Length - j);
                            if (MaskLeftPart[j] != r[k] && MaskLeftPart[j] != '?')
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        static void CallCmpCheckAndResultOutput(string s, string mask)
        {
            Console.WriteLine(CmpWithMaskCheck(s, mask) ? "Yes" : "NotYes");
            return;
        }


        static void Task2()
        {
            string mask = Console.ReadLine();
            string[] stringArray = new string[5];
            CallCmpCheckAndResultOutput(mask, mask);
            for (int i = 0; i < 5; ++i)
            {
                stringArray[i] = Console.ReadLine();
                CallCmpCheckAndResultOutput(stringArray[i], mask);
            }
            return;
        }
        static void Main()
        {
            Task1();
            Task2();
            return;
        }
    }
}

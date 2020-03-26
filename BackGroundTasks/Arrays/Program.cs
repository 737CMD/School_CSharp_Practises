using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static int[][] InputArray(int width)
        {
            int[][] Arr = new int[width][];
            for (int i = 0; i < width; ++i)
            {
                Console.WriteLine("Введите количество элементов в строке {0}", i);
                Arr[i] = new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < Arr.Length; ++i)
            {
                Console.WriteLine("Введите строку {0}", i);
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < Arr[i].Length; ++j)
                {
                    Arr[i][j] = int.Parse(s[j]);
                }
            }
            return Arr;
        }

        static int MaxWidthOfLine(int[][] Arr)
        {
            int max = Arr[0].Length;
            for (int i = 0; i < Arr.Length; ++i)
            {
                if (Arr[i].Length > max)
                {
                    max = Arr[i].Length ;
                }
            }
            return max;
        }


        static int[] Task3(int[][] Arr)
        {
            int max = MaxWidthOfLine(Arr);
            int[] ArrayWithEvenNumbers = new int[max];
            for (int j = 0; j < max; ++j)
            {
                for (int i = 0; i < Arr.Length; ++i)
                {
                    if (j < Arr[i].Length && Arr[i][j] % 2 == 0 && ArrayWithEvenNumbers[j] != 0)
                    {
                        ArrayWithEvenNumbers[j] = Arr[i][j];
                    }
                }
            }
            return ArrayWithEvenNumbers;
        }

        static void Shrink(int[][] Arr)
        {
            int[][] ShrinkedArray = new int[Arr.Length - HowManyStringsWhereMoreThanHalfElementsEqualZero(Arr)][];
            int numberOfZeroes = 0;
            int x = 0;
            foreach (int[] i in Arr)
            {
                foreach (int j in i)
                {
                    numberOfZeroes += j == 0 ? 1 : 0;
                }
                if (!(numberOfZeroes > i.Length / 2))
                {
                    ShrinkedArray[x] = i;
                    ++x;
                }
                numberOfZeroes = 0;
            }
            OutputArray(ShrinkedArray);
        }

        static int HowManyStringsWhereMoreThanHalfElementsEqualZero(int[][] Arr)
        {
            int result = 0, numberOfZeroes = 0;
            foreach(int[] i in Arr)
            {
                foreach(int j in i)
                {
                    numberOfZeroes += j == 0 ? 1 : 0;
                }
                if (numberOfZeroes > i.Length / 2)
                {
                    ++result;
                }
                numberOfZeroes = 0;
            }
            return result;
        }

        static void LineShift(int[][] Arr)
        {
            Console.WriteLine("Введите индекс строки, которую надо сдвинуть");
            int LineToShift = int.Parse(Console.ReadLine());
            for (int x = Arr[LineToShift].Length; x > 0; --x)
            {
                int temp = Arr[LineToShift][Arr[LineToShift].Length - 1];
                for (int j = Arr[LineToShift].Length - 2; j >= 0; --j)
                {
                    Arr[LineToShift][j +1] = Arr[LineToShift][j];
                }
                Arr[LineToShift][0] = temp;
                OutputArray(Arr);
                Console.WriteLine("Строка вернулась в исходное состояние");
            }
        }

        static void OutputArray(int[][] Arr)
        {
            Console.WriteLine("Вывод");
            foreach(int[] i in Arr)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Введите количество строк");
            int width = int.Parse(Console.ReadLine());
            int[][] Arr = InputArray(width);
            OutputArray(Arr);
            LineShift(Arr);
            Console.WriteLine("Уплотнее массива:");
            Shrink(Arr);
            return;
        }
    }
}

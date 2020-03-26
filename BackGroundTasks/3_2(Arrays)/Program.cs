using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_Arrays_
{
    class Program
    {

        static int[] ArrayInput(int N)
        {
            int[] arr = new int[N];
            for (uint i = 0; i < N; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }


        static void ArrayOutput(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            return;
        }
        static void Task1(int[] arr)
        {
            int sum = 0;
            int maxIndex = arr[0];
            int minIndex = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                    continue;
                }
                if (arr[i] <= arr[minIndex])
                {
                    minIndex = i;
                    continue;
                }
            }
            if (minIndex > maxIndex) 
            {
                minIndex |= maxIndex;   //
                maxIndex |= minIndex;   // SWAP
                minIndex |= maxIndex;   //
            }
            for (int i = minIndex; i <= maxIndex; ++i)
            {
                sum += arr[i];
            }
            Console.WriteLine("Task 3\n" + sum);
            return;
        }


        static void CycleShiftRight(int[] arr)
        {
            int k = int.Parse(Console.ReadLine());
            while (k-- > 0)
            {
                CycleShiftRightOneStep(arr);
            }
            ArrayOutput(arr);
            return;
        }


        static void CycleShiftRightOneStep(int[] arr)
        {
            int first = arr[0];
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = first;
            return;
        }

        static bool IsUnique(int[] arr, int index)
        {
            for (int i = 0; i < index; ++i)
            {
                if (arr[i] == arr[index] && i != index)
                    return false;
            }
            return true;
        }


        static void InterSection(int[] arr, int[] arr2)
        {
            Console.WriteLine("InterSections:");
            for (int i = 0; i < arr.Length; ++i)
            {
                if (!(IsUnique(arr, i)))
                {
                    continue;
                }
                for (int j = 0; j < arr2.Length; ++j)
                {
                    if (arr[i] == arr2[j] && IsUnique(arr2, j))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }

        static int[] ArrayCpyWithoutBadElement(int[] arr, int BadIndex)
        {
            int[] arr2 = new int[arr.Length - 1];
            for (int i = 0, j = 0; j < arr2.Length;)
            {
                if (i == BadIndex)
                {
                    ++i;
                    continue;
                }
                arr2[j] = arr[i];
                ++i;
                ++j;
            }
            return arr2;
        }

        static void RmvNonUniqueElementsInARow(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                while (arr[i] == arr[i+1])
                {
                    arr = ArrayCpyWithoutBadElement(arr, i);
                }
            }
            ArrayOutput(arr);
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = ArrayInput(N);
            // int[] arr2 = ArrayInput(N);
            //Task1(arr); 
            //InterSection(arr, arr2); 
            //CycleShiftRight(arr);
            Console.WriteLine();
            RmvNonUniqueElementsInARow(arr); 
        }
    }
}

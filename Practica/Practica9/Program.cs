    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Practica9
    {
        class Program
        {
            static int task1(uint N)
            {
                int number = 0;
                while (N > 0)
                {
                    number += N % 10 < 8 && (N % 10) % 3 != 0 && (N % 10) % 4 != 0 ? 1 : 0;
                    N /= 10;
                }
                return number;
            }
       
            static uint task2(uint N)
            {
                uint sum = 0;
                while (N > 10)
                {
                    sum += (N % 10 + (N / 10) % 10) % 2 == 0 ? N % 10 + (N / 10) % 10 : 0;
                    N /= 10;
                }
                return sum;
            }

            static bool task3(int N)
            {
                int digits = (int)Math.Floor(Math.Log10(N)) + 1;
                int sum = 0, n = N, i = digits / 2; ;
                while (i > 0)
                {
                    sum += N % 10;
                    sum -= ((int) (n / Math.Pow(10, digits-1))) % 10;
                    --digits;
                    --i;
                    N /= 10;
                }
                return sum == 0;
            }
            static void task4(uint N)
            {
                for (int i = 2; i < N; ++i)
                {
                    if(isPerfect(i))
                    {
                        outputPerfectNumbr(N);
                    }
                }
                return;
            }
            static void outputPerfectNumbr (uint N)
            {
                Console.WriteLine(N);
            }
            static bool isPerfect(int N)
            {
                int sumOfDivisors = 0;
                for (int j = 1; j < N; ++j)
                {
                    sumOfDivisors += (N % j == 0 ? j : 0);
                }
                return sumOfDivisors == N;
            }
            static long AdditionalTask(uint N)
            {
                int numberOfDigits = 0, n = (int)N, sign;
                long sum = 0;
                while (n > 0)
                {
                    ++numberOfDigits;
                    n /= 10;
                }
                sign = Convert.ToBoolean(numberOfDigits % 2) ? 1 : -1;
                while(N > 0)
                {
                    sum += (int)(N % 10) * sign;
                    N /= 10;
                    sign *= -1;
                }
                return sum;
            }
            static void Main(string[] args)
            {
                uint N;
                while (true)
                {
                    Console.WriteLine("Input N");
                    N = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Input task number(1,2,3,4,5)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Task1");
                            Console.WriteLine(task1(N) == 0 ? "NO" : task1(N).ToString());
                            break;
                        case "2":
                            Console.WriteLine("Task2");
                            Console.WriteLine(task2(N).ToString());
                            break;
                        case "3":
                            Console.WriteLine("Task3");
                            Console.WriteLine(task3((int)N));
                            break;
                        case "4":
                            Console.WriteLine("Task4");
                            task4(N);
                            break;
                        case "5":
                            Console.WriteLine("AdditionalTask");
                            Console.WriteLine(AdditionalTask(N));
                            break;
                    }
                    Console.WriteLine();
                }
            }
        }
    }

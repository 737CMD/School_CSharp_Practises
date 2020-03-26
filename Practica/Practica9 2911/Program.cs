using System;
namespace Practica9_2911
{
    class Program
    {
        static void TowerOfHanoi(int height, int fromThisTower, int toThisTower)
        {
            if(height == 1)
            {
                Console.WriteLine("Move disk {0} from tower {1} to {2}", height, fromThisTower, toThisTower);
                return;
            }
            TowerOfHanoi(height - 1, fromThisTower, 6 - fromThisTower - toThisTower);
            Console.WriteLine("Move disk {0} from tower {1} to {2}", height, fromThisTower, toThisTower);
            TowerOfHanoi(height - 1, 6 - fromThisTower - toThisTower, toThisTower);
        }
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            TowerOfHanoi(height, 1, 2);
        }
    }
}

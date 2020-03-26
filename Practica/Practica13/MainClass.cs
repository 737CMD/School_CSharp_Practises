using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13
{
    class Point3D
    {
        double x, y, z;
        public Point3D()
        {   }
        public Point3D(double x, double y, double z)
        {
                this.x = x;
                this.y = y;
                this.z = z;
        }
        public Point3D(string InputPoint)
        {
            string[] s = InputPoint.Split(' ');
            x = Convert.ToDouble(s[0]);
            y = Convert.ToDouble(s[1]);
            z = Convert.ToDouble(s[2]);
        }
        public double X
        {
            get => x;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Failed to assigment Y, Y wasn't changed, it equals " + Convert.ToString(x));
                }
                x = value;
            }
        }
        public double Y
        {
            get => y;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Failed to assigment Y, Y wasn't changed, it equals " + Convert.ToString(y));
                }
                y = value;
            }
        }
        public double Z
        {
            get => z;
            set
            {
                if (value > x + y)
                {
                    throw new Exception("Failed to assigment Y, Y wasn't changed, it equals " + Convert.ToString(z));
                }
                z = value;
            }
        }
        public override string ToString()
        {
            return (Convert.ToString(x) + " " + Convert.ToString(y) + " " + Convert.ToString(z));
        }

        public double RadiusVector
        {
            get => Math.Sqrt(x * x + y * y + z * z);
        }

        public static Point3D operator +(Point3D first, Point3D second) => new Point3D(first.x + second.x, first.y + second.y, first.z + second.z);
        public static Point3D operator +(Point3D first) => first;
        public static Point3D operator -(Point3D first) => new Point3D (-first.x, -first.y, -first.z);
        public static bool operator &(Point3D first, Point3D second) => first.x == 42 && second.x == 42;
        public static bool operator |(Point3D first, Point3D second) => first.x == 42 || second.x == 42;
        public static bool operator true(Point3D first) => first.x > 0 && first.y < 0 && first.z < 0;
        public static bool operator false(Point3D first) => first ? false : true;
        public static Point3D operator -(Point3D first, Point3D second) => new Point3D(first.x - second.x, first.y - second.y, first.z - second.z);
        public static Point3D operator ++(Point3D other) //prefix increment
        {
            ++other.x;
            ++other.y;
            ++other.z;
            return other;
        }
        public static Point3D operator --(Point3D other) //prefix decrement
        {
            --other.x;
            --other.y;
            --other.z;
            return other;
        }
        
        public static Point3D CreatePoint(double x, double y, double z)
        {
            if (x % 5  == 0 || y % 5 == 0 || z % 5 == 0)
            {
                return new Point3D(x, y, z);
            }
            return new Point3D();
        }
    };

    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D();
            double x, y, z;
            Console.WriteLine("Input x, y, z");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());
            Point3D result = Point3D.CreatePoint(x, y, z);
            Console.WriteLine("Created point coordinates: " + result.X + ", " + result.Y + ", " + result.Z);
            return;
            }
    }
}

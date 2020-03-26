using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Cuboid
    {
        double length, width, depth;
        double x, y, z;
        public Cuboid()
        {
            length = 5;
            width = 6;
            depth = 7;
        }
        public Cuboid(double length, double width, double depth, double x, double y, double z)
        {
            this.length = length;
            this.width = width;
            this.depth = depth;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double Volume
        {
            get => length * width * depth;
        }
        public double SurfaceArea
        {
            get => 2 * (length * width + width * depth + depth * length);
        }
        public double SideArea
        {
            get => length* width;
        }
        public double BaseArea
        {
            get => width * depth;
        }
        public double FaceArea
        {
            get => length * depth;
        }
        public double EdgesPerimetr
        {
            get =>  4 * (width + depth + length);
        }
        public double Diagonal
        {
            get => Math.Sqrt(depth * depth + width * width + length * length);
        }
        public double SphereRadius
        {
            get =>  Diagonal / 2f;
        }
        public double Length
        {
            get => length;
            set
            {
                length = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                width = value;
            }
        }
        public double Depth
        {
            get => depth;
            set
            {
                depth = value;
            }
        }
        public double X
        {
            get => x;
            set
            {
                if (value == 42)
                {
                    throw new Exception("Ты познал ответ на главный вопрос жини, вселенной и всего такого");
                }
                x = value;
            }
        }
        public double Y
        {
            get => y;
            set
            {
                if (value == 42)
                {
                    throw new Exception("Ты познал ответ на главный вопрос жини, вселенной и всего такого");
                }
                y = value;
            }
        }
        public double Z
        {
            get => z;
            set
            {
                if (value == 42)
                {
                    throw new Exception("Ты познал ответ на главный вопрос жини, вселенной и всего такого");
                }
                z = value;
            }
        }
        public bool IsCube
        {
            get => length == width && length == depth;
        }

        public Cuboid Intersection(Cuboid other)
        {
            double widthInterSection = ((this.width + other.width) - (Math.Abs(this.x - other.x) + Math.Abs(this.x + this.width - (other.x + other.width)))) / 2;
            double depthInterSection = ((this.depth + other.depth) - (Math.Abs(this.z - other.z) + Math.Abs(this.z + this.depth - (other.z + other.depth)))) / 2;
            if (widthInterSection < 0 || depthInterSection < 0)
            {
                widthInterSection = 0;
            }
            if (depthInterSection < 0)
            {
                depthInterSection = 0;
            }
            return new Cuboid(0, widthInterSection, depthInterSection, 0, 0, 0);
        }
        public override string ToString()
        {
            return (Convert.ToString(length) + " " + Convert.ToString(width) + " " + Convert.ToString(depth) + " " + Convert.ToString(x) + " " + Convert.ToString(y) + " " +  Convert.ToString(z));
        }
    };




    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cuboid second = new Cuboid();
            while (true)
            {

                    Console.WriteLine("Введите координаты точки вставки в пространство");
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    double z = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длины сторон кубоида или ноль");
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    double depth = double.Parse(Console.ReadLine());
                    try
                    {
                        second.X = x;
                        second.Y = y;
                        second.Z = z;
                        second.Length = length;
                        second.Width = width;
                        second.Depth = depth;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    Console.WriteLine("Base Area: " + second.BaseArea);
                    Console.WriteLine("Diagonal: " + second.Diagonal);
                    Console.WriteLine("Edges Perimetr: " + second.EdgesPerimetr);
                    Console.WriteLine("Is Cube?: " + second.IsCube);
                    Console.WriteLine("Sphere Radius: " + second.SphereRadius);
                    Console.WriteLine("SideArea: " + second.SideArea);
                    Console.WriteLine("Base Area: " + second.BaseArea);
                    Console.WriteLine("Face Area: " + second.FaceArea);
                    Console.WriteLine("Surface Area: " + second.SurfaceArea);
                    Console.WriteLine("Volume: " + second.Volume);
                 }
            return;
        }

    }
}

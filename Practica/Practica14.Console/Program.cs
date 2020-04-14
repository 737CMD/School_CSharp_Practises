using System;

namespace Practica14.Console
{
    class Program
    {
        static void Main(string[] args){
            DemoPoint point = new DemoPoint(3, 4);
            DemoLine line = new DemoLine(point, new DemoPoint(-2, 0));
            line.Show();
        }
    }
}

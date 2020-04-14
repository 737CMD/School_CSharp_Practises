using System;

namespace Practica14.Console
{
    interface ShowInterface
    {
        void Show();
    }
    class DemoPoint : ShowInterface
    {
        double x, y;
        public DemoPoint() {}
        public DemoPoint(double x, double y){
            this.x = x;
            this.y = y;
        }
        public double X{
            get => x;
            set=> x  = value;
        }
        public double Y{
            get => y;
            set=> y = value;
        }
        public void Show(){
            System.Console.Write("(" + x + ", " + y + ")");
        }
    }
    class DemoLine : ShowInterface
    {
        DemoPoint firstPoint, secondPoint;
        public DemoLine() {
            firstPoint  = new DemoPoint();
            secondPoint = new DemoPoint();
        }
        public DemoLine(DemoPoint firstPoint, DemoPoint secondPoint) {
            this.firstPoint  = firstPoint;
            this.secondPoint = secondPoint;
        }
        public DemoLine(DemoLine other){
            this.firstPoint  = other.firstPoint;
            this.secondPoint = other.secondPoint;
        }
        public DemoPoint FirstPoint{
            get => firstPoint;
            set => firstPoint = value;
        }
        public DemoPoint SecondPoint{
            get => secondPoint;
            set => secondPoint = value;
        }
        public void Show(){
            firstPoint.Show();
            System.Console.Write("\t");
            secondPoint.Show(); 
        }
    }

    class Program
    {
        static void Main(string[] args){
            DemoPoint point = new DemoPoint(3, 4);
            DemoLine line = new DemoLine(point, new DemoPoint(-2, 0));
            point.Show();
            line.Show();
        }
    }
}

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
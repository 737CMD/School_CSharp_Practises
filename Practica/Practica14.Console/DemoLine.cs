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
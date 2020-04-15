class Car : Vehicle
{
    Coachbuilder сoachbuilder;
    int numberOfPassengers;
    int passengersCapacity;
    public Car(){   }
    public Coachbuilder Coachbuilder{
        get => сoachbuilder;
        set => сoachbuilder = value;
    }
     public int NumberOfPassengers{
        get => numberOfPassengers;
        set{
            if (value > PassengersCapacity){
                throw new TooManyPassengersException();
            }
            numberOfPassengers = value;
        }
    }
    public int PassengersCapacity{
        get => passengersCapacity;
        set{
            if (value < NumberOfPassengers){
                throw new TooManyPassengersException();
            }
            passengersCapacity = value;
        } 
    }
    public  double LoadFactor{
        get =>  ((double)NumberOfPassengers / (double)PassengersCapacity);
    }
    public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) / LoadFactor;
    }
}
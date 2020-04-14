class Car : Vehicle
{
    Coachbuiled coachbuiled;
    int numberOfPassengers;
    static readonly int passengersCapacity = 7;
    public Car(){   }
    public Coachbuiled Coachbuiled{
        get => coachbuiled;
        set => coachbuiled = value;
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
    }
    public  double LoadFactor{
        get =>  ((double)NumberOfPassengers / (double)PassengersCapacity);
    }
    public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) / LoadFactor;
    }
}
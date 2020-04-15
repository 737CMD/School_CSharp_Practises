class Car : Vehicle
{
    Coachbuiled coachbuiled;
    int numberOfPassengers;
    int passengersCapacity;
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